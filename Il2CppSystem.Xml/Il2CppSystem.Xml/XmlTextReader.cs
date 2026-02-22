using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000023 RID: 35
	public class XmlTextReader : XmlReader
	{
		// Token: 0x06000182 RID: 386 RVA: 0x0000E780 File Offset: 0x0000C980
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextReader()
		{
			Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr);
			XmlTextReader.NativeFieldInfoPtr_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, "impl");
			XmlTextReader.NativeMethodInfoPtr__ctor_Public_Void_TextReader_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663495);
			XmlTextReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663496);
			XmlTextReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663497);
			XmlTextReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663498);
			XmlTextReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663499);
			XmlTextReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663500);
			XmlTextReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663501);
			XmlTextReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663502);
			XmlTextReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663503);
			XmlTextReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663504);
			XmlTextReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663505);
			XmlTextReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663506);
			XmlTextReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663507);
			XmlTextReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663508);
			XmlTextReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663509);
			XmlTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663510);
			XmlTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663511);
			XmlTextReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663512);
			XmlTextReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663513);
			XmlTextReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663514);
			XmlTextReader.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663515);
			XmlTextReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663516);
			XmlTextReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663517);
			XmlTextReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663518);
			XmlTextReader.NativeMethodInfoPtr_set_EntityHandling_Public_set_Void_EntityHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663519);
			XmlTextReader.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663520);
			XmlTextReader.NativeMethodInfoPtr_get_Impl_Internal_get_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663521);
			XmlTextReader.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663522);
			XmlTextReader.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr, 100663523);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000EA08 File Offset: 0x0000CC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12022, RefRangeEnd = 12023, XrefRangeStart = 12005, XrefRangeEnd = 12022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReader(TextReader input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReader.NativeMethodInfoPtr__ctor_Public_Void_TextReader_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000EA68 File Offset: 0x0000CC68
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12023, XrefRangeEnd = 12024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12024, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12025, XrefRangeEnd = 12026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000EB38 File Offset: 0x0000CD38
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12026, XrefRangeEnd = 12027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12027, XrefRangeEnd = 12028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12028, XrefRangeEnd = 12029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000EC04 File Offset: 0x0000CE04
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12029, XrefRangeEnd = 12030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12030, XrefRangeEnd = 12031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000EC90 File Offset: 0x0000CE90
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12031, XrefRangeEnd = 12032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12032, XrefRangeEnd = 12033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12033, XrefRangeEnd = 12034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12035, RefRangeEnd = 12037, XrefRangeStart = 12034, XrefRangeEnd = 12035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 12038, RefRangeEnd = 12046, XrefRangeStart = 12037, XrefRangeEnd = 12038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000EE08 File Offset: 0x0000D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12046, XrefRangeEnd = 12047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000EE50 File Offset: 0x0000D050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12047, XrefRangeEnd = 12048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000EE98 File Offset: 0x0000D098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12048, XrefRangeEnd = 12049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12049, XrefRangeEnd = 12050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000EF1C File Offset: 0x0000D11C
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12050, XrefRangeEnd = 12051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000EF68 File Offset: 0x0000D168
		[CallerCount(0)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		public unsafe override bool CanResolveEntity
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000F004 File Offset: 0x0000D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12051, XrefRangeEnd = 12052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000F040 File Offset: 0x0000D240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12052, XrefRangeEnd = 12053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000F088 File Offset: 0x0000D288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12053, XrefRangeEnd = 12054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
		public unsafe EntityHandling EntityHandling
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12054, RefRangeEnd = 12056, XrefRangeStart = 12054, XrefRangeEnd = 12054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReader.NativeMethodInfoPtr_set_EntityHandling_Public_set_Void_EntityHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000F110 File Offset: 0x0000D310
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12056, RefRangeEnd = 12058, XrefRangeStart = 12056, XrefRangeEnd = 12056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReader.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000F154 File Offset: 0x0000D354
		public unsafe XmlTextReaderImpl Impl
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReader.NativeMethodInfoPtr_get_Impl_Internal_get_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl>(intPtr3) : null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000F194 File Offset: 0x0000D394
		public unsafe bool XmlValidatingReaderCompatibilityMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12064, RefRangeEnd = 12066, XrefRangeStart = 12058, XrefRangeEnd = 12064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReader.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		public unsafe override IDtdInfo DtdInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12066, XrefRangeEnd = 12067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReader.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000028AA File Offset: 0x00000AAA
		public XmlTextReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000F220 File Offset: 0x0000D420
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000028B3 File Offset: 0x00000AB3
		public unsafe XmlTextReaderImpl impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReader.NativeFieldInfoPtr_impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReader.NativeFieldInfoPtr_impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_impl;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextReader_XmlNameTable_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityHandling_Public_set_Void_EntityHandling_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_get_Impl_Internal_get_XmlTextReaderImpl_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0;
	}
}
