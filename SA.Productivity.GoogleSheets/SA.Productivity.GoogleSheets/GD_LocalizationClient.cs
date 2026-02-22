using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000010 RID: 16
	public class GD_LocalizationClient : Object
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00005F74 File Offset: 0x00004174
		// Note: this type is marked as 'beforefieldinit'.
		static GD_LocalizationClient()
		{
			Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_LocalizationClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr);
			GD_LocalizationClient.NativeFieldInfoPtr_m_langCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, "m_langCode");
			GD_LocalizationClient.NativeFieldInfoPtr_m_sheetDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, "m_sheetDictionary");
			GD_LocalizationClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663414);
			GD_LocalizationClient.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663415);
			GD_LocalizationClient.NativeMethodInfoPtr_SetLanguage_Public_Void_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663416);
			GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_TextType_GD_LangSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663417);
			GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663418);
			GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_LangSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663419);
			GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_LangSection_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663420);
			GD_LocalizationClient.NativeMethodInfoPtr_GetFullSectionLocalization_Public_Dictionary_2_String_String_GD_LangSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663421);
			GD_LocalizationClient.NativeMethodInfoPtr_get_CurrentLanguage_Public_get_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663422);
			GD_LocalizationClient.NativeMethodInfoPtr_FillLocalizationDictionary_Public_Void_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663423);
			GD_LocalizationClient.NativeMethodInfoPtr_GetUparcedTokenValue_Private_String_String_GD_LangSection_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr, 100663424);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000060A8 File Offset: 0x000042A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126634, RefRangeEnd = 126635, XrefRangeStart = 126595, XrefRangeEnd = 126634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_LocalizationClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_LocalizationClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000060E4 File Offset: 0x000042E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006118 File Offset: 0x00004318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126639, RefRangeEnd = 126640, XrefRangeStart = 126635, XrefRangeEnd = 126639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLanguage(GD_LangCode lang)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lang;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_SetLanguage_Public_Void_GD_LangCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006158 File Offset: 0x00004358
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 126669, RefRangeEnd = 126673, XrefRangeStart = 126640, XrefRangeEnd = 126669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(string token, GD_TextType _type, GD_LangSection section = GD_LangSection.General)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_TextType_GD_LangSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000061BC File Offset: 0x000043BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126673, XrefRangeEnd = 126677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(string token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006204 File Offset: 0x00004404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126677, XrefRangeEnd = 126678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(string token, GD_LangSection section)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_LangSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000625C File Offset: 0x0000445C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 126715, RefRangeEnd = 126722, XrefRangeStart = 126678, XrefRangeEnd = 126715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(string token, GD_LangSection section, GD_LangCode language)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref language;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_LangSection_GD_LangCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000062C0 File Offset: 0x000044C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126722, XrefRangeEnd = 126736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> GetFullSectionLocalization(GD_LangSection section)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref section;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_GetFullSectionLocalization_Public_Dictionary_2_String_String_GD_LangSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000630C File Offset: 0x0000450C
		public unsafe GD_LangCode CurrentLanguage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_get_CurrentLanguage_Public_get_GD_LangCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006348 File Offset: 0x00004548
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126864, RefRangeEnd = 126867, XrefRangeStart = 126736, XrefRangeEnd = 126864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillLocalizationDictionary(GD_LangCode lang)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lang;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_FillLocalizationDictionary_Public_Void_GD_LangCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006388 File Offset: 0x00004588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126867, XrefRangeEnd = 126912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUparcedTokenValue(string token, GD_LangSection section, GD_LangCode lang)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lang;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationClient.NativeMethodInfoPtr_GetUparcedTokenValue_Private_String_String_GD_LangSection_GD_LangCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002525 File Offset: 0x00000725
		public GD_LocalizationClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000063EC File Offset: 0x000045EC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000252E File Offset: 0x0000072E
		public unsafe GD_LangCode m_langCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationClient.NativeFieldInfoPtr_m_langCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationClient.NativeFieldInfoPtr_m_langCode)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006414 File Offset: 0x00004614
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002549 File Offset: 0x00000749
		public unsafe Dictionary<string, Dictionary<string, string>> m_sheetDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationClient.NativeFieldInfoPtr_m_sheetDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LocalizationClient.NativeFieldInfoPtr_m_sheetDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_m_langCode;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_m_sheetDictionary;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_Public_Void_GD_LangCode_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_TextType_GD_LangSection_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_String_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_LangSection_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_String_GD_LangSection_GD_LangCode_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_GetFullSectionLocalization_Public_Dictionary_2_String_String_GD_LangSection_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguage_Public_get_GD_LangCode_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_FillLocalizationDictionary_Public_Void_GD_LangCode_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetUparcedTokenValue_Private_String_String_GD_LangSection_GD_LangCode_0;
	}
}
