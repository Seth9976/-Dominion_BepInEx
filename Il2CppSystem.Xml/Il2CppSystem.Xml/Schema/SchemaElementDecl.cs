using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000DC RID: 220
	public sealed class SchemaElementDecl : SchemaDeclBase
	{
		// Token: 0x06000D6E RID: 3438 RVA: 0x00040A54 File Offset: 0x0003EC54
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaElementDecl()
		{
			Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaElementDecl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr);
			SchemaElementDecl.NativeFieldInfoPtr_attdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "attdefs");
			SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "defaultAttdefs");
			SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isIdDeclared");
			SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasNonCDataAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasRequiredAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isNotationDeclared");
			SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "prohibitedAttributes");
			SchemaElementDecl.NativeFieldInfoPtr_contentValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "contentValidator");
			SchemaElementDecl.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "anyAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "Empty");
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665285);
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665286);
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665287);
			SchemaElementDecl.NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665288);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665289);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665290);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665291);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665292);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665293);
			SchemaElementDecl.NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665294);
			SchemaElementDecl.NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665295);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665296);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665297);
			SchemaElementDecl.NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665298);
			SchemaElementDecl.NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665299);
			SchemaElementDecl.NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665300);
			SchemaElementDecl.NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665301);
			SchemaElementDecl.NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665302);
			SchemaElementDecl.NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665303);
			SchemaElementDecl.NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100665304);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00040CDC File Offset: 0x0003EEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24127, RefRangeEnd = 24128, XrefRangeStart = 24110, XrefRangeEnd = 24127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00040D18 File Offset: 0x0003EF18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24149, RefRangeEnd = 24150, XrefRangeStart = 24128, XrefRangeEnd = 24149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl(XmlSchemaDatatype dtype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00040D64 File Offset: 0x0003EF64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24163, RefRangeEnd = 24165, XrefRangeStart = 24150, XrefRangeEnd = 24163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00040DC4 File Offset: 0x0003EFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24177, RefRangeEnd = 24178, XrefRangeStart = 24165, XrefRangeEnd = 24177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SchemaElementDecl CreateAnyTypeElementDecl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00040DF8 File Offset: 0x0003EFF8
		public unsafe bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00040E34 File Offset: 0x0003F034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24178, XrefRangeEnd = 24185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDtdAttributeInfo System_Xml_IDtdAttributeListInfo_LookupAttribute(string prefix, string localName)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeInfo>(intPtr3) : null;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00040E98 File Offset: 0x0003F098
		[CallerCount(0)]
		public unsafe IEnumerable<IDtdDefaultAttributeInfo> System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IDtdDefaultAttributeInfo>>(intPtr3) : null;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00040ED8 File Offset: 0x0003F0D8
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00040F14 File Offset: 0x0003F114
		public unsafe bool IsIdDeclared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00040F54 File Offset: 0x0003F154
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00040F90 File Offset: 0x0003F190
		public unsafe bool HasNonCDataAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00040FD0 File Offset: 0x0003F1D0
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0004100C File Offset: 0x0003F20C
		public unsafe bool IsNotationDeclared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0004104C File Offset: 0x0003F24C
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0004108C File Offset: 0x0003F28C
		public unsafe ContentValidator ContentValidator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x000410D0 File Offset: 0x0003F2D0
		public unsafe XmlSchemaAnyAttribute AnyAttribute
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00041114 File Offset: 0x0003F314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24197, RefRangeEnd = 24198, XrefRangeStart = 24185, XrefRangeEnd = 24197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttDef(SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00041158 File Offset: 0x0003F358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24201, RefRangeEnd = 24202, XrefRangeStart = 24198, XrefRangeEnd = 24201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttDef(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000411A8 File Offset: 0x0003F3A8
		public unsafe IList<IDtdDefaultAttributeInfo> DefaultAttDefs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IDtdDefaultAttributeInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000411E8 File Offset: 0x0003F3E8
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00006627 File Offset: 0x00004827
		public SchemaElementDecl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00041228 File Offset: 0x0003F428
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00006630 File Offset: 0x00004830
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> attdefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_attdefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_attdefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00041258 File Offset: 0x0003F458
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x0000664F File Offset: 0x0000484F
		public unsafe List<IDtdDefaultAttributeInfo> defaultAttdefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IDtdDefaultAttributeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00041288 File Offset: 0x0003F488
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x0000666E File Offset: 0x0000486E
		public unsafe bool isIdDeclared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared)) = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x000412B0 File Offset: 0x0003F4B0
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00006689 File Offset: 0x00004889
		public unsafe bool hasNonCDataAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute)) = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x000412D8 File Offset: 0x0003F4D8
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x000066A4 File Offset: 0x000048A4
		public unsafe bool hasRequiredAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute)) = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00041300 File Offset: 0x0003F500
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x000066BF File Offset: 0x000048BF
		public unsafe bool isNotationDeclared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared)) = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00041328 File Offset: 0x0003F528
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x000066DA File Offset: 0x000048DA
		public unsafe Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00041358 File Offset: 0x0003F558
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x000066F9 File Offset: 0x000048F9
		public unsafe ContentValidator contentValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_contentValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_contentValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00041388 File Offset: 0x0003F588
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x00006718 File Offset: 0x00004918
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000413B8 File Offset: 0x0003F5B8
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00006737 File Offset: 0x00004937
		public unsafe static SchemaElementDecl Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SchemaElementDecl.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SchemaElementDecl.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeFieldInfoPtr_attdefs;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttdefs;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_isIdDeclared;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_hasNonCDataAttribute;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_hasRequiredAttribute;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_isNotationDeclared;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_prohibitedAttributes;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_contentValidator;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0;
	}
}
