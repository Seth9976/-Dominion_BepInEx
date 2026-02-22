using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000066 RID: 102
	public class TMP_Text : MaskableGraphic
	{
		// Token: 0x06000A7B RID: 2683 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Text()
		{
			Il2CppClassPointerStore<TMP_Text>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Text");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr);
			TMP_Text.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_text");
			TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsTextBackingStringDirty");
			TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextPreprocessor");
			TMP_Text.NativeFieldInfoPtr_m_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isRightToLeft");
			TMP_Text.NativeFieldInfoPtr_m_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontAsset");
			TMP_Text.NativeFieldInfoPtr_m_currentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentFontAsset");
			TMP_Text.NativeFieldInfoPtr_m_isSDFShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isSDFShader");
			TMP_Text.NativeFieldInfoPtr_m_sharedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_sharedMaterial");
			TMP_Text.NativeFieldInfoPtr_m_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentMaterial");
			TMP_Text.NativeFieldInfoPtr_m_materialReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferences");
			TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferenceIndexLookup");
			TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferenceStack");
			TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentMaterialIndex");
			TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSharedMaterials");
			TMP_Text.NativeFieldInfoPtr_m_fontMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontMaterial");
			TMP_Text.NativeFieldInfoPtr_m_fontMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontMaterials");
			TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isMaterialDirty");
			TMP_Text.NativeFieldInfoPtr_m_fontColor32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColor32");
			TMP_Text.NativeFieldInfoPtr_m_fontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColor");
			TMP_Text.NativeFieldInfoPtr_s_colorWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "s_colorWhite");
			TMP_Text.NativeFieldInfoPtr_m_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_underlineColor");
			TMP_Text.NativeFieldInfoPtr_m_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_strikethroughColor");
			TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableVertexGradient");
			TMP_Text.NativeFieldInfoPtr_m_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorMode");
			TMP_Text.NativeFieldInfoPtr_m_fontColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColorGradient");
			TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColorGradientPreset");
			TMP_Text.NativeFieldInfoPtr_m_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_tintAllSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tintAllSprites");
			TMP_Text.NativeFieldInfoPtr_m_tintSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tintSprite");
			TMP_Text.NativeFieldInfoPtr_m_spriteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteColor");
			TMP_Text.NativeFieldInfoPtr_m_StyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_StyleSheet");
			TMP_Text.NativeFieldInfoPtr_m_TextStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyle");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleHashCode");
			TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_overrideHtmlColors");
			TMP_Text.NativeFieldInfoPtr_m_faceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_faceColor");
			TMP_Text.NativeFieldInfoPtr_m_outlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_outlineColor");
			TMP_Text.NativeFieldInfoPtr_m_outlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_outlineWidth");
			TMP_Text.NativeFieldInfoPtr_m_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSize");
			TMP_Text.NativeFieldInfoPtr_m_currentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentFontSize");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeBase");
			TMP_Text.NativeFieldInfoPtr_m_sizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_sizeStack");
			TMP_Text.NativeFieldInfoPtr_m_fontWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontWeight");
			TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontWeightInternal");
			TMP_Text.NativeFieldInfoPtr_m_FontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontWeightStack");
			TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableAutoSizing");
			TMP_Text.NativeFieldInfoPtr_m_maxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxFontSize");
			TMP_Text.NativeFieldInfoPtr_m_minFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minFontSize");
			TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_AutoSizeIterationCount");
			TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_AutoSizeMaxIterationCount");
			TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsAutoSizePointSizeSet");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeMin");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeMax");
			TMP_Text.NativeFieldInfoPtr_m_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontStyle");
			TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontStyleInternal");
			TMP_Text.NativeFieldInfoPtr_m_fontStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontStyleStack");
			TMP_Text.NativeFieldInfoPtr_m_isUsingBold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isUsingBold");
			TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_HorizontalAlignment");
			TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_VerticalAlignment");
			TMP_Text.NativeFieldInfoPtr_m_textAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textAlignment");
			TMP_Text.NativeFieldInfoPtr_m_lineJustification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineJustification");
			TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineJustificationStack");
			TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textContainerLocalCorners");
			TMP_Text.NativeFieldInfoPtr_m_characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_characterSpacing");
			TMP_Text.NativeFieldInfoPtr_m_cSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_cSpacing");
			TMP_Text.NativeFieldInfoPtr_m_monoSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_monoSpacing");
			TMP_Text.NativeFieldInfoPtr_m_wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_wordSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacingDelta");
			TMP_Text.NativeFieldInfoPtr_m_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineHeight");
			TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsDrivenLineSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacingMax");
			TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_paragraphSpacing");
			TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_charWidthMaxAdj");
			TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_charWidthAdjDelta");
			TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableWordWrapping");
			TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCharacterWrappingEnabled");
			TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isNonBreakingSpace");
			TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isIgnoringAlignment");
			TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_wordWrappingRatios");
			TMP_Text.NativeFieldInfoPtr_m_overflowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_overflowMode");
			TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstOverflowCharacterIndex");
			TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_linkedTextComponent");
			TMP_Text.NativeFieldInfoPtr_parentLinkedComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "parentLinkedComponent");
			TMP_Text.NativeFieldInfoPtr_m_isTextTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isTextTruncated");
			TMP_Text.NativeFieldInfoPtr_m_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableKerning");
			TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_GlyphHorizontalAdvanceAdjustment");
			TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableExtraPadding");
			TMP_Text.NativeFieldInfoPtr_checkPaddingRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "checkPaddingRequired");
			TMP_Text.NativeFieldInfoPtr_m_isRichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isRichText");
			TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_parseCtrlCharacters");
			TMP_Text.NativeFieldInfoPtr_m_isOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isOverlay");
			TMP_Text.NativeFieldInfoPtr_m_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isOrthographic");
			TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCullingEnabled");
			TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isMaskingEnabled");
			TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "isMaskUpdateRequired");
			TMP_Text.NativeFieldInfoPtr_m_ignoreCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ignoreCulling");
			TMP_Text.NativeFieldInfoPtr_m_horizontalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_horizontalMapping");
			TMP_Text.NativeFieldInfoPtr_m_verticalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_verticalMapping");
			TMP_Text.NativeFieldInfoPtr_m_uvLineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_uvLineOffset");
			TMP_Text.NativeFieldInfoPtr_m_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderMode");
			TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_geometrySortingOrder");
			TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsTextObjectScaleStatic");
			TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_VertexBufferAutoSizeReduction");
			TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstVisibleCharacter");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleCharacters");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleWords");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleLines");
			TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_useMaxVisibleDescender");
			TMP_Text.NativeFieldInfoPtr_m_pageToDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_pageToDisplay");
			TMP_Text.NativeFieldInfoPtr_m_isNewPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isNewPage");
			TMP_Text.NativeFieldInfoPtr_m_margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_margin");
			TMP_Text.NativeFieldInfoPtr_m_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginLeft");
			TMP_Text.NativeFieldInfoPtr_m_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginRight");
			TMP_Text.NativeFieldInfoPtr_m_marginWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginWidth");
			TMP_Text.NativeFieldInfoPtr_m_marginHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginHeight");
			TMP_Text.NativeFieldInfoPtr_m_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_width");
			TMP_Text.NativeFieldInfoPtr_m_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textInfo");
			TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_havePropertiesChanged");
			TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isUsingLegacyAnimationComponent");
			TMP_Text.NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_transform");
			TMP_Text.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_rectTransform");
			TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PreviousRectTransformSize");
			TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PreviousPivotPosition");
			TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "<autoSizeTextContainer>k__BackingField");
			TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_autoSizeTextContainer");
			TMP_Text.NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_mesh");
			TMP_Text.NativeFieldInfoPtr_m_isVolumetricText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isVolumetricText");
			TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnFontAssetRequest");
			TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnSpriteAssetRequest");
			TMP_Text.NativeFieldInfoPtr_OnPreRenderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnPreRenderText");
			TMP_Text.NativeFieldInfoPtr_m_spriteAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAnimator");
			TMP_Text.NativeFieldInfoPtr_m_flexibleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_flexibleHeight");
			TMP_Text.NativeFieldInfoPtr_m_flexibleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_flexibleWidth");
			TMP_Text.NativeFieldInfoPtr_m_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minWidth");
			TMP_Text.NativeFieldInfoPtr_m_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minHeight");
			TMP_Text.NativeFieldInfoPtr_m_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxWidth");
			TMP_Text.NativeFieldInfoPtr_m_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxHeight");
			TMP_Text.NativeFieldInfoPtr_m_LayoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_LayoutElement");
			TMP_Text.NativeFieldInfoPtr_m_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_preferredWidth");
			TMP_Text.NativeFieldInfoPtr_m_renderedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderedWidth");
			TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isPreferredWidthDirty");
			TMP_Text.NativeFieldInfoPtr_m_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_preferredHeight");
			TMP_Text.NativeFieldInfoPtr_m_renderedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderedHeight");
			TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isPreferredHeightDirty");
			TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCalculatingPreferredValues");
			TMP_Text.NativeFieldInfoPtr_m_layoutPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_layoutPriority");
			TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isLayoutDirty");
			TMP_Text.NativeFieldInfoPtr_m_isAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isAwake");
			TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isWaitingOnResourceLoad");
			TMP_Text.NativeFieldInfoPtr_m_inputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_inputSource");
			TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontScaleMultiplier");
			TMP_Text.NativeFieldInfoPtr_m_htmlTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_htmlTag");
			TMP_Text.NativeFieldInfoPtr_m_xmlAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_xmlAttribute");
			TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_attributeParameterValues");
			TMP_Text.NativeFieldInfoPtr_tag_LineIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_LineIndent");
			TMP_Text.NativeFieldInfoPtr_tag_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_Indent");
			TMP_Text.NativeFieldInfoPtr_m_indentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_indentStack");
			TMP_Text.NativeFieldInfoPtr_tag_NoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_NoParsing");
			TMP_Text.NativeFieldInfoPtr_m_isParsingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isParsingText");
			TMP_Text.NativeFieldInfoPtr_m_FXMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FXMatrix");
			TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isFXMatrixSet");
			TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextProcessingArray");
			TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_InternalTextProcessingArraySize");
			TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_internalCharacterInfo");
			TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_totalCharacterCount");
			TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedWordWrapState");
			TMP_Text.NativeFieldInfoPtr_m_SavedLineState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedLineState");
			TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedEllipsisState");
			TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedLastValidState");
			TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedSoftLineBreakState");
			TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_EllipsisInsertionCandidateStack");
			TMP_Text.NativeFieldInfoPtr_m_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_characterCount");
			TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstVisibleCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lastCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lastVisibleCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineNumber");
			TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineVisibleCharacterCount");
			TMP_Text.NativeFieldInfoPtr_m_pageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_pageNumber");
			TMP_Text.NativeFieldInfoPtr_m_PageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PageAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxTextAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxTextAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxCapHeight");
			TMP_Text.NativeFieldInfoPtr_m_ElementAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ElementAscender");
			TMP_Text.NativeFieldInfoPtr_m_ElementDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ElementDescender");
			TMP_Text.NativeFieldInfoPtr_m_maxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxLineAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxLineDescender");
			TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_startOfLineAscender");
			TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_startOfLineDescender");
			TMP_Text.NativeFieldInfoPtr_m_lineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineOffset");
			TMP_Text.NativeFieldInfoPtr_m_meshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_meshExtents");
			TMP_Text.NativeFieldInfoPtr_m_htmlColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_htmlColor");
			TMP_Text.NativeFieldInfoPtr_m_colorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorStack");
			TMP_Text.NativeFieldInfoPtr_m_underlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_underlineColorStack");
			TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_strikethroughColorStack");
			TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_HighlightStateStack");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientPreset");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientStack");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientPresetIsTinted");
			TMP_Text.NativeFieldInfoPtr_m_tabSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tabSpacing");
			TMP_Text.NativeFieldInfoPtr_m_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spacing");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleStacks");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleStackDepth");
			TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ItalicAngleStack");
			TMP_Text.NativeFieldInfoPtr_m_ItalicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ItalicAngle");
			TMP_Text.NativeFieldInfoPtr_m_actionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_actionStack");
			TMP_Text.NativeFieldInfoPtr_m_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_padding");
			TMP_Text.NativeFieldInfoPtr_m_baselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_baselineOffset");
			TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_baselineOffsetStack");
			TMP_Text.NativeFieldInfoPtr_m_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_xAdvance");
			TMP_Text.NativeFieldInfoPtr_m_textElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textElementType");
			TMP_Text.NativeFieldInfoPtr_m_cached_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_cached_TextElement");
			TMP_Text.NativeFieldInfoPtr_m_Ellipsis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_Ellipsis");
			TMP_Text.NativeFieldInfoPtr_m_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_Underline");
			TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_defaultSpriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentSpriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_spriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteCount");
			TMP_Text.NativeFieldInfoPtr_m_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteIndex");
			TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAnimationID");
			TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_ParseTextMarker");
			TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_InsertNewLineMarker");
			TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ignoreActiveState");
			TMP_Text.NativeFieldInfoPtr_m_TextBackingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextBackingArray");
			TMP_Text.NativeFieldInfoPtr_k_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_Power");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveVector2");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeVector2");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveFloat");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeFloat");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveInt");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeInt");
			TMP_Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664369);
			TMP_Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664370);
			TMP_Text.NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664371);
			TMP_Text.NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664372);
			TMP_Text.NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664373);
			TMP_Text.NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664374);
			TMP_Text.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664375);
			TMP_Text.NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664376);
			TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664377);
			TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664378);
			TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664379);
			TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664380);
			TMP_Text.NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664381);
			TMP_Text.NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664382);
			TMP_Text.NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664383);
			TMP_Text.NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664384);
			TMP_Text.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664385);
			TMP_Text.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664386);
			TMP_Text.NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664387);
			TMP_Text.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664388);
			TMP_Text.NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664389);
			TMP_Text.NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664390);
			TMP_Text.NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664391);
			TMP_Text.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664392);
			TMP_Text.NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664393);
			TMP_Text.NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664394);
			TMP_Text.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664395);
			TMP_Text.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664396);
			TMP_Text.NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664397);
			TMP_Text.NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664398);
			TMP_Text.NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664399);
			TMP_Text.NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664400);
			TMP_Text.NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664401);
			TMP_Text.NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664402);
			TMP_Text.NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664403);
			TMP_Text.NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664404);
			TMP_Text.NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664405);
			TMP_Text.NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664406);
			TMP_Text.NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664407);
			TMP_Text.NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664408);
			TMP_Text.NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664409);
			TMP_Text.NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664410);
			TMP_Text.NativeMethodInfoPtr_get_fontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664411);
			TMP_Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664412);
			TMP_Text.NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664413);
			TMP_Text.NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664414);
			TMP_Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664415);
			TMP_Text.NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664416);
			TMP_Text.NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664417);
			TMP_Text.NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664418);
			TMP_Text.NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664419);
			TMP_Text.NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664420);
			TMP_Text.NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664421);
			TMP_Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664422);
			TMP_Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664423);
			TMP_Text.NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664424);
			TMP_Text.NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664425);
			TMP_Text.NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664426);
			TMP_Text.NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664427);
			TMP_Text.NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664428);
			TMP_Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664429);
			TMP_Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664430);
			TMP_Text.NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664431);
			TMP_Text.NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664432);
			TMP_Text.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664433);
			TMP_Text.NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664434);
			TMP_Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664435);
			TMP_Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664436);
			TMP_Text.NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664437);
			TMP_Text.NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664438);
			TMP_Text.NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664439);
			TMP_Text.NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664440);
			TMP_Text.NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664441);
			TMP_Text.NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664442);
			TMP_Text.NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664443);
			TMP_Text.NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664444);
			TMP_Text.NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664445);
			TMP_Text.NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664446);
			TMP_Text.NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664447);
			TMP_Text.NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664448);
			TMP_Text.NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664449);
			TMP_Text.NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664450);
			TMP_Text.NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664451);
			TMP_Text.NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664452);
			TMP_Text.NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664453);
			TMP_Text.NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664454);
			TMP_Text.NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664455);
			TMP_Text.NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664456);
			TMP_Text.NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664457);
			TMP_Text.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664458);
			TMP_Text.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664459);
			TMP_Text.NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664460);
			TMP_Text.NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664461);
			TMP_Text.NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664462);
			TMP_Text.NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664463);
			TMP_Text.NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664464);
			TMP_Text.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664465);
			TMP_Text.NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664466);
			TMP_Text.NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664467);
			TMP_Text.NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664468);
			TMP_Text.NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664469);
			TMP_Text.NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664470);
			TMP_Text.NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664471);
			TMP_Text.NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664472);
			TMP_Text.NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664473);
			TMP_Text.NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664474);
			TMP_Text.NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664475);
			TMP_Text.NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664476);
			TMP_Text.NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664477);
			TMP_Text.NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664478);
			TMP_Text.NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664479);
			TMP_Text.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664480);
			TMP_Text.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664481);
			TMP_Text.NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664482);
			TMP_Text.NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664483);
			TMP_Text.NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664484);
			TMP_Text.NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664485);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664486);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664487);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664488);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664489);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664490);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664491);
			TMP_Text.NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664492);
			TMP_Text.NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664493);
			TMP_Text.NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664494);
			TMP_Text.NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664495);
			TMP_Text.NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664496);
			TMP_Text.NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664497);
			TMP_Text.NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664498);
			TMP_Text.NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664499);
			TMP_Text.NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664500);
			TMP_Text.NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664501);
			TMP_Text.NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664502);
			TMP_Text.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664503);
			TMP_Text.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664504);
			TMP_Text.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664505);
			TMP_Text.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664506);
			TMP_Text.NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664507);
			TMP_Text.NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664508);
			TMP_Text.NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664509);
			TMP_Text.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664510);
			TMP_Text.NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664511);
			TMP_Text.NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664512);
			TMP_Text.NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664513);
			TMP_Text.NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664514);
			TMP_Text.NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664515);
			TMP_Text.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664516);
			TMP_Text.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664517);
			TMP_Text.NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664518);
			TMP_Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664519);
			TMP_Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664520);
			TMP_Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664521);
			TMP_Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664522);
			TMP_Text.NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664523);
			TMP_Text.NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664524);
			TMP_Text.NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664525);
			TMP_Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664526);
			TMP_Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664527);
			TMP_Text.NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664528);
			TMP_Text.NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664529);
			TMP_Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664530);
			TMP_Text.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664531);
			TMP_Text.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664532);
			TMP_Text.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664533);
			TMP_Text.NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664534);
			TMP_Text.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664535);
			TMP_Text.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664536);
			TMP_Text.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664537);
			TMP_Text.NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664538);
			TMP_Text.NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664539);
			TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664540);
			TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664541);
			TMP_Text.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664542);
			TMP_Text.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664543);
			TMP_Text.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664544);
			TMP_Text.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664545);
			TMP_Text.NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664546);
			TMP_Text.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664547);
			TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664548);
			TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664549);
			TMP_Text.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664550);
			TMP_Text.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664551);
			TMP_Text.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664552);
			TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664553);
			TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664554);
			TMP_Text.NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664555);
			TMP_Text.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664556);
			TMP_Text.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664557);
			TMP_Text.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664558);
			TMP_Text.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664559);
			TMP_Text.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664560);
			TMP_Text.NativeMethodInfoPtr_ParseInputText_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664561);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664562);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664563);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664564);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664565);
			TMP_Text.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664566);
			TMP_Text.NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664567);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664568);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664569);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664570);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664571);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664572);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664573);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664574);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664575);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664576);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664577);
			TMP_Text.NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664578);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664579);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664580);
			TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664581);
			TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664582);
			TMP_Text.NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664583);
			TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664584);
			TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664585);
			TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664586);
			TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664587);
			TMP_Text.NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664588);
			TMP_Text.NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664589);
			TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664590);
			TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664591);
			TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664592);
			TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664593);
			TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664594);
			TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664595);
			TMP_Text.NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664596);
			TMP_Text.NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664597);
			TMP_Text.NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664598);
			TMP_Text.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664599);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664600);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664601);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664602);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664603);
			TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664604);
			TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664605);
			TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664606);
			TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664607);
			TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664608);
			TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664609);
			TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664610);
			TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664611);
			TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664612);
			TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664613);
			TMP_Text.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664614);
			TMP_Text.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664615);
			TMP_Text.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664616);
			TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664617);
			TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664618);
			TMP_Text.NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664619);
			TMP_Text.NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664620);
			TMP_Text.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664621);
			TMP_Text.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664622);
			TMP_Text.NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664623);
			TMP_Text.NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664624);
			TMP_Text.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664625);
			TMP_Text.NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664626);
			TMP_Text.NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664627);
			TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664628);
			TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664629);
			TMP_Text.NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664630);
			TMP_Text.NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664631);
			TMP_Text.NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664632);
			TMP_Text.NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664633);
			TMP_Text.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664634);
			TMP_Text.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664635);
			TMP_Text.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664636);
			TMP_Text.NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664637);
			TMP_Text.NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664638);
			TMP_Text.NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664639);
			TMP_Text.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664640);
			TMP_Text.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664641);
			TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664642);
			TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664643);
			TMP_Text.NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664644);
			TMP_Text.NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664645);
			TMP_Text.NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664646);
			TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664647);
			TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664648);
			TMP_Text.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664649);
			TMP_Text.NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664650);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664651);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664652);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664653);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664654);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664655);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664656);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664657);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664658);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664659);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664660);
			TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664661);
			TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664662);
			TMP_Text.NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664663);
			TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664664);
			TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664665);
			TMP_Text.NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664666);
			TMP_Text.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664667);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002F068 File Offset: 0x0002D268
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x0002F0AC File Offset: 0x0002D2AC
		public unsafe virtual string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146287, XrefRangeEnd = 146288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0002F13C File Offset: 0x0002D33C
		public unsafe ITextPreprocessor textPreprocessor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextPreprocessor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002F180 File Offset: 0x0002D380
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		public unsafe bool isRightToLeftText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002F1FC File Offset: 0x0002D3FC
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0002F23C File Offset: 0x0002D43C
		public unsafe TMP_FontAsset font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 146292, RefRangeEnd = 146300, XrefRangeStart = 146288, XrefRangeEnd = 146292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002F280 File Offset: 0x0002D480
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0002F2CC File Offset: 0x0002D4CC
		public unsafe virtual Material fontSharedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146300, XrefRangeEnd = 146304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002F31C File Offset: 0x0002D51C
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0002F368 File Offset: 0x0002D568
		public unsafe virtual Il2CppReferenceArray<Material> fontSharedMaterials
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 146304, RefRangeEnd = 146312, XrefRangeStart = 146304, XrefRangeEnd = 146304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0002F3F8 File Offset: 0x0002D5F8
		public unsafe Material fontMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 146312, RefRangeEnd = 146314, XrefRangeStart = 146312, XrefRangeEnd = 146312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146314, XrefRangeEnd = 146320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002F43C File Offset: 0x0002D63C
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x0002F488 File Offset: 0x0002D688
		public unsafe virtual Il2CppReferenceArray<Material> fontMaterials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0002F520 File Offset: 0x0002D720
		public unsafe override Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146320, XrefRangeEnd = 146321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002F56C File Offset: 0x0002D76C
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0002F5A8 File Offset: 0x0002D7A8
		public unsafe float alpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0002F5E8 File Offset: 0x0002D7E8
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x0002F624 File Offset: 0x0002D824
		public unsafe bool enableVertexGradient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002F664 File Offset: 0x0002D864
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		public unsafe VertexGradient colorGradient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002F6E0 File Offset: 0x0002D8E0
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0002F720 File Offset: 0x0002D920
		public unsafe TMP_ColorGradient colorGradientPreset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002F764 File Offset: 0x0002D964
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0002F7A4 File Offset: 0x0002D9A4
		public unsafe TMP_SpriteAsset spriteAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0002F824 File Offset: 0x0002DA24
		public unsafe bool tintAllSprites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0002F864 File Offset: 0x0002DA64
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x0002F8A4 File Offset: 0x0002DAA4
		public unsafe TMP_StyleSheet styleSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0002F8E8 File Offset: 0x0002DAE8
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x0002F928 File Offset: 0x0002DB28
		public unsafe TMP_Style textStyle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 146332, RefRangeEnd = 146334, XrefRangeStart = 146321, XrefRangeEnd = 146332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146334, XrefRangeEnd = 146335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002F96C File Offset: 0x0002DB6C
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0002F9A8 File Offset: 0x0002DBA8
		public unsafe bool overrideColorTags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0002FA24 File Offset: 0x0002DC24
		public unsafe Color32 faceColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146335, XrefRangeEnd = 146345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146345, XrefRangeEnd = 146346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002FA64 File Offset: 0x0002DC64
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
		public unsafe Color32 outlineColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146346, XrefRangeEnd = 146356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146356, XrefRangeEnd = 146357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002FAE0 File Offset: 0x0002DCE0
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		public unsafe float outlineWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146357, XrefRangeEnd = 146366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002FB5C File Offset: 0x0002DD5C
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0002FB98 File Offset: 0x0002DD98
		public unsafe float fontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 146366, RefRangeEnd = 146387, XrefRangeStart = 146366, XrefRangeEnd = 146366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0002FC14 File Offset: 0x0002DE14
		public unsafe FontWeight fontWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0002FC54 File Offset: 0x0002DE54
		public unsafe float pixelsPerUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146387, XrefRangeEnd = 146403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0002FC90 File Offset: 0x0002DE90
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0002FCCC File Offset: 0x0002DECC
		public unsafe bool enableAutoSizing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002FD0C File Offset: 0x0002DF0C
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0002FD48 File Offset: 0x0002DF48
		public unsafe float fontSizeMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002FD88 File Offset: 0x0002DF88
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0002FDC4 File Offset: 0x0002DFC4
		public unsafe float fontSizeMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0002FE04 File Offset: 0x0002E004
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0002FE40 File Offset: 0x0002E040
		public unsafe FontStyles fontStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 146403, RefRangeEnd = 146404, XrefRangeStart = 146403, XrefRangeEnd = 146403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002FE80 File Offset: 0x0002E080
		public unsafe bool isUsingBold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002FEBC File Offset: 0x0002E0BC
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		public unsafe HorizontalAlignmentOptions horizontalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002FF38 File Offset: 0x0002E138
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x0002FF74 File Offset: 0x0002E174
		public unsafe VerticalAlignmentOptions verticalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0002FFB4 File Offset: 0x0002E1B4
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x0002FFF0 File Offset: 0x0002E1F0
		public unsafe TextAlignmentOptions alignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 146404, RefRangeEnd = 146419, XrefRangeStart = 146404, XrefRangeEnd = 146404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00030030 File Offset: 0x0002E230
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0003006C File Offset: 0x0002E26C
		public unsafe float characterSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x000300AC File Offset: 0x0002E2AC
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x000300E8 File Offset: 0x0002E2E8
		public unsafe float wordSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00030128 File Offset: 0x0002E328
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00030164 File Offset: 0x0002E364
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000301A4 File Offset: 0x0002E3A4
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x000301E0 File Offset: 0x0002E3E0
		public unsafe float lineSpacingAdjustment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00030220 File Offset: 0x0002E420
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0003025C File Offset: 0x0002E45C
		public unsafe float paragraphSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0003029C File Offset: 0x0002E49C
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x000302D8 File Offset: 0x0002E4D8
		public unsafe float characterWidthAdjustment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00030318 File Offset: 0x0002E518
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00030354 File Offset: 0x0002E554
		public unsafe bool enableWordWrapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 146419, RefRangeEnd = 146427, XrefRangeStart = 146419, XrefRangeEnd = 146419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00030394 File Offset: 0x0002E594
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x000303D0 File Offset: 0x0002E5D0
		public unsafe float wordWrappingRatios
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00030410 File Offset: 0x0002E610
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x0003044C File Offset: 0x0002E64C
		public unsafe TextOverflowModes overflowMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0003048C File Offset: 0x0002E68C
		public unsafe bool isTextOverflowing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x000304C8 File Offset: 0x0002E6C8
		public unsafe int firstOverflowCharacterIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00030504 File Offset: 0x0002E704
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x00030544 File Offset: 0x0002E744
		public unsafe TMP_Text linkedTextComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 146435, RefRangeEnd = 146436, XrefRangeStart = 146427, XrefRangeEnd = 146435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00030588 File Offset: 0x0002E788
		public unsafe bool isTextTruncated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000305C4 File Offset: 0x0002E7C4
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00030600 File Offset: 0x0002E800
		public unsafe bool enableKerning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00030640 File Offset: 0x0002E840
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0003067C File Offset: 0x0002E87C
		public unsafe bool extraPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 146436, RefRangeEnd = 146439, XrefRangeStart = 146436, XrefRangeEnd = 146436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000306BC File Offset: 0x0002E8BC
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x000306F8 File Offset: 0x0002E8F8
		public unsafe bool richText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 146439, RefRangeEnd = 146442, XrefRangeStart = 146439, XrefRangeEnd = 146439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00030738 File Offset: 0x0002E938
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00030774 File Offset: 0x0002E974
		public unsafe bool parseCtrlCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000307B4 File Offset: 0x0002E9B4
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x000307F0 File Offset: 0x0002E9F0
		public unsafe bool isOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 146442, RefRangeEnd = 146445, XrefRangeStart = 146442, XrefRangeEnd = 146442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00030830 File Offset: 0x0002EA30
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0003086C File Offset: 0x0002EA6C
		public unsafe bool isOrthographic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 146445, RefRangeEnd = 146446, XrefRangeStart = 146445, XrefRangeEnd = 146445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000308AC File Offset: 0x0002EAAC
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x000308E8 File Offset: 0x0002EAE8
		public unsafe bool enableCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00030928 File Offset: 0x0002EB28
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00030964 File Offset: 0x0002EB64
		public unsafe bool ignoreVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000309A4 File Offset: 0x0002EBA4
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x000309E0 File Offset: 0x0002EBE0
		public unsafe TextureMappingOptions horizontalMapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00030A20 File Offset: 0x0002EC20
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00030A5C File Offset: 0x0002EC5C
		public unsafe TextureMappingOptions verticalMapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00030A9C File Offset: 0x0002EC9C
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		public unsafe float mappingUvLineOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00030B18 File Offset: 0x0002ED18
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00030B54 File Offset: 0x0002ED54
		public unsafe TextRenderFlags renderMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00030B94 File Offset: 0x0002ED94
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00030BD0 File Offset: 0x0002EDD0
		public unsafe VertexSortingOrder geometrySortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00030C10 File Offset: 0x0002EE10
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00030C4C File Offset: 0x0002EE4C
		public unsafe bool isTextObjectScaleStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146446, XrefRangeEnd = 146452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00030C8C File Offset: 0x0002EE8C
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		public unsafe bool vertexBufferAutoSizeReduction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00030D08 File Offset: 0x0002EF08
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00030D44 File Offset: 0x0002EF44
		public unsafe int firstVisibleCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 146452, RefRangeEnd = 146458, XrefRangeStart = 146452, XrefRangeEnd = 146452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00030D84 File Offset: 0x0002EF84
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00030DC0 File Offset: 0x0002EFC0
		public unsafe int maxVisibleCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00030E00 File Offset: 0x0002F000
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00030E3C File Offset: 0x0002F03C
		public unsafe int maxVisibleWords
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00030E7C File Offset: 0x0002F07C
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		public unsafe int maxVisibleLines
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00030EF8 File Offset: 0x0002F0F8
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00030F34 File Offset: 0x0002F134
		public unsafe bool useMaxVisibleDescender
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00030F74 File Offset: 0x0002F174
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00030FB0 File Offset: 0x0002F1B0
		public unsafe int pageToDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00031038 File Offset: 0x0002F238
		public unsafe virtual Vector4 margin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00031084 File Offset: 0x0002F284
		public unsafe TMP_TextInfo textInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000310C4 File Offset: 0x0002F2C4
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00031100 File Offset: 0x0002F300
		public unsafe bool havePropertiesChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 146458, RefRangeEnd = 146460, XrefRangeStart = 146458, XrefRangeEnd = 146458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00031140 File Offset: 0x0002F340
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x0003117C File Offset: 0x0002F37C
		public unsafe bool isUsingLegacyAnimationComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x000311BC File Offset: 0x0002F3BC
		public new unsafe Transform transform
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 146467, RefRangeEnd = 146473, XrefRangeStart = 146460, XrefRangeEnd = 146467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000311FC File Offset: 0x0002F3FC
		public new unsafe RectTransform rectTransform
		{
			[CallerCount(62)]
			[CachedScanResults(RefRangeStart = 146480, RefRangeEnd = 146542, XrefRangeStart = 146473, XrefRangeEnd = 146480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003123C File Offset: 0x0002F43C
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00031284 File Offset: 0x0002F484
		public unsafe virtual bool autoSizeTextContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x000312D0 File Offset: 0x0002F4D0
		public unsafe virtual Mesh mesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0003131C File Offset: 0x0002F51C
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00031358 File Offset: 0x0002F558
		public unsafe bool isVolumetricText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146542, XrefRangeEnd = 146543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00031398 File Offset: 0x0002F598
		public unsafe Bounds bounds
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 146547, RefRangeEnd = 146552, XrefRangeStart = 146543, XrefRangeEnd = 146547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x000313D4 File Offset: 0x0002F5D4
		public unsafe Bounds textBounds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 146553, RefRangeEnd = 146555, XrefRangeStart = 146552, XrefRangeEnd = 146553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00031410 File Offset: 0x0002F610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146555, XrefRangeEnd = 146566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00031448 File Offset: 0x0002F648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146566, XrefRangeEnd = 146577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00031480 File Offset: 0x0002F680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146577, XrefRangeEnd = 146588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000314B8 File Offset: 0x0002F6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146588, XrefRangeEnd = 146599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000314F0 File Offset: 0x0002F6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146599, XrefRangeEnd = 146603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00031540 File Offset: 0x0002F740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146603, XrefRangeEnd = 146607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00031590 File Offset: 0x0002F790
		public unsafe TMP_SpriteAnimator spriteAnimator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146607, XrefRangeEnd = 146621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr3) : null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000315D0 File Offset: 0x0002F7D0
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0003160C File Offset: 0x0002F80C
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00031648 File Offset: 0x0002F848
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00031684 File Offset: 0x0002F884
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000316C0 File Offset: 0x0002F8C0
		public unsafe float maxWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000316FC File Offset: 0x0002F8FC
		public unsafe float maxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00031738 File Offset: 0x0002F938
		public unsafe LayoutElement layoutElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146621, XrefRangeEnd = 146628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00031778 File Offset: 0x0002F978
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146628, XrefRangeEnd = 146629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x000317C0 File Offset: 0x0002F9C0
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146629, XrefRangeEnd = 146630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00031808 File Offset: 0x0002FA08
		public unsafe virtual float renderedWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146630, XrefRangeEnd = 146632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00031850 File Offset: 0x0002FA50
		public unsafe virtual float renderedHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146632, XrefRangeEnd = 146634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00031898 File Offset: 0x0002FA98
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x000318D4 File Offset: 0x0002FAD4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00031910 File Offset: 0x0002FB10
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00031960 File Offset: 0x0002FB60
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000319BC File Offset: 0x0002FBBC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFontBaseMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00031A0C File Offset: 0x0002FC0C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Material> GetSharedMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00031A58 File Offset: 0x0002FC58
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSharedMaterials(Il2CppReferenceArray<Material> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00031AA8 File Offset: 0x0002FCA8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Material> GetMaterials(Il2CppReferenceArray<Material> mats)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mats);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00031B04 File Offset: 0x0002FD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146634, XrefRangeEnd = 146645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material CreateMaterialInstance(Material source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00031B60 File Offset: 0x0002FD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146645, XrefRangeEnd = 146649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexColorGradient(TMP_ColorGradient gradient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gradient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00031BA4 File Offset: 0x0002FDA4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextSortingOrder(VertexSortingOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00031BE4 File Offset: 0x0002FDE4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextSortingOrder(Il2CppStructArray<int> order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00031C28 File Offset: 0x0002FE28
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFaceColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00031C74 File Offset: 0x0002FE74
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOutlineColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00031CC0 File Offset: 0x0002FEC0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOutlineThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00031D0C File Offset: 0x0002FF0C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetShaderDepth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00031D48 File Offset: 0x0002FF48
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00031D84 File Offset: 0x0002FF84
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146649, XrefRangeEnd = 146663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetPaddingForMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00031E08 File Offset: 0x00030008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146663, XrefRangeEnd = 146674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetPaddingForMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00031E60 File Offset: 0x00030060
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<Vector3> GetTextContainerLocalCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00031EAC File Offset: 0x000300AC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreActiveState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceTextReparsing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00031F04 File Offset: 0x00030104
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateGeometry(Mesh mesh, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00031F60 File Offset: 0x00030160
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00031FAC File Offset: 0x000301AC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00031FE8 File Offset: 0x000301E8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVertices(Il2CppStructArray<Vector3> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00032038 File Offset: 0x00030238
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMeshPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00032074 File Offset: 0x00030274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146674, XrefRangeEnd = 146675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000320E8 File Offset: 0x000302E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146675, XrefRangeEnd = 146676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00032150 File Offset: 0x00030350
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000321C4 File Offset: 0x000303C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0003222C File Offset: 0x0003042C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 146690, RefRangeEnd = 146695, XrefRangeStart = 146676, XrefRangeEnd = 146690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInputText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ParseInputText_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00032260 File Offset: 0x00030460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146695, XrefRangeEnd = 146703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(string sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000322A4 File Offset: 0x000304A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146703, XrefRangeEnd = 146713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(string sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00032304 File Offset: 0x00030504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146713, XrefRangeEnd = 146725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(StringBuilder sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00032364 File Offset: 0x00030564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146725, XrefRangeEnd = 146734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000323C4 File Offset: 0x000305C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 146801, RefRangeEnd = 146810, XrefRangeStart = 146734, XrefRangeEnd = 146801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextProcessingArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000323F8 File Offset: 0x000305F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146810, XrefRangeEnd = 146819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextInternal(string sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0003243C File Offset: 0x0003063C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 146829, RefRangeEnd = 146884, XrefRangeStart = 146819, XrefRangeEnd = 146829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, bool syncTextInputBox = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref syncTextInputBox;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0003248C File Offset: 0x0003068C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146885, RefRangeEnd = 146888, XrefRangeStart = 146884, XrefRangeEnd = 146885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000324DC File Offset: 0x000306DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146889, RefRangeEnd = 146891, XrefRangeStart = 146888, XrefRangeEnd = 146889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0003253C File Offset: 0x0003073C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146891, XrefRangeEnd = 146892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000325A8 File Offset: 0x000307A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146892, XrefRangeEnd = 146893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00032624 File Offset: 0x00030824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146893, XrefRangeEnd = 146894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000326AC File Offset: 0x000308AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146894, XrefRangeEnd = 146895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00032744 File Offset: 0x00030944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146895, XrefRangeEnd = 146896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg6;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000327E8 File Offset: 0x000309E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 146918, RefRangeEnd = 146925, XrefRangeStart = 146896, XrefRangeEnd = 146918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg6;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0003289C File Offset: 0x00030A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146925, XrefRangeEnd = 146940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(StringBuilder sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000328E0 File Offset: 0x00030AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146940, XrefRangeEnd = 146954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(StringBuilder sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00032940 File Offset: 0x00030B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146954, XrefRangeEnd = 146956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(Il2CppStructArray<char> sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00032984 File Offset: 0x00030B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146956, XrefRangeEnd = 146957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000329E4 File Offset: 0x00030BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharArray(Il2CppStructArray<char> sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00032A28 File Offset: 0x00030C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146970, RefRangeEnd = 146973, XrefRangeStart = 146957, XrefRangeEnd = 146970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharArray(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00032A88 File Offset: 0x00030C88
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146984, RefRangeEnd = 146994, XrefRangeStart = 146973, XrefRangeEnd = 146984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style GetStyle(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00032AD4 File Offset: 0x00030CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147060, RefRangeEnd = 147061, XrefRangeStart = 146994, XrefRangeEnd = 147060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00032B78 File Offset: 0x00030D78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 147092, RefRangeEnd = 147098, XrefRangeStart = 147061, XrefRangeEnd = 147092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplaceOpeningStyleTag(ref Il2CppStructArray<int> sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sourceText = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00032C34 File Offset: 0x00030E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147154, RefRangeEnd = 147155, XrefRangeStart = 147098, XrefRangeEnd = 147154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceClosingStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00032CBC File Offset: 0x00030EBC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 147181, RefRangeEnd = 147191, XrefRangeStart = 147155, XrefRangeEnd = 147181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceClosingStyleTag(ref Il2CppStructArray<int> sourceText, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sourceText = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr6));
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00032D5C File Offset: 0x00030F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147246, RefRangeEnd = 147247, XrefRangeStart = 147191, XrefRangeEnd = 147246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00032DF0 File Offset: 0x00030FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147303, RefRangeEnd = 147304, XrefRangeStart = 147247, XrefRangeEnd = 147303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertClosingStyleTag(ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00032E58 File Offset: 0x00031058
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 147308, RefRangeEnd = 147318, XrefRangeStart = 147304, XrefRangeEnd = 147308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMarkupTagHashCode(Il2CppStructArray<int> tagDefinition, int readIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tagDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00032EB4 File Offset: 0x000310B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147324, RefRangeEnd = 147325, XrefRangeStart = 147318, XrefRangeEnd = 147324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMarkupTagHashCode(TMP_Text.TextBackingContainer tagDefinition, int readIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tagDefinition));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00032F14 File Offset: 0x00031114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147325, XrefRangeEnd = 147330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStyleHashCode(ref Il2CppStructArray<int> text, int index, out int closeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			text = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00032F94 File Offset: 0x00031194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147330, XrefRangeEnd = 147340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00033000 File Offset: 0x00031200
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 147342, RefRangeEnd = 147395, XrefRangeStart = 147340, XrefRangeEnd = 147342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00033058 File Offset: 0x00031258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147396, RefRangeEnd = 147397, XrefRangeStart = 147395, XrefRangeEnd = 147396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000330C0 File Offset: 0x000312C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147433, RefRangeEnd = 147434, XrefRangeStart = 147397, XrefRangeEnd = 147433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0003312C File Offset: 0x0003132C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147434, XrefRangeEnd = 147440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00033188 File Offset: 0x00031388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147440, XrefRangeEnd = 147450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalTextBackingArrayToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000331C0 File Offset: 0x000313C0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int SetArraySizes(Il2CppStructArray<TMP_Text.UnicodeChar> unicodeChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodeChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00033218 File Offset: 0x00031418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147450, XrefRangeEnd = 147452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00033254 File Offset: 0x00031454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147455, RefRangeEnd = 147456, XrefRangeStart = 147452, XrefRangeEnd = 147455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000332AC File Offset: 0x000314AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147456, XrefRangeEnd = 147471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000332FC File Offset: 0x000314FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147471, XrefRangeEnd = 147482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(string text, float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00033368 File Offset: 0x00031568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147493, RefRangeEnd = 147495, XrefRangeStart = 147482, XrefRangeEnd = 147493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000333A4 File Offset: 0x000315A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147496, RefRangeEnd = 147499, XrefRangeStart = 147495, XrefRangeEnd = 147496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredWidth(Vector2 margin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref margin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000333F0 File Offset: 0x000315F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147514, RefRangeEnd = 147516, XrefRangeStart = 147499, XrefRangeEnd = 147514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0003342C File Offset: 0x0003162C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147517, RefRangeEnd = 147520, XrefRangeStart = 147516, XrefRangeEnd = 147517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredHeight(Vector2 margin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref margin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00033478 File Offset: 0x00031678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147520, XrefRangeEnd = 147522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRenderedValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000334B4 File Offset: 0x000316B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147522, XrefRangeEnd = 147524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRenderedValues(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00033500 File Offset: 0x00031700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0003353C File Offset: 0x0003173C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147524, XrefRangeEnd = 147526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedWidth(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00033588 File Offset: 0x00031788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000335C4 File Offset: 0x000317C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147526, XrefRangeEnd = 147528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedHeight(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00033610 File Offset: 0x00031810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147528, XrefRangeEnd = 147741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fontSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref marginSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTextAutoSizingEnabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWordWrappingEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00033690 File Offset: 0x00031890
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 147741, RefRangeEnd = 147759, XrefRangeStart = 147741, XrefRangeEnd = 147741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Bounds GetCompoundBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000336D8 File Offset: 0x000318D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147759, XrefRangeEnd = 147760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Rect GetCanvasSpaceClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00033720 File Offset: 0x00031920
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 147772, RefRangeEnd = 147778, XrefRangeStart = 147760, XrefRangeEnd = 147772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetTextBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0003375C File Offset: 0x0003195C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147790, RefRangeEnd = 147793, XrefRangeStart = 147778, XrefRangeEnd = 147790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetTextBounds(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000337A8 File Offset: 0x000319A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147793, RefRangeEnd = 147796, XrefRangeStart = 147793, XrefRangeEnd = 147793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustLineOffset(int startIndex, int endIndex, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00033804 File Offset: 0x00031A04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 147809, RefRangeEnd = 147812, XrefRangeStart = 147796, XrefRangeEnd = 147809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeLineExtents(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00033844 File Offset: 0x00031A44
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TMP_TextInfo GetTextInfo(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000338A0 File Offset: 0x00031AA0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ComputeMarginSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000338DC File Offset: 0x00031ADC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 147827, RefRangeEnd = 147833, XrefRangeStart = 147812, XrefRangeEnd = 147827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentElementScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentEmScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphAdjustment;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boldSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineGap;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isMaxVisibleDescenderSet;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxVisibleDescender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000339AC File Offset: 0x00031BAC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 147837, RefRangeEnd = 147873, XrefRangeStart = 147833, XrefRangeEnd = 147837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveWordWrappingState(ref WordWrapState state, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00033A0C File Offset: 0x00031C0C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 147877, RefRangeEnd = 147901, XrefRangeStart = 147873, XrefRangeEnd = 147877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RestoreWordWrappingState(ref WordWrapState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00033A5C File Offset: 0x00031C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147901, XrefRangeEnd = 147964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref padding;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style_padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00033AC4 File Offset: 0x00031CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147964, XrefRangeEnd = 148005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveSpriteVertexInfo(Color32 vertexColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexColor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00033B10 File Offset: 0x00031D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148005, XrefRangeEnd = 148007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillCharacterVertexBuffers(int i, int index_X4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00033B68 File Offset: 0x00031D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148007, XrefRangeEnd = 148010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00033BD0 File Offset: 0x00031DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillSpriteVertexBuffers(int i, int index_X4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00033C28 File Offset: 0x00031E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148010, XrefRangeEnd = 148031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endScale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxScale;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdfScale;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref underlineColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00033CD4 File Offset: 0x00031ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148031, XrefRangeEnd = 148039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highlightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00033D48 File Offset: 0x00031F48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148068, RefRangeEnd = 148070, XrefRangeStart = 148039, XrefRangeEnd = 148068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDefaultSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00033D7C File Offset: 0x00031F7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148072, RefRangeEnd = 148074, XrefRangeStart = 148070, XrefRangeEnd = 148072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpecialCharacters(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00033DC0 File Offset: 0x00031FC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 148098, RefRangeEnd = 148101, XrefRangeStart = 148074, XrefRangeEnd = 148098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00033E04 File Offset: 0x00032004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 148116, RefRangeEnd = 148119, XrefRangeStart = 148101, XrefRangeEnd = 148116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00033E48 File Offset: 0x00032048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148119, XrefRangeEnd = 148120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceTagWithCharacter(Il2CppStructArray<int> chars, int insertionIndex, int tagLength, char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertionIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00033EB4 File Offset: 0x000320B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148120, XrefRangeEnd = 148121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontAsset GetFontAssetForWeight(int fontWeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fontWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00033F00 File Offset: 0x00032100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148139, RefRangeEnd = 148141, XrefRangeStart = 148121, XrefRangeEnd = 148139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isUsingAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr3) : null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00033F8C File Offset: 0x0003218C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetActiveSubMeshes(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00033FD8 File Offset: 0x000321D8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroySubMeshObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00034014 File Offset: 0x00032214
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00034050 File Offset: 0x00032250
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearMesh(bool uploadGeometry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uploadGeometry;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0003409C File Offset: 0x0003229C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148141, XrefRangeEnd = 148147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetParsedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000340E0 File Offset: 0x000322E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148157, RefRangeEnd = 148159, XrefRangeStart = 148147, XrefRangeEnd = 148157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetTextComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00034130 File Offset: 0x00032330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 148170, RefRangeEnd = 148173, XrefRangeStart = 148159, XrefRangeEnd = 148170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseLinkedTextComponent(TMP_Text targetTextComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetTextComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00034174 File Offset: 0x00032374
		[CallerCount(0)]
		public unsafe Vector2 PackUV(float x, float y, float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000341DC File Offset: 0x000323DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 148173, RefRangeEnd = 148181, XrefRangeStart = 148173, XrefRangeEnd = 148173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float PackUV(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00034234 File Offset: 0x00032434
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00034270 File Offset: 0x00032470
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 148181, RefRangeEnd = 148263, XrefRangeStart = 148181, XrefRangeEnd = 148181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int HexToInt(char hex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000342BC File Offset: 0x000324BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148263, XrefRangeEnd = 148271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(string text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00034318 File Offset: 0x00032518
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148275, RefRangeEnd = 148285, XrefRangeStart = 148271, XrefRangeEnd = 148275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(Il2CppStructArray<int> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00034374 File Offset: 0x00032574
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148275, RefRangeEnd = 148285, XrefRangeStart = 148275, XrefRangeEnd = 148285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(Il2CppStructArray<uint> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000343D0 File Offset: 0x000325D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148285, XrefRangeEnd = 148293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(StringBuilder text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0003442C File Offset: 0x0003262C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148301, RefRangeEnd = 148302, XrefRangeStart = 148293, XrefRangeEnd = 148301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(TMP_Text.TextBackingContainer text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0003448C File Offset: 0x0003268C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148302, XrefRangeEnd = 148318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(string text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000344E8 File Offset: 0x000326E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148326, RefRangeEnd = 148336, XrefRangeStart = 148318, XrefRangeEnd = 148326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(Il2CppStructArray<int> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00034544 File Offset: 0x00032744
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148326, RefRangeEnd = 148336, XrefRangeStart = 148326, XrefRangeEnd = 148336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(Il2CppStructArray<uint> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000345A0 File Offset: 0x000327A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148336, XrefRangeEnd = 148352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(StringBuilder text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000345FC File Offset: 0x000327FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148368, RefRangeEnd = 148369, XrefRangeStart = 148352, XrefRangeEnd = 148368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(TMP_Text.TextBackingContainer text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0003465C File Offset: 0x0003285C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148386, RefRangeEnd = 148387, XrefRangeStart = 148369, XrefRangeEnd = 148386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int tagCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000346B8 File Offset: 0x000328B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148387, XrefRangeEnd = 148401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00034724 File Offset: 0x00032924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148401, XrefRangeEnd = 148402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAttributeParameters(Il2CppStructArray<char> chars, int startIndex, int length, ref Il2CppStructArray<float> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parameters = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000347B8 File Offset: 0x000329B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148402, XrefRangeEnd = 148403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00034824 File Offset: 0x00032A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148406, RefRangeEnd = 148408, XrefRangeStart = 148403, XrefRangeEnd = 148406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length, out int lastIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0003489C File Offset: 0x00032A9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 148632, RefRangeEnd = 148637, XrefRangeStart = 148408, XrefRangeEnd = 148632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateHtmlTag(Il2CppStructArray<TMP_Text.UnicodeChar> chars, int startIndex, out int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00034908 File Offset: 0x00032B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148751, RefRangeEnd = 148753, XrefRangeStart = 148637, XrefRangeEnd = 148751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Text()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00006CDA File Offset: 0x00004EDA
		public TMP_Text(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00034944 File Offset: 0x00032B44
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00006CE3 File Offset: 0x00004EE3
		public unsafe string m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003496C File Offset: 0x00032B6C
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00006D02 File Offset: 0x00004F02
		public unsafe bool m_IsTextBackingStringDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00034994 File Offset: 0x00032B94
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00006D1D File Offset: 0x00004F1D
		public unsafe ITextPreprocessor m_TextPreprocessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITextPreprocessor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x000349C4 File Offset: 0x00032BC4
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00006D3C File Offset: 0x00004F3C
		public unsafe bool m_isRightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRightToLeft)) = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000349EC File Offset: 0x00032BEC
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x00006D57 File Offset: 0x00004F57
		public unsafe TMP_FontAsset m_fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00034A1C File Offset: 0x00032C1C
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00006D76 File Offset: 0x00004F76
		public unsafe TMP_FontAsset m_currentFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00034A4C File Offset: 0x00032C4C
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00006D95 File Offset: 0x00004F95
		public unsafe bool m_isSDFShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isSDFShader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isSDFShader)) = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00034A74 File Offset: 0x00032C74
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x00006DB0 File Offset: 0x00004FB0
		public unsafe Material m_sharedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sharedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sharedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00034AA4 File Offset: 0x00032CA4
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x00006DCF File Offset: 0x00004FCF
		public unsafe Material m_currentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00034AD4 File Offset: 0x00032CD4
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00006DEE File Offset: 0x00004FEE
		public unsafe static Il2CppReferenceArray<MaterialReference> m_materialReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MaterialReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00034AFC File Offset: 0x00032CFC
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00006E00 File Offset: 0x00005000
		public unsafe static Dictionary<int, int> m_materialReferenceIndexLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00034B24 File Offset: 0x00032D24
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x00006E12 File Offset: 0x00005012
		public unsafe static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack, intPtr);
				return new TMP_TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00034B60 File Offset: 0x00032D60
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x00006E29 File Offset: 0x00005029
		public unsafe int m_currentMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00034B88 File Offset: 0x00032D88
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x00006E44 File Offset: 0x00005044
		public unsafe Il2CppReferenceArray<Material> m_fontSharedMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00034BB8 File Offset: 0x00032DB8
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00006E63 File Offset: 0x00005063
		public unsafe Material m_fontMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00034BE8 File Offset: 0x00032DE8
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x00006E82 File Offset: 0x00005082
		public unsafe Il2CppReferenceArray<Material> m_fontMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00034C18 File Offset: 0x00032E18
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00006EA1 File Offset: 0x000050A1
		public unsafe bool m_isMaterialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty)) = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00034C40 File Offset: 0x00032E40
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00006EBC File Offset: 0x000050BC
		public unsafe Color32 m_fontColor32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor32);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor32)) = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00034C68 File Offset: 0x00032E68
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00006ED7 File Offset: 0x000050D7
		public unsafe Color m_fontColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor)) = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00034C90 File Offset: 0x00032E90
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00006EF2 File Offset: 0x000050F2
		public unsafe static Color32 s_colorWhite
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_s_colorWhite, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_s_colorWhite, (void*)(&value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00034CAC File Offset: 0x00032EAC
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00006F00 File Offset: 0x00005100
		public unsafe Color32 m_underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColor)) = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00034CD4 File Offset: 0x00032ED4
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x00006F1B File Offset: 0x0000511B
		public unsafe Color32 m_strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColor)) = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00034CFC File Offset: 0x00032EFC
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x00006F36 File Offset: 0x00005136
		public unsafe bool m_enableVertexGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient)) = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00034D24 File Offset: 0x00032F24
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00006F51 File Offset: 0x00005151
		public unsafe ColorMode m_colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorMode)) = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00034D4C File Offset: 0x00032F4C
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00006F6C File Offset: 0x0000516C
		public unsafe VertexGradient m_fontColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradient)) = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00034D74 File Offset: 0x00032F74
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00006F87 File Offset: 0x00005187
		public unsafe TMP_ColorGradient m_fontColorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00034DA4 File Offset: 0x00032FA4
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00006FA6 File Offset: 0x000051A6
		public unsafe TMP_SpriteAsset m_spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00034DD4 File Offset: 0x00032FD4
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00006FC5 File Offset: 0x000051C5
		public unsafe bool m_tintAllSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintAllSprites);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintAllSprites)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00034DFC File Offset: 0x00032FFC
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00006FE0 File Offset: 0x000051E0
		public unsafe bool m_tintSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintSprite)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00034E24 File Offset: 0x00033024
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00006FFB File Offset: 0x000051FB
		public unsafe Color32 m_spriteColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteColor)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00034E4C File Offset: 0x0003304C
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00007016 File Offset: 0x00005216
		public unsafe TMP_StyleSheet m_StyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_StyleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_StyleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00034E7C File Offset: 0x0003307C
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00007035 File Offset: 0x00005235
		public unsafe TMP_Style m_TextStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00034EAC File Offset: 0x000330AC
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x00007054 File Offset: 0x00005254
		public unsafe int m_TextStyleHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode)) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00034ED4 File Offset: 0x000330D4
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0000706F File Offset: 0x0000526F
		public unsafe bool m_overrideHtmlColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors)) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00034EFC File Offset: 0x000330FC
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0000708A File Offset: 0x0000528A
		public unsafe Color32 m_faceColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_faceColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_faceColor)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00034F24 File Offset: 0x00033124
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000070A5 File Offset: 0x000052A5
		public unsafe Color32 m_outlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineColor)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00034F4C File Offset: 0x0003314C
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x000070C0 File Offset: 0x000052C0
		public unsafe float m_outlineWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineWidth)) = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00034F74 File Offset: 0x00033174
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000070DB File Offset: 0x000052DB
		public unsafe float m_fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSize)) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00034F9C File Offset: 0x0003319C
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000070F6 File Offset: 0x000052F6
		public unsafe float m_currentFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontSize)) = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00034FC4 File Offset: 0x000331C4
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00007111 File Offset: 0x00005311
		public unsafe float m_fontSizeBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeBase)) = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00034FEC File Offset: 0x000331EC
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0000712C File Offset: 0x0000532C
		public TMP_TextProcessingStack<float> m_sizeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sizeStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0003501C File Offset: 0x0003321C
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x0000715A File Offset: 0x0000535A
		public unsafe FontWeight m_fontWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontWeight)) = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00035044 File Offset: 0x00033244
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00007175 File Offset: 0x00005375
		public unsafe FontWeight m_FontWeightInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal)) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0003506C File Offset: 0x0003326C
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00007190 File Offset: 0x00005390
		public TMP_TextProcessingStack<FontWeight> m_FontWeightStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightStack);
				return new TMP_TextProcessingStack<FontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0003509C File Offset: 0x0003329C
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x000071BE File Offset: 0x000053BE
		public unsafe bool m_enableAutoSizing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000350C4 File Offset: 0x000332C4
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000071D9 File Offset: 0x000053D9
		public unsafe float m_maxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxFontSize)) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000350EC File Offset: 0x000332EC
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000071F4 File Offset: 0x000053F4
		public unsafe float m_minFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minFontSize)) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00035114 File Offset: 0x00033314
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x0000720F File Offset: 0x0000540F
		public unsafe int m_AutoSizeIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount)) = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0003513C File Offset: 0x0003333C
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0000722A File Offset: 0x0000542A
		public unsafe int m_AutoSizeMaxIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount)) = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00035164 File Offset: 0x00033364
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00007245 File Offset: 0x00005445
		public unsafe bool m_IsAutoSizePointSizeSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003518C File Offset: 0x0003338C
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00007260 File Offset: 0x00005460
		public unsafe float m_fontSizeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMin)) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x000351B4 File Offset: 0x000333B4
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0000727B File Offset: 0x0000547B
		public unsafe float m_fontSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMax)) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000351DC File Offset: 0x000333DC
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00007296 File Offset: 0x00005496
		public unsafe FontStyles m_fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyle)) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00035204 File Offset: 0x00033404
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x000072B1 File Offset: 0x000054B1
		public unsafe FontStyles m_FontStyleInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal)) = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003522C File Offset: 0x0003342C
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x000072CC File Offset: 0x000054CC
		public unsafe TMP_FontStyleStack m_fontStyleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyleStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyleStack)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00035254 File Offset: 0x00033454
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x000072E7 File Offset: 0x000054E7
		public unsafe bool m_isUsingBold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingBold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingBold)) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0003527C File Offset: 0x0003347C
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00007302 File Offset: 0x00005502
		public unsafe HorizontalAlignmentOptions m_HorizontalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x000352A4 File Offset: 0x000334A4
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x0000731D File Offset: 0x0000551D
		public unsafe VerticalAlignmentOptions m_VerticalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x000352CC File Offset: 0x000334CC
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x00007338 File Offset: 0x00005538
		public unsafe TextAlignmentOptions m_textAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textAlignment)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x000352F4 File Offset: 0x000334F4
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x00007353 File Offset: 0x00005553
		public unsafe HorizontalAlignmentOptions m_lineJustification
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustification)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0003531C File Offset: 0x0003351C
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0000736E File Offset: 0x0000556E
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack);
				return new TMP_TextProcessingStack<HorizontalAlignmentOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0003534C File Offset: 0x0003354C
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0000739C File Offset: 0x0000559C
		public unsafe Il2CppStructArray<Vector3> m_textContainerLocalCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0003537C File Offset: 0x0003357C
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x000073BB File Offset: 0x000055BB
		public unsafe float m_characterSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterSpacing)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000353A4 File Offset: 0x000335A4
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x000073D6 File Offset: 0x000055D6
		public unsafe float m_cSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cSpacing)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x000353CC File Offset: 0x000335CC
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x000073F1 File Offset: 0x000055F1
		public unsafe float m_monoSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_monoSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_monoSpacing)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000353F4 File Offset: 0x000335F4
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x0000740C File Offset: 0x0000560C
		public unsafe float m_wordSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordSpacing)) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0003541C File Offset: 0x0003361C
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x00007427 File Offset: 0x00005627
		public unsafe float m_lineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacing)) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00035444 File Offset: 0x00033644
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00007442 File Offset: 0x00005642
		public unsafe float m_lineSpacingDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta)) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0003546C File Offset: 0x0003366C
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x0000745D File Offset: 0x0000565D
		public unsafe float m_lineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineHeight)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00035494 File Offset: 0x00033694
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00007478 File Offset: 0x00005678
		public unsafe bool m_IsDrivenLineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing)) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x000354BC File Offset: 0x000336BC
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00007493 File Offset: 0x00005693
		public unsafe float m_lineSpacingMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax)) = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x000354E4 File Offset: 0x000336E4
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x000074AE File Offset: 0x000056AE
		public unsafe float m_paragraphSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing)) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0003550C File Offset: 0x0003370C
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x000074C9 File Offset: 0x000056C9
		public unsafe float m_charWidthMaxAdj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00035534 File Offset: 0x00033734
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x000074E4 File Offset: 0x000056E4
		public unsafe float m_charWidthAdjDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0003555C File Offset: 0x0003375C
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x000074FF File Offset: 0x000056FF
		public unsafe bool m_enableWordWrapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping)) = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00035584 File Offset: 0x00033784
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x0000751A File Offset: 0x0000571A
		public unsafe bool m_isCharacterWrappingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled)) = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000355AC File Offset: 0x000337AC
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00007535 File Offset: 0x00005735
		public unsafe bool m_isNonBreakingSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace)) = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000355D4 File Offset: 0x000337D4
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00007550 File Offset: 0x00005750
		public unsafe bool m_isIgnoringAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000355FC File Offset: 0x000337FC
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x0000756B File Offset: 0x0000576B
		public unsafe float m_wordWrappingRatios
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios)) = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00035624 File Offset: 0x00033824
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00007586 File Offset: 0x00005786
		public unsafe TextOverflowModes m_overflowMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overflowMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overflowMode)) = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0003564C File Offset: 0x0003384C
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x000075A1 File Offset: 0x000057A1
		public unsafe int m_firstOverflowCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex)) = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00035674 File Offset: 0x00033874
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000075BC File Offset: 0x000057BC
		public unsafe TMP_Text m_linkedTextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x000356A4 File Offset: 0x000338A4
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x000075DB File Offset: 0x000057DB
		public unsafe TMP_Text parentLinkedComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_parentLinkedComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_parentLinkedComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x000356D4 File Offset: 0x000338D4
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x000075FA File Offset: 0x000057FA
		public unsafe bool m_isTextTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isTextTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isTextTruncated)) = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x000356FC File Offset: 0x000338FC
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x00007615 File Offset: 0x00005815
		public unsafe bool m_enableKerning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableKerning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableKerning)) = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00035724 File Offset: 0x00033924
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00007630 File Offset: 0x00005830
		public unsafe float m_GlyphHorizontalAdvanceAdjustment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment)) = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0003574C File Offset: 0x0003394C
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0000764B File Offset: 0x0000584B
		public unsafe bool m_enableExtraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding)) = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00035774 File Offset: 0x00033974
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00007666 File Offset: 0x00005866
		public unsafe bool checkPaddingRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_checkPaddingRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_checkPaddingRequired)) = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003579C File Offset: 0x0003399C
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00007681 File Offset: 0x00005881
		public unsafe bool m_isRichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRichText)) = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x000357C4 File Offset: 0x000339C4
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0000769C File Offset: 0x0000589C
		public unsafe bool m_parseCtrlCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters)) = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000357EC File Offset: 0x000339EC
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x000076B7 File Offset: 0x000058B7
		public unsafe bool m_isOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOverlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOverlay)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00035814 File Offset: 0x00033A14
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x000076D2 File Offset: 0x000058D2
		public unsafe bool m_isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOrthographic)) = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003583C File Offset: 0x00033A3C
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x000076ED File Offset: 0x000058ED
		public unsafe bool m_isCullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled)) = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00035864 File Offset: 0x00033A64
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x00007708 File Offset: 0x00005908
		public unsafe bool m_isMaskingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0003588C File Offset: 0x00033A8C
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00007723 File Offset: 0x00005923
		public unsafe bool isMaskUpdateRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired)) = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x000358B4 File Offset: 0x00033AB4
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0000773E File Offset: 0x0000593E
		public unsafe bool m_ignoreCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreCulling)) = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x000358DC File Offset: 0x00033ADC
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00007759 File Offset: 0x00005959
		public unsafe TextureMappingOptions m_horizontalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_horizontalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_horizontalMapping)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00035904 File Offset: 0x00033B04
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00007774 File Offset: 0x00005974
		public unsafe TextureMappingOptions m_verticalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_verticalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_verticalMapping)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0003592C File Offset: 0x00033B2C
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0000778F File Offset: 0x0000598F
		public unsafe float m_uvLineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_uvLineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_uvLineOffset)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00035954 File Offset: 0x00033B54
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x000077AA File Offset: 0x000059AA
		public unsafe TextRenderFlags m_renderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderMode)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0003597C File Offset: 0x00033B7C
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x000077C5 File Offset: 0x000059C5
		public unsafe VertexSortingOrder m_geometrySortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder)) = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x000359A4 File Offset: 0x00033BA4
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x000077E0 File Offset: 0x000059E0
		public unsafe bool m_IsTextObjectScaleStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic)) = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x000359CC File Offset: 0x00033BCC
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x000077FB File Offset: 0x000059FB
		public unsafe bool m_VertexBufferAutoSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000359F4 File Offset: 0x00033BF4
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00007816 File Offset: 0x00005A16
		public unsafe int m_firstVisibleCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter)) = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00035A1C File Offset: 0x00033C1C
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00007831 File Offset: 0x00005A31
		public unsafe int m_maxVisibleCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters)) = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00035A44 File Offset: 0x00033C44
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0000784C File Offset: 0x00005A4C
		public unsafe int m_maxVisibleWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords)) = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00035A6C File Offset: 0x00033C6C
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00007867 File Offset: 0x00005A67
		public unsafe int m_maxVisibleLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines)) = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00035A94 File Offset: 0x00033C94
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00007882 File Offset: 0x00005A82
		public unsafe bool m_useMaxVisibleDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender)) = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00035ABC File Offset: 0x00033CBC
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0000789D File Offset: 0x00005A9D
		public unsafe int m_pageToDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageToDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageToDisplay)) = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00035AE4 File Offset: 0x00033CE4
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x000078B8 File Offset: 0x00005AB8
		public unsafe bool m_isNewPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNewPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNewPage)) = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00035B0C File Offset: 0x00033D0C
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x000078D3 File Offset: 0x00005AD3
		public unsafe Vector4 m_margin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_margin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_margin)) = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00035B34 File Offset: 0x00033D34
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x000078EE File Offset: 0x00005AEE
		public unsafe float m_marginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginLeft)) = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00035B5C File Offset: 0x00033D5C
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x00007909 File Offset: 0x00005B09
		public unsafe float m_marginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginRight)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00035B84 File Offset: 0x00033D84
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00007924 File Offset: 0x00005B24
		public unsafe float m_marginWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginWidth)) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00035BAC File Offset: 0x00033DAC
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x0000793F File Offset: 0x00005B3F
		public unsafe float m_marginHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginHeight)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00035BD4 File Offset: 0x00033DD4
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0000795A File Offset: 0x00005B5A
		public unsafe float m_width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_width)) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00035BFC File Offset: 0x00033DFC
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00007975 File Offset: 0x00005B75
		public unsafe TMP_TextInfo m_textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00035C2C File Offset: 0x00033E2C
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00007994 File Offset: 0x00005B94
		public unsafe bool m_havePropertiesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00035C54 File Offset: 0x00033E54
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x000079AF File Offset: 0x00005BAF
		public unsafe bool m_isUsingLegacyAnimationComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00035C7C File Offset: 0x00033E7C
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000079CA File Offset: 0x00005BCA
		public unsafe Transform m_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00035CAC File Offset: 0x00033EAC
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000079E9 File Offset: 0x00005BE9
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00035CDC File Offset: 0x00033EDC
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00007A08 File Offset: 0x00005C08
		public unsafe Vector2 m_PreviousRectTransformSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize)) = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00035D04 File Offset: 0x00033F04
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00007A23 File Offset: 0x00005C23
		public unsafe Vector2 m_PreviousPivotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition)) = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00035D2C File Offset: 0x00033F2C
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00007A3E File Offset: 0x00005C3E
		public unsafe bool _autoSizeTextContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField)) = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00035D54 File Offset: 0x00033F54
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00007A59 File Offset: 0x00005C59
		public unsafe bool m_autoSizeTextContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00035D7C File Offset: 0x00033F7C
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00007A74 File Offset: 0x00005C74
		public unsafe Mesh m_mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00035DAC File Offset: 0x00033FAC
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00007A93 File Offset: 0x00005C93
		public unsafe bool m_isVolumetricText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isVolumetricText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isVolumetricText)) = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00035DD4 File Offset: 0x00033FD4
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00007AAE File Offset: 0x00005CAE
		public unsafe static Func<int, string, TMP_FontAsset> OnFontAssetRequest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00035DFC File Offset: 0x00033FFC
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00007AC0 File Offset: 0x00005CC0
		public unsafe static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, TMP_SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00035E24 File Offset: 0x00034024
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00007AD2 File Offset: 0x00005CD2
		public unsafe Action<TMP_TextInfo> OnPreRenderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_OnPreRenderText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_OnPreRenderText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00035E54 File Offset: 0x00034054
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00007AF1 File Offset: 0x00005CF1
		public unsafe TMP_SpriteAnimator m_spriteAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00035E84 File Offset: 0x00034084
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00007B10 File Offset: 0x00005D10
		public unsafe float m_flexibleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleHeight)) = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00035EAC File Offset: 0x000340AC
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00007B2B File Offset: 0x00005D2B
		public unsafe float m_flexibleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleWidth)) = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00035ED4 File Offset: 0x000340D4
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00007B46 File Offset: 0x00005D46
		public unsafe float m_minWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minWidth)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00035EFC File Offset: 0x000340FC
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00007B61 File Offset: 0x00005D61
		public unsafe float m_minHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minHeight)) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00035F24 File Offset: 0x00034124
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00007B7C File Offset: 0x00005D7C
		public unsafe float m_maxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxWidth)) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00035F4C File Offset: 0x0003414C
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00007B97 File Offset: 0x00005D97
		public unsafe float m_maxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxHeight)) = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00035F74 File Offset: 0x00034174
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00007BB2 File Offset: 0x00005DB2
		public unsafe LayoutElement m_LayoutElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_LayoutElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_LayoutElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00035FA4 File Offset: 0x000341A4
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00007BD1 File Offset: 0x00005DD1
		public unsafe float m_preferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredWidth)) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00035FCC File Offset: 0x000341CC
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00007BEC File Offset: 0x00005DEC
		public unsafe float m_renderedWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedWidth)) = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00035FF4 File Offset: 0x000341F4
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00007C07 File Offset: 0x00005E07
		public unsafe bool m_isPreferredWidthDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty)) = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0003601C File Offset: 0x0003421C
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00007C22 File Offset: 0x00005E22
		public unsafe float m_preferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredHeight)) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00036044 File Offset: 0x00034244
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00007C3D File Offset: 0x00005E3D
		public unsafe float m_renderedHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedHeight)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0003606C File Offset: 0x0003426C
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00007C58 File Offset: 0x00005E58
		public unsafe bool m_isPreferredHeightDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty)) = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00036094 File Offset: 0x00034294
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00007C73 File Offset: 0x00005E73
		public unsafe bool m_isCalculatingPreferredValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues)) = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x000360BC File Offset: 0x000342BC
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00007C8E File Offset: 0x00005E8E
		public unsafe int m_layoutPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_layoutPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_layoutPriority)) = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x000360E4 File Offset: 0x000342E4
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00007CA9 File Offset: 0x00005EA9
		public unsafe bool m_isLayoutDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty)) = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0003610C File Offset: 0x0003430C
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00007CC4 File Offset: 0x00005EC4
		public unsafe bool m_isAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isAwake)) = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00036134 File Offset: 0x00034334
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00007CDF File Offset: 0x00005EDF
		public unsafe bool m_isWaitingOnResourceLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad)) = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0003615C File Offset: 0x0003435C
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00007CFA File Offset: 0x00005EFA
		public unsafe TMP_Text.TextInputSources m_inputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_inputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_inputSource)) = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00036184 File Offset: 0x00034384
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00007D15 File Offset: 0x00005F15
		public unsafe float m_fontScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier)) = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000361AC File Offset: 0x000343AC
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00007D30 File Offset: 0x00005F30
		public unsafe static Il2CppStructArray<char> m_htmlTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_htmlTag, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_htmlTag, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x000361D4 File Offset: 0x000343D4
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00007D42 File Offset: 0x00005F42
		public unsafe static Il2CppStructArray<RichTextTagAttribute> m_xmlAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_xmlAttribute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RichTextTagAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_xmlAttribute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x000361FC File Offset: 0x000343FC
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00007D54 File Offset: 0x00005F54
		public unsafe static Il2CppStructArray<float> m_attributeParameterValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00036224 File Offset: 0x00034424
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00007D66 File Offset: 0x00005F66
		public unsafe float tag_LineIndent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_LineIndent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_LineIndent)) = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0003624C File Offset: 0x0003444C
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00007D81 File Offset: 0x00005F81
		public unsafe float tag_Indent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_Indent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_Indent)) = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00036274 File Offset: 0x00034474
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00007D9C File Offset: 0x00005F9C
		public TMP_TextProcessingStack<float> m_indentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_indentStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_indentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000362A4 File Offset: 0x000344A4
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00007DCA File Offset: 0x00005FCA
		public unsafe bool tag_NoParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_NoParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_NoParsing)) = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000362CC File Offset: 0x000344CC
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00007DE5 File Offset: 0x00005FE5
		public unsafe bool m_isParsingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isParsingText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isParsingText)) = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x000362F4 File Offset: 0x000344F4
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00007E00 File Offset: 0x00006000
		public unsafe Matrix4x4 m_FXMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FXMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FXMatrix)) = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0003631C File Offset: 0x0003451C
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00007E1B File Offset: 0x0000601B
		public unsafe bool m_isFXMatrixSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet)) = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00036344 File Offset: 0x00034544
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00007E36 File Offset: 0x00006036
		public unsafe Il2CppStructArray<TMP_Text.UnicodeChar> m_TextProcessingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_Text.UnicodeChar>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00036374 File Offset: 0x00034574
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x00007E55 File Offset: 0x00006055
		public unsafe int m_InternalTextProcessingArraySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize)) = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0003639C File Offset: 0x0003459C
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00007E70 File Offset: 0x00006070
		public unsafe Il2CppReferenceArray<TMP_CharacterInfo> m_internalCharacterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_CharacterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000363CC File Offset: 0x000345CC
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00007E8F File Offset: 0x0000608F
		public unsafe int m_totalCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount)) = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x000363F4 File Offset: 0x000345F4
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00007EAA File Offset: 0x000060AA
		public unsafe static WordWrapState m_SavedWordWrapState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00036430 File Offset: 0x00034630
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00007EC1 File Offset: 0x000060C1
		public unsafe static WordWrapState m_SavedLineState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedLineState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedLineState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0003646C File Offset: 0x0003466C
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00007ED8 File Offset: 0x000060D8
		public unsafe static WordWrapState m_SavedEllipsisState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x000364A8 File Offset: 0x000346A8
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00007EEF File Offset: 0x000060EF
		public unsafe static WordWrapState m_SavedLastValidState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x000364E4 File Offset: 0x000346E4
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00007F06 File Offset: 0x00006106
		public unsafe static WordWrapState m_SavedSoftLineBreakState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00036520 File Offset: 0x00034720
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00007F1D File Offset: 0x0000611D
		public unsafe static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<WordWrapState>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack, intPtr);
				return new TMP_TextProcessingStack<WordWrapState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<WordWrapState>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0003655C File Offset: 0x0003475C
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00007F34 File Offset: 0x00006134
		public unsafe int m_characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterCount)) = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00036584 File Offset: 0x00034784
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00007F4F File Offset: 0x0000614F
		public unsafe int m_firstCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x000365AC File Offset: 0x000347AC
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00007F6A File Offset: 0x0000616A
		public unsafe int m_firstVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x000365D4 File Offset: 0x000347D4
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00007F85 File Offset: 0x00006185
		public unsafe int m_lastCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x000365FC File Offset: 0x000347FC
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00007FA0 File Offset: 0x000061A0
		public unsafe int m_lastVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00036624 File Offset: 0x00034824
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00007FBB File Offset: 0x000061BB
		public unsafe int m_lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineNumber)) = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0003664C File Offset: 0x0003484C
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00007FD6 File Offset: 0x000061D6
		public unsafe int m_lineVisibleCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount)) = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00036674 File Offset: 0x00034874
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00007FF1 File Offset: 0x000061F1
		public unsafe int m_pageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageNumber)) = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0003669C File Offset: 0x0003489C
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x0000800C File Offset: 0x0000620C
		public unsafe float m_PageAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PageAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PageAscender)) = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000366C4 File Offset: 0x000348C4
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00008027 File Offset: 0x00006227
		public unsafe float m_maxTextAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxTextAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxTextAscender)) = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000366EC File Offset: 0x000348EC
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00008042 File Offset: 0x00006242
		public unsafe float m_maxCapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxCapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxCapHeight)) = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00036714 File Offset: 0x00034914
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0000805D File Offset: 0x0000625D
		public unsafe float m_ElementAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementAscender)) = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0003673C File Offset: 0x0003493C
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00008078 File Offset: 0x00006278
		public unsafe float m_ElementDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementDescender)) = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00036764 File Offset: 0x00034964
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00008093 File Offset: 0x00006293
		public unsafe float m_maxLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineAscender)) = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0003678C File Offset: 0x0003498C
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x000080AE File Offset: 0x000062AE
		public unsafe float m_maxLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineDescender)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x000367B4 File Offset: 0x000349B4
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x000080C9 File Offset: 0x000062C9
		public unsafe float m_startOfLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender)) = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x000367DC File Offset: 0x000349DC
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x000080E4 File Offset: 0x000062E4
		public unsafe float m_startOfLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender)) = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00036804 File Offset: 0x00034A04
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x000080FF File Offset: 0x000062FF
		public unsafe float m_lineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineOffset)) = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0003682C File Offset: 0x00034A2C
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x0000811A File Offset: 0x0000631A
		public unsafe Extents m_meshExtents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_meshExtents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_meshExtents)) = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00036854 File Offset: 0x00034A54
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00008135 File Offset: 0x00006335
		public unsafe Color32 m_htmlColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_htmlColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_htmlColor)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0003687C File Offset: 0x00034A7C
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00008150 File Offset: 0x00006350
		public TMP_TextProcessingStack<Color32> m_colorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000368AC File Offset: 0x00034AAC
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0000817E File Offset: 0x0000637E
		public TMP_TextProcessingStack<Color32> m_underlineColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x000368DC File Offset: 0x00034ADC
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x000081AC File Offset: 0x000063AC
		public TMP_TextProcessingStack<Color32> m_strikethroughColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0003690C File Offset: 0x00034B0C
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x000081DA File Offset: 0x000063DA
		public TMP_TextProcessingStack<HighlightState> m_HighlightStateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack);
				return new TMP_TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0003693C File Offset: 0x00034B3C
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00008208 File Offset: 0x00006408
		public unsafe TMP_ColorGradient m_colorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0003696C File Offset: 0x00034B6C
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00008227 File Offset: 0x00006427
		public TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientStack);
				return new TMP_TextProcessingStack<TMP_ColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0003699C File Offset: 0x00034B9C
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00008255 File Offset: 0x00006455
		public unsafe bool m_colorGradientPresetIsTinted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted)) = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x000369C4 File Offset: 0x00034BC4
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00008270 File Offset: 0x00006470
		public unsafe float m_tabSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tabSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tabSpacing)) = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000369EC File Offset: 0x00034BEC
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0000828B File Offset: 0x0000648B
		public unsafe float m_spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spacing)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00036A14 File Offset: 0x00034C14
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x000082A6 File Offset: 0x000064A6
		public unsafe Il2CppReferenceArray<TMP_TextProcessingStack<int>> m_TextStyleStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_TextProcessingStack<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00036A44 File Offset: 0x00034C44
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x000082C5 File Offset: 0x000064C5
		public unsafe int m_TextStyleStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth)) = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00036A6C File Offset: 0x00034C6C
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x000082E0 File Offset: 0x000064E0
		public TMP_TextProcessingStack<int> m_ItalicAngleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00036A9C File Offset: 0x00034C9C
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x0000830E File Offset: 0x0000650E
		public unsafe int m_ItalicAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngle)) = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00036AC4 File Offset: 0x00034CC4
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00008329 File Offset: 0x00006529
		public TMP_TextProcessingStack<int> m_actionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_actionStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_actionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00036AF4 File Offset: 0x00034CF4
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x00008357 File Offset: 0x00006557
		public unsafe float m_padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_padding)) = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00036B1C File Offset: 0x00034D1C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x00008372 File Offset: 0x00006572
		public unsafe float m_baselineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffset)) = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00036B44 File Offset: 0x00034D44
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x0000838D File Offset: 0x0000658D
		public TMP_TextProcessingStack<float> m_baselineOffsetStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00036B74 File Offset: 0x00034D74
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x000083BB File Offset: 0x000065BB
		public unsafe float m_xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_xAdvance)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00036B9C File Offset: 0x00034D9C
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x000083D6 File Offset: 0x000065D6
		public unsafe TMP_TextElementType m_textElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textElementType)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00036BC4 File Offset: 0x00034DC4
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x000083F1 File Offset: 0x000065F1
		public unsafe TMP_TextElement m_cached_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cached_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cached_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00036BF4 File Offset: 0x00034DF4
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x00008410 File Offset: 0x00006610
		public TMP_Text.SpecialCharacter m_Ellipsis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Ellipsis);
				return new TMP_Text.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Ellipsis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00036C24 File Offset: 0x00034E24
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0000843E File Offset: 0x0000663E
		public TMP_Text.SpecialCharacter m_Underline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Underline);
				return new TMP_Text.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Underline), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x00036C54 File Offset: 0x00034E54
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x0000846C File Offset: 0x0000666C
		public unsafe TMP_SpriteAsset m_defaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x00036C84 File Offset: 0x00034E84
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x0000848B File Offset: 0x0000668B
		public unsafe TMP_SpriteAsset m_currentSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00036CB4 File Offset: 0x00034EB4
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x000084AA File Offset: 0x000066AA
		public unsafe int m_spriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteCount)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00036CDC File Offset: 0x00034EDC
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x000084C5 File Offset: 0x000066C5
		public unsafe int m_spriteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteIndex)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00036D04 File Offset: 0x00034F04
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x000084E0 File Offset: 0x000066E0
		public unsafe int m_spriteAnimationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00036D2C File Offset: 0x00034F2C
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x000084FB File Offset: 0x000066FB
		public unsafe static ProfilerMarker k_ParseTextMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker, (void*)(&value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00036D48 File Offset: 0x00034F48
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x00008509 File Offset: 0x00006709
		public unsafe static ProfilerMarker k_InsertNewLineMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker, (void*)(&value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00036D64 File Offset: 0x00034F64
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00008517 File Offset: 0x00006717
		public unsafe bool m_ignoreActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00036D8C File Offset: 0x00034F8C
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00008532 File Offset: 0x00006732
		public TMP_Text.TextBackingContainer m_TextBackingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextBackingArray);
				return new TMP_Text.TextBackingContainer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextBackingArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00036DBC File Offset: 0x00034FBC
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00008560 File Offset: 0x00006760
		public unsafe Il2CppStructArray<Decimal> k_Power
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_k_Power);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_k_Power), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00036DEC File Offset: 0x00034FEC
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x0000857F File Offset: 0x0000677F
		public unsafe static Vector2 k_LargePositiveVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2, (void*)(&value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00036E08 File Offset: 0x00035008
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0000858D File Offset: 0x0000678D
		public unsafe static Vector2 k_LargeNegativeVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2, (void*)(&value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00036E24 File Offset: 0x00035024
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x0000859B File Offset: 0x0000679B
		public unsafe static float k_LargePositiveFloat
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat, (void*)(&value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00036E40 File Offset: 0x00035040
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x000085A9 File Offset: 0x000067A9
		public unsafe static float k_LargeNegativeFloat
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat, (void*)(&value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00036E5C File Offset: 0x0003505C
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x000085B7 File Offset: 0x000067B7
		public unsafe static int k_LargePositiveInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt, (void*)(&value));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00036E78 File Offset: 0x00035078
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x000085C5 File Offset: 0x000067C5
		public unsafe static int k_LargeNegativeInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt, (void*)(&value));
			}
		}

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextBackingStringDirty;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_m_TextPreprocessor;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr_m_isRightToLeft;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeFieldInfoPtr_m_fontAsset;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeFieldInfoPtr_m_currentFontAsset;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_m_isSDFShader;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_m_sharedMaterial;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_m_currentMaterial;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferences;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceIndexLookup;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceStack;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_m_currentMaterialIndex;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSharedMaterials;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeFieldInfoPtr_m_fontMaterial;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeFieldInfoPtr_m_fontMaterials;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeFieldInfoPtr_m_isMaterialDirty;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColor32;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColor;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_s_colorWhite;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeFieldInfoPtr_m_underlineColor;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeFieldInfoPtr_m_strikethroughColor;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeFieldInfoPtr_m_enableVertexGradient;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeFieldInfoPtr_m_colorMode;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColorGradient;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColorGradientPreset;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAsset;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeFieldInfoPtr_m_tintAllSprites;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_m_tintSprite;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteColor;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheet;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyle;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleHashCode;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_m_overrideHtmlColors;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_m_faceColor;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_m_outlineColor;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_m_outlineWidth;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSize;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_m_currentFontSize;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeBase;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_m_sizeStack;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_m_fontWeight;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightInternal;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightStack;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_m_enableAutoSizing;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_m_maxFontSize;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_m_minFontSize;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeIterationCount;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeMaxIterationCount;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAutoSizePointSizeSet;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeMin;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeMax;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_m_fontStyle;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_m_FontStyleInternal;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_m_fontStyleStack;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_m_isUsingBold;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAlignment;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAlignment;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_m_textAlignment;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_m_lineJustification;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_m_lineJustificationStack;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_m_textContainerLocalCorners;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_m_characterSpacing;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_m_cSpacing;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_m_monoSpacing;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_m_wordSpacing;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacing;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacingDelta;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_m_lineHeight;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDrivenLineSpacing;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacingMax;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_m_paragraphSpacing;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_m_charWidthMaxAdj;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_m_charWidthAdjDelta;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_m_enableWordWrapping;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_m_isCharacterWrappingEnabled;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_m_isNonBreakingSpace;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_m_isIgnoringAlignment;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_m_wordWrappingRatios;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_m_overflowMode;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_m_firstOverflowCharacterIndex;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_m_linkedTextComponent;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_parentLinkedComponent;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_m_isTextTruncated;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_m_enableKerning;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_m_enableExtraPadding;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_checkPaddingRequired;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_m_isRichText;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_m_parseCtrlCharacters;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_m_isOverlay;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_m_isOrthographic;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_m_isCullingEnabled;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_m_isMaskingEnabled;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_isMaskUpdateRequired;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_m_ignoreCulling;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalMapping;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalMapping;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr_m_uvLineOffset;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_m_renderMode;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_m_geometrySortingOrder;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextObjectScaleStatic;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_m_firstVisibleCharacter;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleCharacters;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleWords;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleLines;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_m_useMaxVisibleDescender;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_m_pageToDisplay;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_m_isNewPage;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_m_margin;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_m_marginLeft;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_m_marginRight;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeFieldInfoPtr_m_marginWidth;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeFieldInfoPtr_m_marginHeight;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeFieldInfoPtr_m_width;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_m_textInfo;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr_m_havePropertiesChanged;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_m_transform;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousRectTransformSize;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPivotPosition;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_m_autoSizeTextContainer;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_m_mesh;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_m_isVolumetricText;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_OnFontAssetRequest;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_OnSpriteAssetRequest;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_OnPreRenderText;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAnimator;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_m_flexibleHeight;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_m_flexibleWidth;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_m_minWidth;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr_m_minHeight;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr_m_maxWidth;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_m_maxHeight;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutElement;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredWidth;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_m_renderedWidth;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_m_isPreferredWidthDirty;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredHeight;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr_m_renderedHeight;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_m_isPreferredHeightDirty;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_m_isCalculatingPreferredValues;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_m_layoutPriority;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_m_isLayoutDirty;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr_m_isAwake;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr_m_isWaitingOnResourceLoad;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_m_inputSource;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_m_fontScaleMultiplier;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_m_htmlTag;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_m_xmlAttribute;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_m_attributeParameterValues;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_tag_LineIndent;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_tag_Indent;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_m_indentStack;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_tag_NoParsing;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_m_isParsingText;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_m_FXMatrix;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_m_isFXMatrixSet;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_m_TextProcessingArray;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalTextProcessingArraySize;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_m_internalCharacterInfo;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_m_totalCharacterCount;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedWordWrapState;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLineState;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedEllipsisState;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLastValidState;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedSoftLineBreakState;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_m_characterCount;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_m_firstCharacterOfLine;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_m_firstVisibleCharacterOfLine;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_m_lastCharacterOfLine;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_m_lastVisibleCharacterOfLine;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_m_lineNumber;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_m_lineVisibleCharacterCount;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_m_pageNumber;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeFieldInfoPtr_m_PageAscender;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_m_maxTextAscender;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCapHeight;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementAscender;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementDescender;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLineAscender;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLineDescender;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_m_startOfLineAscender;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr_m_startOfLineDescender;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_m_lineOffset;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_m_meshExtents;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_m_htmlColor;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_m_colorStack;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_m_underlineColorStack;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_m_strikethroughColorStack;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightStateStack;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientPreset;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientStack;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientPresetIsTinted;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_m_tabSpacing;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_m_spacing;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStacks;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStackDepth;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngleStack;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngle;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_m_actionStack;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_m_padding;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_m_baselineOffset;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_m_baselineOffsetStack;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_m_xAdvance;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_m_textElementType;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_m_cached_TextElement;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_m_Ellipsis;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_m_Underline;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAsset;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_m_currentSpriteAsset;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteCount;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteIndex;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAnimationID;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_k_ParseTextMarker;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_k_InsertNewLineMarker;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_m_ignoreActiveState;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_m_TextBackingArray;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_k_Power;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveVector2;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeVector2;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveFloat;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeFloat;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveInt;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeInt;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Single_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_ParseInputText_Protected_Void_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000A7 RID: 167
		[StructLayout(2)]
		public struct CharacterSubstitution
		{
			// Token: 0x06000FEC RID: 4076 RVA: 0x0003EBC8 File Offset: 0x0003CDC8
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterSubstitution()
			{
				Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "CharacterSubstitution");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr);
				TMP_Text.CharacterSubstitution.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, "index");
				TMP_Text.CharacterSubstitution.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, "unicode");
				TMP_Text.CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, 100664899);
			}

			// Token: 0x06000FED RID: 4077 RVA: 0x0003EC30 File Offset: 0x0003CE30
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterSubstitution(int index, uint unicode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FEE RID: 4078 RVA: 0x000099C9 File Offset: 0x00007BC9
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C76 RID: 3190
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000C77 RID: 3191
			private static readonly IntPtr NativeFieldInfoPtr_unicode;

			// Token: 0x04000C78 RID: 3192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0;

			// Token: 0x04000C79 RID: 3193
			[FieldOffset(0)]
			public int index;

			// Token: 0x04000C7A RID: 3194
			[FieldOffset(4)]
			public uint unicode;
		}

		// Token: 0x020000A8 RID: 168
		public enum TextInputSources
		{
			// Token: 0x04000C7C RID: 3196
			TextInputBox,
			// Token: 0x04000C7D RID: 3197
			SetText,
			// Token: 0x04000C7E RID: 3198
			SetTextArray,
			// Token: 0x04000C7F RID: 3199
			TextString
		}

		// Token: 0x020000A9 RID: 169
		[StructLayout(2)]
		public struct UnicodeChar
		{
			// Token: 0x06000FEF RID: 4079 RVA: 0x0003EC70 File Offset: 0x0003CE70
			// Note: this type is marked as 'beforefieldinit'.
			static UnicodeChar()
			{
				Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "UnicodeChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr);
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "unicode");
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_stringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "stringIndex");
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "length");
			}

			// Token: 0x06000FF0 RID: 4080 RVA: 0x000099DB File Offset: 0x00007BDB
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C80 RID: 3200
			private static readonly IntPtr NativeFieldInfoPtr_unicode;

			// Token: 0x04000C81 RID: 3201
			private static readonly IntPtr NativeFieldInfoPtr_stringIndex;

			// Token: 0x04000C82 RID: 3202
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x04000C83 RID: 3203
			[FieldOffset(0)]
			public int unicode;

			// Token: 0x04000C84 RID: 3204
			[FieldOffset(4)]
			public int stringIndex;

			// Token: 0x04000C85 RID: 3205
			[FieldOffset(8)]
			public int length;
		}

		// Token: 0x020000AA RID: 170
		public sealed class SpecialCharacter : ValueType
		{
			// Token: 0x06000FF1 RID: 4081 RVA: 0x0003ECD8 File Offset: 0x0003CED8
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialCharacter()
			{
				Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "SpecialCharacter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr);
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "character");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "fontAsset");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "material");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "materialIndex");
				TMP_Text.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, 100664900);
			}

			// Token: 0x06000FF2 RID: 4082 RVA: 0x0003ED68 File Offset: 0x0003CF68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 146177, RefRangeEnd = 146178, XrefRangeStart = 146169, XrefRangeEnd = 146177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialCharacter(TMP_Character character, int materialIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref materialIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FF3 RID: 4083 RVA: 0x000099ED File Offset: 0x00007BED
			public SpecialCharacter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000FF4 RID: 4084 RVA: 0x000099F6 File Offset: 0x00007BF6
			public SpecialCharacter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr))
			{
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
			// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00009A08 File Offset: 0x00007C08
			public unsafe TMP_Character character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0003EDF8 File Offset: 0x0003CFF8
			// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00009A27 File Offset: 0x00007C27
			public unsafe TMP_FontAsset fontAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x0003EE28 File Offset: 0x0003D028
			// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00009A46 File Offset: 0x00007C46
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0003EE58 File Offset: 0x0003D058
			// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00009A65 File Offset: 0x00007C65
			public unsafe int materialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex)) = value;
				}
			}

			// Token: 0x04000C86 RID: 3206
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04000C87 RID: 3207
			private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

			// Token: 0x04000C88 RID: 3208
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04000C89 RID: 3209
			private static readonly IntPtr NativeFieldInfoPtr_materialIndex;

			// Token: 0x04000C8A RID: 3210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0;
		}

		// Token: 0x020000AB RID: 171
		public sealed class TextBackingContainer : ValueType
		{
			// Token: 0x06000FFD RID: 4093 RVA: 0x0003EE80 File Offset: 0x0003D080
			// Note: this type is marked as 'beforefieldinit'.
			static TextBackingContainer()
			{
				Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "TextBackingContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr);
				TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, "m_Array");
				TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, "m_Count");
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664901);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664902);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664903);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664904);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664905);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664906);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664907);
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0003EF60 File Offset: 0x0003D160
			public unsafe int Capacity
			{
				[CallerCount(19)]
				[CachedScanResults(RefRangeStart = 146178, RefRangeEnd = 146197, XrefRangeStart = 146178, XrefRangeEnd = 146178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0003EFA4 File Offset: 0x0003D1A4
			// (set) Token: 0x06001000 RID: 4096 RVA: 0x0003EFE8 File Offset: 0x0003D1E8
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170005D0 RID: 1488
			public unsafe uint this[int index]
			{
				[CallerCount(31)]
				[CachedScanResults(RefRangeStart = 146197, RefRangeEnd = 146228, XrefRangeStart = 146197, XrefRangeEnd = 146197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
				[CallerCount(35)]
				[CachedScanResults(RefRangeStart = 146232, RefRangeEnd = 146267, XrefRangeStart = 146228, XrefRangeEnd = 146232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x0003F0D0 File Offset: 0x0003D2D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 146270, RefRangeEnd = 146271, XrefRangeStart = 146267, XrefRangeEnd = 146270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextBackingContainer(int size)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001004 RID: 4100 RVA: 0x0003F11C File Offset: 0x0003D31C
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 146275, RefRangeEnd = 146287, XrefRangeStart = 146271, XrefRangeEnd = 146275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Resize(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001005 RID: 4101 RVA: 0x00009A80 File Offset: 0x00007C80
			public TextBackingContainer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001006 RID: 4102 RVA: 0x00009A89 File Offset: 0x00007C89
			public TextBackingContainer()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr))
			{
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x06001007 RID: 4103 RVA: 0x0003F160 File Offset: 0x0003D360
			// (set) Token: 0x06001008 RID: 4104 RVA: 0x00009A9B File Offset: 0x00007C9B
			public unsafe Il2CppStructArray<uint> m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x06001009 RID: 4105 RVA: 0x0003F190 File Offset: 0x0003D390
			// (set) Token: 0x0600100A RID: 4106 RVA: 0x00009ABA File Offset: 0x00007CBA
			public unsafe int m_Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count)) = value;
				}
			}

			// Token: 0x04000C8B RID: 3211
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x04000C8C RID: 3212
			private static readonly IntPtr NativeFieldInfoPtr_m_Count;

			// Token: 0x04000C8D RID: 3213
			private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

			// Token: 0x04000C8E RID: 3214
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04000C8F RID: 3215
			private static readonly IntPtr NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0;

			// Token: 0x04000C90 RID: 3216
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0;

			// Token: 0x04000C91 RID: 3217
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0;

			// Token: 0x04000C92 RID: 3218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C93 RID: 3219
			private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;
		}

		// Token: 0x020000AC RID: 172
		[ObfuscatedName("TMPro.TMP_Text+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600100B RID: 4107 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr);
				TMP_Text.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, "<>9");
				TMP_Text.__c.NativeFieldInfoPtr___9__622_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, "<>9__622_0");
				TMP_Text.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, 100664909);
				TMP_Text.__c.NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, 100664910);
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x0003F234 File Offset: 0x0003D434
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600100D RID: 4109 RVA: 0x0003F270 File Offset: 0x0003D470
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__622_0(TMP_TextInfo <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.__c.NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600100E RID: 4110 RVA: 0x00009AD5 File Offset: 0x00007CD5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x0600100F RID: 4111 RVA: 0x0003F2B4 File Offset: 0x0003D4B4
			// (set) Token: 0x06001010 RID: 4112 RVA: 0x00009ADE File Offset: 0x00007CDE
			public unsafe static TMP_Text.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_Text.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_Text.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x06001011 RID: 4113 RVA: 0x0003F2DC File Offset: 0x0003D4DC
			// (set) Token: 0x06001012 RID: 4114 RVA: 0x00009AF0 File Offset: 0x00007CF0
			public unsafe static Action<TMP_TextInfo> __9__622_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_Text.__c.NativeFieldInfoPtr___9__622_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_Text.__c.NativeFieldInfoPtr___9__622_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C94 RID: 3220
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C95 RID: 3221
			private static readonly IntPtr NativeFieldInfoPtr___9__622_0;

			// Token: 0x04000C96 RID: 3222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C97 RID: 3223
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0;
		}

		// Token: 0x020000AD RID: 173
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04000C98 RID: 3224
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TMP_Text>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AE RID: 174
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000C99 RID: 3225
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TMP_Text>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
