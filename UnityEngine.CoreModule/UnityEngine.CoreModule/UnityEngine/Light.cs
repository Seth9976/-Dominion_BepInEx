using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000058 RID: 88
	public sealed class Light : Behaviour
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x0002933C File Offset: 0x0002753C
		// Note: this type is marked as 'beforefieldinit'.
		static Light()
		{
			Il2CppClassPointerStore<Light>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Light");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light>.NativeClassPtr);
			Light.NativeFieldInfoPtr_m_BakedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light>.NativeClassPtr, "m_BakedIndex");
			Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663696);
			Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663697);
			Light.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663698);
			Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663699);
			Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663700);
			Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663701);
			Light.NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663702);
			Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663703);
			Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663704);
			Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663705);
			Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663706);
			Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663707);
			Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663708);
			Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100663709);
			Light.set_typeDelegateField = IL2CPP.ResolveICall<Light.set_typeDelegate>("UnityEngine.Light::set_type");
			Light.get_shapeDelegateField = IL2CPP.ResolveICall<Light.get_shapeDelegate>("UnityEngine.Light::get_shape");
			Light.set_shapeDelegateField = IL2CPP.ResolveICall<Light.set_shapeDelegate>("UnityEngine.Light::set_shape");
			Light.set_spotAngleDelegateField = IL2CPP.ResolveICall<Light.set_spotAngleDelegate>("UnityEngine.Light::set_spotAngle");
			Light.get_innerSpotAngleDelegateField = IL2CPP.ResolveICall<Light.get_innerSpotAngleDelegate>("UnityEngine.Light::get_innerSpotAngle");
			Light.set_innerSpotAngleDelegateField = IL2CPP.ResolveICall<Light.set_innerSpotAngleDelegate>("UnityEngine.Light::set_innerSpotAngle");
			Light.get_colorTemperatureDelegateField = IL2CPP.ResolveICall<Light.get_colorTemperatureDelegate>("UnityEngine.Light::get_colorTemperature");
			Light.set_colorTemperatureDelegateField = IL2CPP.ResolveICall<Light.set_colorTemperatureDelegate>("UnityEngine.Light::set_colorTemperature");
			Light.get_useColorTemperatureDelegateField = IL2CPP.ResolveICall<Light.get_useColorTemperatureDelegate>("UnityEngine.Light::get_useColorTemperature");
			Light.set_useColorTemperatureDelegateField = IL2CPP.ResolveICall<Light.set_useColorTemperatureDelegate>("UnityEngine.Light::set_useColorTemperature");
			Light.set_intensityDelegateField = IL2CPP.ResolveICall<Light.set_intensityDelegate>("UnityEngine.Light::set_intensity");
			Light.set_bounceIntensityDelegateField = IL2CPP.ResolveICall<Light.set_bounceIntensityDelegate>("UnityEngine.Light::set_bounceIntensity");
			Light.get_useBoundingSphereOverrideDelegateField = IL2CPP.ResolveICall<Light.get_useBoundingSphereOverrideDelegate>("UnityEngine.Light::get_useBoundingSphereOverride");
			Light.set_useBoundingSphereOverrideDelegateField = IL2CPP.ResolveICall<Light.set_useBoundingSphereOverrideDelegate>("UnityEngine.Light::set_useBoundingSphereOverride");
			Light.get_useViewFrustumForShadowCasterCullDelegateField = IL2CPP.ResolveICall<Light.get_useViewFrustumForShadowCasterCullDelegate>("UnityEngine.Light::get_useViewFrustumForShadowCasterCull");
			Light.set_useViewFrustumForShadowCasterCullDelegateField = IL2CPP.ResolveICall<Light.set_useViewFrustumForShadowCasterCullDelegate>("UnityEngine.Light::set_useViewFrustumForShadowCasterCull");
			Light.get_shadowCustomResolutionDelegateField = IL2CPP.ResolveICall<Light.get_shadowCustomResolutionDelegate>("UnityEngine.Light::get_shadowCustomResolution");
			Light.set_shadowCustomResolutionDelegateField = IL2CPP.ResolveICall<Light.set_shadowCustomResolutionDelegate>("UnityEngine.Light::set_shadowCustomResolution");
			Light.get_shadowBiasDelegateField = IL2CPP.ResolveICall<Light.get_shadowBiasDelegate>("UnityEngine.Light::get_shadowBias");
			Light.set_shadowBiasDelegateField = IL2CPP.ResolveICall<Light.set_shadowBiasDelegate>("UnityEngine.Light::set_shadowBias");
			Light.get_shadowNormalBiasDelegateField = IL2CPP.ResolveICall<Light.get_shadowNormalBiasDelegate>("UnityEngine.Light::get_shadowNormalBias");
			Light.set_shadowNormalBiasDelegateField = IL2CPP.ResolveICall<Light.set_shadowNormalBiasDelegate>("UnityEngine.Light::set_shadowNormalBias");
			Light.get_shadowNearPlaneDelegateField = IL2CPP.ResolveICall<Light.get_shadowNearPlaneDelegate>("UnityEngine.Light::get_shadowNearPlane");
			Light.set_shadowNearPlaneDelegateField = IL2CPP.ResolveICall<Light.set_shadowNearPlaneDelegate>("UnityEngine.Light::set_shadowNearPlane");
			Light.get_useShadowMatrixOverrideDelegateField = IL2CPP.ResolveICall<Light.get_useShadowMatrixOverrideDelegate>("UnityEngine.Light::get_useShadowMatrixOverride");
			Light.set_useShadowMatrixOverrideDelegateField = IL2CPP.ResolveICall<Light.set_useShadowMatrixOverrideDelegate>("UnityEngine.Light::set_useShadowMatrixOverride");
			Light.set_rangeDelegateField = IL2CPP.ResolveICall<Light.set_rangeDelegate>("UnityEngine.Light::set_range");
			Light.get_flareDelegateField = IL2CPP.ResolveICall<Light.get_flareDelegate>("UnityEngine.Light::get_flare");
			Light.set_flareDelegateField = IL2CPP.ResolveICall<Light.set_flareDelegate>("UnityEngine.Light::set_flare");
			Light.get_cullingMaskDelegateField = IL2CPP.ResolveICall<Light.get_cullingMaskDelegate>("UnityEngine.Light::get_cullingMask");
			Light.set_cullingMaskDelegateField = IL2CPP.ResolveICall<Light.set_cullingMaskDelegate>("UnityEngine.Light::set_cullingMask");
			Light.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Light.get_renderingLayerMaskDelegate>("UnityEngine.Light::get_renderingLayerMask");
			Light.set_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Light.set_renderingLayerMaskDelegate>("UnityEngine.Light::set_renderingLayerMask");
			Light.get_lightShadowCasterModeDelegateField = IL2CPP.ResolveICall<Light.get_lightShadowCasterModeDelegate>("UnityEngine.Light::get_lightShadowCasterMode");
			Light.set_lightShadowCasterModeDelegateField = IL2CPP.ResolveICall<Light.set_lightShadowCasterModeDelegate>("UnityEngine.Light::set_lightShadowCasterMode");
			Light.ResetDelegateField = IL2CPP.ResolveICall<Light.ResetDelegate>("UnityEngine.Light::Reset");
			Light.set_shadowsDelegateField = IL2CPP.ResolveICall<Light.set_shadowsDelegate>("UnityEngine.Light::set_shadows");
			Light.get_shadowStrengthDelegateField = IL2CPP.ResolveICall<Light.get_shadowStrengthDelegate>("UnityEngine.Light::get_shadowStrength");
			Light.set_shadowStrengthDelegateField = IL2CPP.ResolveICall<Light.set_shadowStrengthDelegate>("UnityEngine.Light::set_shadowStrength");
			Light.get_shadowResolutionDelegateField = IL2CPP.ResolveICall<Light.get_shadowResolutionDelegate>("UnityEngine.Light::get_shadowResolution");
			Light.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<Light.set_shadowResolutionDelegate>("UnityEngine.Light::set_shadowResolution");
			Light.get_layerShadowCullDistancesDelegateField = IL2CPP.ResolveICall<Light.get_layerShadowCullDistancesDelegate>("UnityEngine.Light::get_layerShadowCullDistances");
			Light.set_layerShadowCullDistancesDelegateField = IL2CPP.ResolveICall<Light.set_layerShadowCullDistancesDelegate>("UnityEngine.Light::set_layerShadowCullDistances");
			Light.set_cookieSizeDelegateField = IL2CPP.ResolveICall<Light.set_cookieSizeDelegate>("UnityEngine.Light::set_cookieSize");
			Light.set_cookieDelegateField = IL2CPP.ResolveICall<Light.set_cookieDelegate>("UnityEngine.Light::set_cookie");
			Light.get_renderModeDelegateField = IL2CPP.ResolveICall<Light.get_renderModeDelegate>("UnityEngine.Light::get_renderMode");
			Light.set_renderModeDelegateField = IL2CPP.ResolveICall<Light.set_renderModeDelegate>("UnityEngine.Light::set_renderMode");
			Light.AddCommandBufferDelegateField = IL2CPP.ResolveICall<Light.AddCommandBufferDelegate>("UnityEngine.Light::AddCommandBuffer");
			Light.AddCommandBufferAsyncDelegateField = IL2CPP.ResolveICall<Light.AddCommandBufferAsyncDelegate>("UnityEngine.Light::AddCommandBufferAsync");
			Light.RemoveCommandBufferDelegateField = IL2CPP.ResolveICall<Light.RemoveCommandBufferDelegate>("UnityEngine.Light::RemoveCommandBuffer");
			Light.RemoveCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.RemoveCommandBuffersDelegate>("UnityEngine.Light::RemoveCommandBuffers");
			Light.RemoveAllCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.RemoveAllCommandBuffersDelegate>("UnityEngine.Light::RemoveAllCommandBuffers");
			Light.GetCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.GetCommandBuffersDelegate>("UnityEngine.Light::GetCommandBuffers");
			Light.get_commandBufferCountDelegateField = IL2CPP.ResolveICall<Light.get_commandBufferCountDelegate>("UnityEngine.Light::get_commandBufferCount");
			Light.GetLightsDelegateField = IL2CPP.ResolveICall<Light.GetLightsDelegate>("UnityEngine.Light::GetLights");
			Light.get_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.get_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::get_boundingSphereOverride_Injected");
			Light.set_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::set_boundingSphereOverride_Injected");
			Light.get_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.get_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::get_shadowMatrixOverride_Injected");
			Light.set_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::set_shadowMatrixOverride_Injected");
			Light.set_bakingOutput_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_bakingOutput_InjectedDelegate>("UnityEngine.Light::set_bakingOutput_Injected");
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0002981C File Offset: 0x00027A1C
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00006F5D File Offset: 0x0000515D
		public unsafe LightType type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63481, RefRangeEnd = 63482, XrefRangeStart = 63479, XrefRangeEnd = 63481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00029858 File Offset: 0x00027A58
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00006F95 File Offset: 0x00005195
		public unsafe float spotAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63482, XrefRangeEnd = 63484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_spotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00029894 File Offset: 0x00027A94
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x000298D0 File Offset: 0x00027AD0
		public unsafe Color color
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 63486, RefRangeEnd = 63493, XrefRangeStart = 63484, XrefRangeEnd = 63486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 63495, RefRangeEnd = 63503, XrefRangeStart = 63493, XrefRangeEnd = 63495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00029910 File Offset: 0x00027B10
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00007017 File Offset: 0x00005217
		public unsafe float intensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63503, XrefRangeEnd = 63505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0002994C File Offset: 0x00027B4C
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x0000702A File Offset: 0x0000522A
		public unsafe float bounceIntensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63505, XrefRangeEnd = 63507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_bounceIntensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00029988 File Offset: 0x00027B88
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00007154 File Offset: 0x00005354
		public unsafe float range
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63507, XrefRangeEnd = 63509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_rangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000299C4 File Offset: 0x00027BC4
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0000717F File Offset: 0x0000537F
		public unsafe LightBakingOutput bakingOutput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63509, XrefRangeEnd = 63511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_bakingOutput_Injected(ref value);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00029A00 File Offset: 0x00027C00
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0000720A File Offset: 0x0000540A
		public unsafe LightShadows shadows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63511, XrefRangeEnd = 63513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_shadowsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00029A3C File Offset: 0x00027C3C
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00007285 File Offset: 0x00005485
		public unsafe float cookieSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63513, XrefRangeEnd = 63515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_cookieSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00029A78 File Offset: 0x00027C78
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00007298 File Offset: 0x00005498
		public unsafe Texture cookie
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63515, XrefRangeEnd = 63517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			set
			{
				Light.set_cookieDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00029AB8 File Offset: 0x00027CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63517, XrefRangeEnd = 63519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_color_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00029AF8 File Offset: 0x00027CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63519, XrefRangeEnd = 63521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_color_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00029B38 File Offset: 0x00027D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63521, XrefRangeEnd = 63523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bakingOutput_Injected(out LightBakingOutput ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00006F39 File Offset: 0x00005139
		public Light(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00029B78 File Offset: 0x00027D78
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00006F42 File Offset: 0x00005142
		public unsafe int m_BakedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex)) = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00006F70 File Offset: 0x00005170
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00006F82 File Offset: 0x00005182
		public LightShape shape
		{
			get
			{
				return Light.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00006FA8 File Offset: 0x000051A8
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00006FBA File Offset: 0x000051BA
		public float innerSpotAngle
		{
			get
			{
				return Light.get_innerSpotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_innerSpotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00006FCD File Offset: 0x000051CD
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00006FDF File Offset: 0x000051DF
		public float colorTemperature
		{
			get
			{
				return Light.get_colorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_colorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00006FF2 File Offset: 0x000051F2
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00007004 File Offset: 0x00005204
		public bool useColorTemperature
		{
			get
			{
				return Light.get_useColorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useColorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0000703D File Offset: 0x0000523D
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0000704F File Offset: 0x0000524F
		public bool useBoundingSphereOverride
		{
			get
			{
				return Light.get_useBoundingSphereOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useBoundingSphereOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00029BA0 File Offset: 0x00027DA0
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00007062 File Offset: 0x00005262
		public Vector4 boundingSphereOverride
		{
			get
			{
				Vector4 vector;
				this.get_boundingSphereOverride_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_boundingSphereOverride_Injected(ref value);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0000706C File Offset: 0x0000526C
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x0000707E File Offset: 0x0000527E
		public bool useViewFrustumForShadowCasterCull
		{
			get
			{
				return Light.get_useViewFrustumForShadowCasterCullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useViewFrustumForShadowCasterCullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00007091 File Offset: 0x00005291
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000070A3 File Offset: 0x000052A3
		public int shadowCustomResolution
		{
			get
			{
				return Light.get_shadowCustomResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowCustomResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000070B6 File Offset: 0x000052B6
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000070C8 File Offset: 0x000052C8
		public float shadowBias
		{
			get
			{
				return Light.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x000070DB File Offset: 0x000052DB
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x000070ED File Offset: 0x000052ED
		public float shadowNormalBias
		{
			get
			{
				return Light.get_shadowNormalBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowNormalBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00007100 File Offset: 0x00005300
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00007112 File Offset: 0x00005312
		public float shadowNearPlane
		{
			get
			{
				return Light.get_shadowNearPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowNearPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00007125 File Offset: 0x00005325
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00007137 File Offset: 0x00005337
		public bool useShadowMatrixOverride
		{
			get
			{
				return Light.get_useShadowMatrixOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useShadowMatrixOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00029BB8 File Offset: 0x00027DB8
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x0000714A File Offset: 0x0000534A
		public Matrix4x4 shadowMatrixOverride
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_shadowMatrixOverride_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.set_shadowMatrixOverride_Injected(ref value);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00029BD0 File Offset: 0x00027DD0
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00007167 File Offset: 0x00005367
		public Flare flare
		{
			get
			{
				IntPtr intPtr = Light.get_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr2) : null;
			}
			set
			{
				Light.set_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00007189 File Offset: 0x00005389
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0000719B File Offset: 0x0000539B
		public int cullingMask
		{
			get
			{
				return Light.get_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000071AE File Offset: 0x000053AE
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x000071C0 File Offset: 0x000053C0
		public int renderingLayerMask
		{
			get
			{
				return Light.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000071D3 File Offset: 0x000053D3
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x000071E5 File Offset: 0x000053E5
		public LightShadowCasterMode lightShadowCasterMode
		{
			get
			{
				return Light.get_lightShadowCasterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_lightShadowCasterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000071F8 File Offset: 0x000053F8
		public void Reset()
		{
			Light.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0000721D File Offset: 0x0000541D
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x0000722F File Offset: 0x0000542F
		public float shadowStrength
		{
			get
			{
				return Light.get_shadowStrengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowStrengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00007242 File Offset: 0x00005442
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00007254 File Offset: 0x00005454
		public UnityEngine.Rendering.LightShadowResolution shadowResolution
		{
			get
			{
				return Light.get_shadowResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00029BFC File Offset: 0x00027DFC
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00007267 File Offset: 0x00005467
		public float shadowSoftness
		{
			get
			{
				return 4f;
			}
			set
			{
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00029C14 File Offset: 0x00027E14
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0000726A File Offset: 0x0000546A
		public float shadowSoftnessFade
		{
			get
			{
				return 1f;
			}
			set
			{
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00029C2C File Offset: 0x00027E2C
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0000726D File Offset: 0x0000546D
		public Il2CppStructArray<float> layerShadowCullDistances
		{
			get
			{
				IntPtr intPtr = Light.get_layerShadowCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				Light.set_layerShadowCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000072B0 File Offset: 0x000054B0
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000072C2 File Offset: 0x000054C2
		public LightRenderMode renderMode
		{
			get
			{
				return Light.get_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00029C58 File Offset: 0x00027E58
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000072D5 File Offset: 0x000054D5
		public int bakedIndex
		{
			get
			{
				return this.m_BakedIndex;
			}
			set
			{
				this.m_BakedIndex = value;
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000072DF File Offset: 0x000054DF
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			this.AddCommandBuffer(evt, buffer, UnityEngine.Rendering.ShadowMapPass.All);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000072F0 File Offset: 0x000054F0
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask)
		{
			Light.AddCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), shadowPassMask);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0000730A File Offset: 0x0000550A
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			this.AddCommandBufferAsync(evt, buffer, UnityEngine.Rendering.ShadowMapPass.All, queueType);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0000731C File Offset: 0x0000551C
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Light.AddCommandBufferAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), shadowPassMask, queueType);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00007338 File Offset: 0x00005538
		public void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			Light.RemoveCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00007351 File Offset: 0x00005551
		public void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			Light.RemoveCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00007364 File Offset: 0x00005564
		public void RemoveAllCommandBuffers()
		{
			Light.RemoveAllCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00029C70 File Offset: 0x00027E70
		public Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			IntPtr intPtr = Light.GetCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr2) : null;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00007376 File Offset: 0x00005576
		public int commandBufferCount
		{
			get
			{
				return Light.get_commandBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00029CA0 File Offset: 0x00027EA0
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00007388 File Offset: 0x00005588
		public static int pixelLightCount
		{
			get
			{
				return QualitySettings.pixelLightCount;
			}
			set
			{
				QualitySettings.pixelLightCount = value;
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00029CB8 File Offset: 0x00027EB8
		public static Il2CppReferenceArray<Light> GetLights(LightType type, int layer)
		{
			IntPtr intPtr = Light.GetLightsDelegateField(type, layer);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00029CE0 File Offset: 0x00027EE0
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00007392 File Offset: 0x00005592
		public float shadowConstantBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00029CF8 File Offset: 0x00027EF8
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00007395 File Offset: 0x00005595
		public float shadowObjectSizeBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00029D10 File Offset: 0x00027F10
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00007398 File Offset: 0x00005598
		public bool attenuate
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0000739B File Offset: 0x0000559B
		public void get_boundingSphereOverride_Injected(out Vector4 ret)
		{
			Light.get_boundingSphereOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000073AE File Offset: 0x000055AE
		public void set_boundingSphereOverride_Injected(ref Vector4 value)
		{
			Light.set_boundingSphereOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000073C1 File Offset: 0x000055C1
		public void get_shadowMatrixOverride_Injected(out Matrix4x4 ret)
		{
			Light.get_shadowMatrixOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000073D4 File Offset: 0x000055D4
		public void set_shadowMatrixOverride_Injected(ref Matrix4x4 value)
		{
			Light.set_shadowMatrixOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000073E7 File Offset: 0x000055E7
		public void set_bakingOutput_Injected(ref LightBakingOutput value)
		{
			Light.set_bakingOutput_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_m_BakedIndex;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_LightType_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_get_intensity_Public_get_Single_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_cookie_Public_get_Texture_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0;

		// Token: 0x04000560 RID: 1376
		private static readonly Light.set_typeDelegate set_typeDelegateField;

		// Token: 0x04000561 RID: 1377
		private static readonly Light.get_shapeDelegate get_shapeDelegateField;

		// Token: 0x04000562 RID: 1378
		private static readonly Light.set_shapeDelegate set_shapeDelegateField;

		// Token: 0x04000563 RID: 1379
		private static readonly Light.set_spotAngleDelegate set_spotAngleDelegateField;

		// Token: 0x04000564 RID: 1380
		private static readonly Light.get_innerSpotAngleDelegate get_innerSpotAngleDelegateField;

		// Token: 0x04000565 RID: 1381
		private static readonly Light.set_innerSpotAngleDelegate set_innerSpotAngleDelegateField;

		// Token: 0x04000566 RID: 1382
		private static readonly Light.get_colorTemperatureDelegate get_colorTemperatureDelegateField;

		// Token: 0x04000567 RID: 1383
		private static readonly Light.set_colorTemperatureDelegate set_colorTemperatureDelegateField;

		// Token: 0x04000568 RID: 1384
		private static readonly Light.get_useColorTemperatureDelegate get_useColorTemperatureDelegateField;

		// Token: 0x04000569 RID: 1385
		private static readonly Light.set_useColorTemperatureDelegate set_useColorTemperatureDelegateField;

		// Token: 0x0400056A RID: 1386
		private static readonly Light.set_intensityDelegate set_intensityDelegateField;

		// Token: 0x0400056B RID: 1387
		private static readonly Light.set_bounceIntensityDelegate set_bounceIntensityDelegateField;

		// Token: 0x0400056C RID: 1388
		private static readonly Light.get_useBoundingSphereOverrideDelegate get_useBoundingSphereOverrideDelegateField;

		// Token: 0x0400056D RID: 1389
		private static readonly Light.set_useBoundingSphereOverrideDelegate set_useBoundingSphereOverrideDelegateField;

		// Token: 0x0400056E RID: 1390
		private static readonly Light.get_useViewFrustumForShadowCasterCullDelegate get_useViewFrustumForShadowCasterCullDelegateField;

		// Token: 0x0400056F RID: 1391
		private static readonly Light.set_useViewFrustumForShadowCasterCullDelegate set_useViewFrustumForShadowCasterCullDelegateField;

		// Token: 0x04000570 RID: 1392
		private static readonly Light.get_shadowCustomResolutionDelegate get_shadowCustomResolutionDelegateField;

		// Token: 0x04000571 RID: 1393
		private static readonly Light.set_shadowCustomResolutionDelegate set_shadowCustomResolutionDelegateField;

		// Token: 0x04000572 RID: 1394
		private static readonly Light.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x04000573 RID: 1395
		private static readonly Light.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000574 RID: 1396
		private static readonly Light.get_shadowNormalBiasDelegate get_shadowNormalBiasDelegateField;

		// Token: 0x04000575 RID: 1397
		private static readonly Light.set_shadowNormalBiasDelegate set_shadowNormalBiasDelegateField;

		// Token: 0x04000576 RID: 1398
		private static readonly Light.get_shadowNearPlaneDelegate get_shadowNearPlaneDelegateField;

		// Token: 0x04000577 RID: 1399
		private static readonly Light.set_shadowNearPlaneDelegate set_shadowNearPlaneDelegateField;

		// Token: 0x04000578 RID: 1400
		private static readonly Light.get_useShadowMatrixOverrideDelegate get_useShadowMatrixOverrideDelegateField;

		// Token: 0x04000579 RID: 1401
		private static readonly Light.set_useShadowMatrixOverrideDelegate set_useShadowMatrixOverrideDelegateField;

		// Token: 0x0400057A RID: 1402
		private static readonly Light.set_rangeDelegate set_rangeDelegateField;

		// Token: 0x0400057B RID: 1403
		private static readonly Light.get_flareDelegate get_flareDelegateField;

		// Token: 0x0400057C RID: 1404
		private static readonly Light.set_flareDelegate set_flareDelegateField;

		// Token: 0x0400057D RID: 1405
		private static readonly Light.get_cullingMaskDelegate get_cullingMaskDelegateField;

		// Token: 0x0400057E RID: 1406
		private static readonly Light.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x0400057F RID: 1407
		private static readonly Light.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x04000580 RID: 1408
		private static readonly Light.set_renderingLayerMaskDelegate set_renderingLayerMaskDelegateField;

		// Token: 0x04000581 RID: 1409
		private static readonly Light.get_lightShadowCasterModeDelegate get_lightShadowCasterModeDelegateField;

		// Token: 0x04000582 RID: 1410
		private static readonly Light.set_lightShadowCasterModeDelegate set_lightShadowCasterModeDelegateField;

		// Token: 0x04000583 RID: 1411
		private static readonly Light.ResetDelegate ResetDelegateField;

		// Token: 0x04000584 RID: 1412
		private static readonly Light.set_shadowsDelegate set_shadowsDelegateField;

		// Token: 0x04000585 RID: 1413
		private static readonly Light.get_shadowStrengthDelegate get_shadowStrengthDelegateField;

		// Token: 0x04000586 RID: 1414
		private static readonly Light.set_shadowStrengthDelegate set_shadowStrengthDelegateField;

		// Token: 0x04000587 RID: 1415
		private static readonly Light.get_shadowResolutionDelegate get_shadowResolutionDelegateField;

		// Token: 0x04000588 RID: 1416
		private static readonly Light.set_shadowResolutionDelegate set_shadowResolutionDelegateField;

		// Token: 0x04000589 RID: 1417
		private static readonly Light.get_layerShadowCullDistancesDelegate get_layerShadowCullDistancesDelegateField;

		// Token: 0x0400058A RID: 1418
		private static readonly Light.set_layerShadowCullDistancesDelegate set_layerShadowCullDistancesDelegateField;

		// Token: 0x0400058B RID: 1419
		private static readonly Light.set_cookieSizeDelegate set_cookieSizeDelegateField;

		// Token: 0x0400058C RID: 1420
		private static readonly Light.set_cookieDelegate set_cookieDelegateField;

		// Token: 0x0400058D RID: 1421
		private static readonly Light.get_renderModeDelegate get_renderModeDelegateField;

		// Token: 0x0400058E RID: 1422
		private static readonly Light.set_renderModeDelegate set_renderModeDelegateField;

		// Token: 0x0400058F RID: 1423
		private static readonly Light.AddCommandBufferDelegate AddCommandBufferDelegateField;

		// Token: 0x04000590 RID: 1424
		private static readonly Light.AddCommandBufferAsyncDelegate AddCommandBufferAsyncDelegateField;

		// Token: 0x04000591 RID: 1425
		private static readonly Light.RemoveCommandBufferDelegate RemoveCommandBufferDelegateField;

		// Token: 0x04000592 RID: 1426
		private static readonly Light.RemoveCommandBuffersDelegate RemoveCommandBuffersDelegateField;

		// Token: 0x04000593 RID: 1427
		private static readonly Light.RemoveAllCommandBuffersDelegate RemoveAllCommandBuffersDelegateField;

		// Token: 0x04000594 RID: 1428
		private static readonly Light.GetCommandBuffersDelegate GetCommandBuffersDelegateField;

		// Token: 0x04000595 RID: 1429
		private static readonly Light.get_commandBufferCountDelegate get_commandBufferCountDelegateField;

		// Token: 0x04000596 RID: 1430
		private static readonly Light.GetLightsDelegate GetLightsDelegateField;

		// Token: 0x04000597 RID: 1431
		private static readonly Light.get_boundingSphereOverride_InjectedDelegate get_boundingSphereOverride_InjectedDelegateField;

		// Token: 0x04000598 RID: 1432
		private static readonly Light.set_boundingSphereOverride_InjectedDelegate set_boundingSphereOverride_InjectedDelegateField;

		// Token: 0x04000599 RID: 1433
		private static readonly Light.get_shadowMatrixOverride_InjectedDelegate get_shadowMatrixOverride_InjectedDelegateField;

		// Token: 0x0400059A RID: 1434
		private static readonly Light.set_shadowMatrixOverride_InjectedDelegate set_shadowMatrixOverride_InjectedDelegateField;

		// Token: 0x0400059B RID: 1435
		private static readonly Light.set_bakingOutput_InjectedDelegate set_bakingOutput_InjectedDelegateField;

		// Token: 0x020005C7 RID: 1479
		// (Invoke) Token: 0x0600295D RID: 10589
		private delegate void set_typeDelegate(IntPtr @this, LightType value);

		// Token: 0x020005C8 RID: 1480
		// (Invoke) Token: 0x0600295F RID: 10591
		private delegate LightShape get_shapeDelegate(IntPtr @this);

		// Token: 0x020005C9 RID: 1481
		// (Invoke) Token: 0x06002961 RID: 10593
		private delegate void set_shapeDelegate(IntPtr @this, LightShape value);

		// Token: 0x020005CA RID: 1482
		// (Invoke) Token: 0x06002963 RID: 10595
		private delegate void set_spotAngleDelegate(IntPtr @this, float value);

		// Token: 0x020005CB RID: 1483
		// (Invoke) Token: 0x06002965 RID: 10597
		private delegate float get_innerSpotAngleDelegate(IntPtr @this);

		// Token: 0x020005CC RID: 1484
		// (Invoke) Token: 0x06002967 RID: 10599
		private delegate void set_innerSpotAngleDelegate(IntPtr @this, float value);

		// Token: 0x020005CD RID: 1485
		// (Invoke) Token: 0x06002969 RID: 10601
		private delegate float get_colorTemperatureDelegate(IntPtr @this);

		// Token: 0x020005CE RID: 1486
		// (Invoke) Token: 0x0600296B RID: 10603
		private delegate void set_colorTemperatureDelegate(IntPtr @this, float value);

		// Token: 0x020005CF RID: 1487
		// (Invoke) Token: 0x0600296D RID: 10605
		private delegate bool get_useColorTemperatureDelegate(IntPtr @this);

		// Token: 0x020005D0 RID: 1488
		// (Invoke) Token: 0x0600296F RID: 10607
		private delegate void set_useColorTemperatureDelegate(IntPtr @this, bool value);

		// Token: 0x020005D1 RID: 1489
		// (Invoke) Token: 0x06002971 RID: 10609
		private delegate void set_intensityDelegate(IntPtr @this, float value);

		// Token: 0x020005D2 RID: 1490
		// (Invoke) Token: 0x06002973 RID: 10611
		private delegate void set_bounceIntensityDelegate(IntPtr @this, float value);

		// Token: 0x020005D3 RID: 1491
		// (Invoke) Token: 0x06002975 RID: 10613
		private delegate bool get_useBoundingSphereOverrideDelegate(IntPtr @this);

		// Token: 0x020005D4 RID: 1492
		// (Invoke) Token: 0x06002977 RID: 10615
		private delegate void set_useBoundingSphereOverrideDelegate(IntPtr @this, bool value);

		// Token: 0x020005D5 RID: 1493
		// (Invoke) Token: 0x06002979 RID: 10617
		private delegate bool get_useViewFrustumForShadowCasterCullDelegate(IntPtr @this);

		// Token: 0x020005D6 RID: 1494
		// (Invoke) Token: 0x0600297B RID: 10619
		private delegate void set_useViewFrustumForShadowCasterCullDelegate(IntPtr @this, bool value);

		// Token: 0x020005D7 RID: 1495
		// (Invoke) Token: 0x0600297D RID: 10621
		private delegate int get_shadowCustomResolutionDelegate(IntPtr @this);

		// Token: 0x020005D8 RID: 1496
		// (Invoke) Token: 0x0600297F RID: 10623
		private delegate void set_shadowCustomResolutionDelegate(IntPtr @this, int value);

		// Token: 0x020005D9 RID: 1497
		// (Invoke) Token: 0x06002981 RID: 10625
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x020005DA RID: 1498
		// (Invoke) Token: 0x06002983 RID: 10627
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x020005DB RID: 1499
		// (Invoke) Token: 0x06002985 RID: 10629
		private delegate float get_shadowNormalBiasDelegate(IntPtr @this);

		// Token: 0x020005DC RID: 1500
		// (Invoke) Token: 0x06002987 RID: 10631
		private delegate void set_shadowNormalBiasDelegate(IntPtr @this, float value);

		// Token: 0x020005DD RID: 1501
		// (Invoke) Token: 0x06002989 RID: 10633
		private delegate float get_shadowNearPlaneDelegate(IntPtr @this);

		// Token: 0x020005DE RID: 1502
		// (Invoke) Token: 0x0600298B RID: 10635
		private delegate void set_shadowNearPlaneDelegate(IntPtr @this, float value);

		// Token: 0x020005DF RID: 1503
		// (Invoke) Token: 0x0600298D RID: 10637
		private delegate bool get_useShadowMatrixOverrideDelegate(IntPtr @this);

		// Token: 0x020005E0 RID: 1504
		// (Invoke) Token: 0x0600298F RID: 10639
		private delegate void set_useShadowMatrixOverrideDelegate(IntPtr @this, bool value);

		// Token: 0x020005E1 RID: 1505
		// (Invoke) Token: 0x06002991 RID: 10641
		private delegate void set_rangeDelegate(IntPtr @this, float value);

		// Token: 0x020005E2 RID: 1506
		// (Invoke) Token: 0x06002993 RID: 10643
		private delegate IntPtr get_flareDelegate(IntPtr @this);

		// Token: 0x020005E3 RID: 1507
		// (Invoke) Token: 0x06002995 RID: 10645
		private delegate void set_flareDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005E4 RID: 1508
		// (Invoke) Token: 0x06002997 RID: 10647
		private delegate int get_cullingMaskDelegate(IntPtr @this);

		// Token: 0x020005E5 RID: 1509
		// (Invoke) Token: 0x06002999 RID: 10649
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x020005E6 RID: 1510
		// (Invoke) Token: 0x0600299B RID: 10651
		private delegate int get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x020005E7 RID: 1511
		// (Invoke) Token: 0x0600299D RID: 10653
		private delegate void set_renderingLayerMaskDelegate(IntPtr @this, int value);

		// Token: 0x020005E8 RID: 1512
		// (Invoke) Token: 0x0600299F RID: 10655
		private delegate LightShadowCasterMode get_lightShadowCasterModeDelegate(IntPtr @this);

		// Token: 0x020005E9 RID: 1513
		// (Invoke) Token: 0x060029A1 RID: 10657
		private delegate void set_lightShadowCasterModeDelegate(IntPtr @this, LightShadowCasterMode value);

		// Token: 0x020005EA RID: 1514
		// (Invoke) Token: 0x060029A3 RID: 10659
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x020005EB RID: 1515
		// (Invoke) Token: 0x060029A5 RID: 10661
		private delegate void set_shadowsDelegate(IntPtr @this, LightShadows value);

		// Token: 0x020005EC RID: 1516
		// (Invoke) Token: 0x060029A7 RID: 10663
		private delegate float get_shadowStrengthDelegate(IntPtr @this);

		// Token: 0x020005ED RID: 1517
		// (Invoke) Token: 0x060029A9 RID: 10665
		private delegate void set_shadowStrengthDelegate(IntPtr @this, float value);

		// Token: 0x020005EE RID: 1518
		// (Invoke) Token: 0x060029AB RID: 10667
		private delegate UnityEngine.Rendering.LightShadowResolution get_shadowResolutionDelegate(IntPtr @this);

		// Token: 0x020005EF RID: 1519
		// (Invoke) Token: 0x060029AD RID: 10669
		private delegate void set_shadowResolutionDelegate(IntPtr @this, UnityEngine.Rendering.LightShadowResolution value);

		// Token: 0x020005F0 RID: 1520
		// (Invoke) Token: 0x060029AF RID: 10671
		private delegate IntPtr get_layerShadowCullDistancesDelegate(IntPtr @this);

		// Token: 0x020005F1 RID: 1521
		// (Invoke) Token: 0x060029B1 RID: 10673
		private delegate void set_layerShadowCullDistancesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005F2 RID: 1522
		// (Invoke) Token: 0x060029B3 RID: 10675
		private delegate void set_cookieSizeDelegate(IntPtr @this, float value);

		// Token: 0x020005F3 RID: 1523
		// (Invoke) Token: 0x060029B5 RID: 10677
		private delegate void set_cookieDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005F4 RID: 1524
		// (Invoke) Token: 0x060029B7 RID: 10679
		private delegate LightRenderMode get_renderModeDelegate(IntPtr @this);

		// Token: 0x020005F5 RID: 1525
		// (Invoke) Token: 0x060029B9 RID: 10681
		private delegate void set_renderModeDelegate(IntPtr @this, LightRenderMode value);

		// Token: 0x020005F6 RID: 1526
		// (Invoke) Token: 0x060029BB RID: 10683
		private delegate void AddCommandBufferDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);

		// Token: 0x020005F7 RID: 1527
		// (Invoke) Token: 0x060029BD RID: 10685
		private delegate void AddCommandBufferAsyncDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x020005F8 RID: 1528
		// (Invoke) Token: 0x060029BF RID: 10687
		private delegate void RemoveCommandBufferDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer);

		// Token: 0x020005F9 RID: 1529
		// (Invoke) Token: 0x060029C1 RID: 10689
		private delegate void RemoveCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt);

		// Token: 0x020005FA RID: 1530
		// (Invoke) Token: 0x060029C3 RID: 10691
		private delegate void RemoveAllCommandBuffersDelegate(IntPtr @this);

		// Token: 0x020005FB RID: 1531
		// (Invoke) Token: 0x060029C5 RID: 10693
		private delegate IntPtr GetCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt);

		// Token: 0x020005FC RID: 1532
		// (Invoke) Token: 0x060029C7 RID: 10695
		private delegate int get_commandBufferCountDelegate(IntPtr @this);

		// Token: 0x020005FD RID: 1533
		// (Invoke) Token: 0x060029C9 RID: 10697
		private delegate IntPtr GetLightsDelegate(LightType type, int layer);

		// Token: 0x020005FE RID: 1534
		// (Invoke) Token: 0x060029CB RID: 10699
		private delegate void get_boundingSphereOverride_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020005FF RID: 1535
		// (Invoke) Token: 0x060029CD RID: 10701
		private delegate void set_boundingSphereOverride_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000600 RID: 1536
		// (Invoke) Token: 0x060029CF RID: 10703
		private delegate void get_shadowMatrixOverride_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000601 RID: 1537
		// (Invoke) Token: 0x060029D1 RID: 10705
		private delegate void set_shadowMatrixOverride_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000602 RID: 1538
		// (Invoke) Token: 0x060029D3 RID: 10707
		private delegate void set_bakingOutput_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
