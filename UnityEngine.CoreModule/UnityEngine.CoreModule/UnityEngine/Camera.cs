using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000039 RID: 57
	public sealed class Camera : Behaviour
	{
		// Token: 0x06000229 RID: 553 RVA: 0x0001BB70 File Offset: 0x00019D70
		// Note: this type is marked as 'beforefieldinit'.
		static Camera()
		{
			Il2CppClassPointerStore<Camera>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Camera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera>.NativeClassPtr);
			Camera.NativeFieldInfoPtr_onPreCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreCull");
			Camera.NativeFieldInfoPtr_onPreRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreRender");
			Camera.NativeFieldInfoPtr_onPostRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPostRender");
			Camera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663401);
			Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663402);
			Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663403);
			Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663404);
			Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663405);
			Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663406);
			Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663407);
			Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663408);
			Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663409);
			Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663410);
			Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663411);
			Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663412);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663413);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663414);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663415);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663416);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663417);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663418);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663419);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663420);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663421);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663422);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663423);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663424);
			Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663425);
			Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663426);
			Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663427);
			Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663428);
			Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663429);
			Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663430);
			Camera.NativeMethodInfoPtr_Render_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663431);
			Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663432);
			Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663433);
			Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663434);
			Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663435);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663436);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663437);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663438);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663439);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663440);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663441);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663442);
			Camera.set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Camera.set_nearClipPlaneDelegate>("UnityEngine.Camera::set_nearClipPlane");
			Camera.set_farClipPlaneDelegateField = IL2CPP.ResolveICall<Camera.set_farClipPlaneDelegate>("UnityEngine.Camera::set_farClipPlane");
			Camera.get_fieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.get_fieldOfViewDelegate>("UnityEngine.Camera::get_fieldOfView");
			Camera.set_fieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.set_fieldOfViewDelegate>("UnityEngine.Camera::set_fieldOfView");
			Camera.get_renderingPathDelegateField = IL2CPP.ResolveICall<Camera.get_renderingPathDelegate>("UnityEngine.Camera::get_renderingPath");
			Camera.set_renderingPathDelegateField = IL2CPP.ResolveICall<Camera.set_renderingPathDelegate>("UnityEngine.Camera::set_renderingPath");
			Camera.get_actualRenderingPathDelegateField = IL2CPP.ResolveICall<Camera.get_actualRenderingPathDelegate>("UnityEngine.Camera::get_actualRenderingPath");
			Camera.ResetDelegateField = IL2CPP.ResolveICall<Camera.ResetDelegate>("UnityEngine.Camera::Reset");
			Camera.get_allowHDRDelegateField = IL2CPP.ResolveICall<Camera.get_allowHDRDelegate>("UnityEngine.Camera::get_allowHDR");
			Camera.set_allowHDRDelegateField = IL2CPP.ResolveICall<Camera.set_allowHDRDelegate>("UnityEngine.Camera::set_allowHDR");
			Camera.get_allowMSAADelegateField = IL2CPP.ResolveICall<Camera.get_allowMSAADelegate>("UnityEngine.Camera::get_allowMSAA");
			Camera.set_allowMSAADelegateField = IL2CPP.ResolveICall<Camera.set_allowMSAADelegate>("UnityEngine.Camera::set_allowMSAA");
			Camera.get_allowDynamicResolutionDelegateField = IL2CPP.ResolveICall<Camera.get_allowDynamicResolutionDelegate>("UnityEngine.Camera::get_allowDynamicResolution");
			Camera.set_allowDynamicResolutionDelegateField = IL2CPP.ResolveICall<Camera.set_allowDynamicResolutionDelegate>("UnityEngine.Camera::set_allowDynamicResolution");
			Camera.get_forceIntoRenderTextureDelegateField = IL2CPP.ResolveICall<Camera.get_forceIntoRenderTextureDelegate>("UnityEngine.Camera::get_forceIntoRenderTexture");
			Camera.set_forceIntoRenderTextureDelegateField = IL2CPP.ResolveICall<Camera.set_forceIntoRenderTextureDelegate>("UnityEngine.Camera::set_forceIntoRenderTexture");
			Camera.get_orthographicSizeDelegateField = IL2CPP.ResolveICall<Camera.get_orthographicSizeDelegate>("UnityEngine.Camera::get_orthographicSize");
			Camera.get_orthographicDelegateField = IL2CPP.ResolveICall<Camera.get_orthographicDelegate>("UnityEngine.Camera::get_orthographic");
			Camera.set_orthographicDelegateField = IL2CPP.ResolveICall<Camera.set_orthographicDelegate>("UnityEngine.Camera::set_orthographic");
			Camera.get_opaqueSortModeDelegateField = IL2CPP.ResolveICall<Camera.get_opaqueSortModeDelegate>("UnityEngine.Camera::get_opaqueSortMode");
			Camera.set_opaqueSortModeDelegateField = IL2CPP.ResolveICall<Camera.set_opaqueSortModeDelegate>("UnityEngine.Camera::set_opaqueSortMode");
			Camera.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<Camera.get_transparencySortModeDelegate>("UnityEngine.Camera::get_transparencySortMode");
			Camera.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<Camera.set_transparencySortModeDelegate>("UnityEngine.Camera::set_transparencySortMode");
			Camera.ResetTransparencySortSettingsDelegateField = IL2CPP.ResolveICall<Camera.ResetTransparencySortSettingsDelegate>("UnityEngine.Camera::ResetTransparencySortSettings");
			Camera.set_depthDelegateField = IL2CPP.ResolveICall<Camera.set_depthDelegate>("UnityEngine.Camera::set_depth");
			Camera.get_aspectDelegateField = IL2CPP.ResolveICall<Camera.get_aspectDelegate>("UnityEngine.Camera::get_aspect");
			Camera.set_aspectDelegateField = IL2CPP.ResolveICall<Camera.set_aspectDelegate>("UnityEngine.Camera::set_aspect");
			Camera.ResetAspectDelegateField = IL2CPP.ResolveICall<Camera.ResetAspectDelegate>("UnityEngine.Camera::ResetAspect");
			Camera.set_cullingMaskDelegateField = IL2CPP.ResolveICall<Camera.set_cullingMaskDelegate>("UnityEngine.Camera::set_cullingMask");
			Camera.set_eventMaskDelegateField = IL2CPP.ResolveICall<Camera.set_eventMaskDelegate>("UnityEngine.Camera::set_eventMask");
			Camera.get_layerCullSphericalDelegateField = IL2CPP.ResolveICall<Camera.get_layerCullSphericalDelegate>("UnityEngine.Camera::get_layerCullSpherical");
			Camera.set_layerCullSphericalDelegateField = IL2CPP.ResolveICall<Camera.set_layerCullSphericalDelegate>("UnityEngine.Camera::set_layerCullSpherical");
			Camera.get_cameraTypeDelegateField = IL2CPP.ResolveICall<Camera.get_cameraTypeDelegate>("UnityEngine.Camera::get_cameraType");
			Camera.set_cameraTypeDelegateField = IL2CPP.ResolveICall<Camera.set_cameraTypeDelegate>("UnityEngine.Camera::set_cameraType");
			Camera.get_overrideSceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.get_overrideSceneCullingMaskDelegate>("UnityEngine.Camera::get_overrideSceneCullingMask");
			Camera.set_overrideSceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.set_overrideSceneCullingMaskDelegate>("UnityEngine.Camera::set_overrideSceneCullingMask");
			Camera.get_sceneCullingMaskDelegateField = IL2CPP.ResolveICall<Camera.get_sceneCullingMaskDelegate>("UnityEngine.Camera::get_sceneCullingMask");
			Camera.GetLayerCullDistancesDelegateField = IL2CPP.ResolveICall<Camera.GetLayerCullDistancesDelegate>("UnityEngine.Camera::GetLayerCullDistances");
			Camera.SetLayerCullDistancesDelegateField = IL2CPP.ResolveICall<Camera.SetLayerCullDistancesDelegate>("UnityEngine.Camera::SetLayerCullDistances");
			Camera.get_useOcclusionCullingDelegateField = IL2CPP.ResolveICall<Camera.get_useOcclusionCullingDelegate>("UnityEngine.Camera::get_useOcclusionCulling");
			Camera.set_useOcclusionCullingDelegateField = IL2CPP.ResolveICall<Camera.set_useOcclusionCullingDelegate>("UnityEngine.Camera::set_useOcclusionCulling");
			Camera.ResetCullingMatrixDelegateField = IL2CPP.ResolveICall<Camera.ResetCullingMatrixDelegate>("UnityEngine.Camera::ResetCullingMatrix");
			Camera.set_clearFlagsDelegateField = IL2CPP.ResolveICall<Camera.set_clearFlagsDelegate>("UnityEngine.Camera::set_clearFlags");
			Camera.get_depthTextureModeDelegateField = IL2CPP.ResolveICall<Camera.get_depthTextureModeDelegate>("UnityEngine.Camera::get_depthTextureMode");
			Camera.set_depthTextureModeDelegateField = IL2CPP.ResolveICall<Camera.set_depthTextureModeDelegate>("UnityEngine.Camera::set_depthTextureMode");
			Camera.get_clearStencilAfterLightingPassDelegateField = IL2CPP.ResolveICall<Camera.get_clearStencilAfterLightingPassDelegate>("UnityEngine.Camera::get_clearStencilAfterLightingPass");
			Camera.set_clearStencilAfterLightingPassDelegateField = IL2CPP.ResolveICall<Camera.set_clearStencilAfterLightingPassDelegate>("UnityEngine.Camera::set_clearStencilAfterLightingPass");
			Camera.SetReplacementShaderDelegateField = IL2CPP.ResolveICall<Camera.SetReplacementShaderDelegate>("UnityEngine.Camera::SetReplacementShader");
			Camera.ResetReplacementShaderDelegateField = IL2CPP.ResolveICall<Camera.ResetReplacementShaderDelegate>("UnityEngine.Camera::ResetReplacementShader");
			Camera.get_projectionMatrixModeDelegateField = IL2CPP.ResolveICall<Camera.get_projectionMatrixModeDelegate>("UnityEngine.Camera::get_projectionMatrixMode");
			Camera.get_usePhysicalPropertiesDelegateField = IL2CPP.ResolveICall<Camera.get_usePhysicalPropertiesDelegate>("UnityEngine.Camera::get_usePhysicalProperties");
			Camera.set_usePhysicalPropertiesDelegateField = IL2CPP.ResolveICall<Camera.set_usePhysicalPropertiesDelegate>("UnityEngine.Camera::set_usePhysicalProperties");
			Camera.get_focalLengthDelegateField = IL2CPP.ResolveICall<Camera.get_focalLengthDelegate>("UnityEngine.Camera::get_focalLength");
			Camera.set_focalLengthDelegateField = IL2CPP.ResolveICall<Camera.set_focalLengthDelegate>("UnityEngine.Camera::set_focalLength");
			Camera.get_gateFitDelegateField = IL2CPP.ResolveICall<Camera.get_gateFitDelegate>("UnityEngine.Camera::get_gateFit");
			Camera.set_gateFitDelegateField = IL2CPP.ResolveICall<Camera.set_gateFitDelegate>("UnityEngine.Camera::set_gateFit");
			Camera.GetGateFittedFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.GetGateFittedFieldOfViewDelegate>("UnityEngine.Camera::GetGateFittedFieldOfView");
			Camera.get_pixelWidthDelegateField = IL2CPP.ResolveICall<Camera.get_pixelWidthDelegate>("UnityEngine.Camera::get_pixelWidth");
			Camera.get_pixelHeightDelegateField = IL2CPP.ResolveICall<Camera.get_pixelHeightDelegate>("UnityEngine.Camera::get_pixelHeight");
			Camera.get_scaledPixelWidthDelegateField = IL2CPP.ResolveICall<Camera.get_scaledPixelWidthDelegate>("UnityEngine.Camera::get_scaledPixelWidth");
			Camera.get_scaledPixelHeightDelegateField = IL2CPP.ResolveICall<Camera.get_scaledPixelHeightDelegate>("UnityEngine.Camera::get_scaledPixelHeight");
			Camera.get_activeTextureDelegateField = IL2CPP.ResolveICall<Camera.get_activeTextureDelegate>("UnityEngine.Camera::get_activeTexture");
			Camera.set_targetDisplayDelegateField = IL2CPP.ResolveICall<Camera.set_targetDisplayDelegate>("UnityEngine.Camera::set_targetDisplay");
			Camera.GetCameraBufferWarningsDelegateField = IL2CPP.ResolveICall<Camera.GetCameraBufferWarningsDelegate>("UnityEngine.Camera::GetCameraBufferWarnings");
			Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegateField = IL2CPP.ResolveICall<Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegate>("UnityEngine.Camera::get_useJitteredProjectionMatrixForTransparentRendering");
			Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegateField = IL2CPP.ResolveICall<Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegate>("UnityEngine.Camera::set_useJitteredProjectionMatrixForTransparentRendering");
			Camera.ResetWorldToCameraMatrixDelegateField = IL2CPP.ResolveICall<Camera.ResetWorldToCameraMatrixDelegate>("UnityEngine.Camera::ResetWorldToCameraMatrix");
			Camera.ResetProjectionMatrixDelegateField = IL2CPP.ResolveICall<Camera.ResetProjectionMatrixDelegate>("UnityEngine.Camera::ResetProjectionMatrix");
			Camera.FocalLengthToFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.FocalLengthToFieldOfViewDelegate>("UnityEngine.Camera::FocalLengthToFieldOfView");
			Camera.FieldOfViewToFocalLengthDelegateField = IL2CPP.ResolveICall<Camera.FieldOfViewToFocalLengthDelegate>("UnityEngine.Camera::FieldOfViewToFocalLength");
			Camera.HorizontalToVerticalFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.HorizontalToVerticalFieldOfViewDelegate>("UnityEngine.Camera::HorizontalToVerticalFieldOfView");
			Camera.VerticalToHorizontalFieldOfViewDelegateField = IL2CPP.ResolveICall<Camera.VerticalToHorizontalFieldOfViewDelegate>("UnityEngine.Camera::VerticalToHorizontalFieldOfView");
			Camera.get_stereoEnabledDelegateField = IL2CPP.ResolveICall<Camera.get_stereoEnabledDelegate>("UnityEngine.Camera::get_stereoEnabled");
			Camera.get_stereoSeparationDelegateField = IL2CPP.ResolveICall<Camera.get_stereoSeparationDelegate>("UnityEngine.Camera::get_stereoSeparation");
			Camera.set_stereoSeparationDelegateField = IL2CPP.ResolveICall<Camera.set_stereoSeparationDelegate>("UnityEngine.Camera::set_stereoSeparation");
			Camera.get_stereoConvergenceDelegateField = IL2CPP.ResolveICall<Camera.get_stereoConvergenceDelegate>("UnityEngine.Camera::get_stereoConvergence");
			Camera.set_stereoConvergenceDelegateField = IL2CPP.ResolveICall<Camera.set_stereoConvergenceDelegate>("UnityEngine.Camera::set_stereoConvergence");
			Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField = IL2CPP.ResolveICall<Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate>("UnityEngine.Camera::get_areVRStereoViewMatricesWithinSingleCullTolerance");
			Camera.get_stereoTargetEyeDelegateField = IL2CPP.ResolveICall<Camera.get_stereoTargetEyeDelegate>("UnityEngine.Camera::get_stereoTargetEye");
			Camera.set_stereoTargetEyeDelegateField = IL2CPP.ResolveICall<Camera.set_stereoTargetEyeDelegate>("UnityEngine.Camera::set_stereoTargetEye");
			Camera.get_stereoActiveEyeDelegateField = IL2CPP.ResolveICall<Camera.get_stereoActiveEyeDelegate>("UnityEngine.Camera::get_stereoActiveEye");
			Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegateField = IL2CPP.ResolveICall<Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegate>("UnityEngine.Camera::CopyStereoDeviceProjectionMatrixToNonJittered");
			Camera.ResetStereoProjectionMatricesDelegateField = IL2CPP.ResolveICall<Camera.ResetStereoProjectionMatricesDelegate>("UnityEngine.Camera::ResetStereoProjectionMatrices");
			Camera.ResetStereoViewMatricesDelegateField = IL2CPP.ResolveICall<Camera.ResetStereoViewMatricesDelegate>("UnityEngine.Camera::ResetStereoViewMatrices");
			Camera.RenderToCubemapImplDelegateField = IL2CPP.ResolveICall<Camera.RenderToCubemapImplDelegate>("UnityEngine.Camera::RenderToCubemapImpl");
			Camera.RenderToCubemapEyeImplDelegateField = IL2CPP.ResolveICall<Camera.RenderToCubemapEyeImplDelegate>("UnityEngine.Camera::RenderToCubemapEyeImpl");
			Camera.RenderWithShaderDelegateField = IL2CPP.ResolveICall<Camera.RenderWithShaderDelegate>("UnityEngine.Camera::RenderWithShader");
			Camera.RenderDontRestoreDelegateField = IL2CPP.ResolveICall<Camera.RenderDontRestoreDelegate>("UnityEngine.Camera::RenderDontRestore");
			Camera.SubmitRenderRequestsInternalDelegateField = IL2CPP.ResolveICall<Camera.SubmitRenderRequestsInternalDelegate>("UnityEngine.Camera::SubmitRenderRequestsInternal");
			Camera.SetupCurrentDelegateField = IL2CPP.ResolveICall<Camera.SetupCurrentDelegate>("UnityEngine.Camera::SetupCurrent");
			Camera.CopyFromDelegateField = IL2CPP.ResolveICall<Camera.CopyFromDelegate>("UnityEngine.Camera::CopyFrom");
			Camera.get_commandBufferCountDelegateField = IL2CPP.ResolveICall<Camera.get_commandBufferCountDelegate>("UnityEngine.Camera::get_commandBufferCount");
			Camera.RemoveCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.RemoveCommandBuffersDelegate>("UnityEngine.Camera::RemoveCommandBuffers");
			Camera.RemoveAllCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.RemoveAllCommandBuffersDelegate>("UnityEngine.Camera::RemoveAllCommandBuffers");
			Camera.AddCommandBufferImplDelegateField = IL2CPP.ResolveICall<Camera.AddCommandBufferImplDelegate>("UnityEngine.Camera::AddCommandBufferImpl");
			Camera.AddCommandBufferAsyncImplDelegateField = IL2CPP.ResolveICall<Camera.AddCommandBufferAsyncImplDelegate>("UnityEngine.Camera::AddCommandBufferAsyncImpl");
			Camera.RemoveCommandBufferImplDelegateField = IL2CPP.ResolveICall<Camera.RemoveCommandBufferImplDelegate>("UnityEngine.Camera::RemoveCommandBufferImpl");
			Camera.GetCommandBuffersDelegateField = IL2CPP.ResolveICall<Camera.GetCommandBuffersDelegate>("UnityEngine.Camera::GetCommandBuffers");
			Camera.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::get_transparencySortAxis_Injected");
			Camera.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::set_transparencySortAxis_Injected");
			Camera.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_velocity_InjectedDelegate>("UnityEngine.Camera::get_velocity_Injected");
			Camera.get_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::get_cullingMatrix_Injected");
			Camera.set_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::set_cullingMatrix_Injected");
			Camera.get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_backgroundColor_InjectedDelegate>("UnityEngine.Camera::get_backgroundColor_Injected");
			Camera.set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_backgroundColor_InjectedDelegate>("UnityEngine.Camera::set_backgroundColor_Injected");
			Camera.get_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_sensorSize_InjectedDelegate>("UnityEngine.Camera::get_sensorSize_Injected");
			Camera.set_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_sensorSize_InjectedDelegate>("UnityEngine.Camera::set_sensorSize_Injected");
			Camera.get_lensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_lensShift_InjectedDelegate>("UnityEngine.Camera::get_lensShift_Injected");
			Camera.set_lensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_lensShift_InjectedDelegate>("UnityEngine.Camera::set_lensShift_Injected");
			Camera.GetGateFittedLensShift_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetGateFittedLensShift_InjectedDelegate>("UnityEngine.Camera::GetGateFittedLensShift_Injected");
			Camera.GetLocalSpaceAim_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetLocalSpaceAim_InjectedDelegate>("UnityEngine.Camera::GetLocalSpaceAim_Injected");
			Camera.get_rect_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_rect_InjectedDelegate>("UnityEngine.Camera::get_rect_Injected");
			Camera.set_rect_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_rect_InjectedDelegate>("UnityEngine.Camera::set_rect_Injected");
			Camera.set_pixelRect_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_pixelRect_InjectedDelegate>("UnityEngine.Camera::set_pixelRect_Injected");
			Camera.get_cameraToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_cameraToWorldMatrix_InjectedDelegate>("UnityEngine.Camera::get_cameraToWorldMatrix_Injected");
			Camera.set_worldToCameraMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_worldToCameraMatrix_InjectedDelegate>("UnityEngine.Camera::set_worldToCameraMatrix_Injected");
			Camera.set_projectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_projectionMatrix_InjectedDelegate>("UnityEngine.Camera::set_projectionMatrix_Injected");
			Camera.get_nonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_nonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_nonJitteredProjectionMatrix_Injected");
			Camera.set_nonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_nonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::set_nonJitteredProjectionMatrix_Injected");
			Camera.get_previousViewProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_previousViewProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_previousViewProjectionMatrix_Injected");
			Camera.CalculateObliqueMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateObliqueMatrix_InjectedDelegate>("UnityEngine.Camera::CalculateObliqueMatrix_Injected");
			Camera.WorldToViewportPoint_InjectedDelegateField = IL2CPP.ResolveICall<Camera.WorldToViewportPoint_InjectedDelegate>("UnityEngine.Camera::WorldToViewportPoint_Injected");
			Camera.ViewportToScreenPoint_InjectedDelegateField = IL2CPP.ResolveICall<Camera.ViewportToScreenPoint_InjectedDelegate>("UnityEngine.Camera::ViewportToScreenPoint_Injected");
			Camera.GetFrustumPlaneSizeAt_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetFrustumPlaneSizeAt_InjectedDelegate>("UnityEngine.Camera::GetFrustumPlaneSizeAt_Injected");
			Camera.ViewportPointToRay_InjectedDelegateField = IL2CPP.ResolveICall<Camera.ViewportPointToRay_InjectedDelegate>("UnityEngine.Camera::ViewportPointToRay_Injected");
			Camera.CalculateFrustumCornersInternal_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateFrustumCornersInternal_InjectedDelegate>("UnityEngine.Camera::CalculateFrustumCornersInternal_Injected");
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField = IL2CPP.ResolveICall<Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate>("UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected");
			Camera.get_scene_InjectedDelegateField = IL2CPP.ResolveICall<Camera.get_scene_InjectedDelegate>("UnityEngine.Camera::get_scene_Injected");
			Camera.set_scene_InjectedDelegateField = IL2CPP.ResolveICall<Camera.set_scene_InjectedDelegate>("UnityEngine.Camera::set_scene_Injected");
			Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoNonJitteredProjectionMatrix_Injected");
			Camera.GetStereoViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoViewMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoViewMatrix_Injected");
			Camera.GetStereoProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.GetStereoProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoProjectionMatrix_Injected");
			Camera.SetStereoProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.SetStereoProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::SetStereoProjectionMatrix_Injected");
			Camera.SetStereoViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Camera.SetStereoViewMatrix_InjectedDelegate>("UnityEngine.Camera::SetStereoViewMatrix_Injected");
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0001C700 File Offset: 0x0001A900
		[CallerCount(279)]
		[CachedScanResults(RefRangeStart = 59667, RefRangeEnd = 59946, XrefRangeStart = 59663, XrefRangeEnd = 59667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0001C73C File Offset: 0x0001A93C
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00003529 File Offset: 0x00001729
		public unsafe float nearClipPlane
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 59948, RefRangeEnd = 59952, XrefRangeStart = 59946, XrefRangeEnd = 59948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0001C778 File Offset: 0x0001A978
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000353C File Offset: 0x0000173C
		public unsafe float farClipPlane
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 59954, RefRangeEnd = 59958, XrefRangeStart = 59952, XrefRangeEnd = 59954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00003651 File Offset: 0x00001851
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		public unsafe float orthographicSize
		{
			get
			{
				return Camera.get_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59960, RefRangeEnd = 59961, XrefRangeStart = 59958, XrefRangeEnd = 59960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0001C7F4 File Offset: 0x0001A9F4
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000036EE File Offset: 0x000018EE
		public unsafe float depth
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 59963, RefRangeEnd = 59970, XrefRangeStart = 59961, XrefRangeEnd = 59963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0001C830 File Offset: 0x0001AA30
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00003738 File Offset: 0x00001938
		public unsafe int cullingMask
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59972, RefRangeEnd = 59975, XrefRangeStart = 59970, XrefRangeEnd = 59972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0001C86C File Offset: 0x0001AA6C
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0000374B File Offset: 0x0000194B
		public unsafe int eventMask
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59977, RefRangeEnd = 59980, XrefRangeStart = 59975, XrefRangeEnd = 59977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_eventMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00003842 File Offset: 0x00001A42
		public unsafe CameraClearFlags clearFlags
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 59982, RefRangeEnd = 59986, XrefRangeStart = 59980, XrefRangeEnd = 59982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003980 File Offset: 0x00001B80
		public unsafe Rect pixelRect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59988, RefRangeEnd = 59990, XrefRangeStart = 59986, XrefRangeEnd = 59988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_pixelRect_Injected(ref value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0001C920 File Offset: 0x0001AB20
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0001C960 File Offset: 0x0001AB60
		public unsafe RenderTexture targetTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59992, RefRangeEnd = 59993, XrefRangeStart = 59990, XrefRangeEnd = 59992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59995, RefRangeEnd = 59997, XrefRangeStart = 59993, XrefRangeEnd = 59995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
		// (set) Token: 0x060002AC RID: 684 RVA: 0x000039D2 File Offset: 0x00001BD2
		public unsafe int targetDisplay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59999, RefRangeEnd = 60002, XrefRangeStart = 59997, XrefRangeEnd = 59999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Camera.set_targetDisplayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000039E5 File Offset: 0x00001BE5
		public unsafe Matrix4x4 worldToCameraMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60002, XrefRangeEnd = 60004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_worldToCameraMatrix_Injected(ref value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0001CA1C File Offset: 0x0001AC1C
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x000039EF File Offset: 0x00001BEF
		public unsafe Matrix4x4 projectionMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60004, XrefRangeEnd = 60006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_projectionMatrix_Injected(ref value);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001CA58 File Offset: 0x0001AC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60006, XrefRangeEnd = 60008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60008, XrefRangeEnd = 60010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001CB08 File Offset: 0x0001AD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60010, XrefRangeEnd = 60012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001CB60 File Offset: 0x0001AD60
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 60014, RefRangeEnd = 60023, XrefRangeStart = 60012, XrefRangeEnd = 60014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001CBAC File Offset: 0x0001ADAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60025, RefRangeEnd = 60027, XrefRangeStart = 60023, XrefRangeEnd = 60025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001CBF8 File Offset: 0x0001ADF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60029, RefRangeEnd = 60031, XrefRangeStart = 60027, XrefRangeEnd = 60029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001CC44 File Offset: 0x0001AE44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60033, RefRangeEnd = 60034, XrefRangeStart = 60031, XrefRangeEnd = 60033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToViewportPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001CC90 File Offset: 0x0001AE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60034, XrefRangeEnd = 60036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60036, XrefRangeEnd = 60038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001CD40 File Offset: 0x0001AF40
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 60040, RefRangeEnd = 60048, XrefRangeStart = 60038, XrefRangeEnd = 60040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0001CD8C File Offset: 0x0001AF8C
		public unsafe static Camera main
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 60050, RefRangeEnd = 60078, XrefRangeStart = 60048, XrefRangeEnd = 60050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		public unsafe static Camera current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 60080, RefRangeEnd = 60081, XrefRangeStart = 60078, XrefRangeEnd = 60080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001CDF4 File Offset: 0x0001AFF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60083, RefRangeEnd = 60084, XrefRangeStart = 60081, XrefRangeEnd = 60083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001CE24 File Offset: 0x0001B024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60084, XrefRangeEnd = 60086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasImpl([Out] Il2CppReferenceArray<Camera> cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*cam = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Camera>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0001CE78 File Offset: 0x0001B078
		public unsafe static int allCamerasCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 60083, RefRangeEnd = 60084, XrefRangeStart = 60083, XrefRangeEnd = 60084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60101, RefRangeEnd = 60102, XrefRangeStart = 60086, XrefRangeEnd = 60101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCameras(Il2CppReferenceArray<Camera> cameras)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameras);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001CEEC File Offset: 0x0001B0EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60104, RefRangeEnd = 60105, XrefRangeStart = 60102, XrefRangeEnd = 60104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_Render_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001CF20 File Offset: 0x0001B120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60105, XrefRangeEnd = 60108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreCull(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001CF58 File Offset: 0x0001B158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60108, XrefRangeEnd = 60111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreRender(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001CF90 File Offset: 0x0001B190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60111, XrefRangeEnd = 60114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPostRender(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60114, XrefRangeEnd = 60116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pixelRect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001D008 File Offset: 0x0001B208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60116, XrefRangeEnd = 60118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001D048 File Offset: 0x0001B248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60118, XrefRangeEnd = 60120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_projectionMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001D088 File Offset: 0x0001B288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60120, XrefRangeEnd = 60122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001D0E4 File Offset: 0x0001B2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60122, XrefRangeEnd = 60124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001D140 File Offset: 0x0001B340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60124, XrefRangeEnd = 60126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001D19C File Offset: 0x0001B39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60126, XrefRangeEnd = 60128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60128, XrefRangeEnd = 60130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000034EA File Offset: 0x000016EA
		public Camera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0001D244 File Offset: 0x0001B444
		// (set) Token: 0x06000256 RID: 598 RVA: 0x000034F3 File Offset: 0x000016F3
		public unsafe static Camera.CameraCallback onPreCull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreCull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreCull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0001D26C File Offset: 0x0001B46C
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00003505 File Offset: 0x00001705
		public unsafe static Camera.CameraCallback onPreRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0001D294 File Offset: 0x0001B494
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00003517 File Offset: 0x00001717
		public unsafe static Camera.CameraCallback onPostRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPostRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPostRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000354F File Offset: 0x0000174F
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00003561 File Offset: 0x00001761
		public float fieldOfView
		{
			get
			{
				return Camera.get_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00003574 File Offset: 0x00001774
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00003586 File Offset: 0x00001786
		public RenderingPath renderingPath
		{
			get
			{
				return Camera.get_renderingPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_renderingPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00003599 File Offset: 0x00001799
		public RenderingPath actualRenderingPath
		{
			get
			{
				return Camera.get_actualRenderingPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000035AB File Offset: 0x000017AB
		public void Reset()
		{
			Camera.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000035BD File Offset: 0x000017BD
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000035CF File Offset: 0x000017CF
		public bool allowHDR
		{
			get
			{
				return Camera.get_allowHDRDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_allowHDRDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000035E2 File Offset: 0x000017E2
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000035F4 File Offset: 0x000017F4
		public bool allowMSAA
		{
			get
			{
				return Camera.get_allowMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_allowMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00003607 File Offset: 0x00001807
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00003619 File Offset: 0x00001819
		public bool allowDynamicResolution
		{
			get
			{
				return Camera.get_allowDynamicResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_allowDynamicResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000362C File Offset: 0x0000182C
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0000363E File Offset: 0x0000183E
		public bool forceIntoRenderTexture
		{
			get
			{
				return Camera.get_forceIntoRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_forceIntoRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00003663 File Offset: 0x00001863
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00003675 File Offset: 0x00001875
		public bool orthographic
		{
			get
			{
				return Camera.get_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00003688 File Offset: 0x00001888
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0000369A File Offset: 0x0000189A
		public UnityEngine.Rendering.OpaqueSortMode opaqueSortMode
		{
			get
			{
				return Camera.get_opaqueSortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_opaqueSortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000036AD File Offset: 0x000018AD
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000036BF File Offset: 0x000018BF
		public TransparencySortMode transparencySortMode
		{
			get
			{
				return Camera.get_transparencySortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_transparencySortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0001D2BC File Offset: 0x0001B4BC
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000036D2 File Offset: 0x000018D2
		public Vector3 transparencySortAxis
		{
			get
			{
				Vector3 vector;
				this.get_transparencySortAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000036DC File Offset: 0x000018DC
		public void ResetTransparencySortSettings()
		{
			Camera.ResetTransparencySortSettingsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00003701 File Offset: 0x00001901
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00003713 File Offset: 0x00001913
		public float aspect
		{
			get
			{
				return Camera.get_aspectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_aspectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00003726 File Offset: 0x00001926
		public void ResetAspect()
		{
			Camera.ResetAspectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0001D2D4 File Offset: 0x0001B4D4
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000375E File Offset: 0x0000195E
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00003770 File Offset: 0x00001970
		public bool layerCullSpherical
		{
			get
			{
				return Camera.get_layerCullSphericalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_layerCullSphericalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00003783 File Offset: 0x00001983
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00003795 File Offset: 0x00001995
		public CameraType cameraType
		{
			get
			{
				return Camera.get_cameraTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_cameraTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000037A8 File Offset: 0x000019A8
		// (set) Token: 0x06000281 RID: 641 RVA: 0x000037BA File Offset: 0x000019BA
		public ulong overrideSceneCullingMask
		{
			get
			{
				return Camera.get_overrideSceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_overrideSceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000037CD File Offset: 0x000019CD
		public ulong sceneCullingMask
		{
			get
			{
				return Camera.get_sceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		public Il2CppStructArray<float> GetLayerCullDistances()
		{
			IntPtr intPtr = Camera.GetLayerCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000037DF File Offset: 0x000019DF
		public void SetLayerCullDistances(Il2CppStructArray<float> d)
		{
			Camera.SetLayerCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(d));
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0001D318 File Offset: 0x0001B518
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0001D330 File Offset: 0x0001B530
		public Il2CppStructArray<float> layerCullDistances
		{
			get
			{
				return this.GetLayerCullDistances();
			}
			set
			{
				bool flag = value.Length != 32;
				if (flag)
				{
					throw new UnityException("Array needs to contain exactly 32 floats for layerCullDistances.");
				}
				this.SetLayerCullDistances(value);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0001D364 File Offset: 0x0001B564
		public static int PreviewCullingLayer
		{
			get
			{
				return 31;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000037F7 File Offset: 0x000019F7
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00003809 File Offset: 0x00001A09
		public bool useOcclusionCulling
		{
			get
			{
				return Camera.get_useOcclusionCullingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_useOcclusionCullingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0001D378 File Offset: 0x0001B578
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0000381C File Offset: 0x00001A1C
		public Matrix4x4 cullingMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_cullingMatrix_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.set_cullingMatrix_Injected(ref value);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003826 File Offset: 0x00001A26
		public void ResetCullingMatrix()
		{
			Camera.ResetCullingMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0001D390 File Offset: 0x0001B590
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003838 File Offset: 0x00001A38
		public Color backgroundColor
		{
			get
			{
				Color color;
				this.get_backgroundColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_backgroundColor_Injected(ref value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00003855 File Offset: 0x00001A55
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003867 File Offset: 0x00001A67
		public DepthTextureMode depthTextureMode
		{
			get
			{
				return Camera.get_depthTextureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_depthTextureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000387A File Offset: 0x00001A7A
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000388C File Offset: 0x00001A8C
		public bool clearStencilAfterLightingPass
		{
			get
			{
				return Camera.get_clearStencilAfterLightingPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_clearStencilAfterLightingPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000389F File Offset: 0x00001A9F
		public void SetReplacementShader(Shader shader, string replacementTag)
		{
			Camera.SetReplacementShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(replacementTag));
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000038BD File Offset: 0x00001ABD
		public void ResetReplacementShader()
		{
			Camera.ResetReplacementShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000038CF File Offset: 0x00001ACF
		public Camera.ProjectionMatrixMode projectionMatrixMode
		{
			get
			{
				return Camera.get_projectionMatrixModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000038E1 File Offset: 0x00001AE1
		// (set) Token: 0x06000298 RID: 664 RVA: 0x000038F3 File Offset: 0x00001AF3
		public bool usePhysicalProperties
		{
			get
			{
				return Camera.get_usePhysicalPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_usePhysicalPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0001D3A8 File Offset: 0x0001B5A8
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00003906 File Offset: 0x00001B06
		public Vector2 sensorSize
		{
			get
			{
				Vector2 vector;
				this.get_sensorSize_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_sensorSize_Injected(ref value);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0001D3C0 File Offset: 0x0001B5C0
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00003910 File Offset: 0x00001B10
		public Vector2 lensShift
		{
			get
			{
				Vector2 vector;
				this.get_lensShift_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_lensShift_Injected(ref value);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000391A File Offset: 0x00001B1A
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0000392C File Offset: 0x00001B2C
		public float focalLength
		{
			get
			{
				return Camera.get_focalLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_focalLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000393F File Offset: 0x00001B3F
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00003951 File Offset: 0x00001B51
		public Camera.GateFitMode gateFit
		{
			get
			{
				return Camera.get_gateFitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_gateFitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003964 File Offset: 0x00001B64
		public float GetGateFittedFieldOfView()
		{
			return Camera.GetGateFittedFieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001D3D8 File Offset: 0x0001B5D8
		public Vector2 GetGateFittedLensShift()
		{
			Vector2 vector;
			this.GetGateFittedLensShift_Injected(out vector);
			return vector;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		public Vector3 GetLocalSpaceAim()
		{
			Vector3 vector;
			this.GetLocalSpaceAim_Injected(out vector);
			return vector;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0001D408 File Offset: 0x0001B608
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00003976 File Offset: 0x00001B76
		public Rect rect
		{
			get
			{
				Rect rect;
				this.get_rect_Injected(out rect);
				return rect;
			}
			set
			{
				this.set_rect_Injected(ref value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000398A File Offset: 0x00001B8A
		public int pixelWidth
		{
			get
			{
				return Camera.get_pixelWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000399C File Offset: 0x00001B9C
		public int pixelHeight
		{
			get
			{
				return Camera.get_pixelHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000039AE File Offset: 0x00001BAE
		public int scaledPixelWidth
		{
			get
			{
				return Camera.get_scaledPixelWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000039C0 File Offset: 0x00001BC0
		public int scaledPixelHeight
		{
			get
			{
				return Camera.get_scaledPixelHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0001D420 File Offset: 0x0001B620
		public RenderTexture activeTexture
		{
			get
			{
				IntPtr intPtr = Camera.get_activeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0001D44C File Offset: 0x0001B64C
		public Il2CppStringArray GetCameraBufferWarnings()
		{
			IntPtr intPtr = Camera.GetCameraBufferWarningsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001D478 File Offset: 0x0001B678
		public Matrix4x4 cameraToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_cameraToWorldMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001D490 File Offset: 0x0001B690
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x000039F9 File Offset: 0x00001BF9
		public Matrix4x4 nonJitteredProjectionMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_nonJitteredProjectionMatrix_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.set_nonJitteredProjectionMatrix_Injected(ref value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00003A03 File Offset: 0x00001C03
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00003A15 File Offset: 0x00001C15
		public bool useJitteredProjectionMatrixForTransparentRendering
		{
			get
			{
				return Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
		public Matrix4x4 previousViewProjectionMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_previousViewProjectionMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00003A28 File Offset: 0x00001C28
		public void ResetWorldToCameraMatrix()
		{
			Camera.ResetWorldToCameraMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003A3A File Offset: 0x00001C3A
		public void ResetProjectionMatrix()
		{
			Camera.ResetProjectionMatrixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
		{
			Matrix4x4 matrix4x;
			this.CalculateObliqueMatrix_Injected(ref clipPlane, out matrix4x);
			return matrix4x;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			Vector3 vector;
			this.WorldToViewportPoint_Injected(ref position, eye, out vector);
			return vector;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001D4F4 File Offset: 0x0001B6F4
		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			return this.WorldToViewportPoint(position, Camera.MonoOrStereoscopicEye.Mono);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001D510 File Offset: 0x0001B710
		public Vector3 ViewportToScreenPoint(Vector3 position)
		{
			Vector3 vector;
			this.ViewportToScreenPoint_Injected(ref position, out vector);
			return vector;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001D528 File Offset: 0x0001B728
		public Vector2 GetFrustumPlaneSizeAt(float distance)
		{
			Vector2 vector;
			this.GetFrustumPlaneSizeAt_Injected(distance, out vector);
			return vector;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001D540 File Offset: 0x0001B740
		public Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			Ray ray;
			this.ViewportPointToRay_Injected(ref pos, eye, out ray);
			return ray;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001D55C File Offset: 0x0001B75C
		public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			return this.ViewportPointToRay(pos, eye);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0001D57C File Offset: 0x0001B77C
		public Ray ViewportPointToRay(Vector3 pos)
		{
			return this.ViewportPointToRay(pos, Camera.MonoOrStereoscopicEye.Mono);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00003A4C File Offset: 0x00001C4C
		public void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			this.CalculateFrustumCornersInternal_Injected(ref viewport, z, eye, outCorners);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001D598 File Offset: 0x0001B798
		public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Il2CppStructArray<Vector3> outCorners)
		{
			bool flag = outCorners == null;
			if (flag)
			{
				throw new ArgumentNullException("outCorners");
			}
			bool flag2 = outCorners.Length < 4;
			if (flag2)
			{
				throw new ArgumentException("outCorners minimum size is 4", "outCorners");
			}
			this.CalculateFrustumCornersInternal(viewport, z, eye, outCorners);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00003A5A File Offset: 0x00001C5A
		public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out output, focalLength, ref sensorSize, ref lensShift, nearClip, farClip, gateAspect, gateFitMode);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003A6F File Offset: 0x00001C6F
		public static float FocalLengthToFieldOfView(float focalLength, float sensorSize)
		{
			return Camera.FocalLengthToFieldOfViewDelegateField(focalLength, sensorSize);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003A7D File Offset: 0x00001C7D
		public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
		{
			return Camera.FieldOfViewToFocalLengthDelegateField(fieldOfView, sensorSize);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00003A8B File Offset: 0x00001C8B
		public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio)
		{
			return Camera.HorizontalToVerticalFieldOfViewDelegateField(horizontalFieldOfView, aspectRatio);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003A99 File Offset: 0x00001C99
		public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio)
		{
			return Camera.VerticalToHorizontalFieldOfViewDelegateField(verticalFieldOfView, aspectRatio);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0001D5E8 File Offset: 0x0001B7E8
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00003AA7 File Offset: 0x00001CA7
		public UnityEngine.SceneManagement.Scene scene
		{
			get
			{
				UnityEngine.SceneManagement.Scene scene;
				this.get_scene_Injected(out scene);
				return scene;
			}
			set
			{
				this.set_scene_Injected(ref value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00003AB1 File Offset: 0x00001CB1
		public bool stereoEnabled
		{
			get
			{
				return Camera.get_stereoEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00003AC3 File Offset: 0x00001CC3
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00003AD5 File Offset: 0x00001CD5
		public float stereoSeparation
		{
			get
			{
				return Camera.get_stereoSeparationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_stereoSeparationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00003AE8 File Offset: 0x00001CE8
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003AFA File Offset: 0x00001CFA
		public float stereoConvergence
		{
			get
			{
				return Camera.get_stereoConvergenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_stereoConvergenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00003B0D File Offset: 0x00001D0D
		public bool areVRStereoViewMatricesWithinSingleCullTolerance
		{
			get
			{
				return Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00003B1F File Offset: 0x00001D1F
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003B31 File Offset: 0x00001D31
		public StereoTargetEyeMask stereoTargetEye
		{
			get
			{
				return Camera.get_stereoTargetEyeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Camera.set_stereoTargetEyeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00003B44 File Offset: 0x00001D44
		public Camera.MonoOrStereoscopicEye stereoActiveEye
		{
			get
			{
				return Camera.get_stereoActiveEyeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001D600 File Offset: 0x0001B800
		public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 matrix4x;
			this.GetStereoNonJitteredProjectionMatrix_Injected(eye, out matrix4x);
			return matrix4x;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001D618 File Offset: 0x0001B818
		public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 matrix4x;
			this.GetStereoViewMatrix_Injected(eye, out matrix4x);
			return matrix4x;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003B56 File Offset: 0x00001D56
		public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye)
		{
			Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001D630 File Offset: 0x0001B830
		public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 matrix4x;
			this.GetStereoProjectionMatrix_Injected(eye, out matrix4x);
			return matrix4x;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00003B69 File Offset: 0x00001D69
		public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			this.SetStereoProjectionMatrix_Injected(eye, ref matrix);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00003B74 File Offset: 0x00001D74
		public void ResetStereoProjectionMatrices()
		{
			Camera.ResetStereoProjectionMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00003B86 File Offset: 0x00001D86
		public void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			this.SetStereoViewMatrix_Injected(eye, ref matrix);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003B91 File Offset: 0x00001D91
		public void ResetStereoViewMatrices()
		{
			Camera.ResetStereoViewMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0001D648 File Offset: 0x0001B848
		public static Il2CppReferenceArray<Camera> allCameras
		{
			get
			{
				Il2CppReferenceArray<Camera> il2CppReferenceArray = new Il2CppReferenceArray<Camera>((long)Camera.allCamerasCount);
				Camera.GetAllCamerasImpl(il2CppReferenceArray);
				return il2CppReferenceArray;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public bool RenderToCubemapImpl(Texture tex, int faceMask)
		{
			return Camera.RenderToCubemapImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(tex), faceMask);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001D670 File Offset: 0x0001B870
		public bool RenderToCubemap(Cubemap cubemap, int faceMask)
		{
			return this.RenderToCubemapImpl(cubemap, faceMask);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001D68C File Offset: 0x0001B88C
		public bool RenderToCubemap(Cubemap cubemap)
		{
			return this.RenderToCubemapImpl(cubemap, 63);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001D6A8 File Offset: 0x0001B8A8
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask)
		{
			return this.RenderToCubemapImpl(cubemap, faceMask);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
		public bool RenderToCubemap(RenderTexture cubemap)
		{
			return this.RenderToCubemapImpl(cubemap, 63);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003BBC File Offset: 0x00001DBC
		public bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			return Camera.RenderToCubemapEyeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(cubemap), faceMask, stereoEye);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			return this.RenderToCubemapEyeImpl(cubemap, faceMask, stereoEye);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003BD6 File Offset: 0x00001DD6
		public void RenderWithShader(Shader shader, string replacementTag)
		{
			Camera.RenderWithShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(replacementTag));
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public void RenderDontRestore()
		{
			Camera.RenderDontRestoreDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001D6FC File Offset: 0x0001B8FC
		public void SubmitRenderRequests(List<Camera.RenderRequest> renderRequests)
		{
			bool flag = renderRequests == null || renderRequests.Count == 0;
			if (flag)
			{
				throw new ArgumentException("SubmitRenderRequests has been invoked with invalid renderRequests");
			}
			bool flag2 = UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline == null;
			if (flag2)
			{
				Debug.LogWarning("Trying to invoke 'SubmitRenderRequests' when no SRP is set. A scriptable render pipeline is needed for this function call");
			}
			else
			{
				this.SubmitRenderRequestsInternal(renderRequests);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003C06 File Offset: 0x00001E06
		public void SubmitRenderRequestsInternal(Object requests)
		{
			Camera.SubmitRenderRequestsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(requests));
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00003C1E File Offset: 0x00001E1E
		public static void SetupCurrent(Camera cur)
		{
			Camera.SetupCurrentDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cur));
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00003C30 File Offset: 0x00001E30
		public void CopyFrom(Camera other)
		{
			Camera.CopyFromDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(other));
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00003C48 File Offset: 0x00001E48
		public int commandBufferCount
		{
			get
			{
				return Camera.get_commandBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003C5A File Offset: 0x00001E5A
		public void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			Camera.RemoveCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00003C6D File Offset: 0x00001E6D
		public void RemoveAllCommandBuffers()
		{
			Camera.RemoveAllCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003C7F File Offset: 0x00001E7F
		public void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			Camera.AddCommandBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003C98 File Offset: 0x00001E98
		public void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Camera.AddCommandBufferAsyncImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), queueType);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003CB2 File Offset: 0x00001EB2
		public void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			Camera.RemoveCommandBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001D750 File Offset: 0x0001B950
		public void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			bool flag = !UnityEngine.Rendering.CameraEventUtils.IsValid(evt);
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid CameraEvent value \"{0}\".", (int)evt), "evt");
			}
			bool flag2 = buffer == null;
			if (flag2)
			{
				throw new NullReferenceException("buffer is null");
			}
			this.AddCommandBufferImpl(evt, buffer);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001D7A4 File Offset: 0x0001B9A4
		public void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			bool flag = !UnityEngine.Rendering.CameraEventUtils.IsValid(evt);
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid CameraEvent value \"{0}\".", (int)evt), "evt");
			}
			bool flag2 = buffer == null;
			if (flag2)
			{
				throw new NullReferenceException("buffer is null");
			}
			this.AddCommandBufferAsyncImpl(evt, buffer, queueType);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
		public void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			bool flag = !UnityEngine.Rendering.CameraEventUtils.IsValid(evt);
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid CameraEvent value \"{0}\".", (int)evt), "evt");
			}
			bool flag2 = buffer == null;
			if (flag2)
			{
				throw new NullReferenceException("buffer is null");
			}
			this.RemoveCommandBufferImpl(evt, buffer);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001D84C File Offset: 0x0001BA4C
		public Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			IntPtr intPtr = Camera.GetCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr2) : null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003CCB File Offset: 0x00001ECB
		public void OnlyUsedForTesting1()
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00003CCE File Offset: 0x00001ECE
		public void OnlyUsedForTesting2()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003CD1 File Offset: 0x00001ED1
		public void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			Camera.get_transparencySortAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			Camera.set_transparencySortAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003CF7 File Offset: 0x00001EF7
		public void get_velocity_Injected(out Vector3 ret)
		{
			Camera.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003D0A File Offset: 0x00001F0A
		public void get_cullingMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_cullingMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003D1D File Offset: 0x00001F1D
		public void set_cullingMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_cullingMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003D30 File Offset: 0x00001F30
		public void get_backgroundColor_Injected(out Color ret)
		{
			Camera.get_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00003D43 File Offset: 0x00001F43
		public void set_backgroundColor_Injected(ref Color value)
		{
			Camera.set_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00003D56 File Offset: 0x00001F56
		public void get_sensorSize_Injected(out Vector2 ret)
		{
			Camera.get_sensorSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003D69 File Offset: 0x00001F69
		public void set_sensorSize_Injected(ref Vector2 value)
		{
			Camera.set_sensorSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003D7C File Offset: 0x00001F7C
		public void get_lensShift_Injected(out Vector2 ret)
		{
			Camera.get_lensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003D8F File Offset: 0x00001F8F
		public void set_lensShift_Injected(ref Vector2 value)
		{
			Camera.set_lensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003DA2 File Offset: 0x00001FA2
		public void GetGateFittedLensShift_Injected(out Vector2 ret)
		{
			Camera.GetGateFittedLensShift_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003DB5 File Offset: 0x00001FB5
		public void GetLocalSpaceAim_Injected(out Vector3 ret)
		{
			Camera.GetLocalSpaceAim_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public void get_rect_Injected(out Rect ret)
		{
			Camera.get_rect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00003DDB File Offset: 0x00001FDB
		public void set_rect_Injected(ref Rect value)
		{
			Camera.set_rect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00003DEE File Offset: 0x00001FEE
		public void set_pixelRect_Injected(ref Rect value)
		{
			Camera.set_pixelRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003E01 File Offset: 0x00002001
		public void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_cameraToWorldMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003E14 File Offset: 0x00002014
		public void set_worldToCameraMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_worldToCameraMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003E27 File Offset: 0x00002027
		public void set_projectionMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_projectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003E3A File Offset: 0x0000203A
		public void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_nonJitteredProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003E4D File Offset: 0x0000204D
		public void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value)
		{
			Camera.set_nonJitteredProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003E60 File Offset: 0x00002060
		public void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Camera.get_previousViewProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003E73 File Offset: 0x00002073
		public void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret)
		{
			Camera.CalculateObliqueMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref clipPlane, out ret);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003E87 File Offset: 0x00002087
		public void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			Camera.WorldToViewportPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, eye, out ret);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003E9C File Offset: 0x0000209C
		public void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			Camera.ViewportToScreenPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003EB0 File Offset: 0x000020B0
		public void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret)
		{
			Camera.GetFrustumPlaneSizeAt_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), distance, out ret);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00003EC4 File Offset: 0x000020C4
		public void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			Camera.ViewportPointToRay_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref pos, eye, out ret);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003ED9 File Offset: 0x000020D9
		public void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			Camera.CalculateFrustumCornersInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref viewport, z, eye, IL2CPP.Il2CppObjectBaseToPtr(outCorners));
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001D87C File Offset: 0x0001BA7C
		public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField(out output, focalLength, ref sensorSize, ref lensShift, nearClip, farClip, gateAspect, gateFitMode);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00003EF5 File Offset: 0x000020F5
		public void get_scene_Injected(out UnityEngine.SceneManagement.Scene ret)
		{
			Camera.get_scene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003F08 File Offset: 0x00002108
		public void set_scene_Injected(ref UnityEngine.SceneManagement.Scene value)
		{
			Camera.set_scene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003F1B File Offset: 0x0000211B
		public void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003F2F File Offset: 0x0000212F
		public void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoViewMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003F43 File Offset: 0x00002143
		public void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			Camera.GetStereoProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, out ret);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00003F57 File Offset: 0x00002157
		public void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			Camera.SetStereoProjectionMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, ref matrix);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00003F6B File Offset: 0x0000216B
		public void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			Camera.SetStereoViewMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eye, ref matrix);
		}

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_onPreCull;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_onPreRender;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_onPostRender;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Single_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0;

		// Token: 0x040001AE RID: 430
		private static readonly Camera.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField;

		// Token: 0x040001AF RID: 431
		private static readonly Camera.set_farClipPlaneDelegate set_farClipPlaneDelegateField;

		// Token: 0x040001B0 RID: 432
		private static readonly Camera.get_fieldOfViewDelegate get_fieldOfViewDelegateField;

		// Token: 0x040001B1 RID: 433
		private static readonly Camera.set_fieldOfViewDelegate set_fieldOfViewDelegateField;

		// Token: 0x040001B2 RID: 434
		private static readonly Camera.get_renderingPathDelegate get_renderingPathDelegateField;

		// Token: 0x040001B3 RID: 435
		private static readonly Camera.set_renderingPathDelegate set_renderingPathDelegateField;

		// Token: 0x040001B4 RID: 436
		private static readonly Camera.get_actualRenderingPathDelegate get_actualRenderingPathDelegateField;

		// Token: 0x040001B5 RID: 437
		private static readonly Camera.ResetDelegate ResetDelegateField;

		// Token: 0x040001B6 RID: 438
		private static readonly Camera.get_allowHDRDelegate get_allowHDRDelegateField;

		// Token: 0x040001B7 RID: 439
		private static readonly Camera.set_allowHDRDelegate set_allowHDRDelegateField;

		// Token: 0x040001B8 RID: 440
		private static readonly Camera.get_allowMSAADelegate get_allowMSAADelegateField;

		// Token: 0x040001B9 RID: 441
		private static readonly Camera.set_allowMSAADelegate set_allowMSAADelegateField;

		// Token: 0x040001BA RID: 442
		private static readonly Camera.get_allowDynamicResolutionDelegate get_allowDynamicResolutionDelegateField;

		// Token: 0x040001BB RID: 443
		private static readonly Camera.set_allowDynamicResolutionDelegate set_allowDynamicResolutionDelegateField;

		// Token: 0x040001BC RID: 444
		private static readonly Camera.get_forceIntoRenderTextureDelegate get_forceIntoRenderTextureDelegateField;

		// Token: 0x040001BD RID: 445
		private static readonly Camera.set_forceIntoRenderTextureDelegate set_forceIntoRenderTextureDelegateField;

		// Token: 0x040001BE RID: 446
		private static readonly Camera.get_orthographicSizeDelegate get_orthographicSizeDelegateField;

		// Token: 0x040001BF RID: 447
		private static readonly Camera.get_orthographicDelegate get_orthographicDelegateField;

		// Token: 0x040001C0 RID: 448
		private static readonly Camera.set_orthographicDelegate set_orthographicDelegateField;

		// Token: 0x040001C1 RID: 449
		private static readonly Camera.get_opaqueSortModeDelegate get_opaqueSortModeDelegateField;

		// Token: 0x040001C2 RID: 450
		private static readonly Camera.set_opaqueSortModeDelegate set_opaqueSortModeDelegateField;

		// Token: 0x040001C3 RID: 451
		private static readonly Camera.get_transparencySortModeDelegate get_transparencySortModeDelegateField;

		// Token: 0x040001C4 RID: 452
		private static readonly Camera.set_transparencySortModeDelegate set_transparencySortModeDelegateField;

		// Token: 0x040001C5 RID: 453
		private static readonly Camera.ResetTransparencySortSettingsDelegate ResetTransparencySortSettingsDelegateField;

		// Token: 0x040001C6 RID: 454
		private static readonly Camera.set_depthDelegate set_depthDelegateField;

		// Token: 0x040001C7 RID: 455
		private static readonly Camera.get_aspectDelegate get_aspectDelegateField;

		// Token: 0x040001C8 RID: 456
		private static readonly Camera.set_aspectDelegate set_aspectDelegateField;

		// Token: 0x040001C9 RID: 457
		private static readonly Camera.ResetAspectDelegate ResetAspectDelegateField;

		// Token: 0x040001CA RID: 458
		private static readonly Camera.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x040001CB RID: 459
		private static readonly Camera.set_eventMaskDelegate set_eventMaskDelegateField;

		// Token: 0x040001CC RID: 460
		private static readonly Camera.get_layerCullSphericalDelegate get_layerCullSphericalDelegateField;

		// Token: 0x040001CD RID: 461
		private static readonly Camera.set_layerCullSphericalDelegate set_layerCullSphericalDelegateField;

		// Token: 0x040001CE RID: 462
		private static readonly Camera.get_cameraTypeDelegate get_cameraTypeDelegateField;

		// Token: 0x040001CF RID: 463
		private static readonly Camera.set_cameraTypeDelegate set_cameraTypeDelegateField;

		// Token: 0x040001D0 RID: 464
		private static readonly Camera.get_overrideSceneCullingMaskDelegate get_overrideSceneCullingMaskDelegateField;

		// Token: 0x040001D1 RID: 465
		private static readonly Camera.set_overrideSceneCullingMaskDelegate set_overrideSceneCullingMaskDelegateField;

		// Token: 0x040001D2 RID: 466
		private static readonly Camera.get_sceneCullingMaskDelegate get_sceneCullingMaskDelegateField;

		// Token: 0x040001D3 RID: 467
		private static readonly Camera.GetLayerCullDistancesDelegate GetLayerCullDistancesDelegateField;

		// Token: 0x040001D4 RID: 468
		private static readonly Camera.SetLayerCullDistancesDelegate SetLayerCullDistancesDelegateField;

		// Token: 0x040001D5 RID: 469
		private static readonly Camera.get_useOcclusionCullingDelegate get_useOcclusionCullingDelegateField;

		// Token: 0x040001D6 RID: 470
		private static readonly Camera.set_useOcclusionCullingDelegate set_useOcclusionCullingDelegateField;

		// Token: 0x040001D7 RID: 471
		private static readonly Camera.ResetCullingMatrixDelegate ResetCullingMatrixDelegateField;

		// Token: 0x040001D8 RID: 472
		private static readonly Camera.set_clearFlagsDelegate set_clearFlagsDelegateField;

		// Token: 0x040001D9 RID: 473
		private static readonly Camera.get_depthTextureModeDelegate get_depthTextureModeDelegateField;

		// Token: 0x040001DA RID: 474
		private static readonly Camera.set_depthTextureModeDelegate set_depthTextureModeDelegateField;

		// Token: 0x040001DB RID: 475
		private static readonly Camera.get_clearStencilAfterLightingPassDelegate get_clearStencilAfterLightingPassDelegateField;

		// Token: 0x040001DC RID: 476
		private static readonly Camera.set_clearStencilAfterLightingPassDelegate set_clearStencilAfterLightingPassDelegateField;

		// Token: 0x040001DD RID: 477
		private static readonly Camera.SetReplacementShaderDelegate SetReplacementShaderDelegateField;

		// Token: 0x040001DE RID: 478
		private static readonly Camera.ResetReplacementShaderDelegate ResetReplacementShaderDelegateField;

		// Token: 0x040001DF RID: 479
		private static readonly Camera.get_projectionMatrixModeDelegate get_projectionMatrixModeDelegateField;

		// Token: 0x040001E0 RID: 480
		private static readonly Camera.get_usePhysicalPropertiesDelegate get_usePhysicalPropertiesDelegateField;

		// Token: 0x040001E1 RID: 481
		private static readonly Camera.set_usePhysicalPropertiesDelegate set_usePhysicalPropertiesDelegateField;

		// Token: 0x040001E2 RID: 482
		private static readonly Camera.get_focalLengthDelegate get_focalLengthDelegateField;

		// Token: 0x040001E3 RID: 483
		private static readonly Camera.set_focalLengthDelegate set_focalLengthDelegateField;

		// Token: 0x040001E4 RID: 484
		private static readonly Camera.get_gateFitDelegate get_gateFitDelegateField;

		// Token: 0x040001E5 RID: 485
		private static readonly Camera.set_gateFitDelegate set_gateFitDelegateField;

		// Token: 0x040001E6 RID: 486
		private static readonly Camera.GetGateFittedFieldOfViewDelegate GetGateFittedFieldOfViewDelegateField;

		// Token: 0x040001E7 RID: 487
		private static readonly Camera.get_pixelWidthDelegate get_pixelWidthDelegateField;

		// Token: 0x040001E8 RID: 488
		private static readonly Camera.get_pixelHeightDelegate get_pixelHeightDelegateField;

		// Token: 0x040001E9 RID: 489
		private static readonly Camera.get_scaledPixelWidthDelegate get_scaledPixelWidthDelegateField;

		// Token: 0x040001EA RID: 490
		private static readonly Camera.get_scaledPixelHeightDelegate get_scaledPixelHeightDelegateField;

		// Token: 0x040001EB RID: 491
		private static readonly Camera.get_activeTextureDelegate get_activeTextureDelegateField;

		// Token: 0x040001EC RID: 492
		private static readonly Camera.set_targetDisplayDelegate set_targetDisplayDelegateField;

		// Token: 0x040001ED RID: 493
		private static readonly Camera.GetCameraBufferWarningsDelegate GetCameraBufferWarningsDelegateField;

		// Token: 0x040001EE RID: 494
		private static readonly Camera.get_useJitteredProjectionMatrixForTransparentRenderingDelegate get_useJitteredProjectionMatrixForTransparentRenderingDelegateField;

		// Token: 0x040001EF RID: 495
		private static readonly Camera.set_useJitteredProjectionMatrixForTransparentRenderingDelegate set_useJitteredProjectionMatrixForTransparentRenderingDelegateField;

		// Token: 0x040001F0 RID: 496
		private static readonly Camera.ResetWorldToCameraMatrixDelegate ResetWorldToCameraMatrixDelegateField;

		// Token: 0x040001F1 RID: 497
		private static readonly Camera.ResetProjectionMatrixDelegate ResetProjectionMatrixDelegateField;

		// Token: 0x040001F2 RID: 498
		private static readonly Camera.FocalLengthToFieldOfViewDelegate FocalLengthToFieldOfViewDelegateField;

		// Token: 0x040001F3 RID: 499
		private static readonly Camera.FieldOfViewToFocalLengthDelegate FieldOfViewToFocalLengthDelegateField;

		// Token: 0x040001F4 RID: 500
		private static readonly Camera.HorizontalToVerticalFieldOfViewDelegate HorizontalToVerticalFieldOfViewDelegateField;

		// Token: 0x040001F5 RID: 501
		private static readonly Camera.VerticalToHorizontalFieldOfViewDelegate VerticalToHorizontalFieldOfViewDelegateField;

		// Token: 0x040001F6 RID: 502
		private static readonly Camera.get_stereoEnabledDelegate get_stereoEnabledDelegateField;

		// Token: 0x040001F7 RID: 503
		private static readonly Camera.get_stereoSeparationDelegate get_stereoSeparationDelegateField;

		// Token: 0x040001F8 RID: 504
		private static readonly Camera.set_stereoSeparationDelegate set_stereoSeparationDelegateField;

		// Token: 0x040001F9 RID: 505
		private static readonly Camera.get_stereoConvergenceDelegate get_stereoConvergenceDelegateField;

		// Token: 0x040001FA RID: 506
		private static readonly Camera.set_stereoConvergenceDelegate set_stereoConvergenceDelegateField;

		// Token: 0x040001FB RID: 507
		private static readonly Camera.get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate get_areVRStereoViewMatricesWithinSingleCullToleranceDelegateField;

		// Token: 0x040001FC RID: 508
		private static readonly Camera.get_stereoTargetEyeDelegate get_stereoTargetEyeDelegateField;

		// Token: 0x040001FD RID: 509
		private static readonly Camera.set_stereoTargetEyeDelegate set_stereoTargetEyeDelegateField;

		// Token: 0x040001FE RID: 510
		private static readonly Camera.get_stereoActiveEyeDelegate get_stereoActiveEyeDelegateField;

		// Token: 0x040001FF RID: 511
		private static readonly Camera.CopyStereoDeviceProjectionMatrixToNonJitteredDelegate CopyStereoDeviceProjectionMatrixToNonJitteredDelegateField;

		// Token: 0x04000200 RID: 512
		private static readonly Camera.ResetStereoProjectionMatricesDelegate ResetStereoProjectionMatricesDelegateField;

		// Token: 0x04000201 RID: 513
		private static readonly Camera.ResetStereoViewMatricesDelegate ResetStereoViewMatricesDelegateField;

		// Token: 0x04000202 RID: 514
		private static readonly Camera.RenderToCubemapImplDelegate RenderToCubemapImplDelegateField;

		// Token: 0x04000203 RID: 515
		private static readonly Camera.RenderToCubemapEyeImplDelegate RenderToCubemapEyeImplDelegateField;

		// Token: 0x04000204 RID: 516
		private static readonly Camera.RenderWithShaderDelegate RenderWithShaderDelegateField;

		// Token: 0x04000205 RID: 517
		private static readonly Camera.RenderDontRestoreDelegate RenderDontRestoreDelegateField;

		// Token: 0x04000206 RID: 518
		private static readonly Camera.SubmitRenderRequestsInternalDelegate SubmitRenderRequestsInternalDelegateField;

		// Token: 0x04000207 RID: 519
		private static readonly Camera.SetupCurrentDelegate SetupCurrentDelegateField;

		// Token: 0x04000208 RID: 520
		private static readonly Camera.CopyFromDelegate CopyFromDelegateField;

		// Token: 0x04000209 RID: 521
		private static readonly Camera.get_commandBufferCountDelegate get_commandBufferCountDelegateField;

		// Token: 0x0400020A RID: 522
		private static readonly Camera.RemoveCommandBuffersDelegate RemoveCommandBuffersDelegateField;

		// Token: 0x0400020B RID: 523
		private static readonly Camera.RemoveAllCommandBuffersDelegate RemoveAllCommandBuffersDelegateField;

		// Token: 0x0400020C RID: 524
		private static readonly Camera.AddCommandBufferImplDelegate AddCommandBufferImplDelegateField;

		// Token: 0x0400020D RID: 525
		private static readonly Camera.AddCommandBufferAsyncImplDelegate AddCommandBufferAsyncImplDelegateField;

		// Token: 0x0400020E RID: 526
		private static readonly Camera.RemoveCommandBufferImplDelegate RemoveCommandBufferImplDelegateField;

		// Token: 0x0400020F RID: 527
		private static readonly Camera.GetCommandBuffersDelegate GetCommandBuffersDelegateField;

		// Token: 0x04000210 RID: 528
		private static readonly Camera.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

		// Token: 0x04000211 RID: 529
		private static readonly Camera.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

		// Token: 0x04000212 RID: 530
		private static readonly Camera.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x04000213 RID: 531
		private static readonly Camera.get_cullingMatrix_InjectedDelegate get_cullingMatrix_InjectedDelegateField;

		// Token: 0x04000214 RID: 532
		private static readonly Camera.set_cullingMatrix_InjectedDelegate set_cullingMatrix_InjectedDelegateField;

		// Token: 0x04000215 RID: 533
		private static readonly Camera.get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;

		// Token: 0x04000216 RID: 534
		private static readonly Camera.set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;

		// Token: 0x04000217 RID: 535
		private static readonly Camera.get_sensorSize_InjectedDelegate get_sensorSize_InjectedDelegateField;

		// Token: 0x04000218 RID: 536
		private static readonly Camera.set_sensorSize_InjectedDelegate set_sensorSize_InjectedDelegateField;

		// Token: 0x04000219 RID: 537
		private static readonly Camera.get_lensShift_InjectedDelegate get_lensShift_InjectedDelegateField;

		// Token: 0x0400021A RID: 538
		private static readonly Camera.set_lensShift_InjectedDelegate set_lensShift_InjectedDelegateField;

		// Token: 0x0400021B RID: 539
		private static readonly Camera.GetGateFittedLensShift_InjectedDelegate GetGateFittedLensShift_InjectedDelegateField;

		// Token: 0x0400021C RID: 540
		private static readonly Camera.GetLocalSpaceAim_InjectedDelegate GetLocalSpaceAim_InjectedDelegateField;

		// Token: 0x0400021D RID: 541
		private static readonly Camera.get_rect_InjectedDelegate get_rect_InjectedDelegateField;

		// Token: 0x0400021E RID: 542
		private static readonly Camera.set_rect_InjectedDelegate set_rect_InjectedDelegateField;

		// Token: 0x0400021F RID: 543
		private static readonly Camera.set_pixelRect_InjectedDelegate set_pixelRect_InjectedDelegateField;

		// Token: 0x04000220 RID: 544
		private static readonly Camera.get_cameraToWorldMatrix_InjectedDelegate get_cameraToWorldMatrix_InjectedDelegateField;

		// Token: 0x04000221 RID: 545
		private static readonly Camera.set_worldToCameraMatrix_InjectedDelegate set_worldToCameraMatrix_InjectedDelegateField;

		// Token: 0x04000222 RID: 546
		private static readonly Camera.set_projectionMatrix_InjectedDelegate set_projectionMatrix_InjectedDelegateField;

		// Token: 0x04000223 RID: 547
		private static readonly Camera.get_nonJitteredProjectionMatrix_InjectedDelegate get_nonJitteredProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000224 RID: 548
		private static readonly Camera.set_nonJitteredProjectionMatrix_InjectedDelegate set_nonJitteredProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000225 RID: 549
		private static readonly Camera.get_previousViewProjectionMatrix_InjectedDelegate get_previousViewProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000226 RID: 550
		private static readonly Camera.CalculateObliqueMatrix_InjectedDelegate CalculateObliqueMatrix_InjectedDelegateField;

		// Token: 0x04000227 RID: 551
		private static readonly Camera.WorldToViewportPoint_InjectedDelegate WorldToViewportPoint_InjectedDelegateField;

		// Token: 0x04000228 RID: 552
		private static readonly Camera.ViewportToScreenPoint_InjectedDelegate ViewportToScreenPoint_InjectedDelegateField;

		// Token: 0x04000229 RID: 553
		private static readonly Camera.GetFrustumPlaneSizeAt_InjectedDelegate GetFrustumPlaneSizeAt_InjectedDelegateField;

		// Token: 0x0400022A RID: 554
		private static readonly Camera.ViewportPointToRay_InjectedDelegate ViewportPointToRay_InjectedDelegateField;

		// Token: 0x0400022B RID: 555
		private static readonly Camera.CalculateFrustumCornersInternal_InjectedDelegate CalculateFrustumCornersInternal_InjectedDelegateField;

		// Token: 0x0400022C RID: 556
		private static readonly Camera.CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField;

		// Token: 0x0400022D RID: 557
		private static readonly Camera.get_scene_InjectedDelegate get_scene_InjectedDelegateField;

		// Token: 0x0400022E RID: 558
		private static readonly Camera.set_scene_InjectedDelegate set_scene_InjectedDelegateField;

		// Token: 0x0400022F RID: 559
		private static readonly Camera.GetStereoNonJitteredProjectionMatrix_InjectedDelegate GetStereoNonJitteredProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000230 RID: 560
		private static readonly Camera.GetStereoViewMatrix_InjectedDelegate GetStereoViewMatrix_InjectedDelegateField;

		// Token: 0x04000231 RID: 561
		private static readonly Camera.GetStereoProjectionMatrix_InjectedDelegate GetStereoProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000232 RID: 562
		private static readonly Camera.SetStereoProjectionMatrix_InjectedDelegate SetStereoProjectionMatrix_InjectedDelegateField;

		// Token: 0x04000233 RID: 563
		private static readonly Camera.SetStereoViewMatrix_InjectedDelegate SetStereoViewMatrix_InjectedDelegateField;

		// Token: 0x02000352 RID: 850
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x04001C2B RID: 7211
			Left,
			// Token: 0x04001C2C RID: 7212
			Right,
			// Token: 0x04001C2D RID: 7213
			Mono
		}

		// Token: 0x02000353 RID: 851
		public enum RenderRequestMode
		{
			// Token: 0x04001C2F RID: 7215
			None,
			// Token: 0x04001C30 RID: 7216
			ObjectId,
			// Token: 0x04001C31 RID: 7217
			Depth,
			// Token: 0x04001C32 RID: 7218
			VertexNormal,
			// Token: 0x04001C33 RID: 7219
			WorldPosition,
			// Token: 0x04001C34 RID: 7220
			EntityId,
			// Token: 0x04001C35 RID: 7221
			BaseColor,
			// Token: 0x04001C36 RID: 7222
			SpecularColor,
			// Token: 0x04001C37 RID: 7223
			Metallic,
			// Token: 0x04001C38 RID: 7224
			Emission,
			// Token: 0x04001C39 RID: 7225
			Normal,
			// Token: 0x04001C3A RID: 7226
			Smoothness,
			// Token: 0x04001C3B RID: 7227
			Occlusion,
			// Token: 0x04001C3C RID: 7228
			DiffuseColor
		}

		// Token: 0x02000354 RID: 852
		public enum RenderRequestOutputSpace
		{
			// Token: 0x04001C3E RID: 7230
			ScreenSpace = -1,
			// Token: 0x04001C3F RID: 7231
			UV0,
			// Token: 0x04001C40 RID: 7232
			UV1,
			// Token: 0x04001C41 RID: 7233
			UV2,
			// Token: 0x04001C42 RID: 7234
			UV3,
			// Token: 0x04001C43 RID: 7235
			UV4,
			// Token: 0x04001C44 RID: 7236
			UV5,
			// Token: 0x04001C45 RID: 7237
			UV6,
			// Token: 0x04001C46 RID: 7238
			UV7,
			// Token: 0x04001C47 RID: 7239
			UV8
		}

		// Token: 0x02000355 RID: 853
		public sealed class RenderRequest : ValueType
		{
			// Token: 0x06002469 RID: 9321 RVA: 0x0006B5E4 File Offset: 0x000697E4
			// Note: this type is marked as 'beforefieldinit'.
			static RenderRequest()
			{
				Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "RenderRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr);
				Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_CameraRenderMode");
				Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_ResultRT");
				Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_OutputSpace");
			}

			// Token: 0x0600246A RID: 9322 RVA: 0x0001511F File Offset: 0x0001331F
			public RenderRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600246B RID: 9323 RVA: 0x00015128 File Offset: 0x00013328
			public RenderRequest()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr))
			{
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x0600246C RID: 9324 RVA: 0x0006B64C File Offset: 0x0006984C
			// (set) Token: 0x0600246D RID: 9325 RVA: 0x0001513A File Offset: 0x0001333A
			public unsafe Camera.RenderRequestMode m_CameraRenderMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode)) = value;
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x0600246E RID: 9326 RVA: 0x0006B674 File Offset: 0x00069874
			// (set) Token: 0x0600246F RID: 9327 RVA: 0x00015155 File Offset: 0x00013355
			public unsafe RenderTexture m_ResultRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06002470 RID: 9328 RVA: 0x0006B6A4 File Offset: 0x000698A4
			// (set) Token: 0x06002471 RID: 9329 RVA: 0x00015174 File Offset: 0x00013374
			public unsafe Camera.RenderRequestOutputSpace m_OutputSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace)) = value;
				}
			}

			// Token: 0x04001C48 RID: 7240
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraRenderMode;

			// Token: 0x04001C49 RID: 7241
			private static readonly IntPtr NativeFieldInfoPtr_m_ResultRT;

			// Token: 0x04001C4A RID: 7242
			private static readonly IntPtr NativeFieldInfoPtr_m_OutputSpace;
		}

		// Token: 0x02000356 RID: 854
		public sealed class CameraCallback : MulticastDelegate
		{
			// Token: 0x06002472 RID: 9330 RVA: 0x0001518F File Offset: 0x0001338F
			// Note: this type is marked as 'beforefieldinit'.
			static CameraCallback()
			{
				Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "CameraCallback");
				Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663443);
				Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100663444);
			}

			// Token: 0x06002473 RID: 9331 RVA: 0x0006B6CC File Offset: 0x000698CC
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002474 RID: 9332 RVA: 0x0006B728 File Offset: 0x00069928
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59624, XrefRangeEnd = 59640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002475 RID: 9333 RVA: 0x000151CD File Offset: 0x000133CD
			public CameraCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002476 RID: 9334 RVA: 0x000151D6 File Offset: 0x000133D6
			public static implicit operator Camera.CameraCallback(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<Camera.CameraCallback>(A_0);
			}

			// Token: 0x06002477 RID: 9335 RVA: 0x000151DE File Offset: 0x000133DE
			public static Camera.CameraCallback operator +(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Camera.CameraCallback>();
			}

			// Token: 0x06002478 RID: 9336 RVA: 0x000151EC File Offset: 0x000133EC
			public static Camera.CameraCallback operator -(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Camera.CameraCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001C4B RID: 7243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C4C RID: 7244
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;
		}

		// Token: 0x02000357 RID: 855
		public enum ProjectionMatrixMode
		{
			// Token: 0x04001C4E RID: 7246
			Explicit,
			// Token: 0x04001C4F RID: 7247
			Implicit,
			// Token: 0x04001C50 RID: 7248
			PhysicalPropertiesBased
		}

		// Token: 0x02000358 RID: 856
		public enum GateFitMode
		{
			// Token: 0x04001C52 RID: 7250
			Vertical = 1,
			// Token: 0x04001C53 RID: 7251
			Horizontal,
			// Token: 0x04001C54 RID: 7252
			Fill,
			// Token: 0x04001C55 RID: 7253
			Overscan,
			// Token: 0x04001C56 RID: 7254
			None = 0
		}

		// Token: 0x02000359 RID: 857
		public enum FieldOfViewAxis
		{
			// Token: 0x04001C58 RID: 7256
			Vertical,
			// Token: 0x04001C59 RID: 7257
			Horizontal
		}

		// Token: 0x0200035A RID: 858
		public enum StereoscopicEye
		{
			// Token: 0x04001C5B RID: 7259
			Left,
			// Token: 0x04001C5C RID: 7260
			Right
		}

		// Token: 0x0200035B RID: 859
		// (Invoke) Token: 0x0600247A RID: 9338
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x0200035C RID: 860
		// (Invoke) Token: 0x0600247C RID: 9340
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x0200035D RID: 861
		// (Invoke) Token: 0x0600247E RID: 9342
		private delegate float get_fieldOfViewDelegate(IntPtr @this);

		// Token: 0x0200035E RID: 862
		// (Invoke) Token: 0x06002480 RID: 9344
		private delegate void set_fieldOfViewDelegate(IntPtr @this, float value);

		// Token: 0x0200035F RID: 863
		// (Invoke) Token: 0x06002482 RID: 9346
		private delegate RenderingPath get_renderingPathDelegate(IntPtr @this);

		// Token: 0x02000360 RID: 864
		// (Invoke) Token: 0x06002484 RID: 9348
		private delegate void set_renderingPathDelegate(IntPtr @this, RenderingPath value);

		// Token: 0x02000361 RID: 865
		// (Invoke) Token: 0x06002486 RID: 9350
		private delegate RenderingPath get_actualRenderingPathDelegate(IntPtr @this);

		// Token: 0x02000362 RID: 866
		// (Invoke) Token: 0x06002488 RID: 9352
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x02000363 RID: 867
		// (Invoke) Token: 0x0600248A RID: 9354
		private delegate bool get_allowHDRDelegate(IntPtr @this);

		// Token: 0x02000364 RID: 868
		// (Invoke) Token: 0x0600248C RID: 9356
		private delegate void set_allowHDRDelegate(IntPtr @this, bool value);

		// Token: 0x02000365 RID: 869
		// (Invoke) Token: 0x0600248E RID: 9358
		private delegate bool get_allowMSAADelegate(IntPtr @this);

		// Token: 0x02000366 RID: 870
		// (Invoke) Token: 0x06002490 RID: 9360
		private delegate void set_allowMSAADelegate(IntPtr @this, bool value);

		// Token: 0x02000367 RID: 871
		// (Invoke) Token: 0x06002492 RID: 9362
		private delegate bool get_allowDynamicResolutionDelegate(IntPtr @this);

		// Token: 0x02000368 RID: 872
		// (Invoke) Token: 0x06002494 RID: 9364
		private delegate void set_allowDynamicResolutionDelegate(IntPtr @this, bool value);

		// Token: 0x02000369 RID: 873
		// (Invoke) Token: 0x06002496 RID: 9366
		private delegate bool get_forceIntoRenderTextureDelegate(IntPtr @this);

		// Token: 0x0200036A RID: 874
		// (Invoke) Token: 0x06002498 RID: 9368
		private delegate void set_forceIntoRenderTextureDelegate(IntPtr @this, bool value);

		// Token: 0x0200036B RID: 875
		// (Invoke) Token: 0x0600249A RID: 9370
		private delegate float get_orthographicSizeDelegate(IntPtr @this);

		// Token: 0x0200036C RID: 876
		// (Invoke) Token: 0x0600249C RID: 9372
		private delegate bool get_orthographicDelegate(IntPtr @this);

		// Token: 0x0200036D RID: 877
		// (Invoke) Token: 0x0600249E RID: 9374
		private delegate void set_orthographicDelegate(IntPtr @this, bool value);

		// Token: 0x0200036E RID: 878
		// (Invoke) Token: 0x060024A0 RID: 9376
		private delegate UnityEngine.Rendering.OpaqueSortMode get_opaqueSortModeDelegate(IntPtr @this);

		// Token: 0x0200036F RID: 879
		// (Invoke) Token: 0x060024A2 RID: 9378
		private delegate void set_opaqueSortModeDelegate(IntPtr @this, UnityEngine.Rendering.OpaqueSortMode value);

		// Token: 0x02000370 RID: 880
		// (Invoke) Token: 0x060024A4 RID: 9380
		private delegate TransparencySortMode get_transparencySortModeDelegate(IntPtr @this);

		// Token: 0x02000371 RID: 881
		// (Invoke) Token: 0x060024A6 RID: 9382
		private delegate void set_transparencySortModeDelegate(IntPtr @this, TransparencySortMode value);

		// Token: 0x02000372 RID: 882
		// (Invoke) Token: 0x060024A8 RID: 9384
		private delegate void ResetTransparencySortSettingsDelegate(IntPtr @this);

		// Token: 0x02000373 RID: 883
		// (Invoke) Token: 0x060024AA RID: 9386
		private delegate void set_depthDelegate(IntPtr @this, float value);

		// Token: 0x02000374 RID: 884
		// (Invoke) Token: 0x060024AC RID: 9388
		private delegate float get_aspectDelegate(IntPtr @this);

		// Token: 0x02000375 RID: 885
		// (Invoke) Token: 0x060024AE RID: 9390
		private delegate void set_aspectDelegate(IntPtr @this, float value);

		// Token: 0x02000376 RID: 886
		// (Invoke) Token: 0x060024B0 RID: 9392
		private delegate void ResetAspectDelegate(IntPtr @this);

		// Token: 0x02000377 RID: 887
		// (Invoke) Token: 0x060024B2 RID: 9394
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000378 RID: 888
		// (Invoke) Token: 0x060024B4 RID: 9396
		private delegate void set_eventMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000379 RID: 889
		// (Invoke) Token: 0x060024B6 RID: 9398
		private delegate bool get_layerCullSphericalDelegate(IntPtr @this);

		// Token: 0x0200037A RID: 890
		// (Invoke) Token: 0x060024B8 RID: 9400
		private delegate void set_layerCullSphericalDelegate(IntPtr @this, bool value);

		// Token: 0x0200037B RID: 891
		// (Invoke) Token: 0x060024BA RID: 9402
		private delegate CameraType get_cameraTypeDelegate(IntPtr @this);

		// Token: 0x0200037C RID: 892
		// (Invoke) Token: 0x060024BC RID: 9404
		private delegate void set_cameraTypeDelegate(IntPtr @this, CameraType value);

		// Token: 0x0200037D RID: 893
		// (Invoke) Token: 0x060024BE RID: 9406
		private delegate ulong get_overrideSceneCullingMaskDelegate(IntPtr @this);

		// Token: 0x0200037E RID: 894
		// (Invoke) Token: 0x060024C0 RID: 9408
		private delegate void set_overrideSceneCullingMaskDelegate(IntPtr @this, ulong value);

		// Token: 0x0200037F RID: 895
		// (Invoke) Token: 0x060024C2 RID: 9410
		private delegate ulong get_sceneCullingMaskDelegate(IntPtr @this);

		// Token: 0x02000380 RID: 896
		// (Invoke) Token: 0x060024C4 RID: 9412
		private delegate IntPtr GetLayerCullDistancesDelegate(IntPtr @this);

		// Token: 0x02000381 RID: 897
		// (Invoke) Token: 0x060024C6 RID: 9414
		private delegate void SetLayerCullDistancesDelegate(IntPtr @this, IntPtr d);

		// Token: 0x02000382 RID: 898
		// (Invoke) Token: 0x060024C8 RID: 9416
		private delegate bool get_useOcclusionCullingDelegate(IntPtr @this);

		// Token: 0x02000383 RID: 899
		// (Invoke) Token: 0x060024CA RID: 9418
		private delegate void set_useOcclusionCullingDelegate(IntPtr @this, bool value);

		// Token: 0x02000384 RID: 900
		// (Invoke) Token: 0x060024CC RID: 9420
		private delegate void ResetCullingMatrixDelegate(IntPtr @this);

		// Token: 0x02000385 RID: 901
		// (Invoke) Token: 0x060024CE RID: 9422
		private delegate void set_clearFlagsDelegate(IntPtr @this, CameraClearFlags value);

		// Token: 0x02000386 RID: 902
		// (Invoke) Token: 0x060024D0 RID: 9424
		private delegate DepthTextureMode get_depthTextureModeDelegate(IntPtr @this);

		// Token: 0x02000387 RID: 903
		// (Invoke) Token: 0x060024D2 RID: 9426
		private delegate void set_depthTextureModeDelegate(IntPtr @this, DepthTextureMode value);

		// Token: 0x02000388 RID: 904
		// (Invoke) Token: 0x060024D4 RID: 9428
		private delegate bool get_clearStencilAfterLightingPassDelegate(IntPtr @this);

		// Token: 0x02000389 RID: 905
		// (Invoke) Token: 0x060024D6 RID: 9430
		private delegate void set_clearStencilAfterLightingPassDelegate(IntPtr @this, bool value);

		// Token: 0x0200038A RID: 906
		// (Invoke) Token: 0x060024D8 RID: 9432
		private delegate void SetReplacementShaderDelegate(IntPtr @this, IntPtr shader, IntPtr replacementTag);

		// Token: 0x0200038B RID: 907
		// (Invoke) Token: 0x060024DA RID: 9434
		private delegate void ResetReplacementShaderDelegate(IntPtr @this);

		// Token: 0x0200038C RID: 908
		// (Invoke) Token: 0x060024DC RID: 9436
		private delegate Camera.ProjectionMatrixMode get_projectionMatrixModeDelegate(IntPtr @this);

		// Token: 0x0200038D RID: 909
		// (Invoke) Token: 0x060024DE RID: 9438
		private delegate bool get_usePhysicalPropertiesDelegate(IntPtr @this);

		// Token: 0x0200038E RID: 910
		// (Invoke) Token: 0x060024E0 RID: 9440
		private delegate void set_usePhysicalPropertiesDelegate(IntPtr @this, bool value);

		// Token: 0x0200038F RID: 911
		// (Invoke) Token: 0x060024E2 RID: 9442
		private delegate float get_focalLengthDelegate(IntPtr @this);

		// Token: 0x02000390 RID: 912
		// (Invoke) Token: 0x060024E4 RID: 9444
		private delegate void set_focalLengthDelegate(IntPtr @this, float value);

		// Token: 0x02000391 RID: 913
		// (Invoke) Token: 0x060024E6 RID: 9446
		private delegate Camera.GateFitMode get_gateFitDelegate(IntPtr @this);

		// Token: 0x02000392 RID: 914
		// (Invoke) Token: 0x060024E8 RID: 9448
		private delegate void set_gateFitDelegate(IntPtr @this, Camera.GateFitMode value);

		// Token: 0x02000393 RID: 915
		// (Invoke) Token: 0x060024EA RID: 9450
		private delegate float GetGateFittedFieldOfViewDelegate(IntPtr @this);

		// Token: 0x02000394 RID: 916
		// (Invoke) Token: 0x060024EC RID: 9452
		private delegate int get_pixelWidthDelegate(IntPtr @this);

		// Token: 0x02000395 RID: 917
		// (Invoke) Token: 0x060024EE RID: 9454
		private delegate int get_pixelHeightDelegate(IntPtr @this);

		// Token: 0x02000396 RID: 918
		// (Invoke) Token: 0x060024F0 RID: 9456
		private delegate int get_scaledPixelWidthDelegate(IntPtr @this);

		// Token: 0x02000397 RID: 919
		// (Invoke) Token: 0x060024F2 RID: 9458
		private delegate int get_scaledPixelHeightDelegate(IntPtr @this);

		// Token: 0x02000398 RID: 920
		// (Invoke) Token: 0x060024F4 RID: 9460
		private delegate IntPtr get_activeTextureDelegate(IntPtr @this);

		// Token: 0x02000399 RID: 921
		// (Invoke) Token: 0x060024F6 RID: 9462
		private delegate void set_targetDisplayDelegate(IntPtr @this, int value);

		// Token: 0x0200039A RID: 922
		// (Invoke) Token: 0x060024F8 RID: 9464
		private delegate IntPtr GetCameraBufferWarningsDelegate(IntPtr @this);

		// Token: 0x0200039B RID: 923
		// (Invoke) Token: 0x060024FA RID: 9466
		private delegate bool get_useJitteredProjectionMatrixForTransparentRenderingDelegate(IntPtr @this);

		// Token: 0x0200039C RID: 924
		// (Invoke) Token: 0x060024FC RID: 9468
		private delegate void set_useJitteredProjectionMatrixForTransparentRenderingDelegate(IntPtr @this, bool value);

		// Token: 0x0200039D RID: 925
		// (Invoke) Token: 0x060024FE RID: 9470
		private delegate void ResetWorldToCameraMatrixDelegate(IntPtr @this);

		// Token: 0x0200039E RID: 926
		// (Invoke) Token: 0x06002500 RID: 9472
		private delegate void ResetProjectionMatrixDelegate(IntPtr @this);

		// Token: 0x0200039F RID: 927
		// (Invoke) Token: 0x06002502 RID: 9474
		private delegate float FocalLengthToFieldOfViewDelegate(float focalLength, float sensorSize);

		// Token: 0x020003A0 RID: 928
		// (Invoke) Token: 0x06002504 RID: 9476
		private delegate float FieldOfViewToFocalLengthDelegate(float fieldOfView, float sensorSize);

		// Token: 0x020003A1 RID: 929
		// (Invoke) Token: 0x06002506 RID: 9478
		private delegate float HorizontalToVerticalFieldOfViewDelegate(float horizontalFieldOfView, float aspectRatio);

		// Token: 0x020003A2 RID: 930
		// (Invoke) Token: 0x06002508 RID: 9480
		private delegate float VerticalToHorizontalFieldOfViewDelegate(float verticalFieldOfView, float aspectRatio);

		// Token: 0x020003A3 RID: 931
		// (Invoke) Token: 0x0600250A RID: 9482
		private delegate bool get_stereoEnabledDelegate(IntPtr @this);

		// Token: 0x020003A4 RID: 932
		// (Invoke) Token: 0x0600250C RID: 9484
		private delegate float get_stereoSeparationDelegate(IntPtr @this);

		// Token: 0x020003A5 RID: 933
		// (Invoke) Token: 0x0600250E RID: 9486
		private delegate void set_stereoSeparationDelegate(IntPtr @this, float value);

		// Token: 0x020003A6 RID: 934
		// (Invoke) Token: 0x06002510 RID: 9488
		private delegate float get_stereoConvergenceDelegate(IntPtr @this);

		// Token: 0x020003A7 RID: 935
		// (Invoke) Token: 0x06002512 RID: 9490
		private delegate void set_stereoConvergenceDelegate(IntPtr @this, float value);

		// Token: 0x020003A8 RID: 936
		// (Invoke) Token: 0x06002514 RID: 9492
		private delegate bool get_areVRStereoViewMatricesWithinSingleCullToleranceDelegate(IntPtr @this);

		// Token: 0x020003A9 RID: 937
		// (Invoke) Token: 0x06002516 RID: 9494
		private delegate StereoTargetEyeMask get_stereoTargetEyeDelegate(IntPtr @this);

		// Token: 0x020003AA RID: 938
		// (Invoke) Token: 0x06002518 RID: 9496
		private delegate void set_stereoTargetEyeDelegate(IntPtr @this, StereoTargetEyeMask value);

		// Token: 0x020003AB RID: 939
		// (Invoke) Token: 0x0600251A RID: 9498
		private delegate Camera.MonoOrStereoscopicEye get_stereoActiveEyeDelegate(IntPtr @this);

		// Token: 0x020003AC RID: 940
		// (Invoke) Token: 0x0600251C RID: 9500
		private delegate void CopyStereoDeviceProjectionMatrixToNonJitteredDelegate(IntPtr @this, Camera.StereoscopicEye eye);

		// Token: 0x020003AD RID: 941
		// (Invoke) Token: 0x0600251E RID: 9502
		private delegate void ResetStereoProjectionMatricesDelegate(IntPtr @this);

		// Token: 0x020003AE RID: 942
		// (Invoke) Token: 0x06002520 RID: 9504
		private delegate void ResetStereoViewMatricesDelegate(IntPtr @this);

		// Token: 0x020003AF RID: 943
		// (Invoke) Token: 0x06002522 RID: 9506
		private delegate bool RenderToCubemapImplDelegate(IntPtr @this, IntPtr tex, int faceMask);

		// Token: 0x020003B0 RID: 944
		// (Invoke) Token: 0x06002524 RID: 9508
		private delegate bool RenderToCubemapEyeImplDelegate(IntPtr @this, IntPtr cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye);

		// Token: 0x020003B1 RID: 945
		// (Invoke) Token: 0x06002526 RID: 9510
		private delegate void RenderWithShaderDelegate(IntPtr @this, IntPtr shader, IntPtr replacementTag);

		// Token: 0x020003B2 RID: 946
		// (Invoke) Token: 0x06002528 RID: 9512
		private delegate void RenderDontRestoreDelegate(IntPtr @this);

		// Token: 0x020003B3 RID: 947
		// (Invoke) Token: 0x0600252A RID: 9514
		private delegate void SubmitRenderRequestsInternalDelegate(IntPtr @this, IntPtr requests);

		// Token: 0x020003B4 RID: 948
		// (Invoke) Token: 0x0600252C RID: 9516
		private delegate void SetupCurrentDelegate(IntPtr cur);

		// Token: 0x020003B5 RID: 949
		// (Invoke) Token: 0x0600252E RID: 9518
		private delegate void CopyFromDelegate(IntPtr @this, IntPtr other);

		// Token: 0x020003B6 RID: 950
		// (Invoke) Token: 0x06002530 RID: 9520
		private delegate int get_commandBufferCountDelegate(IntPtr @this);

		// Token: 0x020003B7 RID: 951
		// (Invoke) Token: 0x06002532 RID: 9522
		private delegate void RemoveCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt);

		// Token: 0x020003B8 RID: 952
		// (Invoke) Token: 0x06002534 RID: 9524
		private delegate void RemoveAllCommandBuffersDelegate(IntPtr @this);

		// Token: 0x020003B9 RID: 953
		// (Invoke) Token: 0x06002536 RID: 9526
		private delegate void AddCommandBufferImplDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt, IntPtr buffer);

		// Token: 0x020003BA RID: 954
		// (Invoke) Token: 0x06002538 RID: 9528
		private delegate void AddCommandBufferAsyncImplDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt, IntPtr buffer, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x020003BB RID: 955
		// (Invoke) Token: 0x0600253A RID: 9530
		private delegate void RemoveCommandBufferImplDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt, IntPtr buffer);

		// Token: 0x020003BC RID: 956
		// (Invoke) Token: 0x0600253C RID: 9532
		private delegate IntPtr GetCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.CameraEvent evt);

		// Token: 0x020003BD RID: 957
		// (Invoke) Token: 0x0600253E RID: 9534
		private delegate void get_transparencySortAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003BE RID: 958
		// (Invoke) Token: 0x06002540 RID: 9536
		private delegate void set_transparencySortAxis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003BF RID: 959
		// (Invoke) Token: 0x06002542 RID: 9538
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C0 RID: 960
		// (Invoke) Token: 0x06002544 RID: 9540
		private delegate void get_cullingMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C1 RID: 961
		// (Invoke) Token: 0x06002546 RID: 9542
		private delegate void set_cullingMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003C2 RID: 962
		// (Invoke) Token: 0x06002548 RID: 9544
		private delegate void get_backgroundColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C3 RID: 963
		// (Invoke) Token: 0x0600254A RID: 9546
		private delegate void set_backgroundColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003C4 RID: 964
		// (Invoke) Token: 0x0600254C RID: 9548
		private delegate void get_sensorSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C5 RID: 965
		// (Invoke) Token: 0x0600254E RID: 9550
		private delegate void set_sensorSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003C6 RID: 966
		// (Invoke) Token: 0x06002550 RID: 9552
		private delegate void get_lensShift_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C7 RID: 967
		// (Invoke) Token: 0x06002552 RID: 9554
		private delegate void set_lensShift_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003C8 RID: 968
		// (Invoke) Token: 0x06002554 RID: 9556
		private delegate void GetGateFittedLensShift_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003C9 RID: 969
		// (Invoke) Token: 0x06002556 RID: 9558
		private delegate void GetLocalSpaceAim_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003CA RID: 970
		// (Invoke) Token: 0x06002558 RID: 9560
		private delegate void get_rect_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003CB RID: 971
		// (Invoke) Token: 0x0600255A RID: 9562
		private delegate void set_rect_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003CC RID: 972
		// (Invoke) Token: 0x0600255C RID: 9564
		private delegate void set_pixelRect_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003CD RID: 973
		// (Invoke) Token: 0x0600255E RID: 9566
		private delegate void get_cameraToWorldMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003CE RID: 974
		// (Invoke) Token: 0x06002560 RID: 9568
		private delegate void set_worldToCameraMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003CF RID: 975
		// (Invoke) Token: 0x06002562 RID: 9570
		private delegate void set_projectionMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003D0 RID: 976
		// (Invoke) Token: 0x06002564 RID: 9572
		private delegate void get_nonJitteredProjectionMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003D1 RID: 977
		// (Invoke) Token: 0x06002566 RID: 9574
		private delegate void set_nonJitteredProjectionMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003D2 RID: 978
		// (Invoke) Token: 0x06002568 RID: 9576
		private delegate void get_previousViewProjectionMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003D3 RID: 979
		// (Invoke) Token: 0x0600256A RID: 9578
		private delegate void CalculateObliqueMatrix_InjectedDelegate(IntPtr @this, IntPtr clipPlane, [Out] IntPtr ret);

		// Token: 0x020003D4 RID: 980
		// (Invoke) Token: 0x0600256C RID: 9580
		private delegate void WorldToViewportPoint_InjectedDelegate(IntPtr @this, IntPtr position, Camera.MonoOrStereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003D5 RID: 981
		// (Invoke) Token: 0x0600256E RID: 9582
		private delegate void ViewportToScreenPoint_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x020003D6 RID: 982
		// (Invoke) Token: 0x06002570 RID: 9584
		private delegate void GetFrustumPlaneSizeAt_InjectedDelegate(IntPtr @this, float distance, [Out] IntPtr ret);

		// Token: 0x020003D7 RID: 983
		// (Invoke) Token: 0x06002572 RID: 9586
		private delegate void ViewportPointToRay_InjectedDelegate(IntPtr @this, IntPtr pos, Camera.MonoOrStereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003D8 RID: 984
		// (Invoke) Token: 0x06002574 RID: 9588
		private delegate void CalculateFrustumCornersInternal_InjectedDelegate(IntPtr @this, IntPtr viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] IntPtr outCorners);

		// Token: 0x020003D9 RID: 985
		// (Invoke) Token: 0x06002576 RID: 9590
		private delegate void CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate([Out] IntPtr output, float focalLength, IntPtr sensorSize, IntPtr lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode);

		// Token: 0x020003DA RID: 986
		// (Invoke) Token: 0x06002578 RID: 9592
		private delegate void get_scene_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020003DB RID: 987
		// (Invoke) Token: 0x0600257A RID: 9594
		private delegate void set_scene_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003DC RID: 988
		// (Invoke) Token: 0x0600257C RID: 9596
		private delegate void GetStereoNonJitteredProjectionMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003DD RID: 989
		// (Invoke) Token: 0x0600257E RID: 9598
		private delegate void GetStereoViewMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003DE RID: 990
		// (Invoke) Token: 0x06002580 RID: 9600
		private delegate void GetStereoProjectionMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, [Out] IntPtr ret);

		// Token: 0x020003DF RID: 991
		// (Invoke) Token: 0x06002582 RID: 9602
		private delegate void SetStereoProjectionMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, IntPtr matrix);

		// Token: 0x020003E0 RID: 992
		// (Invoke) Token: 0x06002584 RID: 9604
		private delegate void SetStereoViewMatrix_InjectedDelegate(IntPtr @this, Camera.StereoscopicEye eye, IntPtr matrix);
	}
}
