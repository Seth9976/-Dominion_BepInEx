using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000021 RID: 33
	public sealed class XmlReaderSettings : Object
	{
		// Token: 0x06000141 RID: 321 RVA: 0x0000DB08 File Offset: 0x0000BD08
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReaderSettings()
		{
			Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlReaderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr);
			XmlReaderSettings.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "useAsync");
			XmlReaderSettings.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "nameTable");
			XmlReaderSettings.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "xmlResolver");
			XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "lineNumberOffset");
			XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "linePositionOffset");
			XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "conformanceLevel");
			XmlReaderSettings.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "checkCharacters");
			XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "maxCharactersInDocument");
			XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "maxCharactersFromEntities");
			XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignoreWhitespace");
			XmlReaderSettings.NativeFieldInfoPtr_ignorePIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignorePIs");
			XmlReaderSettings.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignoreComments");
			XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "dtdProcessing");
			XmlReaderSettings.NativeFieldInfoPtr_validationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "validationType");
			XmlReaderSettings.NativeFieldInfoPtr_validationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "validationFlags");
			XmlReaderSettings.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "schemas");
			XmlReaderSettings.NativeFieldInfoPtr_closeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "closeInput");
			XmlReaderSettings.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "isReadOnly");
			XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "<IsXmlResolverSet>k__BackingField");
			XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "s_enableLegacyXmlSettings");
			XmlReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663472);
			XmlReaderSettings.NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663473);
			XmlReaderSettings.NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663474);
			XmlReaderSettings.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663475);
			XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663476);
			XmlReaderSettings.NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663477);
			XmlReaderSettings.NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663478);
			XmlReaderSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663479);
			XmlReaderSettings.NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663480);
			XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663481);
			XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663482);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663483);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663484);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663485);
			XmlReaderSettings.NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663486);
			XmlReaderSettings.NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663487);
			XmlReaderSettings.NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663488);
			XmlReaderSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663489);
			XmlReaderSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663490);
			XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663491);
			XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663492);
			XmlReaderSettings.NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663493);
			XmlReaderSettings.NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100663494);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000DE94 File Offset: 0x0000C094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11893, RefRangeEnd = 11895, XrefRangeStart = 11888, XrefRangeEnd = 11893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReaderSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000AD RID: 173
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11895, XrefRangeEnd = 11898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000DF14 File Offset: 0x0000C114
		public unsafe bool IsXmlResolverSet
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000DF54 File Offset: 0x0000C154
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11898, XrefRangeEnd = 11901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000DF98 File Offset: 0x0000C198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetXmlResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x170000B0 RID: 176
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000DFD8 File Offset: 0x0000C1D8
		public unsafe int LineNumberOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11901, XrefRangeEnd = 11904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000E018 File Offset: 0x0000C218
		public unsafe int LinePositionOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11904, XrefRangeEnd = 11907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000E058 File Offset: 0x0000C258
		public unsafe ConformanceLevel ConformanceLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11907, XrefRangeEnd = 11910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000E098 File Offset: 0x0000C298
		public unsafe bool CheckCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11910, XrefRangeEnd = 11913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		public unsafe long MaxCharactersInDocument
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11913, XrefRangeEnd = 11916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0000E118 File Offset: 0x0000C318
		public unsafe long MaxCharactersFromEntities
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11916, XrefRangeEnd = 11919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000E158 File Offset: 0x0000C358
		public unsafe bool IgnoreWhitespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11919, XrefRangeEnd = 11922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0000E198 File Offset: 0x0000C398
		public unsafe bool IgnoreProcessingInstructions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11922, XrefRangeEnd = 11925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		public unsafe bool IgnoreComments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11925, XrefRangeEnd = 11928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000E218 File Offset: 0x0000C418
		public unsafe DtdProcessing DtdProcessing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 11931, RefRangeEnd = 11932, XrefRangeStart = 11928, XrefRangeEnd = 11931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000E258 File Offset: 0x0000C458
		public unsafe ValidationType ValidationType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 11932, RefRangeEnd = 11934, XrefRangeStart = 11932, XrefRangeEnd = 11932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000E294 File Offset: 0x0000C494
		public unsafe XmlSchemaSet Schemas
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 11942, RefRangeEnd = 11943, XrefRangeStart = 11934, XrefRangeEnd = 11942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr3) : null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (set) Token: 0x06000153 RID: 339 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		public unsafe bool ReadOnly
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000E314 File Offset: 0x0000C514
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 11943, RefRangeEnd = 11971, XrefRangeStart = 11943, XrefRangeEnd = 11943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckReadOnly(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000E358 File Offset: 0x0000C558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11971, XrefRangeEnd = 11975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000E38C File Offset: 0x0000C58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11975, XrefRangeEnd = 11979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11979, XrefRangeEnd = 11983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlResolver CreateDefaultResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000E404 File Offset: 0x0000C604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12003, RefRangeEnd = 12005, XrefRangeStart = 11983, XrefRangeEnd = 12003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableLegacyXmlSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000267D File Offset: 0x0000087D
		public XmlReaderSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000E434 File Offset: 0x0000C634
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002686 File Offset: 0x00000886
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000E45C File Offset: 0x0000C65C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000026A1 File Offset: 0x000008A1
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000E48C File Offset: 0x0000C68C
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000026DF File Offset: 0x000008DF
		public unsafe int lineNumberOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000026FA File Offset: 0x000008FA
		public unsafe int linePositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000E50C File Offset: 0x0000C70C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002715 File Offset: 0x00000915
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000E534 File Offset: 0x0000C734
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002730 File Offset: 0x00000930
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000E55C File Offset: 0x0000C75C
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000274B File Offset: 0x0000094B
		public unsafe long maxCharactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000E584 File Offset: 0x0000C784
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002766 File Offset: 0x00000966
		public unsafe long maxCharactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002781 File Offset: 0x00000981
		public unsafe bool ignoreWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000279C File Offset: 0x0000099C
		public unsafe bool ignorePIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignorePIs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignorePIs)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000027B7 File Offset: 0x000009B7
		public unsafe bool ignoreComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreComments)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000E624 File Offset: 0x0000C824
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000027D2 File Offset: 0x000009D2
		public unsafe DtdProcessing dtdProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000E64C File Offset: 0x0000C84C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000027ED File Offset: 0x000009ED
		public unsafe ValidationType validationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationType)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000E674 File Offset: 0x0000C874
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002808 File Offset: 0x00000A08
		public unsafe XmlSchemaValidationFlags validationFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationFlags)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000E69C File Offset: 0x0000C89C
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002823 File Offset: 0x00000A23
		public unsafe XmlSchemaSet schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002842 File Offset: 0x00000A42
		public unsafe bool closeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_closeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_closeInput)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000E6F4 File Offset: 0x0000C8F4
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000285D File Offset: 0x00000A5D
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000E71C File Offset: 0x0000C91C
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002878 File Offset: 0x00000A78
		public unsafe bool _IsXmlResolverSet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000E744 File Offset: 0x0000C944
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002893 File Offset: 0x00000A93
		public unsafe static Nullable<bool> s_enableLegacyXmlSettings
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_lineNumberOffset;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_linePositionOffset;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersInDocument;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersFromEntities;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_ignoreWhitespace;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_ignorePIs;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_dtdProcessing;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_validationType;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_validationFlags;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_closeInput;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_s_enableLegacyXmlSettings;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0;
	}
}
