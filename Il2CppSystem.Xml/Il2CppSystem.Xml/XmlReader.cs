using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000020 RID: 32
	[DefaultMember("Item")]
	public class XmlReader : Object
	{
		// Token: 0x0600011D RID: 285 RVA: 0x0000D05C File Offset: 0x0000B25C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReader()
		{
			Il2CppClassPointerStore<XmlReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReader>.NativeClassPtr);
			XmlReader.NativeFieldInfoPtr_IsTextualNodeBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, "IsTextualNodeBitmap");
			XmlReader.NativeFieldInfoPtr_CanReadContentAsBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, "CanReadContentAsBitmap");
			XmlReader.NativeFieldInfoPtr_HasValueBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, "HasValueBitmap");
			XmlReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_New_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663443);
			XmlReader.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663444);
			XmlReader.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663445);
			XmlReader.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663446);
			XmlReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663447);
			XmlReader.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663448);
			XmlReader.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663449);
			XmlReader.NativeMethodInfoPtr_get_BaseURI_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663450);
			XmlReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663451);
			XmlReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663452);
			XmlReader.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663453);
			XmlReader.NativeMethodInfoPtr_MoveToAttribute_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663454);
			XmlReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663455);
			XmlReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663456);
			XmlReader.NativeMethodInfoPtr_MoveToElement_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663457);
			XmlReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663458);
			XmlReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663459);
			XmlReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663460);
			XmlReader.NativeMethodInfoPtr_get_ReadState_Public_Abstract_Virtual_New_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663461);
			XmlReader.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663462);
			XmlReader.NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663463);
			XmlReader.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663464);
			XmlReader.NativeMethodInfoPtr_ResolveEntity_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663465);
			XmlReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663466);
			XmlReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663467);
			XmlReader.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_New_get_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663468);
			XmlReader.NativeMethodInfoPtr_CalcBufferSize_Internal_Static_Int32_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663469);
			XmlReader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReader>.NativeClassPtr, 100663470);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
		public unsafe virtual XmlReaderSettings Settings
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_New_get_XmlReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000D344 File Offset: 0x0000B544
		public unsafe virtual XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000D38C File Offset: 0x0000B58C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11876, XrefRangeEnd = 11880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000D414 File Offset: 0x0000B614
		public unsafe virtual string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000D458 File Offset: 0x0000B658
		public unsafe virtual string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000D49C File Offset: 0x0000B69C
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		public unsafe virtual string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_BaseURI_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000D524 File Offset: 0x0000B724
		public unsafe virtual bool IsEmptyElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000D56C File Offset: 0x0000B76C
		public unsafe virtual bool IsDefault
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public unsafe virtual IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11880, XrefRangeEnd = 11883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000D600 File Offset: 0x0000B800
		[CallerCount(0)]
		public unsafe virtual bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_MoveToAttribute_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000D658 File Offset: 0x0000B858
		[CallerCount(0)]
		public unsafe virtual bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
		[CallerCount(0)]
		public unsafe virtual bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		[CallerCount(0)]
		public unsafe virtual bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_MoveToElement_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000D730 File Offset: 0x0000B930
		[CallerCount(0)]
		public unsafe virtual bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000D778 File Offset: 0x0000B978
		[CallerCount(0)]
		public unsafe virtual bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		public unsafe virtual ReadState ReadState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_ReadState_Public_Abstract_Virtual_New_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000D844 File Offset: 0x0000BA44
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000D890 File Offset: 0x0000BA90
		[CallerCount(0)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		public unsafe virtual bool CanResolveEntity
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000D92C File Offset: 0x0000BB2C
		[CallerCount(0)]
		public unsafe virtual void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_ResolveEntity_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000D968 File Offset: 0x0000BB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11883, XrefRangeEnd = 11887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000D99C File Offset: 0x0000BB9C
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		public unsafe virtual IDtdInfo DtdInfo
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlReader.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_New_get_IDtdInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000DA34 File Offset: 0x0000BC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11887, XrefRangeEnd = 11888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalcBufferSize(Stream input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReader.NativeMethodInfoPtr_CalcBufferSize_Internal_Static_Int32_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000DA78 File Offset: 0x0000BC78
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000264A File Offset: 0x0000084A
		public XmlReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002653 File Offset: 0x00000853
		public unsafe static uint IsTextualNodeBitmap
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(XmlReader.NativeFieldInfoPtr_IsTextualNodeBitmap, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReader.NativeFieldInfoPtr_IsTextualNodeBitmap, (void*)(&value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002661 File Offset: 0x00000861
		public unsafe static uint CanReadContentAsBitmap
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(XmlReader.NativeFieldInfoPtr_CanReadContentAsBitmap, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReader.NativeFieldInfoPtr_CanReadContentAsBitmap, (void*)(&value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000DAEC File Offset: 0x0000BCEC
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000266F File Offset: 0x0000086F
		public unsafe static uint HasValueBitmap
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(XmlReader.NativeFieldInfoPtr_HasValueBitmap, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReader.NativeFieldInfoPtr_HasValueBitmap, (void*)(&value));
			}
		}

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_IsTextualNodeBitmap;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_CanReadContentAsBitmap;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_HasValueBitmap;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_New_get_XmlReaderSettings_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Abstract_Virtual_New_get_ReadState_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_New_get_IDtdInfo_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_CalcBufferSize_Internal_Static_Int32_Stream_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
