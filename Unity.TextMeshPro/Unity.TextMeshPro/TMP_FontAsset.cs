using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	public class TMP_FontAsset : TMP_Asset
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x00017DC0 File Offset: 0x00015FC0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontAsset()
		{
			Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr);
			TMP_FontAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_Version");
			TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_SourceFontFileGUID");
			TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_SourceFontFile");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasPopulationMode");
			TMP_FontAsset.NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FaceInfo");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphLookupDictionary");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharacterTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharacterLookupDictionary");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTexture");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTextures");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTextureIndex");
			TMP_FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_IsMultiAtlasTexturesEnabled");
			TMP_FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_ClearDynamicDataOnBuild");
			TMP_FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_UsedGlyphRects");
			TMP_FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FreeGlyphRects");
			TMP_FontAsset.NativeFieldInfoPtr_m_fontInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_fontInfo");
			TMP_FontAsset.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "atlas");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasWidth");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasHeight");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasPadding");
			TMP_FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasRenderMode");
			TMP_FontAsset.NativeFieldInfoPtr_m_glyphInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_glyphInfoList");
			TMP_FontAsset.NativeFieldInfoPtr_m_KerningTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_KerningTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_FontFeatureTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FontFeatureTable");
			TMP_FontAsset.NativeFieldInfoPtr_fallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "fallbackFontAssets");
			TMP_FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FallbackFontAssetTable");
			TMP_FontAsset.NativeFieldInfoPtr_m_CreationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CreationSettings");
			TMP_FontAsset.NativeFieldInfoPtr_m_FontWeightTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FontWeightTable");
			TMP_FontAsset.NativeFieldInfoPtr_fontWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "fontWeights");
			TMP_FontAsset.NativeFieldInfoPtr_normalStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "normalStyle");
			TMP_FontAsset.NativeFieldInfoPtr_normalSpacingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "normalSpacingOffset");
			TMP_FontAsset.NativeFieldInfoPtr_boldStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "boldStyle");
			TMP_FontAsset.NativeFieldInfoPtr_boldSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "boldSpacing");
			TMP_FontAsset.NativeFieldInfoPtr_italicStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "italicStyle");
			TMP_FontAsset.NativeFieldInfoPtr_tabSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "tabSize");
			TMP_FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "IsFontAssetLookupTablesDirty");
			TMP_FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_ReadFontAssetDefinitionMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_AddSynthesizedCharactersMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_TryAddCharacterMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_TryAddCharactersMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateGlyphAdjustmentRecordsMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_ClearFontAssetDataMarker");
			TMP_FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateFontAssetDataMarker");
			TMP_FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "s_DefaultMaterialSuffix");
			TMP_FontAsset.NativeFieldInfoPtr_FallbackSearchQueryLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "FallbackSearchQueryLookup");
			TMP_FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_SearchedFontAssetLookup");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueue");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueueLookup");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueue");
			TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueueLookup");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToRender");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsRendered");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphIndexList");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphIndexListNewlyAdded");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToAdd");
			TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToAddLookup");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharactersToAdd");
			TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharactersToAddLookup");
			TMP_FontAsset.NativeFieldInfoPtr_s_MissingCharacterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "s_MissingCharacterList");
			TMP_FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_MissingUnicodesFromFontFile");
			TMP_FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_GlyphIndexArray");
			TMP_FontAsset.NativeMethodInfoPtr_get_version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663712);
			TMP_FontAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663713);
			TMP_FontAsset.NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663714);
			TMP_FontAsset.NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663715);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663716);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663717);
			TMP_FontAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663718);
			TMP_FontAsset.NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663719);
			TMP_FontAsset.NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663720);
			TMP_FontAsset.NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663721);
			TMP_FontAsset.NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663722);
			TMP_FontAsset.NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663723);
			TMP_FontAsset.NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663724);
			TMP_FontAsset.NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663725);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663726);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663727);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663728);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663729);
			TMP_FontAsset.NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663730);
			TMP_FontAsset.NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663731);
			TMP_FontAsset.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663732);
			TMP_FontAsset.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663733);
			TMP_FontAsset.NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663734);
			TMP_FontAsset.NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663735);
			TMP_FontAsset.NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663736);
			TMP_FontAsset.NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663737);
			TMP_FontAsset.NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663738);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663739);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663740);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663741);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663742);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663743);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663744);
			TMP_FontAsset.NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663745);
			TMP_FontAsset.NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663746);
			TMP_FontAsset.NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663747);
			TMP_FontAsset.NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663748);
			TMP_FontAsset.NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663749);
			TMP_FontAsset.NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663750);
			TMP_FontAsset.NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663751);
			TMP_FontAsset.NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663752);
			TMP_FontAsset.NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663753);
			TMP_FontAsset.NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663754);
			TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663755);
			TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663756);
			TMP_FontAsset.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663757);
			TMP_FontAsset.NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663758);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663759);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663760);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663761);
			TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663762);
			TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663763);
			TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663764);
			TMP_FontAsset.NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663765);
			TMP_FontAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663766);
			TMP_FontAsset.NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663767);
			TMP_FontAsset.NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663768);
			TMP_FontAsset.NativeMethodInfoPtr_SortAllTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663769);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663770);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663771);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663772);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663773);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663774);
			TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663775);
			TMP_FontAsset.NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663776);
			TMP_FontAsset.NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663777);
			TMP_FontAsset.NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663778);
			TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663779);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663780);
			TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForAtlasTextureUpdate_Internal_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663781);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexturesForFontAssetsInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663782);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663783);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663784);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663785);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663786);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663787);
			TMP_FontAsset.NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663788);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663789);
			TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663790);
			TMP_FontAsset.NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663791);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663792);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663793);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663794);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663795);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663796);
			TMP_FontAsset.NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663797);
			TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663798);
			TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663799);
			TMP_FontAsset.NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663800);
			TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663801);
			TMP_FontAsset.NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663802);
			TMP_FontAsset.NativeMethodInfoPtr_UpgradeFontAsset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663803);
			TMP_FontAsset.NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663804);
			TMP_FontAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663805);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00018A20 File Offset: 0x00016C20
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00018A58 File Offset: 0x00016C58
		public unsafe string version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00018A9C File Offset: 0x00016C9C
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00018ADC File Offset: 0x00016CDC
		public unsafe Font sourceFontFile
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00018B20 File Offset: 0x00016D20
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00018B5C File Offset: 0x00016D5C
		public unsafe AtlasPopulationMode atlasPopulationMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00018B9C File Offset: 0x00016D9C
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00018BD4 File Offset: 0x00016DD4
		public unsafe FaceInfo faceInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FaceInfo(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00018C1C File Offset: 0x00016E1C
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00018C5C File Offset: 0x00016E5C
		public unsafe List<Glyph> glyphTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00018CA0 File Offset: 0x00016EA0
		public unsafe Dictionary<uint, Glyph> glyphLookupTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138909, XrefRangeEnd = 138910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr3) : null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00018CE0 File Offset: 0x00016EE0
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00018D20 File Offset: 0x00016F20
		public unsafe List<TMP_Character> characterTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00018D64 File Offset: 0x00016F64
		public unsafe Dictionary<uint, TMP_Character> characterLookupTable
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 138911, RefRangeEnd = 138922, XrefRangeStart = 138910, XrefRangeEnd = 138911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_Character>>(intPtr3) : null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00018DA4 File Offset: 0x00016FA4
		public unsafe Texture2D atlasTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 138926, RefRangeEnd = 138928, XrefRangeStart = 138922, XrefRangeEnd = 138926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00018DE4 File Offset: 0x00016FE4
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00018E24 File Offset: 0x00017024
		public unsafe Il2CppReferenceArray<Texture2D> atlasTextures
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00018E68 File Offset: 0x00017068
		public unsafe int atlasTextureCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00018EA4 File Offset: 0x000170A4
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00018EE0 File Offset: 0x000170E0
		public unsafe bool isMultiAtlasTexturesEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00018F20 File Offset: 0x00017120
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00018F5C File Offset: 0x0001715C
		public unsafe bool clearDynamicDataOnBuild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00018F9C File Offset: 0x0001719C
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00018FDC File Offset: 0x000171DC
		public unsafe List<GlyphRect> usedGlyphRects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00019020 File Offset: 0x00017220
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00019060 File Offset: 0x00017260
		public unsafe List<GlyphRect> freeGlyphRects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000190A4 File Offset: 0x000172A4
		public unsafe FaceInfo_Legacy fontInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FaceInfo_Legacy>(intPtr3) : null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000190E4 File Offset: 0x000172E4
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00019120 File Offset: 0x00017320
		public unsafe int atlasWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00019160 File Offset: 0x00017360
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x0001919C File Offset: 0x0001739C
		public unsafe int atlasHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000191DC File Offset: 0x000173DC
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00019218 File Offset: 0x00017418
		public unsafe int atlasPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00019258 File Offset: 0x00017458
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00019294 File Offset: 0x00017494
		public unsafe GlyphRenderMode atlasRenderMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000192D4 File Offset: 0x000174D4
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00019314 File Offset: 0x00017514
		public unsafe TMP_FontFeatureTable fontFeatureTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00019358 File Offset: 0x00017558
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00019398 File Offset: 0x00017598
		public unsafe List<TMP_FontAsset> fallbackFontAssetTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000193DC File Offset: 0x000175DC
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00019414 File Offset: 0x00017614
		public unsafe FontAssetCreationSettings creationSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontAssetCreationSettings(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0001945C File Offset: 0x0001765C
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0001949C File Offset: 0x0001769C
		public unsafe Il2CppReferenceArray<TMP_FontWeightPair> fontWeightTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000194E0 File Offset: 0x000176E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138928, XrefRangeEnd = 138932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset CreateFontAsset(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00019524 File Offset: 0x00017724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139036, RefRangeEnd = 139037, XrefRangeStart = 138932, XrefRangeEnd = 139036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingPointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPadding;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPopulationMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMultiAtlasSupport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000195CC File Offset: 0x000177CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139037, XrefRangeEnd = 139043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00019600 File Offset: 0x00017800
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 139079, RefRangeEnd = 139095, XrefRangeStart = 139043, XrefRangeEnd = 139079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadFontAssetDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00019634 File Offset: 0x00017834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139095, XrefRangeEnd = 139098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDictionaryLookupTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00019668 File Offset: 0x00017868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139138, RefRangeEnd = 139140, XrefRangeStart = 139098, XrefRangeEnd = 139138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeGlyphLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001969C File Offset: 0x0001789C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139168, RefRangeEnd = 139170, XrefRangeStart = 139140, XrefRangeEnd = 139168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCharacterLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000196D0 File Offset: 0x000178D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139192, RefRangeEnd = 139194, XrefRangeStart = 139170, XrefRangeEnd = 139192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00019704 File Offset: 0x00017904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139234, RefRangeEnd = 139235, XrefRangeStart = 139194, XrefRangeEnd = 139234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSynthesizedCharactersAndFaceMetrics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00019738 File Offset: 0x00017938
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 139255, RefRangeEnd = 139267, XrefRangeStart = 139235, XrefRangeEnd = 139255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFontFaceLoaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addImmediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00019794 File Offset: 0x00017994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139267, XrefRangeEnd = 139275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCharacterToLookupCache(uint unicode, TMP_Character character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(character);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000197E4 File Offset: 0x000179E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139275, XrefRangeEnd = 139297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCharacterTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00019818 File Offset: 0x00017A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139297, XrefRangeEnd = 139319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001984C File Offset: 0x00017A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139319, XrefRangeEnd = 139321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortFontFeatureTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00019880 File Offset: 0x00017A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139321, XrefRangeEnd = 139367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortAllTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SortAllTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000198B4 File Offset: 0x00017AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139367, XrefRangeEnd = 139370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(int character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00019900 File Offset: 0x00017B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139370, XrefRangeEnd = 139448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00019968 File Offset: 0x00017B68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 139472, RefRangeEnd = 139476, XrefRangeStart = 139448, XrefRangeEnd = 139472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000199D0 File Offset: 0x00017BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139476, XrefRangeEnd = 139492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text, out List<char> missingCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingCharacters = ((intPtr4 == 0) ? null : new List<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00019A40 File Offset: 0x00017C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139492, XrefRangeEnd = 139506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text, out Il2CppStructArray<uint> missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingCharacters = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00019ACC File Offset: 0x00017CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139506, XrefRangeEnd = 139512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00019B1C File Offset: 0x00017D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139512, XrefRangeEnd = 139520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCharacters(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00019B58 File Offset: 0x00017D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139520, XrefRangeEnd = 139527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetCharactersArray(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00019B9C File Offset: 0x00017D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139527, XrefRangeEnd = 139539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetGlyphIndex(uint unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00019BE8 File Offset: 0x00017DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139553, RefRangeEnd = 139554, XrefRangeStart = 139539, XrefRangeEnd = 139553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00019C20 File Offset: 0x00017E20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139577, RefRangeEnd = 139579, XrefRangeStart = 139554, XrefRangeEnd = 139577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateFontFeaturesForFontAssetsInQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00019C48 File Offset: 0x00017E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139579, XrefRangeEnd = 139593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_RegisterFontAssetForAtlasTextureUpdate_Internal_Static_Void_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00019C80 File Offset: 0x00017E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139593, XrefRangeEnd = 139615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAtlasTexturesForFontAssetsInQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexturesForFontAssetsInQueue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00019CA8 File Offset: 0x00017EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139615, XrefRangeEnd = 139616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00019D04 File Offset: 0x00017F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139731, RefRangeEnd = 139733, XrefRangeStart = 139616, XrefRangeEnd = 139731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, out Il2CppStructArray<uint> missingUnicodes, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingUnicodes = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00019D84 File Offset: 0x00017F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139733, XrefRangeEnd = 139734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(string characters, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00019DE0 File Offset: 0x00017FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139850, RefRangeEnd = 139851, XrefRangeStart = 139734, XrefRangeEnd = 139850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			missingCharacters = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00019E58 File Offset: 0x00018058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 139885, RefRangeEnd = 139889, XrefRangeStart = 139851, XrefRangeEnd = 139885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacterInternal(uint unicode, out TMP_Character character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00019EC4 File Offset: 0x000180C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139889, XrefRangeEnd = 139964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00019F30 File Offset: 0x00018130
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAddGlyphsToAtlasTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00019F64 File Offset: 0x00018164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140005, RefRangeEnd = 140007, XrefRangeStart = 139964, XrefRangeEnd = 140005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddGlyphsToNewAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00019FA0 File Offset: 0x000181A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140028, RefRangeEnd = 140029, XrefRangeStart = 140007, XrefRangeEnd = 140028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupNewAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00019FD4 File Offset: 0x000181D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140029, XrefRangeEnd = 140036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001A008 File Offset: 0x00018208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140067, RefRangeEnd = 140070, XrefRangeStart = 140036, XrefRangeEnd = 140067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001A03C File Offset: 0x0001823C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140070, XrefRangeEnd = 140098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001A080 File Offset: 0x00018280
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001A0C4 File Offset: 0x000182C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newGlyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allGlyphIndexes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001A118 File Offset: 0x00018318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140098, XrefRangeEnd = 140101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyListDataToArray<T>(List<T> srcList, ref Il2CppArrayBase<T> dstArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcList);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dstArray);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dstArray = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001A184 File Offset: 0x00018384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140101, XrefRangeEnd = 140104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetData(bool setAtlasSizeToZero = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setAtlasSizeToZero;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001A1C4 File Offset: 0x000183C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140104, XrefRangeEnd = 140106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetDataInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001A1F8 File Offset: 0x000183F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140106, XrefRangeEnd = 140117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFontAssetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001A22C File Offset: 0x0001842C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140139, RefRangeEnd = 140142, XrefRangeStart = 140117, XrefRangeEnd = 140139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001A260 File Offset: 0x00018460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140165, RefRangeEnd = 140168, XrefRangeStart = 140142, XrefRangeEnd = 140165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAtlasTextures(bool setAtlasSizeToZero = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setAtlasSizeToZero;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001A2A0 File Offset: 0x000184A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140343, RefRangeEnd = 140345, XrefRangeStart = 140168, XrefRangeEnd = 140343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpgradeFontAsset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001A2D4 File Offset: 0x000184D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140384, RefRangeEnd = 140385, XrefRangeStart = 140345, XrefRangeEnd = 140384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeGlyphAdjustmentTableToFontFeatureTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001A308 File Offset: 0x00018508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140385, XrefRangeEnd = 140465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000041CE File Offset: 0x000023CE
		public TMP_FontAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0001A344 File Offset: 0x00018544
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x000041D7 File Offset: 0x000023D7
		public unsafe string m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_Version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_Version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0001A36C File Offset: 0x0001856C
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x000041F6 File Offset: 0x000023F6
		public unsafe string m_SourceFontFileGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0001A394 File Offset: 0x00018594
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00004215 File Offset: 0x00002415
		public unsafe Font m_SourceFontFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_SourceFontFile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0001A3C4 File Offset: 0x000185C4
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00004234 File Offset: 0x00002434
		public unsafe AtlasPopulationMode m_AtlasPopulationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0001A3EC File Offset: 0x000185EC
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x0000424F File Offset: 0x0000244F
		public FaceInfo m_FaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FaceInfo);
				return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001A41C File Offset: 0x0001861C
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x0000427D File Offset: 0x0000247D
		public unsafe List<Glyph> m_GlyphTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0001A44C File Offset: 0x0001864C
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x0000429C File Offset: 0x0000249C
		public unsafe Dictionary<uint, Glyph> m_GlyphLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0001A47C File Offset: 0x0001867C
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x000042BB File Offset: 0x000024BB
		public unsafe List<TMP_Character> m_CharacterTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0001A4AC File Offset: 0x000186AC
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x000042DA File Offset: 0x000024DA
		public unsafe Dictionary<uint, TMP_Character> m_CharacterLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0001A4DC File Offset: 0x000186DC
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x000042F9 File Offset: 0x000024F9
		public unsafe Texture2D m_AtlasTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0001A50C File Offset: 0x0001870C
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00004318 File Offset: 0x00002518
		public unsafe Il2CppReferenceArray<Texture2D> m_AtlasTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001A53C File Offset: 0x0001873C
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00004337 File Offset: 0x00002537
		public unsafe int m_AtlasTextureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0001A564 File Offset: 0x00018764
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00004352 File Offset: 0x00002552
		public unsafe bool m_IsMultiAtlasTexturesEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001A58C File Offset: 0x0001878C
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000436D File Offset: 0x0000256D
		public unsafe bool m_ClearDynamicDataOnBuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0001A5B4 File Offset: 0x000187B4
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00004388 File Offset: 0x00002588
		public unsafe List<GlyphRect> m_UsedGlyphRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0001A5E4 File Offset: 0x000187E4
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000043A7 File Offset: 0x000025A7
		public unsafe List<GlyphRect> m_FreeGlyphRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0001A614 File Offset: 0x00018814
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000043C6 File Offset: 0x000025C6
		public unsafe FaceInfo_Legacy m_fontInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_fontInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FaceInfo_Legacy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_fontInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0001A644 File Offset: 0x00018844
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000043E5 File Offset: 0x000025E5
		public unsafe Texture2D atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0001A674 File Offset: 0x00018874
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00004404 File Offset: 0x00002604
		public unsafe int m_AtlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasWidth)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0001A69C File Offset: 0x0001889C
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0000441F File Offset: 0x0000261F
		public unsafe int m_AtlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasHeight)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0001A6C4 File Offset: 0x000188C4
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0000443A File Offset: 0x0000263A
		public unsafe int m_AtlasPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasPadding)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001A6EC File Offset: 0x000188EC
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00004455 File Offset: 0x00002655
		public unsafe GlyphRenderMode m_AtlasRenderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode)) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0001A714 File Offset: 0x00018914
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00004470 File Offset: 0x00002670
		public unsafe List<TMP_Glyph> m_glyphInfoList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_glyphInfoList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_glyphInfoList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0001A744 File Offset: 0x00018944
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x0000448F File Offset: 0x0000268F
		public unsafe KerningTable m_KerningTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_KerningTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_KerningTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0001A774 File Offset: 0x00018974
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x000044AE File Offset: 0x000026AE
		public unsafe TMP_FontFeatureTable m_FontFeatureTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontFeatureTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontFeatureTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001A7A4 File Offset: 0x000189A4
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x000044CD File Offset: 0x000026CD
		public unsafe List<TMP_FontAsset> fallbackFontAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fallbackFontAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fallbackFontAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001A7D4 File Offset: 0x000189D4
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000044EC File Offset: 0x000026EC
		public unsafe List<TMP_FontAsset> m_FallbackFontAssetTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001A804 File Offset: 0x00018A04
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0000450B File Offset: 0x0000270B
		public FontAssetCreationSettings m_CreationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CreationSettings);
				return new FontAssetCreationSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CreationSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0001A834 File Offset: 0x00018A34
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004539 File Offset: 0x00002739
		public unsafe Il2CppReferenceArray<TMP_FontWeightPair> m_FontWeightTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontWeightTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_FontWeightTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001A864 File Offset: 0x00018A64
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00004558 File Offset: 0x00002758
		public unsafe Il2CppReferenceArray<TMP_FontWeightPair> fontWeights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fontWeights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_fontWeights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0001A894 File Offset: 0x00018A94
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00004577 File Offset: 0x00002777
		public unsafe float normalStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalStyle)) = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0001A8BC File Offset: 0x00018ABC
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00004592 File Offset: 0x00002792
		public unsafe float normalSpacingOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalSpacingOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_normalSpacingOffset)) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001A8E4 File Offset: 0x00018AE4
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000045AD File Offset: 0x000027AD
		public unsafe float boldStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldStyle)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001A90C File Offset: 0x00018B0C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000045C8 File Offset: 0x000027C8
		public unsafe float boldSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_boldSpacing)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001A934 File Offset: 0x00018B34
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000045E3 File Offset: 0x000027E3
		public unsafe byte italicStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_italicStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_italicStyle)) = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001A95C File Offset: 0x00018B5C
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x000045FE File Offset: 0x000027FE
		public unsafe byte tabSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_tabSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_tabSize)) = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001A984 File Offset: 0x00018B84
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00004619 File Offset: 0x00002819
		public unsafe bool IsFontAssetLookupTablesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty)) = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001A9AC File Offset: 0x00018BAC
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004634 File Offset: 0x00002834
		public unsafe static ProfilerMarker k_ReadFontAssetDefinitionMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001A9C8 File Offset: 0x00018BC8
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004642 File Offset: 0x00002842
		public unsafe static ProfilerMarker k_AddSynthesizedCharactersMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0001A9E4 File Offset: 0x00018BE4
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004650 File Offset: 0x00002850
		public unsafe static ProfilerMarker k_TryAddCharacterMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0001AA00 File Offset: 0x00018C00
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x0000465E File Offset: 0x0000285E
		public unsafe static ProfilerMarker k_TryAddCharactersMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0001AA1C File Offset: 0x00018C1C
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x0000466C File Offset: 0x0000286C
		public unsafe static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0001AA38 File Offset: 0x00018C38
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0000467A File Offset: 0x0000287A
		public unsafe static ProfilerMarker k_ClearFontAssetDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0001AA54 File Offset: 0x00018C54
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00004688 File Offset: 0x00002888
		public unsafe static ProfilerMarker k_UpdateFontAssetDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0001AA70 File Offset: 0x00018C70
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00004696 File Offset: 0x00002896
		public unsafe static string s_DefaultMaterialSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0001AA90 File Offset: 0x00018C90
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x000046A8 File Offset: 0x000028A8
		public unsafe HashSet<int> FallbackSearchQueryLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_FallbackSearchQueryLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_FallbackSearchQueryLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x000046C7 File Offset: 0x000028C7
		public unsafe static HashSet<int> k_SearchedFontAssetLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0001AAE8 File Offset: 0x00018CE8
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x000046D9 File Offset: 0x000028D9
		public unsafe static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001AB10 File Offset: 0x00018D10
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x000046EB File Offset: 0x000028EB
		public unsafe static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001AB38 File Offset: 0x00018D38
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x000046FD File Offset: 0x000028FD
		public unsafe static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001AB60 File Offset: 0x00018D60
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0000470F File Offset: 0x0000290F
		public unsafe static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001AB88 File Offset: 0x00018D88
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00004721 File Offset: 0x00002921
		public unsafe List<Glyph> m_GlyphsToRender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToRender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToRender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00004740 File Offset: 0x00002940
		public unsafe List<Glyph> m_GlyphsRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsRendered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsRendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0001ABE8 File Offset: 0x00018DE8
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x0000475F File Offset: 0x0000295F
		public unsafe List<uint> m_GlyphIndexList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0001AC18 File Offset: 0x00018E18
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0000477E File Offset: 0x0000297E
		public unsafe List<uint> m_GlyphIndexListNewlyAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0001AC48 File Offset: 0x00018E48
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0000479D File Offset: 0x0000299D
		public unsafe List<uint> m_GlyphsToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0001AC78 File Offset: 0x00018E78
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x000047BC File Offset: 0x000029BC
		public unsafe HashSet<uint> m_GlyphsToAddLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x000047DB File Offset: 0x000029DB
		public unsafe List<TMP_Character> m_CharactersToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x000047FA File Offset: 0x000029FA
		public unsafe HashSet<uint> m_CharactersToAddLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001AD08 File Offset: 0x00018F08
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00004819 File Offset: 0x00002A19
		public unsafe List<uint> s_MissingCharacterList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_s_MissingCharacterList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_s_MissingCharacterList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001AD38 File Offset: 0x00018F38
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00004838 File Offset: 0x00002A38
		public unsafe HashSet<uint> m_MissingUnicodesFromFontFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001AD68 File Offset: 0x00018F68
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00004857 File Offset: 0x00002A57
		public unsafe static Il2CppStructArray<uint> k_GlyphIndexArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceFontFileGUID;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceFontFile;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasPopulationMode;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceInfo;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphTable;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphLookupDictionary;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterTable;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLookupDictionary;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTexture;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTextures;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTextureIndex;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDynamicDataOnBuild;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_m_UsedGlyphRects;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeGlyphRects;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_m_fontInfo;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_atlas;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasWidth;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasHeight;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasPadding;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasRenderMode;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_m_glyphInfoList;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_m_KerningTable;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_m_FontFeatureTable;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_fallbackFontAssets;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackFontAssetTable;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_m_CreationSettings;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightTable;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_fontWeights;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr_normalStyle;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeFieldInfoPtr_normalSpacingOffset;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeFieldInfoPtr_boldStyle;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeFieldInfoPtr_boldSpacing;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeFieldInfoPtr_italicStyle;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeFieldInfoPtr_tabSize;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeFieldInfoPtr_IsFontAssetLookupTablesDirty;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_k_TryAddCharacterMarker;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr_k_TryAddCharactersMarker;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeFieldInfoPtr_k_ClearFontAssetDataMarker;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateFontAssetDataMarker;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultMaterialSuffix;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_FallbackSearchQueryLookup;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr_k_SearchedFontAssetLookup;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToRender;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsRendered;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexList;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToAdd;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToAddLookup;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_m_CharactersToAdd;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_m_CharactersToAddLookup;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_s_MissingCharacterList;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingUnicodesFromFontFile;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_k_GlyphIndexArray;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_String_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_set_version_Internal_set_Void_String_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_SortAllTables_Internal_Void_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFontAssetForAtlasTextureUpdate_Internal_Static_Void_TMP_FontAsset_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAtlasTexturesForFontAssetsInQueue_Internal_Static_Void_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeFontAsset_Internal_Void_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000086 RID: 134
		[ObfuscatedName("TMPro.TMP_FontAsset+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000F09 RID: 3849 RVA: 0x0003C54C File Offset: 0x0003A74C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr);
				TMP_FontAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, "<>9");
				TMP_FontAsset.__c.NativeFieldInfoPtr___9__124_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, "<>9__124_0");
				TMP_FontAsset.__c.NativeFieldInfoPtr___9__125_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, "<>9__125_0");
				TMP_FontAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, 100664837);
				TMP_FontAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__124_0_Internal_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, 100664838);
				TMP_FontAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__125_0_Internal_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr, 100664839);
			}

			// Token: 0x06000F0A RID: 3850 RVA: 0x0003C5F0 File Offset: 0x0003A7F0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F0B RID: 3851 RVA: 0x0003C62C File Offset: 0x0003A82C
			[CallerCount(0)]
			public unsafe uint _SortCharacterTable_b__124_0(TMP_Character c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__124_0_Internal_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F0C RID: 3852 RVA: 0x0003C67C File Offset: 0x0003A87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138907, XrefRangeEnd = 138909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortGlyphTable_b__125_0(Glyph c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__125_0_Internal_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F0D RID: 3853 RVA: 0x000091CA File Offset: 0x000073CA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0003C6CC File Offset: 0x0003A8CC
			// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000091D3 File Offset: 0x000073D3
			public unsafe static TMP_FontAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0003C6F4 File Offset: 0x0003A8F4
			// (set) Token: 0x06000F11 RID: 3857 RVA: 0x000091E5 File Offset: 0x000073E5
			public unsafe static Func<TMP_Character, uint> __9__124_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__124_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_Character, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__124_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0003C71C File Offset: 0x0003A91C
			// (set) Token: 0x06000F13 RID: 3859 RVA: 0x000091F7 File Offset: 0x000073F7
			public unsafe static Func<Glyph, uint> __9__125_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__125_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Glyph, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_FontAsset.__c.NativeFieldInfoPtr___9__125_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BDF RID: 3039
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000BE0 RID: 3040
			private static readonly IntPtr NativeFieldInfoPtr___9__124_0;

			// Token: 0x04000BE1 RID: 3041
			private static readonly IntPtr NativeFieldInfoPtr___9__125_0;

			// Token: 0x04000BE2 RID: 3042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BE3 RID: 3043
			private static readonly IntPtr NativeMethodInfoPtr__SortCharacterTable_b__124_0_Internal_UInt32_TMP_Character_0;

			// Token: 0x04000BE4 RID: 3044
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphTable_b__125_0_Internal_UInt32_Glyph_0;
		}

		// Token: 0x02000087 RID: 135
		private sealed class MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04000BE5 RID: 3045
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_FontAsset.NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
