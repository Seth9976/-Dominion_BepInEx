using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000011 RID: 17
	public class Graphic : UIBehaviour
	{
		// Token: 0x06000148 RID: 328 RVA: 0x0000BC9C File Offset: 0x00009E9C
		// Note: this type is marked as 'beforefieldinit'.
		static Graphic()
		{
			Il2CppClassPointerStore<Graphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Graphic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphic>.NativeClassPtr);
			Graphic.NativeFieldInfoPtr_s_DefaultUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_DefaultUI");
			Graphic.NativeFieldInfoPtr_s_WhiteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_WhiteTexture");
			Graphic.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Material");
			Graphic.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Color");
			Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_SkipLayoutUpdate");
			Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_SkipMaterialUpdate");
			Graphic.NativeFieldInfoPtr_m_RaycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastTarget");
			Graphic.NativeFieldInfoPtr_m_RaycastPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastPadding");
			Graphic.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RectTransform");
			Graphic.NativeFieldInfoPtr_m_CanvasRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CanvasRenderer");
			Graphic.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Canvas");
			Graphic.NativeFieldInfoPtr_m_VertsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_VertsDirty");
			Graphic.NativeFieldInfoPtr_m_MaterialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_MaterialDirty");
			Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyLayoutCallback");
			Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyVertsCallback");
			Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyMaterialCallback");
			Graphic.NativeFieldInfoPtr_s_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_Mesh");
			Graphic.NativeFieldInfoPtr_s_VertexHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_VertexHelper");
			Graphic.NativeFieldInfoPtr_m_CachedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CachedMesh");
			Graphic.NativeFieldInfoPtr_m_CachedUvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CachedUvs");
			Graphic.NativeFieldInfoPtr_m_ColorTweenRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_ColorTweenRunner");
			Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "<useLegacyMeshGeneration>k__BackingField");
			Graphic.NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663475);
			Graphic.NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663476);
			Graphic.NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663477);
			Graphic.NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663478);
			Graphic.NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663479);
			Graphic.NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663480);
			Graphic.NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663481);
			Graphic.NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663482);
			Graphic.NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663483);
			Graphic.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663484);
			Graphic.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663485);
			Graphic.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663486);
			Graphic.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663487);
			Graphic.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663488);
			Graphic.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663489);
			Graphic.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663490);
			Graphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663491);
			Graphic.NativeMethodInfoPtr_get_depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663492);
			Graphic.NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663493);
			Graphic.NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663494);
			Graphic.NativeMethodInfoPtr_CacheCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663495);
			Graphic.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663496);
			Graphic.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663497);
			Graphic.NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663498);
			Graphic.NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663499);
			Graphic.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663500);
			Graphic.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663501);
			Graphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663502);
			Graphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663503);
			Graphic.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663504);
			Graphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663505);
			Graphic.NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663506);
			Graphic.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663507);
			Graphic.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663508);
			Graphic.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663509);
			Graphic.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663510);
			Graphic.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663511);
			Graphic.NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663512);
			Graphic.NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663513);
			Graphic.NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663514);
			Graphic.NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663515);
			Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663516);
			Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663517);
			Graphic.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663518);
			Graphic.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663519);
			Graphic.NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663520);
			Graphic.NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663521);
			Graphic.NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663522);
			Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663523);
			Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663524);
			Graphic.NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663525);
			Graphic.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663526);
			Graphic.NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663527);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663528);
			Graphic.NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663529);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663530);
			Graphic.NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663531);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663532);
			Graphic.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663534);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000C320 File Offset: 0x0000A520
		public unsafe static Material defaultGraphicMaterial
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 110390, RefRangeEnd = 110395, XrefRangeStart = 110375, XrefRangeEnd = 110390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000C354 File Offset: 0x0000A554
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000C39C File Offset: 0x0000A59C
		public unsafe virtual Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110395, XrefRangeEnd = 110396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000C430 File Offset: 0x0000A630
		public unsafe virtual bool raycastTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110396, XrefRangeEnd = 110406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000C47C File Offset: 0x0000A67C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
		public unsafe Vector4 raycastPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000C534 File Offset: 0x0000A734
		public unsafe bool useLegacyMeshGeneration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000C574 File Offset: 0x0000A774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110415, RefRangeEnd = 110417, XrefRangeStart = 110406, XrefRangeEnd = 110415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Graphic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Graphic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000C5B0 File Offset: 0x0000A7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110417, XrefRangeEnd = 110419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAllDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000C5EC File Offset: 0x0000A7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110419, XrefRangeEnd = 110427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000C628 File Offset: 0x0000A828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110427, XrefRangeEnd = 110432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000C664 File Offset: 0x0000A864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110432, XrefRangeEnd = 110437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110437, XrefRangeEnd = 110447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110447, XrefRangeEnd = 110459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000C718 File Offset: 0x0000A918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110466, RefRangeEnd = 110467, XrefRangeStart = 110459, XrefRangeEnd = 110466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000C754 File Offset: 0x0000A954
		public unsafe int depth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 110470, RefRangeEnd = 110472, XrefRangeStart = 110467, XrefRangeEnd = 110470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000C790 File Offset: 0x0000A990
		public unsafe virtual RectTransform rectTransform
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 110475, RefRangeEnd = 110523, XrefRangeStart = 110472, XrefRangeEnd = 110475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
		public unsafe Canvas canvas
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 110528, RefRangeEnd = 110569, XrefRangeStart = 110523, XrefRangeEnd = 110528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000C810 File Offset: 0x0000AA10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110593, RefRangeEnd = 110597, XrefRangeStart = 110569, XrefRangeEnd = 110593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_CacheCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000C844 File Offset: 0x0000AA44
		public unsafe CanvasRenderer canvasRenderer
		{
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 110604, RefRangeEnd = 110650, XrefRangeStart = 110597, XrefRangeEnd = 110604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr3) : null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000C884 File Offset: 0x0000AA84
		public unsafe virtual Material defaultMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110650, XrefRangeEnd = 110669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000C91C File Offset: 0x0000AB1C
		public unsafe virtual Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110669, XrefRangeEnd = 110673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110677, RefRangeEnd = 110678, XrefRangeStart = 110673, XrefRangeEnd = 110677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000C96C File Offset: 0x0000AB6C
		public unsafe virtual Material materialForRendering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110678, XrefRangeEnd = 110708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		public unsafe virtual Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110708, XrefRangeEnd = 110712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000CA04 File Offset: 0x0000AC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110731, RefRangeEnd = 110732, XrefRangeStart = 110712, XrefRangeEnd = 110731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000CA40 File Offset: 0x0000AC40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110757, RefRangeEnd = 110758, XrefRangeStart = 110732, XrefRangeEnd = 110757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110758, XrefRangeEnd = 110766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110779, RefRangeEnd = 110780, XrefRangeStart = 110766, XrefRangeEnd = 110779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110780, XrefRangeEnd = 110786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCullingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000CB30 File Offset: 0x0000AD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110786, XrefRangeEnd = 110793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110799, RefRangeEnd = 110800, XrefRangeStart = 110793, XrefRangeEnd = 110799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110801, RefRangeEnd = 110802, XrefRangeStart = 110800, XrefRangeEnd = 110801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110802, XrefRangeEnd = 110868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMeshGeneration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110931, RefRangeEnd = 110932, XrefRangeStart = 110868, XrefRangeEnd = 110931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoLegacyMeshGeneration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		public unsafe static Mesh workerMesh
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 110956, RefRangeEnd = 110962, XrefRangeStart = 110932, XrefRangeEnd = 110956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnFillVBO(List<UIVertex> vbo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000CD58 File Offset: 0x0000AF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110962, XrefRangeEnd = 110969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPopulateMesh(Mesh m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110989, RefRangeEnd = 110990, XrefRangeStart = 110969, XrefRangeEnd = 110989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPopulateMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[CallerCount(0)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000CE34 File Offset: 0x0000B034
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNativeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000CE70 File Offset: 0x0000B070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110990, XrefRangeEnd = 111039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000CED8 File Offset: 0x0000B0D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111056, RefRangeEnd = 111058, XrefRangeStart = 111039, XrefRangeEnd = 111056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 PixelAdjustPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000CF24 File Offset: 0x0000B124
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 111075, RefRangeEnd = 111083, XrefRangeStart = 111058, XrefRangeEnd = 111075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetPixelAdjustedRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000CF60 File Offset: 0x0000B160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111083, RefRangeEnd = 111084, XrefRangeStart = 111083, XrefRangeEnd = 111083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111084, XrefRangeEnd = 111115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000D058 File Offset: 0x0000B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111115, XrefRangeEnd = 111116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color CreateColorFromAlpha(float alpha)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000D098 File Offset: 0x0000B298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111120, RefRangeEnd = 111121, XrefRangeStart = 111116, XrefRangeEnd = 111120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000D100 File Offset: 0x0000B300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111121, XrefRangeEnd = 111124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyLayoutCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000D144 File Offset: 0x0000B344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111124, XrefRangeEnd = 111127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyLayoutCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000D188 File Offset: 0x0000B388
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 111130, RefRangeEnd = 111136, XrefRangeStart = 111127, XrefRangeEnd = 111130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyVerticesCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 111139, RefRangeEnd = 111145, XrefRangeStart = 111136, XrefRangeEnd = 111139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyVerticesCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000D210 File Offset: 0x0000B410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111148, RefRangeEnd = 111150, XrefRangeStart = 111145, XrefRangeEnd = 111148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyMaterialCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000D254 File Offset: 0x0000B454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111153, RefRangeEnd = 111155, XrefRangeStart = 111150, XrefRangeEnd = 111153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyMaterialCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000D298 File Offset: 0x0000B498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111155, XrefRangeEnd = 111156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002759 File Offset: 0x00000959
		public Graphic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002762 File Offset: 0x00000962
		public unsafe static Material s_DefaultUI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_DefaultUI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_DefaultUI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000D300 File Offset: 0x0000B500
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002774 File Offset: 0x00000974
		public unsafe static Texture2D s_WhiteTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_WhiteTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_WhiteTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000D328 File Offset: 0x0000B528
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002786 File Offset: 0x00000986
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000D358 File Offset: 0x0000B558
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000027A5 File Offset: 0x000009A5
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000D380 File Offset: 0x0000B580
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000027C0 File Offset: 0x000009C0
		public unsafe bool m_SkipLayoutUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe bool m_SkipMaterialUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000027F6 File Offset: 0x000009F6
		public unsafe bool m_RaycastTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTarget)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002811 File Offset: 0x00000A11
		public unsafe Vector4 m_RaycastPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastPadding)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000D420 File Offset: 0x0000B620
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000282C File Offset: 0x00000A2C
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000D450 File Offset: 0x0000B650
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000284B File Offset: 0x00000A4B
		public unsafe CanvasRenderer m_CanvasRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CanvasRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CanvasRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000D480 File Offset: 0x0000B680
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0000286A File Offset: 0x00000A6A
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000D4B0 File Offset: 0x0000B6B0
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002889 File Offset: 0x00000A89
		public unsafe bool m_VertsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_VertsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_VertsDirty)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000028A4 File Offset: 0x00000AA4
		public unsafe bool m_MaterialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_MaterialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_MaterialDirty)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000D500 File Offset: 0x0000B700
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000028BF File Offset: 0x00000ABF
		public unsafe UnityAction m_OnDirtyLayoutCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000D530 File Offset: 0x0000B730
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000028DE File Offset: 0x00000ADE
		public unsafe UnityAction m_OnDirtyVertsCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000D560 File Offset: 0x0000B760
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000028FD File Offset: 0x00000AFD
		public unsafe UnityAction m_OnDirtyMaterialCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000D590 File Offset: 0x0000B790
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000291C File Offset: 0x00000B1C
		public unsafe static Mesh s_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000292E File Offset: 0x00000B2E
		public unsafe static VertexHelper s_VertexHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_VertexHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_VertexHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002940 File Offset: 0x00000B40
		public unsafe Mesh m_CachedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000D610 File Offset: 0x0000B810
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000295F File Offset: 0x00000B5F
		public unsafe Il2CppStructArray<Vector2> m_CachedUvs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedUvs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedUvs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000D640 File Offset: 0x0000B840
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000297E File Offset: 0x00000B7E
		public unsafe TweenRunner<ColorTween> m_ColorTweenRunner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_ColorTweenRunner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenRunner<ColorTween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_ColorTweenRunner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000D670 File Offset: 0x0000B870
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000299D File Offset: 0x00000B9D
		public unsafe bool _useLegacyMeshGeneration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField)) = value;
			}
		}

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultUI;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_s_WhiteTexture;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipLayoutUpdate;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipMaterialUpdate;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastTarget;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastPadding;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasRenderer;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_m_VertsDirty;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialDirty;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyLayoutCallback;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyVertsCallback;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyMaterialCallback;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_s_Mesh;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_s_VertexHelper;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedMesh;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedUvs;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorTweenRunner;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Int32_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_CacheCanvas_Private_Void_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;
	}
}
