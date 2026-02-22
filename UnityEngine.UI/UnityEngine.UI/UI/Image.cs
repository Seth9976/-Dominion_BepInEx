using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.U2D;

namespace UnityEngine.UI
{
	// Token: 0x02000015 RID: 21
	public class Image : MaskableGraphic
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x0000E140 File Offset: 0x0000C340
		// Note: this type is marked as 'beforefieldinit'.
		static Image()
		{
			Il2CppClassPointerStore<Image>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Image");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image>.NativeClassPtr);
			Image.NativeFieldInfoPtr_s_ETC1DefaultUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_ETC1DefaultUI");
			Image.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Sprite");
			Image.NativeFieldInfoPtr_m_OverrideSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_OverrideSprite");
			Image.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Type");
			Image.NativeFieldInfoPtr_m_PreserveAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_PreserveAspect");
			Image.NativeFieldInfoPtr_m_FillCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillCenter");
			Image.NativeFieldInfoPtr_m_FillMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillMethod");
			Image.NativeFieldInfoPtr_m_FillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillAmount");
			Image.NativeFieldInfoPtr_m_FillClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillClockwise");
			Image.NativeFieldInfoPtr_m_FillOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillOrigin");
			Image.NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_AlphaHitTestMinimumThreshold");
			Image.NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Tracked");
			Image.NativeFieldInfoPtr_m_UseSpriteMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_UseSpriteMesh");
			Image.NativeFieldInfoPtr_m_PixelsPerUnitMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_PixelsPerUnitMultiplier");
			Image.NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_CachedReferencePixelsPerUnit");
			Image.NativeFieldInfoPtr_s_VertScratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_VertScratch");
			Image.NativeFieldInfoPtr_s_UVScratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_UVScratch");
			Image.NativeFieldInfoPtr_s_Xy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_Xy");
			Image.NativeFieldInfoPtr_s_Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_Uv");
			Image.NativeFieldInfoPtr_m_TrackedTexturelessImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_TrackedTexturelessImages");
			Image.NativeFieldInfoPtr_s_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_Initialized");
			Image.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663559);
			Image.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663560);
			Image.NativeMethodInfoPtr_DisableSpriteOptimizations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663561);
			Image.NativeMethodInfoPtr_get_overrideSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663562);
			Image.NativeMethodInfoPtr_set_overrideSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663563);
			Image.NativeMethodInfoPtr_get_activeSprite_Private_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663564);
			Image.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663565);
			Image.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663566);
			Image.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663567);
			Image.NativeMethodInfoPtr_set_preserveAspect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663568);
			Image.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663569);
			Image.NativeMethodInfoPtr_set_fillCenter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663570);
			Image.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663571);
			Image.NativeMethodInfoPtr_set_fillMethod_Public_set_Void_FillMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663572);
			Image.NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663573);
			Image.NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663574);
			Image.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663575);
			Image.NativeMethodInfoPtr_set_fillClockwise_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663576);
			Image.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663577);
			Image.NativeMethodInfoPtr_set_fillOrigin_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663578);
			Image.NativeMethodInfoPtr_get_eventAlphaThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663579);
			Image.NativeMethodInfoPtr_set_eventAlphaThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663580);
			Image.NativeMethodInfoPtr_get_alphaHitTestMinimumThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663581);
			Image.NativeMethodInfoPtr_set_alphaHitTestMinimumThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663582);
			Image.NativeMethodInfoPtr_get_useSpriteMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663583);
			Image.NativeMethodInfoPtr_set_useSpriteMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663584);
			Image.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663585);
			Image.NativeMethodInfoPtr_get_defaultETC1GraphicMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663586);
			Image.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663587);
			Image.NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663588);
			Image.NativeMethodInfoPtr_get_pixelsPerUnitMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663589);
			Image.NativeMethodInfoPtr_set_pixelsPerUnitMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663590);
			Image.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663591);
			Image.NativeMethodInfoPtr_get_multipliedPixelsPerUnit_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663592);
			Image.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663593);
			Image.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663594);
			Image.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663595);
			Image.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663596);
			Image.NativeMethodInfoPtr_PreserveSpriteAspectRatio_Private_Void_byref_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663597);
			Image.NativeMethodInfoPtr_GetDrawingDimensions_Private_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663598);
			Image.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663599);
			Image.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663600);
			Image.NativeMethodInfoPtr_TrackSprite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663601);
			Image.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663602);
			Image.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663603);
			Image.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663604);
			Image.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663605);
			Image.NativeMethodInfoPtr_GenerateSimpleSprite_Private_Void_VertexHelper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663606);
			Image.NativeMethodInfoPtr_GenerateSprite_Private_Void_VertexHelper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663607);
			Image.NativeMethodInfoPtr_GenerateSlicedSprite_Private_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663608);
			Image.NativeMethodInfoPtr_GenerateTiledSprite_Private_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663609);
			Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Il2CppStructArray_1_Vector3_Color32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663610);
			Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Vector2_Vector2_Color32_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663611);
			Image.NativeMethodInfoPtr_GetAdjustedBorders_Private_Vector4_Vector4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663612);
			Image.NativeMethodInfoPtr_GenerateFilledSprite_Private_Void_VertexHelper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663613);
			Image.NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663614);
			Image.NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector3_Single_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663615);
			Image.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663616);
			Image.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663617);
			Image.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663618);
			Image.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663619);
			Image.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663620);
			Image.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663621);
			Image.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663622);
			Image.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663623);
			Image.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663624);
			Image.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663625);
			Image.NativeMethodInfoPtr_MapCoordinate_Private_Vector2_Vector2_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663626);
			Image.NativeMethodInfoPtr_RebuildImage_Private_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663627);
			Image.NativeMethodInfoPtr_TrackImage_Private_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663628);
			Image.NativeMethodInfoPtr_UnTrackImage_Private_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663629);
			Image.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663630);
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		public unsafe Sprite sprite
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(57)]
			[CachedScanResults(RefRangeStart = 111665, RefRangeEnd = 111722, XrefRangeStart = 111650, XrefRangeEnd = 111665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000E938 File Offset: 0x0000CB38
		[CallerCount(0)]
		public unsafe void DisableSpriteOptimizations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_DisableSpriteOptimizations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000E96C File Offset: 0x0000CB6C
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		public unsafe Sprite overrideSprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111722, XrefRangeEnd = 111723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_overrideSprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 111727, RefRangeEnd = 111728, XrefRangeStart = 111723, XrefRangeEnd = 111727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_overrideSprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		public unsafe Sprite activeSprite
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 111732, RefRangeEnd = 111790, XrefRangeStart = 111728, XrefRangeEnd = 111732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_activeSprite_Private_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000EA30 File Offset: 0x0000CC30
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		public unsafe Image.Type type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 111793, RefRangeEnd = 111813, XrefRangeStart = 111790, XrefRangeEnd = 111793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000EAAC File Offset: 0x0000CCAC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		public unsafe bool preserveAspect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111813, XrefRangeEnd = 111816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_preserveAspect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000EB28 File Offset: 0x0000CD28
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000EB64 File Offset: 0x0000CD64
		public unsafe bool fillCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111816, XrefRangeEnd = 111819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillCenter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		public unsafe Image.FillMethod fillMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111819, XrefRangeEnd = 111822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillMethod_Public_set_Void_FillMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000EC20 File Offset: 0x0000CE20
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000EC5C File Offset: 0x0000CE5C
		public unsafe float fillAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 111826, RefRangeEnd = 111830, XrefRangeStart = 111822, XrefRangeEnd = 111826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000EC9C File Offset: 0x0000CE9C
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		public unsafe bool fillClockwise
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111830, XrefRangeEnd = 111833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillClockwise_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000ED54 File Offset: 0x0000CF54
		public unsafe int fillOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111833, XrefRangeEnd = 111836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillOrigin_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000ED94 File Offset: 0x0000CF94
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		public unsafe float eventAlphaThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_eventAlphaThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_eventAlphaThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000EE10 File Offset: 0x0000D010
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000EE4C File Offset: 0x0000D04C
		public unsafe float alphaHitTestMinimumThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_alphaHitTestMinimumThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_alphaHitTestMinimumThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000EE8C File Offset: 0x0000D08C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		public unsafe bool useSpriteMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_useSpriteMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111836, XrefRangeEnd = 111839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_useSpriteMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000EF08 File Offset: 0x0000D108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111839, XrefRangeEnd = 111840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Image()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Image>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000EF44 File Offset: 0x0000D144
		public unsafe static Material defaultETC1GraphicMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111840, XrefRangeEnd = 111855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_defaultETC1GraphicMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000EF78 File Offset: 0x0000D178
		public unsafe override Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111855, XrefRangeEnd = 111874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		public unsafe bool hasBorder
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 111879, RefRangeEnd = 111883, XrefRangeStart = 111874, XrefRangeEnd = 111879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000F000 File Offset: 0x0000D200
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000F03C File Offset: 0x0000D23C
		public unsafe float pixelsPerUnitMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_pixelsPerUnitMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111883, XrefRangeEnd = 111884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_pixelsPerUnitMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000F07C File Offset: 0x0000D27C
		public unsafe float pixelsPerUnit
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 111897, RefRangeEnd = 111908, XrefRangeStart = 111884, XrefRangeEnd = 111897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
		public unsafe float multipliedPixelsPerUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111908, XrefRangeEnd = 111909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_multipliedPixelsPerUnit_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000F140 File Offset: 0x0000D340
		public unsafe override Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111909, XrefRangeEnd = 111941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111941, XrefRangeEnd = 111942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000F190 File Offset: 0x0000D390
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000F1CC File Offset: 0x0000D3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111942, XrefRangeEnd = 111944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000F208 File Offset: 0x0000D408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111954, RefRangeEnd = 111956, XrefRangeStart = 111944, XrefRangeEnd = 111954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spriteSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_PreserveSpriteAspectRatio_Private_Void_byref_Rect_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000F254 File Offset: 0x0000D454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111992, RefRangeEnd = 111994, XrefRangeStart = 111956, XrefRangeEnd = 111992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldPreserveAspect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetDrawingDimensions_Private_Vector4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111994, XrefRangeEnd = 112013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNativeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112013, XrefRangeEnd = 112024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPopulateMesh(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000F32C File Offset: 0x0000D52C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112063, RefRangeEnd = 112066, XrefRangeStart = 112024, XrefRangeEnd = 112063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackSprite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_TrackSprite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000F360 File Offset: 0x0000D560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112066, XrefRangeEnd = 112068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000F39C File Offset: 0x0000D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112068, XrefRangeEnd = 112080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112080, XrefRangeEnd = 112093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000F414 File Offset: 0x0000D614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112093, XrefRangeEnd = 112103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000F450 File Offset: 0x0000D650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112128, RefRangeEnd = 112129, XrefRangeStart = 112103, XrefRangeEnd = 112128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lPreserveAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateSimpleSprite_Private_Void_VertexHelper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112164, RefRangeEnd = 112165, XrefRangeStart = 112129, XrefRangeEnd = 112164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lPreserveAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateSprite_Private_Void_VertexHelper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112222, RefRangeEnd = 112223, XrefRangeStart = 112165, XrefRangeEnd = 112222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateSlicedSprite(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateSlicedSprite_Private_Void_VertexHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000F534 File Offset: 0x0000D734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112318, RefRangeEnd = 112319, XrefRangeStart = 112223, XrefRangeEnd = 112318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTiledSprite(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateTiledSprite_Private_Void_VertexHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000F578 File Offset: 0x0000D778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112329, RefRangeEnd = 112330, XrefRangeStart = 112319, XrefRangeEnd = 112329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddQuad(VertexHelper vertexHelper, Il2CppStructArray<Vector3> quadPositions, Color32 color, Il2CppStructArray<Vector3> quadUVs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertexHelper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadPositions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadUVs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Il2CppStructArray_1_Vector3_Color32_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 112342, RefRangeEnd = 112352, XrefRangeStart = 112330, XrefRangeEnd = 112342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertexHelper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvMin;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Vector2_Vector2_Color32_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000F65C File Offset: 0x0000D85C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112374, RefRangeEnd = 112377, XrefRangeStart = 112352, XrefRangeEnd = 112374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref border;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref adjustedRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetAdjustedBorders_Private_Vector4_Vector4_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112446, RefRangeEnd = 112447, XrefRangeStart = 112377, XrefRangeEnd = 112446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateFilledSprite_Private_Void_VertexHelper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000F704 File Offset: 0x0000D904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112448, RefRangeEnd = 112449, XrefRangeStart = 112447, XrefRangeEnd = 112448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RadialCut(Il2CppStructArray<Vector3> xy, Il2CppStructArray<Vector3> uv, float fill, bool invert, int corner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fill;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref corner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000F784 File Offset: 0x0000D984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112449, XrefRangeEnd = 112454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RadialCut(Il2CppStructArray<Vector3> xy, float cos, float sin, bool invert, int corner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref corner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector3_Single_Single_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000F830 File Offset: 0x0000DA30
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000F86C File Offset: 0x0000DA6C
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112454, XrefRangeEnd = 112463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000F944 File Offset: 0x0000DB44
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000F98C File Offset: 0x0000DB8C
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112463, XrefRangeEnd = 112475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		public unsafe virtual int layoutPriority
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000FA64 File Offset: 0x0000DC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112475, XrefRangeEnd = 112513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000FACC File Offset: 0x0000DCCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112557, RefRangeEnd = 112558, XrefRangeStart = 112513, XrefRangeEnd = 112557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref local;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_MapCoordinate_Private_Vector2_Vector2_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000FB24 File Offset: 0x0000DD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112558, XrefRangeEnd = 112583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildImage(SpriteAtlas spriteAtlas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_RebuildImage_Private_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000FB5C File Offset: 0x0000DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112583, XrefRangeEnd = 112609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackImage(Image g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_TrackImage_Private_Static_Void_Image_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000FB94 File Offset: 0x0000DD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112609, XrefRangeEnd = 112617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnTrackImage(Image g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_UnTrackImage_Private_Static_Void_Image_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		[CallerCount(0)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002B13 File Offset: 0x00000D13
		public Image(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000FC08 File Offset: 0x0000DE08
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002B1C File Offset: 0x00000D1C
		public unsafe static Material s_ETC1DefaultUI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_ETC1DefaultUI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_ETC1DefaultUI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000FC30 File Offset: 0x0000DE30
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002B2E File Offset: 0x00000D2E
		public unsafe Sprite m_Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000FC60 File Offset: 0x0000DE60
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002B4D File Offset: 0x00000D4D
		public unsafe Sprite m_OverrideSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_OverrideSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_OverrideSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000FC90 File Offset: 0x0000DE90
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002B6C File Offset: 0x00000D6C
		public unsafe Image.Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002B87 File Offset: 0x00000D87
		public unsafe bool m_PreserveAspect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PreserveAspect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PreserveAspect)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002BA2 File Offset: 0x00000DA2
		public unsafe bool m_FillCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillCenter)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000FD08 File Offset: 0x0000DF08
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002BBD File Offset: 0x00000DBD
		public unsafe Image.FillMethod m_FillMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillMethod)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000FD30 File Offset: 0x0000DF30
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public unsafe float m_FillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillAmount)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000FD58 File Offset: 0x0000DF58
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002BF3 File Offset: 0x00000DF3
		public unsafe bool m_FillClockwise
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillClockwise);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillClockwise)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000FD80 File Offset: 0x0000DF80
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002C0E File Offset: 0x00000E0E
		public unsafe int m_FillOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillOrigin)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000FDA8 File Offset: 0x0000DFA8
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002C29 File Offset: 0x00000E29
		public unsafe float m_AlphaHitTestMinimumThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000FDD0 File Offset: 0x0000DFD0
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002C44 File Offset: 0x00000E44
		public unsafe bool m_Tracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Tracked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Tracked)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002C5F File Offset: 0x00000E5F
		public unsafe bool m_UseSpriteMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_UseSpriteMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_UseSpriteMesh)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000FE20 File Offset: 0x0000E020
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002C7A File Offset: 0x00000E7A
		public unsafe float m_PixelsPerUnitMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PixelsPerUnitMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PixelsPerUnitMultiplier)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000FE48 File Offset: 0x0000E048
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002C95 File Offset: 0x00000E95
		public unsafe float m_CachedReferencePixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000FE70 File Offset: 0x0000E070
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public unsafe static Il2CppStructArray<Vector2> s_VertScratch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_VertScratch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_VertScratch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000FE98 File Offset: 0x0000E098
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002CC2 File Offset: 0x00000EC2
		public unsafe static Il2CppStructArray<Vector2> s_UVScratch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_UVScratch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_UVScratch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public unsafe static Il2CppStructArray<Vector3> s_Xy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_Xy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_Xy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public unsafe static Il2CppStructArray<Vector3> s_Uv
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_Uv, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_Uv, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000FF10 File Offset: 0x0000E110
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public unsafe static List<Image> m_TrackedTexturelessImages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_m_TrackedTexturelessImages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Image>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_m_TrackedTexturelessImages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000FF38 File Offset: 0x0000E138
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002D0A File Offset: 0x00000F0A
		public unsafe static bool s_Initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_Initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_Initialized, (void*)(&value));
			}
		}

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_s_ETC1DefaultUI;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideSprite;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_m_PreserveAspect;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_m_FillCenter;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_m_FillMethod;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_m_FillAmount;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_m_FillClockwise;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_m_FillOrigin;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracked;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_m_UseSpriteMesh;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_m_PixelsPerUnitMultiplier;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_s_VertScratch;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_s_UVScratch;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_s_Xy;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_s_Uv;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedTexturelessImages;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_s_Initialized;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_DisableSpriteOptimizations_Public_Void_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideSprite_Public_get_Sprite_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideSprite_Public_set_Void_Sprite_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_get_activeSprite_Private_get_Sprite_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_Type_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_set_preserveAspect_Public_set_Void_Boolean_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_set_fillCenter_Public_set_Void_Boolean_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_set_fillMethod_Public_set_Void_FillMethod_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_set_fillClockwise_Public_set_Void_Boolean_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_set_fillOrigin_Public_set_Void_Int32_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_eventAlphaThreshold_Public_get_Single_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_set_eventAlphaThreshold_Public_set_Void_Single_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaHitTestMinimumThreshold_Public_get_Single_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaHitTestMinimumThreshold_Public_set_Void_Single_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_useSpriteMesh_Public_get_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_set_useSpriteMesh_Public_set_Void_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultETC1GraphicMaterial_Public_Static_get_Material_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnitMultiplier_Public_get_Single_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelsPerUnitMultiplier_Public_set_Void_Single_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_multipliedPixelsPerUnit_Protected_get_Single_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_PreserveSpriteAspectRatio_Private_Void_byref_Rect_Vector2_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_GetDrawingDimensions_Private_Vector4_Boolean_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_TrackSprite_Private_Void_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSimpleSprite_Private_Void_VertexHelper_Boolean_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSprite_Private_Void_VertexHelper_Boolean_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSlicedSprite_Private_Void_VertexHelper_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTiledSprite_Private_Void_VertexHelper_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Il2CppStructArray_1_Vector3_Color32_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Vector2_Vector2_Color32_Vector2_Vector2_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustedBorders_Private_Vector4_Vector4_Rect_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFilledSprite_Private_Void_VertexHelper_Boolean_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_Int32_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector3_Single_Single_Boolean_Int32_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_MapCoordinate_Private_Vector2_Vector2_Rect_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_RebuildImage_Private_Static_Void_SpriteAtlas_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_TrackImage_Private_Static_Void_Image_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_UnTrackImage_Private_Static_Void_Image_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x02000083 RID: 131
		public enum Type
		{
			// Token: 0x040008E6 RID: 2278
			Simple,
			// Token: 0x040008E7 RID: 2279
			Sliced,
			// Token: 0x040008E8 RID: 2280
			Tiled,
			// Token: 0x040008E9 RID: 2281
			Filled
		}

		// Token: 0x02000084 RID: 132
		public enum FillMethod
		{
			// Token: 0x040008EB RID: 2283
			Horizontal,
			// Token: 0x040008EC RID: 2284
			Vertical,
			// Token: 0x040008ED RID: 2285
			Radial90,
			// Token: 0x040008EE RID: 2286
			Radial180,
			// Token: 0x040008EF RID: 2287
			Radial360
		}

		// Token: 0x02000085 RID: 133
		public enum OriginHorizontal
		{
			// Token: 0x040008F1 RID: 2289
			Left,
			// Token: 0x040008F2 RID: 2290
			Right
		}

		// Token: 0x02000086 RID: 134
		public enum OriginVertical
		{
			// Token: 0x040008F4 RID: 2292
			Bottom,
			// Token: 0x040008F5 RID: 2293
			Top
		}

		// Token: 0x02000087 RID: 135
		public enum Origin90
		{
			// Token: 0x040008F7 RID: 2295
			BottomLeft,
			// Token: 0x040008F8 RID: 2296
			TopLeft,
			// Token: 0x040008F9 RID: 2297
			TopRight,
			// Token: 0x040008FA RID: 2298
			BottomRight
		}

		// Token: 0x02000088 RID: 136
		public enum Origin180
		{
			// Token: 0x040008FC RID: 2300
			Bottom,
			// Token: 0x040008FD RID: 2301
			Left,
			// Token: 0x040008FE RID: 2302
			Top,
			// Token: 0x040008FF RID: 2303
			Right
		}

		// Token: 0x02000089 RID: 137
		public enum Origin360
		{
			// Token: 0x04000901 RID: 2305
			Bottom,
			// Token: 0x04000902 RID: 2306
			Right,
			// Token: 0x04000903 RID: 2307
			Top,
			// Token: 0x04000904 RID: 2308
			Left
		}
	}
}
