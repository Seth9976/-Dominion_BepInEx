using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000DA RID: 218
	public sealed class SchemaAttDef : SchemaDeclBase
	{
		// Token: 0x06000D1A RID: 3354 RVA: 0x0003F740 File Offset: 0x0003D940
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaAttDef()
		{
			Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaAttDef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr);
			SchemaAttDef.NativeFieldInfoPtr_defExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "defExpanded");
			SchemaAttDef.NativeFieldInfoPtr_lineNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "lineNum");
			SchemaAttDef.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "linePos");
			SchemaAttDef.NativeFieldInfoPtr_valueLineNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "valueLineNum");
			SchemaAttDef.NativeFieldInfoPtr_valueLinePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "valueLinePos");
			SchemaAttDef.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "reserved");
			SchemaAttDef.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "Empty");
			SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665240);
			SchemaAttDef.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665241);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665242);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665243);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665244);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665245);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665246);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665247);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665248);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665249);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665250);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665251);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665252);
			SchemaAttDef.NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665253);
			SchemaAttDef.NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665254);
			SchemaAttDef.NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665255);
			SchemaAttDef.NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665256);
			SchemaAttDef.NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665257);
			SchemaAttDef.NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665258);
			SchemaAttDef.NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665259);
			SchemaAttDef.NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665260);
			SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665261);
			SchemaAttDef.NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665262);
			SchemaAttDef.NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665263);
			SchemaAttDef.NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665264);
			SchemaAttDef.NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665265);
			SchemaAttDef.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665266);
			SchemaAttDef.NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100665267);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0003FA2C File Offset: 0x0003DC2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24046, RefRangeEnd = 24047, XrefRangeStart = 24045, XrefRangeEnd = 24046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0003FA8C File Offset: 0x0003DC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24047, XrefRangeEnd = 24052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0003FAC8 File Offset: 0x0003DCC8
		public unsafe string System.Xml.IDtdAttributeInfo.Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24052, XrefRangeEnd = 24054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0003FB00 File Offset: 0x0003DD00
		public unsafe string System.Xml.IDtdAttributeInfo.LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0003FB38 File Offset: 0x0003DD38
		public unsafe int System.Xml.IDtdAttributeInfo.LineNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12786, RefRangeEnd = 12787, XrefRangeStart = 12786, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0003FB74 File Offset: 0x0003DD74
		public unsafe int System.Xml.IDtdAttributeInfo.LinePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12787, RefRangeEnd = 12788, XrefRangeStart = 12787, XrefRangeEnd = 12788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0003FBB0 File Offset: 0x0003DDB0
		public unsafe bool System.Xml.IDtdAttributeInfo.IsNonCDataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0003FBEC File Offset: 0x0003DDEC
		public unsafe bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0003FC28 File Offset: 0x0003DE28
		public unsafe bool System.Xml.IDtdAttributeInfo.IsXmlAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0003FC64 File Offset: 0x0003DE64
		public unsafe string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24054, XrefRangeEnd = 24056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0003FC9C File Offset: 0x0003DE9C
		public unsafe Object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0003FCDC File Offset: 0x0003DEDC
		public unsafe int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0003FD18 File Offset: 0x0003DF18
		public unsafe int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0003FD54 File Offset: 0x0003DF54
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0003FD90 File Offset: 0x0003DF90
		public unsafe int LinePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12787, RefRangeEnd = 12788, XrefRangeStart = 12787, XrefRangeEnd = 12788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0003FDD0 File Offset: 0x0003DFD0
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x0003FE0C File Offset: 0x0003E00C
		public unsafe int LineNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12786, RefRangeEnd = 12787, XrefRangeStart = 12786, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0003FE4C File Offset: 0x0003E04C
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x0003FE88 File Offset: 0x0003E088
		public unsafe int ValueLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0003FEC8 File Offset: 0x0003E0C8
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x0003FF04 File Offset: 0x0003E104
		public unsafe int ValueLineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0003FF44 File Offset: 0x0003E144
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x0003FF7C File Offset: 0x0003E17C
		public unsafe string DefaultValueExpanded
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24058, RefRangeEnd = 24059, XrefRangeStart = 24056, XrefRangeEnd = 24058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0003FFC0 File Offset: 0x0003E1C0
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x0003FFFC File Offset: 0x0003E1FC
		public unsafe XmlTokenizedType TokenizedType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 24060, RefRangeEnd = 24062, XrefRangeStart = 24059, XrefRangeEnd = 24060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24063, RefRangeEnd = 24064, XrefRangeStart = 24062, XrefRangeEnd = 24063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0004003C File Offset: 0x0003E23C
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00040078 File Offset: 0x0003E278
		public unsafe SchemaAttDef.Reserve Reserved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000400B8 File Offset: 0x0003E2B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24077, RefRangeEnd = 24079, XrefRangeStart = 24064, XrefRangeEnd = 24077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckXmlSpace(IValidationEventHandling validationEventHandling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validationEventHandling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00006418 File Offset: 0x00004618
		public SchemaAttDef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000400FC File Offset: 0x0003E2FC
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00006421 File Offset: 0x00004621
		public unsafe string defExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defExpanded);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defExpanded), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00040124 File Offset: 0x0003E324
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00006440 File Offset: 0x00004640
		public unsafe int lineNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_lineNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_lineNum)) = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0004014C File Offset: 0x0003E34C
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x0000645B File Offset: 0x0000465B
		public unsafe int linePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_linePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_linePos)) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00040174 File Offset: 0x0003E374
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00006476 File Offset: 0x00004676
		public unsafe int valueLineNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLineNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLineNum)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0004019C File Offset: 0x0003E39C
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00006491 File Offset: 0x00004691
		public unsafe int valueLinePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLinePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLinePos)) = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x000401C4 File Offset: 0x0003E3C4
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x000064AC File Offset: 0x000046AC
		public unsafe SchemaAttDef.Reserve reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_reserved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_reserved)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x000401EC File Offset: 0x0003E3EC
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x000064C7 File Offset: 0x000046C7
		public unsafe static SchemaAttDef Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SchemaAttDef.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SchemaAttDef.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeFieldInfoPtr_defExpanded;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_lineNum;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeFieldInfoPtr_valueLineNum;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr_valueLinePos;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0;

		// Token: 0x02000132 RID: 306
		public enum Reserve
		{
			// Token: 0x04000EC1 RID: 3777
			None,
			// Token: 0x04000EC2 RID: 3778
			XmlSpace,
			// Token: 0x04000EC3 RID: 3779
			XmlLang
		}
	}
}
