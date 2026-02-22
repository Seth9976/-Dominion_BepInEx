using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001F RID: 31
	public class XmlParserContext : Object
	{
		// Token: 0x060000FA RID: 250 RVA: 0x0000C85C File Offset: 0x0000AA5C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlParserContext()
		{
			Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlParserContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr);
			XmlParserContext.NativeFieldInfoPtr__nt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_nt");
			XmlParserContext.NativeFieldInfoPtr__nsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_nsMgr");
			XmlParserContext.NativeFieldInfoPtr__docTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_docTypeName");
			XmlParserContext.NativeFieldInfoPtr__pubId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_pubId");
			XmlParserContext.NativeFieldInfoPtr__sysId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_sysId");
			XmlParserContext.NativeFieldInfoPtr__internalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_internalSubset");
			XmlParserContext.NativeFieldInfoPtr__xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_xmlLang");
			XmlParserContext.NativeFieldInfoPtr__xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_xmlSpace");
			XmlParserContext.NativeFieldInfoPtr__baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_baseURI");
			XmlParserContext.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_encoding");
			XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663430);
			XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663431);
			XmlParserContext.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663432);
			XmlParserContext.NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663433);
			XmlParserContext.NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663434);
			XmlParserContext.NativeMethodInfoPtr_get_PublicId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663435);
			XmlParserContext.NativeMethodInfoPtr_get_SystemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663436);
			XmlParserContext.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663437);
			XmlParserContext.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663438);
			XmlParserContext.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663439);
			XmlParserContext.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663440);
			XmlParserContext.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663441);
			XmlParserContext.NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100663442);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000CA58 File Offset: 0x0000AC58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11820, RefRangeEnd = 11822, XrefRangeStart = 11805, XrefRangeEnd = 11820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysId);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseURI);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlLang);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000CB38 File Offset: 0x0000AD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11822, XrefRangeEnd = 11837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysId);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseURI);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlLang);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlSpace;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000CC2C File Offset: 0x0000AE2C
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		public unsafe XmlNamespaceManager NamespaceManager
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000CCAC File Offset: 0x0000AEAC
		public unsafe string DocTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
		public unsafe string PublicId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_PublicId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		public unsafe string SystemId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_SystemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000CD54 File Offset: 0x0000AF54
		public unsafe string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		public unsafe string InternalSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		public unsafe string XmlLang
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		public unsafe XmlSpace XmlSpace
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000CE38 File Offset: 0x0000B038
		public unsafe Encoding Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000CE78 File Offset: 0x0000B078
		public unsafe bool HasDtdInfo
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 11847, RefRangeEnd = 11853, XrefRangeStart = 11840, XrefRangeEnd = 11847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000250F File Offset: 0x0000070F
		public XmlParserContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002518 File Offset: 0x00000718
		public unsafe XmlNameTable _nt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002537 File Offset: 0x00000737
		public unsafe XmlNamespaceManager _nsMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nsMgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nsMgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000CF14 File Offset: 0x0000B114
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe string _docTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__docTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__docTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000CF3C File Offset: 0x0000B13C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002575 File Offset: 0x00000775
		public unsafe string _pubId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__pubId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__pubId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000CF64 File Offset: 0x0000B164
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002594 File Offset: 0x00000794
		public unsafe string _sysId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__sysId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__sysId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000CF8C File Offset: 0x0000B18C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000025B3 File Offset: 0x000007B3
		public unsafe string _internalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__internalSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__internalSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000025D2 File Offset: 0x000007D2
		public unsafe string _xmlLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlLang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000025F1 File Offset: 0x000007F1
		public unsafe XmlSpace _xmlSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlSpace)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000D004 File Offset: 0x0000B204
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000260C File Offset: 0x0000080C
		public unsafe string _baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000D02C File Offset: 0x0000B22C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000262B File Offset: 0x0000082B
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr__nt;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr__nsMgr;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr__docTypeName;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr__pubId;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr__sysId;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr__internalSubset;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr__xmlLang;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr__xmlSpace;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr__baseURI;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_get_String_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_get_String_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_get_String_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_get_String_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0;
	}
}
