using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200000D RID: 13
	public class TextMeshProUGUI : TMP_Text
	{
		// Token: 0x06000143 RID: 323 RVA: 0x0000E7D0 File Offset: 0x0000C9D0
		// Note: this type is marked as 'beforefieldinit'.
		static TextMeshProUGUI()
		{
			Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TextMeshProUGUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr);
			TextMeshProUGUI.NativeFieldInfoPtr_m_isRebuildingLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_isRebuildingLayout");
			TextMeshProUGUI.NativeFieldInfoPtr_m_DelayedGraphicRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_DelayedGraphicRebuild");
			TextMeshProUGUI.NativeFieldInfoPtr_m_DelayedMaterialRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_DelayedMaterialRebuild");
			TextMeshProUGUI.NativeFieldInfoPtr_m_ClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_ClipRect");
			TextMeshProUGUI.NativeFieldInfoPtr_m_ValidRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_ValidRect");
			TextMeshProUGUI.NativeFieldInfoPtr_OnPreRenderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "OnPreRenderText");
			TextMeshProUGUI.NativeFieldInfoPtr_m_hasFontAssetChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_hasFontAssetChanged");
			TextMeshProUGUI.NativeFieldInfoPtr_m_subTextObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_subTextObjects");
			TextMeshProUGUI.NativeFieldInfoPtr_m_previousLossyScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_previousLossyScaleY");
			TextMeshProUGUI.NativeFieldInfoPtr_m_RectTransformCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_RectTransformCorners");
			TextMeshProUGUI.NativeFieldInfoPtr_m_canvasRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_canvasRenderer");
			TextMeshProUGUI.NativeFieldInfoPtr_m_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_canvas");
			TextMeshProUGUI.NativeFieldInfoPtr_m_CanvasScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_CanvasScaleFactor");
			TextMeshProUGUI.NativeFieldInfoPtr_m_isFirstAllocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_isFirstAllocation");
			TextMeshProUGUI.NativeFieldInfoPtr_m_max_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_max_characters");
			TextMeshProUGUI.NativeFieldInfoPtr_m_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_baseMaterial");
			TextMeshProUGUI.NativeFieldInfoPtr_m_isScrollRegionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_isScrollRegionSet");
			TextMeshProUGUI.NativeFieldInfoPtr_m_maskOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_maskOffset");
			TextMeshProUGUI.NativeFieldInfoPtr_m_EnvMapMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_EnvMapMatrix");
			TextMeshProUGUI.NativeFieldInfoPtr_m_isRegisteredForEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "m_isRegisteredForEvents");
			TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_GenerateTextMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_SetArraySizesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_SetArraySizesMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_GenerateTextPhaseIMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_ParseMarkupTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_ParseMarkupTextMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_CharacterLookupMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_CharacterLookupMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_HandleGPOSFeaturesMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_CalculateVerticesPositionMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_CalculateVerticesPositionMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_ComputeTextMetricsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_ComputeTextMetricsMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_HandleVisibleCharacterMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_HandleVisibleCharacterMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_HandleWhiteSpacesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_HandleWhiteSpacesMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_HandleHorizontalLineBreakingMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_HandleVerticalLineBreakingMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_SaveGlyphVertexDataMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_ComputeCharacterAdvanceMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_HandleCarriageReturnMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_HandleCarriageReturnMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_HandleLineTerminationMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_HandleLineTerminationMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_SavePageInfoMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_SavePageInfoMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_SaveProcessingStatesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_SaveProcessingStatesMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_GenerateTextPhaseIIMarker");
			TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "k_GenerateTextPhaseIIIMarker");
			TextMeshProUGUI.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663451);
			TextMeshProUGUI.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663452);
			TextMeshProUGUI.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663453);
			TextMeshProUGUI.NativeMethodInfoPtr_get_mesh_Public_Virtual_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663454);
			TextMeshProUGUI.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663455);
			TextMeshProUGUI.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663456);
			TextMeshProUGUI.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663457);
			TextMeshProUGUI.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663458);
			TextMeshProUGUI.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663459);
			TextMeshProUGUI.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663460);
			TextMeshProUGUI.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663461);
			TextMeshProUGUI.NativeMethodInfoPtr_DelayedGraphicRebuild_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663462);
			TextMeshProUGUI.NativeMethodInfoPtr_DelayedMaterialRebuild_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663463);
			TextMeshProUGUI.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663464);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateSubObjectPivot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663465);
			TextMeshProUGUI.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663466);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663467);
			TextMeshProUGUI.NativeMethodInfoPtr_get_maskOffset_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663468);
			TextMeshProUGUI.NativeMethodInfoPtr_set_maskOffset_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663469);
			TextMeshProUGUI.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663470);
			TextMeshProUGUI.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663471);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663472);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663473);
			TextMeshProUGUI.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663474);
			TextMeshProUGUI.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663475);
			TextMeshProUGUI.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663476);
			TextMeshProUGUI.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_TMP_TextInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663477);
			TextMeshProUGUI.NativeMethodInfoPtr_ClearMesh_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663478);
			TextMeshProUGUI.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_add_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663479);
			TextMeshProUGUI.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_rem_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663480);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663481);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_TMP_VertexDataUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663482);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663483);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateFontAsset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663484);
			TextMeshProUGUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663485);
			TextMeshProUGUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663486);
			TextMeshProUGUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663487);
			TextMeshProUGUI.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663488);
			TextMeshProUGUI.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663489);
			TextMeshProUGUI.NativeMethodInfoPtr_GetCanvas_Private_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663490);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateEnvMapMatrix_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663491);
			TextMeshProUGUI.NativeMethodInfoPtr_EnableMasking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663492);
			TextMeshProUGUI.NativeMethodInfoPtr_DisableMasking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663493);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateMask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663494);
			TextMeshProUGUI.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663495);
			TextMeshProUGUI.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663496);
			TextMeshProUGUI.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663497);
			TextMeshProUGUI.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663498);
			TextMeshProUGUI.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663499);
			TextMeshProUGUI.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663500);
			TextMeshProUGUI.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663501);
			TextMeshProUGUI.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663502);
			TextMeshProUGUI.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663503);
			TextMeshProUGUI.NativeMethodInfoPtr_SetCulling_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663504);
			TextMeshProUGUI.NativeMethodInfoPtr_SetPerspectiveCorrection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663505);
			TextMeshProUGUI.NativeMethodInfoPtr_SetMeshArrays_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663506);
			TextMeshProUGUI.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_Int32_Il2CppStructArray_1_UnicodeChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663507);
			TextMeshProUGUI.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663508);
			TextMeshProUGUI.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663509);
			TextMeshProUGUI.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663510);
			TextMeshProUGUI.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663511);
			TextMeshProUGUI.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663512);
			TextMeshProUGUI.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663513);
			TextMeshProUGUI.NativeMethodInfoPtr_OnPreRenderCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663514);
			TextMeshProUGUI.NativeMethodInfoPtr_GenerateTextMesh_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663515);
			TextMeshProUGUI.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663516);
			TextMeshProUGUI.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663517);
			TextMeshProUGUI.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663518);
			TextMeshProUGUI.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663519);
			TextMeshProUGUI.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663520);
			TextMeshProUGUI.NativeMethodInfoPtr_UpdateSDFScale_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663521);
			TextMeshProUGUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, 100663522);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		public unsafe override Material materialForRendering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134745, XrefRangeEnd = 134749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000F10C File Offset: 0x0000D30C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000F154 File Offset: 0x0000D354
		public unsafe override bool autoSizeTextContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134749, XrefRangeEnd = 134753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		public unsafe override Mesh mesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_get_mesh_Public_Virtual_get_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000F1EC File Offset: 0x0000D3EC
		public new unsafe CanvasRenderer canvasRenderer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134753, XrefRangeEnd = 134760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr3) : null;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000F22C File Offset: 0x0000D42C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000F260 File Offset: 0x0000D460
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000F294 File Offset: 0x0000D494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134760, XrefRangeEnd = 134772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134772, XrefRangeEnd = 134782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000F30C File Offset: 0x0000D50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134782, XrefRangeEnd = 134794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000F348 File Offset: 0x0000D548
		[CallerCount(0)]
		public unsafe override void SetAllDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000F384 File Offset: 0x0000D584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134794, XrefRangeEnd = 134798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedGraphicRebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_DelayedGraphicRebuild_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134798, XrefRangeEnd = 134802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedMaterialRebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_DelayedMaterialRebuild_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000F404 File Offset: 0x0000D604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134802, XrefRangeEnd = 134807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000F450 File Offset: 0x0000D650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134807, XrefRangeEnd = 134813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSubObjectPivot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_UpdateSubObjectPivot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000F484 File Offset: 0x0000D684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134813, XrefRangeEnd = 134824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134824, XrefRangeEnd = 134840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000F51C File Offset: 0x0000D71C
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000F558 File Offset: 0x0000D758
		public unsafe Vector4 maskOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_get_maskOffset_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134840, XrefRangeEnd = 134841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_set_maskOffset_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000F598 File Offset: 0x0000D798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134841, XrefRangeEnd = 134842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecalculateClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134842, XrefRangeEnd = 134862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000F62C File Offset: 0x0000D82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134862, XrefRangeEnd = 134878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000F668 File Offset: 0x0000D868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134878, XrefRangeEnd = 134885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMeshPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		[CallerCount(0)]
		public unsafe override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000F718 File Offset: 0x0000D918
		[CallerCount(0)]
		public unsafe override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000F780 File Offset: 0x0000D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134885, XrefRangeEnd = 134893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134893, XrefRangeEnd = 134899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TMP_TextInfo GetTextInfo(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_TMP_TextInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000F834 File Offset: 0x0000DA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134899, XrefRangeEnd = 134907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_ClearMesh_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000F870 File Offset: 0x0000DA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134907, XrefRangeEnd = 134911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_add_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000F8C0 File Offset: 0x0000DAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134911, XrefRangeEnd = 134915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_rem_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000F910 File Offset: 0x0000DB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134915, XrefRangeEnd = 134922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateGeometry(Mesh mesh, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_Void_Mesh_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000F96C File Offset: 0x0000DB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134922, XrefRangeEnd = 134933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_TMP_VertexDataUpdateFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134933, XrefRangeEnd = 134944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000F9F4 File Offset: 0x0000DBF4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 132538, RefRangeEnd = 132556, XrefRangeStart = 132538, XrefRangeEnd = 132556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_UpdateFontAsset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000FA28 File Offset: 0x0000DC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134944, XrefRangeEnd = 134994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000FA64 File Offset: 0x0000DC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134994, XrefRangeEnd = 135024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000FAA0 File Offset: 0x0000DCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135024, XrefRangeEnd = 135045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000FADC File Offset: 0x0000DCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135045, XrefRangeEnd = 135067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000FB18 File Offset: 0x0000DD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135067, XrefRangeEnd = 135181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LoadFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000FB54 File Offset: 0x0000DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135181, XrefRangeEnd = 135203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canvas GetCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_GetCanvas_Private_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000FB94 File Offset: 0x0000DD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135203, XrefRangeEnd = 135227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEnvMapMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_UpdateEnvMapMatrix_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135227, XrefRangeEnd = 135250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_EnableMasking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_DisableMasking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135294, RefRangeEnd = 135296, XrefRangeStart = 135250, XrefRangeEnd = 135294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_UpdateMask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000FC64 File Offset: 0x0000DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135296, XrefRangeEnd = 135306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135306, XrefRangeEnd = 135320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Material> GetMaterials(Il2CppReferenceArray<Material> mats)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mats);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		[CallerCount(0)]
		public unsafe override void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135320, XrefRangeEnd = 135333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Material> GetSharedMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135333, XrefRangeEnd = 135379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetSharedMaterials(Il2CppReferenceArray<Material> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000FE08 File Offset: 0x0000E008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135379, XrefRangeEnd = 135400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOutlineThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000FE54 File Offset: 0x0000E054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135400, XrefRangeEnd = 135410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFaceColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135410, XrefRangeEnd = 135420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOutlineColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135420, XrefRangeEnd = 135433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetShaderDepth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000FF28 File Offset: 0x0000E128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135433, XrefRangeEnd = 135468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetCulling_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000FF64 File Offset: 0x0000E164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135468, XrefRangeEnd = 135477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerspectiveCorrection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_SetPerspectiveCorrection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000FF98 File Offset: 0x0000E198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135477, XrefRangeEnd = 135484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMeshArrays(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_SetMeshArrays_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135484, XrefRangeEnd = 135782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int SetArraySizes(Il2CppStructArray<TMP_Text.UnicodeChar> unicodeChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodeChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_Int32_Il2CppStructArray_1_UnicodeChar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00010030 File Offset: 0x0000E230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135782, XrefRangeEnd = 135792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ComputeMarginSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001006C File Offset: 0x0000E26C
		[CallerCount(0)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000100A8 File Offset: 0x0000E2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135792, XrefRangeEnd = 135807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000100E4 File Offset: 0x0000E2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135807, XrefRangeEnd = 135809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00010120 File Offset: 0x0000E320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135809, XrefRangeEnd = 135834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001015C File Offset: 0x0000E35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135834, XrefRangeEnd = 135837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InternalUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00010198 File Offset: 0x0000E398
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 135857, RefRangeEnd = 135861, XrefRangeStart = 135837, XrefRangeEnd = 135857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRenderCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_OnPreRenderCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000101CC File Offset: 0x0000E3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135861, XrefRangeEnd = 137083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GenerateTextMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GenerateTextMesh_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00010208 File Offset: 0x0000E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137083, XrefRangeEnd = 137089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<Vector3> GetTextContainerLocalCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00010254 File Offset: 0x0000E454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137089, XrefRangeEnd = 137096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetActiveSubMeshes(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000102A0 File Offset: 0x0000E4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137096, XrefRangeEnd = 137104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroySubMeshObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000102DC File Offset: 0x0000E4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137104, XrefRangeEnd = 137123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Bounds GetCompoundBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00010324 File Offset: 0x0000E524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137123, XrefRangeEnd = 137145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetCanvasSpaceClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshProUGUI.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001036C File Offset: 0x0000E56C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137156, RefRangeEnd = 137157, XrefRangeStart = 137145, XrefRangeEnd = 137156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSDFScale(float scaleDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr_UpdateSDFScale_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000103AC File Offset: 0x0000E5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137157, XrefRangeEnd = 137167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMeshProUGUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002819 File Offset: 0x00000A19
		public TextMeshProUGUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000103E8 File Offset: 0x0000E5E8
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002822 File Offset: 0x00000A22
		public unsafe bool m_isRebuildingLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isRebuildingLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isRebuildingLayout)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00010410 File Offset: 0x0000E610
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000283D File Offset: 0x00000A3D
		public unsafe Coroutine m_DelayedGraphicRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_DelayedGraphicRebuild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_DelayedGraphicRebuild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00010440 File Offset: 0x0000E640
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000285C File Offset: 0x00000A5C
		public unsafe Coroutine m_DelayedMaterialRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_DelayedMaterialRebuild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_DelayedMaterialRebuild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00010470 File Offset: 0x0000E670
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000287B File Offset: 0x00000A7B
		public unsafe Rect m_ClipRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_ClipRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_ClipRect)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00010498 File Offset: 0x0000E698
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002896 File Offset: 0x00000A96
		public unsafe bool m_ValidRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_ValidRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_ValidRect)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000104C0 File Offset: 0x0000E6C0
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000028B1 File Offset: 0x00000AB1
		public new unsafe Action<TMP_TextInfo> OnPreRenderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_OnPreRenderText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_OnPreRenderText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000104F0 File Offset: 0x0000E6F0
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000028D0 File Offset: 0x00000AD0
		public unsafe bool m_hasFontAssetChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_hasFontAssetChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_hasFontAssetChanged)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00010518 File Offset: 0x0000E718
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000028EB File Offset: 0x00000AEB
		public unsafe Il2CppReferenceArray<TMP_SubMeshUI> m_subTextObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_subTextObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_SubMeshUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_subTextObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00010548 File Offset: 0x0000E748
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000290A File Offset: 0x00000B0A
		public unsafe float m_previousLossyScaleY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_previousLossyScaleY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_previousLossyScaleY)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00010570 File Offset: 0x0000E770
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002925 File Offset: 0x00000B25
		public unsafe Il2CppStructArray<Vector3> m_RectTransformCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_RectTransformCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_RectTransformCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000105A0 File Offset: 0x0000E7A0
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002944 File Offset: 0x00000B44
		public unsafe CanvasRenderer m_canvasRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_canvasRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_canvasRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000105D0 File Offset: 0x0000E7D0
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002963 File Offset: 0x00000B63
		public unsafe Canvas m_canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00010600 File Offset: 0x0000E800
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002982 File Offset: 0x00000B82
		public unsafe float m_CanvasScaleFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_CanvasScaleFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_CanvasScaleFactor)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00010628 File Offset: 0x0000E828
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000299D File Offset: 0x00000B9D
		public unsafe bool m_isFirstAllocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isFirstAllocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isFirstAllocation)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00010650 File Offset: 0x0000E850
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000029B8 File Offset: 0x00000BB8
		public unsafe int m_max_characters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_max_characters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_max_characters)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00010678 File Offset: 0x0000E878
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000029D3 File Offset: 0x00000BD3
		public unsafe Material m_baseMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_baseMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000106A8 File Offset: 0x0000E8A8
		// (set) Token: 0x060001AE RID: 430 RVA: 0x000029F2 File Offset: 0x00000BF2
		public unsafe bool m_isScrollRegionSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isScrollRegionSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isScrollRegionSet)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000106D0 File Offset: 0x0000E8D0
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002A0D File Offset: 0x00000C0D
		public unsafe Vector4 m_maskOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_maskOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_maskOffset)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000106F8 File Offset: 0x0000E8F8
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002A28 File Offset: 0x00000C28
		public unsafe Matrix4x4 m_EnvMapMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_EnvMapMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_EnvMapMatrix)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00010720 File Offset: 0x0000E920
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002A43 File Offset: 0x00000C43
		public unsafe bool m_isRegisteredForEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isRegisteredForEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI.NativeFieldInfoPtr_m_isRegisteredForEvents)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00010748 File Offset: 0x0000E948
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002A5E File Offset: 0x00000C5E
		public unsafe static ProfilerMarker k_GenerateTextMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextMarker, (void*)(&value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00010764 File Offset: 0x0000E964
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002A6C File Offset: 0x00000C6C
		public unsafe static ProfilerMarker k_SetArraySizesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SetArraySizesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SetArraySizesMarker, (void*)(&value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00010780 File Offset: 0x0000E980
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002A7A File Offset: 0x00000C7A
		public unsafe static ProfilerMarker k_GenerateTextPhaseIMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIMarker, (void*)(&value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0001079C File Offset: 0x0000E99C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002A88 File Offset: 0x00000C88
		public unsafe static ProfilerMarker k_ParseMarkupTextMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_ParseMarkupTextMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_ParseMarkupTextMarker, (void*)(&value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000107B8 File Offset: 0x0000E9B8
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002A96 File Offset: 0x00000C96
		public unsafe static ProfilerMarker k_CharacterLookupMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_CharacterLookupMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_CharacterLookupMarker, (void*)(&value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000107D4 File Offset: 0x0000E9D4
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public unsafe static ProfilerMarker k_HandleGPOSFeaturesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker, (void*)(&value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000107F0 File Offset: 0x0000E9F0
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public unsafe static ProfilerMarker k_CalculateVerticesPositionMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_CalculateVerticesPositionMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_CalculateVerticesPositionMarker, (void*)(&value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001080C File Offset: 0x0000EA0C
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public unsafe static ProfilerMarker k_ComputeTextMetricsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_ComputeTextMetricsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_ComputeTextMetricsMarker, (void*)(&value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00010828 File Offset: 0x0000EA28
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002ACE File Offset: 0x00000CCE
		public unsafe static ProfilerMarker k_HandleVisibleCharacterMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleVisibleCharacterMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleVisibleCharacterMarker, (void*)(&value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00010844 File Offset: 0x0000EA44
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002ADC File Offset: 0x00000CDC
		public unsafe static ProfilerMarker k_HandleWhiteSpacesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleWhiteSpacesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleWhiteSpacesMarker, (void*)(&value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00010860 File Offset: 0x0000EA60
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002AEA File Offset: 0x00000CEA
		public unsafe static ProfilerMarker k_HandleHorizontalLineBreakingMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker, (void*)(&value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0001087C File Offset: 0x0000EA7C
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public unsafe static ProfilerMarker k_HandleVerticalLineBreakingMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker, (void*)(&value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00010898 File Offset: 0x0000EA98
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002B06 File Offset: 0x00000D06
		public unsafe static ProfilerMarker k_SaveGlyphVertexDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker, (void*)(&value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000108B4 File Offset: 0x0000EAB4
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe static ProfilerMarker k_ComputeCharacterAdvanceMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker, (void*)(&value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000108D0 File Offset: 0x0000EAD0
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002B22 File Offset: 0x00000D22
		public unsafe static ProfilerMarker k_HandleCarriageReturnMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleCarriageReturnMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleCarriageReturnMarker, (void*)(&value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000108EC File Offset: 0x0000EAEC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002B30 File Offset: 0x00000D30
		public unsafe static ProfilerMarker k_HandleLineTerminationMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleLineTerminationMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_HandleLineTerminationMarker, (void*)(&value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00010908 File Offset: 0x0000EB08
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002B3E File Offset: 0x00000D3E
		public unsafe static ProfilerMarker k_SavePageInfoMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SavePageInfoMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SavePageInfoMarker, (void*)(&value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00010924 File Offset: 0x0000EB24
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002B4C File Offset: 0x00000D4C
		public unsafe static ProfilerMarker k_SaveProcessingStatesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SaveProcessingStatesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_SaveProcessingStatesMarker, (void*)(&value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00010940 File Offset: 0x0000EB40
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002B5A File Offset: 0x00000D5A
		public unsafe static ProfilerMarker k_GenerateTextPhaseIIMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker, (void*)(&value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0001095C File Offset: 0x0000EB5C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002B68 File Offset: 0x00000D68
		public unsafe static ProfilerMarker k_GenerateTextPhaseIIIMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshProUGUI.NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker, (void*)(&value));
			}
		}

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_m_isRebuildingLayout;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedGraphicRebuild;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedMaterialRebuild;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipRect;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidRect;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_OnPreRenderText;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_m_hasFontAssetChanged;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_m_subTextObjects;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_m_previousLossyScaleY;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransformCorners;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_m_canvasRenderer;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_m_canvas;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasScaleFactor;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_m_isFirstAllocation;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_m_max_characters;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_baseMaterial;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_m_isScrollRegionSet;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_m_maskOffset;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_m_EnvMapMatrix;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_m_isRegisteredForEvents;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextMarker;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_k_SetArraySizesMarker;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextPhaseIMarker;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_k_ParseMarkupTextMarker;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_k_CharacterLookupMarker;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_k_CalculateVerticesPositionMarker;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_k_ComputeTextMetricsMarker;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleVisibleCharacterMarker;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleWhiteSpacesMarker;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleCarriageReturnMarker;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleLineTerminationMarker;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_k_SavePageInfoMarker;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_k_SaveProcessingStatesMarker;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_get_Boolean_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_Virtual_get_Mesh_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_DelayedGraphicRebuild_Private_IEnumerator_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_DelayedMaterialRebuild_Private_IEnumerator_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSubObjectPivot_Private_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_maskOffset_Public_get_Vector4_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_set_maskOffset_Public_set_Void_Vector4_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_Void_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_Void_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_Void_Single_Single_Boolean_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_Void_Boolean_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfo_Public_Virtual_TMP_TextInfo_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_Void_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_add_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_rem_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_Void_Mesh_Int32_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_TMP_VertexDataUpdateFlags_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontAsset_Public_Void_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_Void_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvas_Private_Canvas_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEnvMapMatrix_Private_Void_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_EnableMasking_Private_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_DisableMasking_Private_Void_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMask_Private_Void_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_Material_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_Void_Material_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_Void_Single_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_Void_Color32_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_Void_Color32_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_SetCulling_Protected_Virtual_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_SetPerspectiveCorrection_Private_Void_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_SetMeshArrays_Private_Void_Int32_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_Int32_Il2CppStructArray_1_UnicodeChar_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_Void_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_Void_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRenderCanvas_Private_Void_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTextMesh_Protected_Virtual_New_Void_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_Void_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_Bounds_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_Rect_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSDFScale_Private_Void_Single_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("TMPro.TextMeshProUGUI+<DelayedGraphicRebuild>d__18")]
		public sealed class _DelayedGraphicRebuild_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x06000E7F RID: 3711 RVA: 0x0003A9FC File Offset: 0x00038BFC
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedGraphicRebuild_d__18()
			{
				Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "<DelayedGraphicRebuild>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr);
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, "<>1__state");
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, "<>2__current");
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, "<>4__this");
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, 100664785);
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, 100664786);
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, 100664787);
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, 100664788);
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, 100664789);
				TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr, 100664790);
			}

			// Token: 0x06000E80 RID: 3712 RVA: 0x0003AADC File Offset: 0x00038CDC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedGraphicRebuild_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshProUGUI._DelayedGraphicRebuild_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E81 RID: 3713 RVA: 0x0003AB24 File Offset: 0x00038D24
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E82 RID: 3714 RVA: 0x0003AB58 File Offset: 0x00038D58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134733, XrefRangeEnd = 134734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700055F RID: 1375
			// (get) Token: 0x06000E83 RID: 3715 RVA: 0x0003AB94 File Offset: 0x00038D94
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E84 RID: 3716 RVA: 0x0003ABD4 File Offset: 0x00038DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134734, XrefRangeEnd = 134739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000560 RID: 1376
			// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0003AC08 File Offset: 0x00038E08
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E86 RID: 3718 RVA: 0x00008D45 File Offset: 0x00006F45
			public _DelayedGraphicRebuild_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700055C RID: 1372
			// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0003AC48 File Offset: 0x00038E48
			// (set) Token: 0x06000E88 RID: 3720 RVA: 0x00008D4E File Offset: 0x00006F4E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700055D RID: 1373
			// (get) Token: 0x06000E89 RID: 3721 RVA: 0x0003AC70 File Offset: 0x00038E70
			// (set) Token: 0x06000E8A RID: 3722 RVA: 0x00008D69 File Offset: 0x00006F69
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700055E RID: 1374
			// (get) Token: 0x06000E8B RID: 3723 RVA: 0x0003ACA0 File Offset: 0x00038EA0
			// (set) Token: 0x06000E8C RID: 3724 RVA: 0x00008D88 File Offset: 0x00006F88
			public unsafe TextMeshProUGUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedGraphicRebuild_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000B7C RID: 2940
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000B7D RID: 2941
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000B7E RID: 2942
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000B7F RID: 2943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000B80 RID: 2944
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000B81 RID: 2945
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000B82 RID: 2946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000B83 RID: 2947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000B84 RID: 2948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000077 RID: 119
		[ObfuscatedName("TMPro.TextMeshProUGUI+<DelayedMaterialRebuild>d__19")]
		public sealed class _DelayedMaterialRebuild_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x06000E8D RID: 3725 RVA: 0x0003ACD0 File Offset: 0x00038ED0
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedMaterialRebuild_d__19()
			{
				Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextMeshProUGUI>.NativeClassPtr, "<DelayedMaterialRebuild>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr);
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, "<>1__state");
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, "<>2__current");
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, "<>4__this");
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, 100664791);
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, 100664792);
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, 100664793);
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, 100664794);
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, 100664795);
				TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr, 100664796);
			}

			// Token: 0x06000E8E RID: 3726 RVA: 0x0003ADB0 File Offset: 0x00038FB0
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedMaterialRebuild_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshProUGUI._DelayedMaterialRebuild_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E8F RID: 3727 RVA: 0x0003ADF8 File Offset: 0x00038FF8
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E90 RID: 3728 RVA: 0x0003AE2C File Offset: 0x0003902C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134739, XrefRangeEnd = 134740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000564 RID: 1380
			// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0003AE68 File Offset: 0x00039068
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E92 RID: 3730 RVA: 0x0003AEA8 File Offset: 0x000390A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134740, XrefRangeEnd = 134745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000565 RID: 1381
			// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0003AEDC File Offset: 0x000390DC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E94 RID: 3732 RVA: 0x00008DA7 File Offset: 0x00006FA7
			public _DelayedMaterialRebuild_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000561 RID: 1377
			// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0003AF1C File Offset: 0x0003911C
			// (set) Token: 0x06000E96 RID: 3734 RVA: 0x00008DB0 File Offset: 0x00006FB0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000562 RID: 1378
			// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0003AF44 File Offset: 0x00039144
			// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00008DCB File Offset: 0x00006FCB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000563 RID: 1379
			// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0003AF74 File Offset: 0x00039174
			// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00008DEA File Offset: 0x00006FEA
			public unsafe TextMeshProUGUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProUGUI._DelayedMaterialRebuild_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000B85 RID: 2949
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000B86 RID: 2950
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000B87 RID: 2951
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000B88 RID: 2952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000B89 RID: 2953
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000B8A RID: 2954
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000B8B RID: 2955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000B8C RID: 2956
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000B8D RID: 2957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
