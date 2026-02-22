using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000DB RID: 219
	public class SchemaDeclBase : Object
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x00040214 File Offset: 0x0003E414
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaDeclBase()
		{
			Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaDeclBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr);
			SchemaDeclBase.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "name");
			SchemaDeclBase.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "prefix");
			SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "isDeclaredInExternal");
			SchemaDeclBase.NativeFieldInfoPtr_presence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "presence");
			SchemaDeclBase.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "schemaType");
			SchemaDeclBase.NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "datatype");
			SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "defaultValueRaw");
			SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "defaultValueTyped");
			SchemaDeclBase.NativeFieldInfoPtr_maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "maxLength");
			SchemaDeclBase.NativeFieldInfoPtr_minLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "minLength");
			SchemaDeclBase.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "values");
			SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665269);
			SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665270);
			SchemaDeclBase.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665271);
			SchemaDeclBase.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665272);
			SchemaDeclBase.NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665273);
			SchemaDeclBase.NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665274);
			SchemaDeclBase.NativeMethodInfoPtr_get_Presence_Internal_get_Use_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665275);
			SchemaDeclBase.NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665276);
			SchemaDeclBase.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665277);
			SchemaDeclBase.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665278);
			SchemaDeclBase.NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665279);
			SchemaDeclBase.NativeMethodInfoPtr_AddValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665280);
			SchemaDeclBase.NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665281);
			SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665282);
			SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665283);
			SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100665284);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00040460 File Offset: 0x0003E660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24084, RefRangeEnd = 24086, XrefRangeStart = 24079, XrefRangeEnd = 24084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDeclBase(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x000404C0 File Offset: 0x0003E6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDeclBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x000404FC File Offset: 0x0003E6FC
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0004053C File Offset: 0x0003E73C
		public unsafe string Prefix
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 24088, RefRangeEnd = 24095, XrefRangeStart = 24086, XrefRangeEnd = 24088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00040574 File Offset: 0x0003E774
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x000405B0 File Offset: 0x0003E7B0
		public unsafe bool IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x000405F0 File Offset: 0x0003E7F0
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0004062C File Offset: 0x0003E82C
		public unsafe SchemaDeclBase.Use Presence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Presence_Internal_get_Use_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0004066C File Offset: 0x0003E86C
		public unsafe XmlSchemaType SchemaType
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x000406B0 File Offset: 0x0003E8B0
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x000406F0 File Offset: 0x0003E8F0
		public unsafe XmlSchemaDatatype Datatype
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00040734 File Offset: 0x0003E934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24105, RefRangeEnd = 24107, XrefRangeStart = 24095, XrefRangeEnd = 24105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_AddValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00040778 File Offset: 0x0003E978
		public unsafe List<string> Values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x000407B8 File Offset: 0x0003E9B8
		public unsafe string DefaultValueRaw
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24109, RefRangeEnd = 24110, XrefRangeStart = 24107, XrefRangeEnd = 24109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000407F0 File Offset: 0x0003E9F0
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00040830 File Offset: 0x0003EA30
		public unsafe Object DefaultValueTyped
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x000064D9 File Offset: 0x000046D9
		public SchemaDeclBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00040874 File Offset: 0x0003EA74
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x000064E2 File Offset: 0x000046E2
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x000408A4 File Offset: 0x0003EAA4
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x00006501 File Offset: 0x00004701
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x000408CC File Offset: 0x0003EACC
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x00006520 File Offset: 0x00004720
		public unsafe bool isDeclaredInExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x000408F4 File Offset: 0x0003EAF4
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0000653B File Offset: 0x0000473B
		public unsafe SchemaDeclBase.Use presence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_presence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_presence)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0004091C File Offset: 0x0003EB1C
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00006556 File Offset: 0x00004756
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x0004094C File Offset: 0x0003EB4C
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00006575 File Offset: 0x00004775
		public unsafe XmlSchemaDatatype datatype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_datatype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0004097C File Offset: 0x0003EB7C
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00006594 File Offset: 0x00004794
		public unsafe string defaultValueRaw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x000409A4 File Offset: 0x0003EBA4
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x000065B3 File Offset: 0x000047B3
		public unsafe Object defaultValueTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x000409D4 File Offset: 0x0003EBD4
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x000065D2 File Offset: 0x000047D2
		public unsafe long maxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_maxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_maxLength)) = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000409FC File Offset: 0x0003EBFC
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x000065ED File Offset: 0x000047ED
		public unsafe long minLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_minLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_minLength)) = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00040A24 File Offset: 0x0003EC24
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00006608 File Offset: 0x00004808
		public unsafe List<string> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_isDeclaredInExternal;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_presence;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr_datatype;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueRaw;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueTyped;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr_maxLength;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr_minLength;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Internal_get_String_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_get_Presence_Internal_get_Use_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Internal_Void_String_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0;

		// Token: 0x02000133 RID: 307
		public enum Use
		{
			// Token: 0x04000EC5 RID: 3781
			Default,
			// Token: 0x04000EC6 RID: 3782
			Required,
			// Token: 0x04000EC7 RID: 3783
			Implied,
			// Token: 0x04000EC8 RID: 3784
			Fixed,
			// Token: 0x04000EC9 RID: 3785
			RequiredFixed
		}
	}
}
