using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200004F RID: 79
	[Serializable]
	public class TMP_Settings : ScriptableObject
	{
		// Token: 0x06000855 RID: 2133 RVA: 0x00025D40 File Offset: 0x00023F40
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Settings()
		{
			Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr);
			TMP_Settings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "s_Instance");
			TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableWordWrapping");
			TMP_Settings.NativeFieldInfoPtr_m_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableKerning");
			TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableExtraPadding");
			TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableTintAllSprites");
			TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableParseEscapeCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_EnableRaycastTarget");
			TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_GetFontFeaturesAtRuntime");
			TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_missingGlyphCharacter");
			TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_warningsDisabled");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAsset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAssetPath");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontSize");
			TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMinRatio");
			TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMaxRatio");
			TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProTextContainerSize");
			TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProUITextContainerSize");
			TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_autoSizeTextContainer");
			TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_IsTextObjectScaleStatic");
			TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_fallbackFontAssets");
			TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_matchMaterialPreset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAsset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAssetPath");
			TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableEmojiSupport");
			TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_MissingCharacterSpriteUnicode");
			TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultColorGradientPresetsPath");
			TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultStyleSheet");
			TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_StyleSheetsResourcePath");
			TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_leadingCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_followingCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_linebreakingRules");
			TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_UseModernHangulLineBreakingRules");
			TMP_Settings.NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664164);
			TMP_Settings.NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664165);
			TMP_Settings.NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664166);
			TMP_Settings.NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664167);
			TMP_Settings.NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664168);
			TMP_Settings.NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664169);
			TMP_Settings.NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664170);
			TMP_Settings.NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664171);
			TMP_Settings.NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664172);
			TMP_Settings.NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664173);
			TMP_Settings.NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664174);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664175);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664176);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664177);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664178);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664179);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664180);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664181);
			TMP_Settings.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664182);
			TMP_Settings.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664183);
			TMP_Settings.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664184);
			TMP_Settings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664185);
			TMP_Settings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664186);
			TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664187);
			TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664188);
			TMP_Settings.NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664189);
			TMP_Settings.NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664190);
			TMP_Settings.NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664191);
			TMP_Settings.NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664192);
			TMP_Settings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664193);
			TMP_Settings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664194);
			TMP_Settings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664195);
			TMP_Settings.NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664196);
			TMP_Settings.NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664197);
			TMP_Settings.NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664198);
			TMP_Settings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664199);
			TMP_Settings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664200);
			TMP_Settings.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664201);
			TMP_Settings.NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664202);
			TMP_Settings.NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664203);
			TMP_Settings.NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664204);
			TMP_Settings.NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664205);
			TMP_Settings.NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664206);
			TMP_Settings.NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664207);
			TMP_Settings.NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664208);
			TMP_Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664209);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00026388 File Offset: 0x00024588
		public unsafe static string version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143935, XrefRangeEnd = 143937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x000263B4 File Offset: 0x000245B4
		public unsafe static bool enableWordWrapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143937, XrefRangeEnd = 143938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x000263E4 File Offset: 0x000245E4
		public unsafe static bool enableKerning
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143938, XrefRangeEnd = 143939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00026414 File Offset: 0x00024614
		public unsafe static bool enableExtraPadding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143939, XrefRangeEnd = 143940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00026444 File Offset: 0x00024644
		public unsafe static bool enableTintAllSprites
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143940, XrefRangeEnd = 143941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00026474 File Offset: 0x00024674
		public unsafe static bool enableParseEscapeCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143941, XrefRangeEnd = 143942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000264A4 File Offset: 0x000246A4
		public unsafe static bool enableRaycastTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143942, XrefRangeEnd = 143943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000264D4 File Offset: 0x000246D4
		public unsafe static bool getFontFeaturesAtRuntime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 143944, RefRangeEnd = 143945, XrefRangeStart = 143943, XrefRangeEnd = 143944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00026504 File Offset: 0x00024704
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00026534 File Offset: 0x00024734
		public unsafe static int missingGlyphCharacter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 143946, RefRangeEnd = 143950, XrefRangeStart = 143945, XrefRangeEnd = 143946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143950, XrefRangeEnd = 143951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00026568 File Offset: 0x00024768
		public unsafe static bool warningsDisabled
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 143952, RefRangeEnd = 143956, XrefRangeStart = 143951, XrefRangeEnd = 143952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00026598 File Offset: 0x00024798
		public unsafe static TMP_FontAsset defaultFontAsset
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 143957, RefRangeEnd = 143967, XrefRangeStart = 143956, XrefRangeEnd = 143957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x000265CC File Offset: 0x000247CC
		public unsafe static string defaultFontAssetPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143967, XrefRangeEnd = 143968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000265F8 File Offset: 0x000247F8
		public unsafe static float defaultFontSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143968, XrefRangeEnd = 143969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00026628 File Offset: 0x00024828
		public unsafe static float defaultTextAutoSizingMinRatio
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143969, XrefRangeEnd = 143970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00026658 File Offset: 0x00024858
		public unsafe static float defaultTextAutoSizingMaxRatio
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143970, XrefRangeEnd = 143971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00026688 File Offset: 0x00024888
		public unsafe static Vector2 defaultTextMeshProTextContainerSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143971, XrefRangeEnd = 143972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000266B8 File Offset: 0x000248B8
		public unsafe static Vector2 defaultTextMeshProUITextContainerSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143972, XrefRangeEnd = 143973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x000266E8 File Offset: 0x000248E8
		public unsafe static bool autoSizeTextContainer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143973, XrefRangeEnd = 143974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00026718 File Offset: 0x00024918
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00026748 File Offset: 0x00024948
		public unsafe static bool isTextObjectScaleStatic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143974, XrefRangeEnd = 143975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143975, XrefRangeEnd = 143976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0002677C File Offset: 0x0002497C
		public unsafe static List<TMP_FontAsset> fallbackFontAssets
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 143977, RefRangeEnd = 143989, XrefRangeStart = 143976, XrefRangeEnd = 143977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr3) : null;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x000267B0 File Offset: 0x000249B0
		public unsafe static bool matchMaterialPreset
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 143990, RefRangeEnd = 143994, XrefRangeStart = 143989, XrefRangeEnd = 143990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000267E0 File Offset: 0x000249E0
		public unsafe static TMP_SpriteAsset defaultSpriteAsset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143994, XrefRangeEnd = 143995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00026814 File Offset: 0x00024A14
		public unsafe static string defaultSpriteAssetPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143995, XrefRangeEnd = 143996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00026840 File Offset: 0x00024A40
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00026870 File Offset: 0x00024A70
		public unsafe static bool enableEmojiSupport
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143996, XrefRangeEnd = 143997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143997, XrefRangeEnd = 143998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x000268A4 File Offset: 0x00024AA4
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x000268D4 File Offset: 0x00024AD4
		public unsafe static uint missingCharacterSpriteUnicode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143998, XrefRangeEnd = 143999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143999, XrefRangeEnd = 144000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00026908 File Offset: 0x00024B08
		public unsafe static string defaultColorGradientPresetsPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144000, XrefRangeEnd = 144001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00026934 File Offset: 0x00024B34
		public unsafe static TMP_StyleSheet defaultStyleSheet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144001, XrefRangeEnd = 144002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00026968 File Offset: 0x00024B68
		public unsafe static string styleSheetsResourcePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144002, XrefRangeEnd = 144003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00026994 File Offset: 0x00024B94
		public unsafe static TextAsset leadingCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144003, XrefRangeEnd = 144004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000269C8 File Offset: 0x00024BC8
		public unsafe static TextAsset followingCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144004, XrefRangeEnd = 144005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000269FC File Offset: 0x00024BFC
		public unsafe static TMP_Settings.LineBreakingTable linebreakingRules
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 144022, RefRangeEnd = 144029, XrefRangeStart = 144005, XrefRangeEnd = 144022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings.LineBreakingTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00026A30 File Offset: 0x00024C30
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00026A60 File Offset: 0x00024C60
		public unsafe static bool useModernHangulLineBreakingRules
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 144030, RefRangeEnd = 144032, XrefRangeStart = 144029, XrefRangeEnd = 144030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144032, XrefRangeEnd = 144033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00026A94 File Offset: 0x00024C94
		public unsafe static TMP_Settings instance
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 144046, RefRangeEnd = 144125, XrefRangeStart = 144033, XrefRangeEnd = 144046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00026AC8 File Offset: 0x00024CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144125, XrefRangeEnd = 144141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings LoadDefaultSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00026AFC File Offset: 0x00024CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144141, XrefRangeEnd = 144147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings GetSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00026B30 File Offset: 0x00024D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144147, XrefRangeEnd = 144153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset GetFontAsset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00026B64 File Offset: 0x00024D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144153, XrefRangeEnd = 144159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset GetSpriteAsset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00026B98 File Offset: 0x00024D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144159, XrefRangeEnd = 144165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_StyleSheet GetStyleSheet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00026BCC File Offset: 0x00024DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144165, XrefRangeEnd = 144180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadLinebreakingRules()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00026BF4 File Offset: 0x00024DF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 144195, RefRangeEnd = 144199, XrefRangeStart = 144180, XrefRangeEnd = 144195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, char> GetCharacters(TextAsset file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00026C38 File Offset: 0x00024E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144199, XrefRangeEnd = 144200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00005DE3 File Offset: 0x00003FE3
		public TMP_Settings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00026C74 File Offset: 0x00024E74
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00005DEC File Offset: 0x00003FEC
		public unsafe static TMP_Settings s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Settings.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Settings.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00026C9C File Offset: 0x00024E9C
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x00005DFE File Offset: 0x00003FFE
		public unsafe bool m_enableWordWrapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping)) = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00026CC4 File Offset: 0x00024EC4
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00005E19 File Offset: 0x00004019
		public unsafe bool m_enableKerning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableKerning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableKerning)) = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00026CEC File Offset: 0x00024EEC
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00005E34 File Offset: 0x00004034
		public unsafe bool m_enableExtraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding)) = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00026D14 File Offset: 0x00024F14
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00005E4F File Offset: 0x0000404F
		public unsafe bool m_enableTintAllSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites)) = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00026D3C File Offset: 0x00024F3C
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00005E6A File Offset: 0x0000406A
		public unsafe bool m_enableParseEscapeCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters)) = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00026D64 File Offset: 0x00024F64
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00005E85 File Offset: 0x00004085
		public unsafe bool m_EnableRaycastTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget)) = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00026D8C File Offset: 0x00024F8C
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00005EA0 File Offset: 0x000040A0
		public unsafe bool m_GetFontFeaturesAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime)) = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00026DB4 File Offset: 0x00024FB4
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00005EBB File Offset: 0x000040BB
		public unsafe int m_missingGlyphCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter)) = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00026DDC File Offset: 0x00024FDC
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00005ED6 File Offset: 0x000040D6
		public unsafe bool m_warningsDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00026E04 File Offset: 0x00025004
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00005EF1 File Offset: 0x000040F1
		public unsafe TMP_FontAsset m_defaultFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00026E34 File Offset: 0x00025034
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00005F10 File Offset: 0x00004110
		public unsafe string m_defaultFontAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00026E5C File Offset: 0x0002505C
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00005F2F File Offset: 0x0000412F
		public unsafe float m_defaultFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00026E84 File Offset: 0x00025084
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00005F4A File Offset: 0x0000414A
		public unsafe float m_defaultAutoSizeMinRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio)) = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00026EAC File Offset: 0x000250AC
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00005F65 File Offset: 0x00004165
		public unsafe float m_defaultAutoSizeMaxRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00026ED4 File Offset: 0x000250D4
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00005F80 File Offset: 0x00004180
		public unsafe Vector2 m_defaultTextMeshProTextContainerSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize)) = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00026EFC File Offset: 0x000250FC
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00005F9B File Offset: 0x0000419B
		public unsafe Vector2 m_defaultTextMeshProUITextContainerSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00026F24 File Offset: 0x00025124
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00005FB6 File Offset: 0x000041B6
		public unsafe bool m_autoSizeTextContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer)) = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00026F4C File Offset: 0x0002514C
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00005FD1 File Offset: 0x000041D1
		public unsafe bool m_IsTextObjectScaleStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00026F74 File Offset: 0x00025174
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00005FEC File Offset: 0x000041EC
		public unsafe List<TMP_FontAsset> m_fallbackFontAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00026FA4 File Offset: 0x000251A4
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x0000600B File Offset: 0x0000420B
		public unsafe bool m_matchMaterialPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00026FCC File Offset: 0x000251CC
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00006026 File Offset: 0x00004226
		public unsafe TMP_SpriteAsset m_defaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00026FFC File Offset: 0x000251FC
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00006045 File Offset: 0x00004245
		public unsafe string m_defaultSpriteAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00027024 File Offset: 0x00025224
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00006064 File Offset: 0x00004264
		public unsafe bool m_enableEmojiSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0002704C File Offset: 0x0002524C
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x0000607F File Offset: 0x0000427F
		public unsafe uint m_MissingCharacterSpriteUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00027074 File Offset: 0x00025274
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x0000609A File Offset: 0x0000429A
		public unsafe string m_defaultColorGradientPresetsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0002709C File Offset: 0x0002529C
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x000060B9 File Offset: 0x000042B9
		public unsafe TMP_StyleSheet m_defaultStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x000270CC File Offset: 0x000252CC
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x000060D8 File Offset: 0x000042D8
		public unsafe string m_StyleSheetsResourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x000270F4 File Offset: 0x000252F4
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x000060F7 File Offset: 0x000042F7
		public unsafe TextAsset m_leadingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00027124 File Offset: 0x00025324
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00006116 File Offset: 0x00004316
		public unsafe TextAsset m_followingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_followingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_followingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00027154 File Offset: 0x00025354
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00006135 File Offset: 0x00004335
		public unsafe TMP_Settings.LineBreakingTable m_linebreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings.LineBreakingTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00027184 File Offset: 0x00025384
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00006154 File Offset: 0x00004354
		public unsafe bool m_UseModernHangulLineBreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules)) = value;
			}
		}

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_m_enableWordWrapping;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_m_enableKerning;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_m_enableExtraPadding;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_m_enableTintAllSprites;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_m_enableParseEscapeCharacters;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableRaycastTarget;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_m_missingGlyphCharacter;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_m_warningsDisabled;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontAsset;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontAssetPath;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontSize;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMinRatio;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_m_autoSizeTextContainer;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextObjectScaleStatic;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackFontAssets;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_m_matchMaterialPreset;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAsset;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAssetPath;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_m_enableEmojiSupport;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultColorGradientPresetsPath;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultStyleSheet;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheetsResourcePath;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_m_leadingCharacters;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_m_followingCharacters;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_m_linebreakingRules;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A4 RID: 164
		public class LineBreakingTable : global::Il2CppSystem.Object
		{
			// Token: 0x06000FB2 RID: 4018 RVA: 0x0003E2D4 File Offset: 0x0003C4D4
			// Note: this type is marked as 'beforefieldinit'.
			static LineBreakingTable()
			{
				Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "LineBreakingTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr);
				TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, "leadingCharacters");
				TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, "followingCharacters");
				TMP_Settings.LineBreakingTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, 100664888);
			}

			// Token: 0x06000FB3 RID: 4019 RVA: 0x0003E33C File Offset: 0x0003C53C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LineBreakingTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.LineBreakingTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FB4 RID: 4020 RVA: 0x00009758 File Offset: 0x00007958
			public LineBreakingTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x0003E378 File Offset: 0x0003C578
			// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00009761 File Offset: 0x00007961
			public unsafe Dictionary<int, char> leadingCharacters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x0003E3A8 File Offset: 0x0003C5A8
			// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x00009780 File Offset: 0x00007980
			public unsafe Dictionary<int, char> followingCharacters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C57 RID: 3159
			private static readonly IntPtr NativeFieldInfoPtr_leadingCharacters;

			// Token: 0x04000C58 RID: 3160
			private static readonly IntPtr NativeFieldInfoPtr_followingCharacters;

			// Token: 0x04000C59 RID: 3161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
