using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FE RID: 254
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		// Token: 0x06000F31 RID: 3889 RVA: 0x00046AE0 File Offset: 0x00044CE0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaType()
		{
			Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr);
			XmlSchemaType.NativeFieldInfoPtr_final = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "final");
			XmlSchemaType.NativeFieldInfoPtr_derivedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "derivedBy");
			XmlSchemaType.NativeFieldInfoPtr_baseSchemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "baseSchemaType");
			XmlSchemaType.NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "datatype");
			XmlSchemaType.NativeFieldInfoPtr_elementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "elementDecl");
			XmlSchemaType.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "qname");
			XmlSchemaType.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "contentType");
			XmlSchemaType.NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665482);
			XmlSchemaType.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665483);
			XmlSchemaType.NativeMethodInfoPtr_get_BaseXmlSchemaType_Public_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665484);
			XmlSchemaType.NativeMethodInfoPtr_get_Datatype_Public_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665485);
			XmlSchemaType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665486);
			XmlSchemaType.NativeMethodInfoPtr_get_TypeCode_Public_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665487);
			XmlSchemaType.NativeMethodInfoPtr_get_ValueConverter_Internal_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665488);
			XmlSchemaType.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665489);
			XmlSchemaType.NativeMethodInfoPtr_SetBaseSchemaType_Internal_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665490);
			XmlSchemaType.NativeMethodInfoPtr_SetDerivedBy_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665491);
			XmlSchemaType.NativeMethodInfoPtr_SetDatatype_Internal_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665492);
			XmlSchemaType.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665493);
			XmlSchemaType.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665494);
			XmlSchemaType.NativeMethodInfoPtr_SetContentType_Internal_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665495);
			XmlSchemaType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100665496);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00046CC8 File Offset: 0x00044EC8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 24928, RefRangeEnd = 24943, XrefRangeStart = 24924, XrefRangeEnd = 24928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00046D08 File Offset: 0x00044F08
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 24944, RefRangeEnd = 24957, XrefRangeStart = 24943, XrefRangeEnd = 24944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00046D48 File Offset: 0x00044F48
		public unsafe XmlSchemaType BaseXmlSchemaType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_BaseXmlSchemaType_Public_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00046D88 File Offset: 0x00044F88
		public unsafe XmlSchemaDatatype Datatype
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_Datatype_Public_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00046DC8 File Offset: 0x00044FC8
		public unsafe virtual bool IsMixed
		{
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00046E14 File Offset: 0x00045014
		public unsafe XmlTypeCode TypeCode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 24965, RefRangeEnd = 24970, XrefRangeStart = 24957, XrefRangeEnd = 24965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_TypeCode_Public_get_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00046E50 File Offset: 0x00045050
		public unsafe XmlValueConverter ValueConverter
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 24974, RefRangeEnd = 24991, XrefRangeStart = 24970, XrefRangeEnd = 24974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_ValueConverter_Internal_get_XmlValueConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00046E90 File Offset: 0x00045090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24992, RefRangeEnd = 24993, XrefRangeStart = 24991, XrefRangeEnd = 24992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQualifiedName(XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00046ED4 File Offset: 0x000450D4
		[CallerCount(0)]
		public unsafe void SetBaseSchemaType(XmlSchemaType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetBaseSchemaType_Internal_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00046F18 File Offset: 0x00045118
		[CallerCount(0)]
		public unsafe void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetDerivedBy_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00046F58 File Offset: 0x00045158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDatatype(XmlSchemaDatatype value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetDatatype_Internal_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00046F9C File Offset: 0x0004519C
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00046FDC File Offset: 0x000451DC
		public unsafe SchemaElementDecl ElementDecl
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 24994, RefRangeEnd = 25005, XrefRangeStart = 24993, XrefRangeEnd = 24994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 25006, RefRangeEnd = 25007, XrefRangeStart = 25005, XrefRangeEnd = 25006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00047020 File Offset: 0x00045220
		[CallerCount(0)]
		public unsafe void SetContentType(XmlSchemaContentType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetContentType_Internal_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00047060 File Offset: 0x00045260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25013, RefRangeEnd = 25014, XrefRangeStart = 25007, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x000073A2 File Offset: 0x000055A2
		public XmlSchemaType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0004709C File Offset: 0x0004529C
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x000073AB File Offset: 0x000055AB
		public unsafe XmlSchemaDerivationMethod final
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_final);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_final)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x000470C4 File Offset: 0x000452C4
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x000073C6 File Offset: 0x000055C6
		public unsafe XmlSchemaDerivationMethod derivedBy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_derivedBy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_derivedBy)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x000470EC File Offset: 0x000452EC
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x000073E1 File Offset: 0x000055E1
		public unsafe XmlSchemaType baseSchemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_baseSchemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_baseSchemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0004711C File Offset: 0x0004531C
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x00007400 File Offset: 0x00005600
		public unsafe XmlSchemaDatatype datatype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_datatype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0004714C File Offset: 0x0004534C
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x0000741F File Offset: 0x0000561F
		public unsafe SchemaElementDecl elementDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_elementDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_elementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0004717C File Offset: 0x0004537C
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x0000743E File Offset: 0x0000563E
		public unsafe XmlQualifiedName qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_qname);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x000471AC File Offset: 0x000453AC
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x0000745D File Offset: 0x0000565D
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_final;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeFieldInfoPtr_derivedBy;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_baseSchemaType;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_datatype;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_elementDecl;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlTypeCode_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseXmlSchemaType_Public_get_XmlSchemaType_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_get_Datatype_Public_get_XmlSchemaDatatype_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMixed_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_get_XmlTypeCode_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_get_XmlValueConverter_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseSchemaType_Internal_Void_XmlSchemaType_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_SetDerivedBy_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_SetDatatype_Internal_Void_XmlSchemaDatatype_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_SetContentType_Internal_Void_XmlSchemaContentType_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
