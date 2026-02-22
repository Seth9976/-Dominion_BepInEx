using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000039 RID: 57
	public sealed class XmlNameEx : XmlName
	{
		// Token: 0x06000533 RID: 1331 RVA: 0x0001EB80 File Offset: 0x0001CD80
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNameEx()
		{
			Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNameEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr);
			XmlNameEx.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "flags");
			XmlNameEx.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "memberType");
			XmlNameEx.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "schemaType");
			XmlNameEx.NativeFieldInfoPtr_decl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, "decl");
			XmlNameEx.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664136);
			XmlNameEx.NativeMethodInfoPtr_get_Validity_Public_Virtual_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664137);
			XmlNameEx.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664138);
			XmlNameEx.NativeMethodInfoPtr_get_IsNil_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664139);
			XmlNameEx.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664140);
			XmlNameEx.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664141);
			XmlNameEx.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664142);
			XmlNameEx.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664143);
			XmlNameEx.NativeMethodInfoPtr_SetValidity_Public_Void_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664144);
			XmlNameEx.NativeMethodInfoPtr_SetIsDefault_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664145);
			XmlNameEx.NativeMethodInfoPtr_SetIsNil_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664146);
			XmlNameEx.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr, 100664147);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16118, XrefRangeEnd = 16138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNameEx>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerDoc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001EDA8 File Offset: 0x0001CFA8
		public unsafe override XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_Validity_Public_Virtual_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0001EE20 File Offset: 0x0001D020
		public unsafe override bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_IsNil_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0001EE5C File Offset: 0x0001D05C
		public unsafe override XmlSchemaSimpleType MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0001EE9C File Offset: 0x0001D09C
		public unsafe override XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001EEDC File Offset: 0x0001D0DC
		public unsafe override XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16138, XrefRangeEnd = 16139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001EF1C File Offset: 0x0001D11C
		public unsafe override XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16139, XrefRangeEnd = 16140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001EF5C File Offset: 0x0001D15C
		[CallerCount(0)]
		public unsafe void SetValidity(XmlSchemaValidity value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_SetValidity_Public_Void_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001EF9C File Offset: 0x0001D19C
		[CallerCount(0)]
		public unsafe void SetIsDefault(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_SetIsDefault_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001EFDC File Offset: 0x0001D1DC
		[CallerCount(0)]
		public unsafe void SetIsNil(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_SetIsNil_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001F01C File Offset: 0x0001D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16140, XrefRangeEnd = 16162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameEx.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00003CEB File Offset: 0x00001EEB
		public XmlNameEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001F06C File Offset: 0x0001D26C
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public unsafe byte flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001F094 File Offset: 0x0001D294
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003D0F File Offset: 0x00001F0F
		public unsafe XmlSchemaSimpleType memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001F0C4 File Offset: 0x0001D2C4
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00003D2E File Offset: 0x00001F2E
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001F0F4 File Offset: 0x0001D2F4
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00003D4D File Offset: 0x00001F4D
		public unsafe Object decl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_decl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNameEx.NativeFieldInfoPtr_decl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_decl;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Virtual_get_XmlSchemaValidity_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Virtual_get_Boolean_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_XmlSchemaSimpleType_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Virtual_get_XmlSchemaType_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_get_XmlSchemaElement_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_get_XmlSchemaAttribute_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_SetValidity_Public_Void_XmlSchemaValidity_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_SetIsDefault_Public_Void_Boolean_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_SetIsNil_Public_Void_Boolean_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_IXmlSchemaInfo_0;
	}
}
