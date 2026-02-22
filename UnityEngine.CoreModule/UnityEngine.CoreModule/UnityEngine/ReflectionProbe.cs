using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200003D RID: 61
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x06000344 RID: 836 RVA: 0x0001DCD8 File Offset: 0x0001BED8
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbe()
		{
			Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ReflectionProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr);
			ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "reflectionProbeChanged");
			ReflectionProbe.NativeFieldInfoPtr_defaultReflectionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "defaultReflectionSet");
			ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663448);
			ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663449);
			ReflectionProbe.get_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_typeDelegate>("UnityEngine.ReflectionProbe::get_type");
			ReflectionProbe.set_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_typeDelegate>("UnityEngine.ReflectionProbe::set_type");
			ReflectionProbe.get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_nearClipPlane");
			ReflectionProbe.set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_nearClipPlane");
			ReflectionProbe.get_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_farClipPlane");
			ReflectionProbe.set_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_farClipPlane");
			ReflectionProbe.get_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_intensityDelegate>("UnityEngine.ReflectionProbe::get_intensity");
			ReflectionProbe.set_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_intensityDelegate>("UnityEngine.ReflectionProbe::set_intensity");
			ReflectionProbe.get_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_hdrDelegate>("UnityEngine.ReflectionProbe::get_hdr");
			ReflectionProbe.set_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_hdrDelegate>("UnityEngine.ReflectionProbe::set_hdr");
			ReflectionProbe.get_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::get_renderDynamicObjects");
			ReflectionProbe.set_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::set_renderDynamicObjects");
			ReflectionProbe.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::get_shadowDistance");
			ReflectionProbe.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::set_shadowDistance");
			ReflectionProbe.get_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_resolutionDelegate>("UnityEngine.ReflectionProbe::get_resolution");
			ReflectionProbe.set_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_resolutionDelegate>("UnityEngine.ReflectionProbe::set_resolution");
			ReflectionProbe.get_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_cullingMaskDelegate>("UnityEngine.ReflectionProbe::get_cullingMask");
			ReflectionProbe.set_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_cullingMaskDelegate>("UnityEngine.ReflectionProbe::set_cullingMask");
			ReflectionProbe.get_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_clearFlagsDelegate>("UnityEngine.ReflectionProbe::get_clearFlags");
			ReflectionProbe.set_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_clearFlagsDelegate>("UnityEngine.ReflectionProbe::set_clearFlags");
			ReflectionProbe.get_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_blendDistanceDelegate>("UnityEngine.ReflectionProbe::get_blendDistance");
			ReflectionProbe.set_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_blendDistanceDelegate>("UnityEngine.ReflectionProbe::set_blendDistance");
			ReflectionProbe.get_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_boxProjectionDelegate>("UnityEngine.ReflectionProbe::get_boxProjection");
			ReflectionProbe.set_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_boxProjectionDelegate>("UnityEngine.ReflectionProbe::set_boxProjection");
			ReflectionProbe.get_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_modeDelegate>("UnityEngine.ReflectionProbe::get_mode");
			ReflectionProbe.set_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_modeDelegate>("UnityEngine.ReflectionProbe::set_mode");
			ReflectionProbe.get_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_importanceDelegate>("UnityEngine.ReflectionProbe::get_importance");
			ReflectionProbe.set_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_importanceDelegate>("UnityEngine.ReflectionProbe::set_importance");
			ReflectionProbe.get_refreshModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_refreshModeDelegate>("UnityEngine.ReflectionProbe::get_refreshMode");
			ReflectionProbe.set_refreshModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_refreshModeDelegate>("UnityEngine.ReflectionProbe::set_refreshMode");
			ReflectionProbe.get_timeSlicingModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_timeSlicingModeDelegate>("UnityEngine.ReflectionProbe::get_timeSlicingMode");
			ReflectionProbe.set_timeSlicingModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_timeSlicingModeDelegate>("UnityEngine.ReflectionProbe::set_timeSlicingMode");
			ReflectionProbe.get_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bakedTextureDelegate>("UnityEngine.ReflectionProbe::get_bakedTexture");
			ReflectionProbe.set_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_bakedTextureDelegate>("UnityEngine.ReflectionProbe::set_bakedTexture");
			ReflectionProbe.get_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::get_customBakedTexture");
			ReflectionProbe.set_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::set_customBakedTexture");
			ReflectionProbe.get_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::get_realtimeTexture");
			ReflectionProbe.set_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::set_realtimeTexture");
			ReflectionProbe.get_textureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureDelegate>("UnityEngine.ReflectionProbe::get_texture");
			ReflectionProbe.ResetDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ResetDelegate>("UnityEngine.ReflectionProbe::Reset");
			ReflectionProbe.IsFinishedRenderingDelegateField = IL2CPP.ResolveICall<ReflectionProbe.IsFinishedRenderingDelegate>("UnityEngine.ReflectionProbe::IsFinishedRendering");
			ReflectionProbe.ScheduleRenderDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ScheduleRenderDelegate>("UnityEngine.ReflectionProbe::ScheduleRender");
			ReflectionProbe.BlendCubemapDelegateField = IL2CPP.ResolveICall<ReflectionProbe.BlendCubemapDelegate>("UnityEngine.ReflectionProbe::BlendCubemap");
			ReflectionProbe.get_minBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_minBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_minBakedCubemapResolution");
			ReflectionProbe.get_maxBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_maxBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_maxBakedCubemapResolution");
			ReflectionProbe.get_defaultTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_defaultTextureDelegate>("UnityEngine.ReflectionProbe::get_defaultTexture");
			ReflectionProbe.get_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_size_InjectedDelegate>("UnityEngine.ReflectionProbe::get_size_Injected");
			ReflectionProbe.set_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_size_InjectedDelegate>("UnityEngine.ReflectionProbe::set_size_Injected");
			ReflectionProbe.get_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_center_InjectedDelegate>("UnityEngine.ReflectionProbe::get_center_Injected");
			ReflectionProbe.set_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_center_InjectedDelegate>("UnityEngine.ReflectionProbe::set_center_Injected");
			ReflectionProbe.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bounds_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bounds_Injected");
			ReflectionProbe.get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::get_backgroundColor_Injected");
			ReflectionProbe.set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::set_backgroundColor_Injected");
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_textureHDRDecodeValues_Injected");
			ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_defaultTextureHDRDecodeValues_Injected");
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001E094 File Offset: 0x0001C294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60137, XrefRangeEnd = 60142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(probe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probeEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60142, XrefRangeEnd = 60147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultReflectionCubemap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Cubemap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00004179 File Offset: 0x00002379
		public ReflectionProbe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0001E110 File Offset: 0x0001C310
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00004182 File Offset: 0x00002382
		public unsafe static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0001E138 File Offset: 0x0001C338
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00004194 File Offset: 0x00002394
		public unsafe static Action<Cubemap> defaultReflectionSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_defaultReflectionSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Cubemap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_defaultReflectionSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000041A6 File Offset: 0x000023A6
		// (set) Token: 0x0600034D RID: 845 RVA: 0x000041B8 File Offset: 0x000023B8
		public UnityEngine.Rendering.ReflectionProbeType type
		{
			get
			{
				return ReflectionProbe.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0001E160 File Offset: 0x0001C360
		// (set) Token: 0x0600034F RID: 847 RVA: 0x000041CB File Offset: 0x000023CB
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0001E178 File Offset: 0x0001C378
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000041D5 File Offset: 0x000023D5
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000352 RID: 850 RVA: 0x000041DF File Offset: 0x000023DF
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000041F1 File Offset: 0x000023F1
		public float nearClipPlane
		{
			get
			{
				return ReflectionProbe.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00004204 File Offset: 0x00002404
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00004216 File Offset: 0x00002416
		public float farClipPlane
		{
			get
			{
				return ReflectionProbe.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00004229 File Offset: 0x00002429
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000423B File Offset: 0x0000243B
		public float intensity
		{
			get
			{
				return ReflectionProbe.get_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0001E190 File Offset: 0x0001C390
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.get_bounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000424E File Offset: 0x0000244E
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00004260 File Offset: 0x00002460
		public bool hdr
		{
			get
			{
				return ReflectionProbe.get_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00004273 File Offset: 0x00002473
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00004285 File Offset: 0x00002485
		public bool renderDynamicObjects
		{
			get
			{
				return ReflectionProbe.get_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00004298 File Offset: 0x00002498
		// (set) Token: 0x0600035E RID: 862 RVA: 0x000042AA File Offset: 0x000024AA
		public float shadowDistance
		{
			get
			{
				return ReflectionProbe.get_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000042BD File Offset: 0x000024BD
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000042CF File Offset: 0x000024CF
		public int resolution
		{
			get
			{
				return ReflectionProbe.get_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000361 RID: 865 RVA: 0x000042E2 File Offset: 0x000024E2
		// (set) Token: 0x06000362 RID: 866 RVA: 0x000042F4 File Offset: 0x000024F4
		public int cullingMask
		{
			get
			{
				return ReflectionProbe.get_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00004307 File Offset: 0x00002507
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00004319 File Offset: 0x00002519
		public UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags
		{
			get
			{
				return ReflectionProbe.get_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0000432C File Offset: 0x0000252C
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00004336 File Offset: 0x00002536
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00004348 File Offset: 0x00002548
		public float blendDistance
		{
			get
			{
				return ReflectionProbe.get_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000435B File Offset: 0x0000255B
		// (set) Token: 0x0600036A RID: 874 RVA: 0x0000436D File Offset: 0x0000256D
		public bool boxProjection
		{
			get
			{
				return ReflectionProbe.get_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00004380 File Offset: 0x00002580
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00004392 File Offset: 0x00002592
		public UnityEngine.Rendering.ReflectionProbeMode mode
		{
			get
			{
				return ReflectionProbe.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600036D RID: 877 RVA: 0x000043A5 File Offset: 0x000025A5
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000043B7 File Offset: 0x000025B7
		public int importance
		{
			get
			{
				return ReflectionProbe.get_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000043CA File Offset: 0x000025CA
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000043DC File Offset: 0x000025DC
		public UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode
		{
			get
			{
				return ReflectionProbe.get_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000043EF File Offset: 0x000025EF
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00004401 File Offset: 0x00002601
		public UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode
		{
			get
			{
				return ReflectionProbe.get_timeSlicingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_timeSlicingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00004414 File Offset: 0x00002614
		public Texture bakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0001E1EC File Offset: 0x0001C3EC
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000442C File Offset: 0x0000262C
		public Texture customBakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0001E218 File Offset: 0x0001C418
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00004444 File Offset: 0x00002644
		public RenderTexture realtimeTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001E244 File Offset: 0x0001C444
		public Texture texture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_textureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0001E270 File Offset: 0x0001C470
		public Vector4 textureHDRDecodeValues
		{
			get
			{
				Vector4 vector;
				this.get_textureHDRDecodeValues_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000445C File Offset: 0x0000265C
		public void Reset()
		{
			ReflectionProbe.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0001E288 File Offset: 0x0001C488
		public int RenderProbe()
		{
			return this.RenderProbe(null);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		public int RenderProbe(RenderTexture targetTexture)
		{
			return this.ScheduleRender(this.timeSlicingMode, targetTexture);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000446E File Offset: 0x0000266E
		public bool IsFinishedRendering(int renderId)
		{
			return ReflectionProbe.IsFinishedRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderId);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00004481 File Offset: 0x00002681
		public int ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
		{
			return ReflectionProbe.ScheduleRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeSlicingMode, IL2CPP.Il2CppObjectBaseToPtr(targetTexture));
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000449A File Offset: 0x0000269A
		public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target)
		{
			return ReflectionProbe.BlendCubemapDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), blend, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000044B9 File Offset: 0x000026B9
		public static int minBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_minBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000044C5 File Offset: 0x000026C5
		public static int maxBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_maxBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0001E2C4 File Offset: 0x0001C4C4
		public static Vector4 defaultTextureHDRDecodeValues
		{
			get
			{
				Vector4 vector;
				ReflectionProbe.get_defaultTextureHDRDecodeValues_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		public static Texture defaultTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_defaultTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000044D1 File Offset: 0x000026D1
		public static void add_defaultReflectionSet(Action<Cubemap> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000044DE File Offset: 0x000026DE
		public static void remove_defaultReflectionSet(Action<Cubemap> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000044EB File Offset: 0x000026EB
		public void get_size_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000044FE File Offset: 0x000026FE
		public void set_size_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00004511 File Offset: 0x00002711
		public void get_center_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00004524 File Offset: 0x00002724
		public void set_center_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00004537 File Offset: 0x00002737
		public void get_bounds_Injected(out Bounds ret)
		{
			ReflectionProbe.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000454A File Offset: 0x0000274A
		public void get_backgroundColor_Injected(out Color ret)
		{
			ReflectionProbe.get_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000455D File Offset: 0x0000275D
		public void set_backgroundColor_Injected(ref Color value)
		{
			ReflectionProbe.set_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00004570 File Offset: 0x00002770
		public void get_textureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00004583 File Offset: 0x00002783
		public static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegateField(out ret);
		}

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeChanged;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_defaultReflectionSet;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Cubemap_0;

		// Token: 0x04000252 RID: 594
		private static readonly ReflectionProbe.get_typeDelegate get_typeDelegateField;

		// Token: 0x04000253 RID: 595
		private static readonly ReflectionProbe.set_typeDelegate set_typeDelegateField;

		// Token: 0x04000254 RID: 596
		private static readonly ReflectionProbe.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField;

		// Token: 0x04000255 RID: 597
		private static readonly ReflectionProbe.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField;

		// Token: 0x04000256 RID: 598
		private static readonly ReflectionProbe.get_farClipPlaneDelegate get_farClipPlaneDelegateField;

		// Token: 0x04000257 RID: 599
		private static readonly ReflectionProbe.set_farClipPlaneDelegate set_farClipPlaneDelegateField;

		// Token: 0x04000258 RID: 600
		private static readonly ReflectionProbe.get_intensityDelegate get_intensityDelegateField;

		// Token: 0x04000259 RID: 601
		private static readonly ReflectionProbe.set_intensityDelegate set_intensityDelegateField;

		// Token: 0x0400025A RID: 602
		private static readonly ReflectionProbe.get_hdrDelegate get_hdrDelegateField;

		// Token: 0x0400025B RID: 603
		private static readonly ReflectionProbe.set_hdrDelegate set_hdrDelegateField;

		// Token: 0x0400025C RID: 604
		private static readonly ReflectionProbe.get_renderDynamicObjectsDelegate get_renderDynamicObjectsDelegateField;

		// Token: 0x0400025D RID: 605
		private static readonly ReflectionProbe.set_renderDynamicObjectsDelegate set_renderDynamicObjectsDelegateField;

		// Token: 0x0400025E RID: 606
		private static readonly ReflectionProbe.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x0400025F RID: 607
		private static readonly ReflectionProbe.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x04000260 RID: 608
		private static readonly ReflectionProbe.get_resolutionDelegate get_resolutionDelegateField;

		// Token: 0x04000261 RID: 609
		private static readonly ReflectionProbe.set_resolutionDelegate set_resolutionDelegateField;

		// Token: 0x04000262 RID: 610
		private static readonly ReflectionProbe.get_cullingMaskDelegate get_cullingMaskDelegateField;

		// Token: 0x04000263 RID: 611
		private static readonly ReflectionProbe.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x04000264 RID: 612
		private static readonly ReflectionProbe.get_clearFlagsDelegate get_clearFlagsDelegateField;

		// Token: 0x04000265 RID: 613
		private static readonly ReflectionProbe.set_clearFlagsDelegate set_clearFlagsDelegateField;

		// Token: 0x04000266 RID: 614
		private static readonly ReflectionProbe.get_blendDistanceDelegate get_blendDistanceDelegateField;

		// Token: 0x04000267 RID: 615
		private static readonly ReflectionProbe.set_blendDistanceDelegate set_blendDistanceDelegateField;

		// Token: 0x04000268 RID: 616
		private static readonly ReflectionProbe.get_boxProjectionDelegate get_boxProjectionDelegateField;

		// Token: 0x04000269 RID: 617
		private static readonly ReflectionProbe.set_boxProjectionDelegate set_boxProjectionDelegateField;

		// Token: 0x0400026A RID: 618
		private static readonly ReflectionProbe.get_modeDelegate get_modeDelegateField;

		// Token: 0x0400026B RID: 619
		private static readonly ReflectionProbe.set_modeDelegate set_modeDelegateField;

		// Token: 0x0400026C RID: 620
		private static readonly ReflectionProbe.get_importanceDelegate get_importanceDelegateField;

		// Token: 0x0400026D RID: 621
		private static readonly ReflectionProbe.set_importanceDelegate set_importanceDelegateField;

		// Token: 0x0400026E RID: 622
		private static readonly ReflectionProbe.get_refreshModeDelegate get_refreshModeDelegateField;

		// Token: 0x0400026F RID: 623
		private static readonly ReflectionProbe.set_refreshModeDelegate set_refreshModeDelegateField;

		// Token: 0x04000270 RID: 624
		private static readonly ReflectionProbe.get_timeSlicingModeDelegate get_timeSlicingModeDelegateField;

		// Token: 0x04000271 RID: 625
		private static readonly ReflectionProbe.set_timeSlicingModeDelegate set_timeSlicingModeDelegateField;

		// Token: 0x04000272 RID: 626
		private static readonly ReflectionProbe.get_bakedTextureDelegate get_bakedTextureDelegateField;

		// Token: 0x04000273 RID: 627
		private static readonly ReflectionProbe.set_bakedTextureDelegate set_bakedTextureDelegateField;

		// Token: 0x04000274 RID: 628
		private static readonly ReflectionProbe.get_customBakedTextureDelegate get_customBakedTextureDelegateField;

		// Token: 0x04000275 RID: 629
		private static readonly ReflectionProbe.set_customBakedTextureDelegate set_customBakedTextureDelegateField;

		// Token: 0x04000276 RID: 630
		private static readonly ReflectionProbe.get_realtimeTextureDelegate get_realtimeTextureDelegateField;

		// Token: 0x04000277 RID: 631
		private static readonly ReflectionProbe.set_realtimeTextureDelegate set_realtimeTextureDelegateField;

		// Token: 0x04000278 RID: 632
		private static readonly ReflectionProbe.get_textureDelegate get_textureDelegateField;

		// Token: 0x04000279 RID: 633
		private static readonly ReflectionProbe.ResetDelegate ResetDelegateField;

		// Token: 0x0400027A RID: 634
		private static readonly ReflectionProbe.IsFinishedRenderingDelegate IsFinishedRenderingDelegateField;

		// Token: 0x0400027B RID: 635
		private static readonly ReflectionProbe.ScheduleRenderDelegate ScheduleRenderDelegateField;

		// Token: 0x0400027C RID: 636
		private static readonly ReflectionProbe.BlendCubemapDelegate BlendCubemapDelegateField;

		// Token: 0x0400027D RID: 637
		private static readonly ReflectionProbe.get_minBakedCubemapResolutionDelegate get_minBakedCubemapResolutionDelegateField;

		// Token: 0x0400027E RID: 638
		private static readonly ReflectionProbe.get_maxBakedCubemapResolutionDelegate get_maxBakedCubemapResolutionDelegateField;

		// Token: 0x0400027F RID: 639
		private static readonly ReflectionProbe.get_defaultTextureDelegate get_defaultTextureDelegateField;

		// Token: 0x04000280 RID: 640
		private static readonly ReflectionProbe.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x04000281 RID: 641
		private static readonly ReflectionProbe.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x04000282 RID: 642
		private static readonly ReflectionProbe.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x04000283 RID: 643
		private static readonly ReflectionProbe.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x04000284 RID: 644
		private static readonly ReflectionProbe.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x04000285 RID: 645
		private static readonly ReflectionProbe.get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;

		// Token: 0x04000286 RID: 646
		private static readonly ReflectionProbe.set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;

		// Token: 0x04000287 RID: 647
		private static readonly ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate get_textureHDRDecodeValues_InjectedDelegateField;

		// Token: 0x04000288 RID: 648
		private static readonly ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegate get_defaultTextureHDRDecodeValues_InjectedDelegateField;

		// Token: 0x020003F1 RID: 1009
		public enum ReflectionProbeEvent
		{
			// Token: 0x04001C60 RID: 7264
			ReflectionProbeAdded,
			// Token: 0x04001C61 RID: 7265
			ReflectionProbeRemoved
		}

		// Token: 0x020003F2 RID: 1010
		// (Invoke) Token: 0x060025AB RID: 9643
		private delegate UnityEngine.Rendering.ReflectionProbeType get_typeDelegate(IntPtr @this);

		// Token: 0x020003F3 RID: 1011
		// (Invoke) Token: 0x060025AD RID: 9645
		private delegate void set_typeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeType value);

		// Token: 0x020003F4 RID: 1012
		// (Invoke) Token: 0x060025AF RID: 9647
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x020003F5 RID: 1013
		// (Invoke) Token: 0x060025B1 RID: 9649
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x020003F6 RID: 1014
		// (Invoke) Token: 0x060025B3 RID: 9651
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x020003F7 RID: 1015
		// (Invoke) Token: 0x060025B5 RID: 9653
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x020003F8 RID: 1016
		// (Invoke) Token: 0x060025B7 RID: 9655
		private delegate float get_intensityDelegate(IntPtr @this);

		// Token: 0x020003F9 RID: 1017
		// (Invoke) Token: 0x060025B9 RID: 9657
		private delegate void set_intensityDelegate(IntPtr @this, float value);

		// Token: 0x020003FA RID: 1018
		// (Invoke) Token: 0x060025BB RID: 9659
		private delegate bool get_hdrDelegate(IntPtr @this);

		// Token: 0x020003FB RID: 1019
		// (Invoke) Token: 0x060025BD RID: 9661
		private delegate void set_hdrDelegate(IntPtr @this, bool value);

		// Token: 0x020003FC RID: 1020
		// (Invoke) Token: 0x060025BF RID: 9663
		private delegate bool get_renderDynamicObjectsDelegate(IntPtr @this);

		// Token: 0x020003FD RID: 1021
		// (Invoke) Token: 0x060025C1 RID: 9665
		private delegate void set_renderDynamicObjectsDelegate(IntPtr @this, bool value);

		// Token: 0x020003FE RID: 1022
		// (Invoke) Token: 0x060025C3 RID: 9667
		private delegate float get_shadowDistanceDelegate(IntPtr @this);

		// Token: 0x020003FF RID: 1023
		// (Invoke) Token: 0x060025C5 RID: 9669
		private delegate void set_shadowDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000400 RID: 1024
		// (Invoke) Token: 0x060025C7 RID: 9671
		private delegate int get_resolutionDelegate(IntPtr @this);

		// Token: 0x02000401 RID: 1025
		// (Invoke) Token: 0x060025C9 RID: 9673
		private delegate void set_resolutionDelegate(IntPtr @this, int value);

		// Token: 0x02000402 RID: 1026
		// (Invoke) Token: 0x060025CB RID: 9675
		private delegate int get_cullingMaskDelegate(IntPtr @this);

		// Token: 0x02000403 RID: 1027
		// (Invoke) Token: 0x060025CD RID: 9677
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000404 RID: 1028
		// (Invoke) Token: 0x060025CF RID: 9679
		private delegate UnityEngine.Rendering.ReflectionProbeClearFlags get_clearFlagsDelegate(IntPtr @this);

		// Token: 0x02000405 RID: 1029
		// (Invoke) Token: 0x060025D1 RID: 9681
		private delegate void set_clearFlagsDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeClearFlags value);

		// Token: 0x02000406 RID: 1030
		// (Invoke) Token: 0x060025D3 RID: 9683
		private delegate float get_blendDistanceDelegate(IntPtr @this);

		// Token: 0x02000407 RID: 1031
		// (Invoke) Token: 0x060025D5 RID: 9685
		private delegate void set_blendDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000408 RID: 1032
		// (Invoke) Token: 0x060025D7 RID: 9687
		private delegate bool get_boxProjectionDelegate(IntPtr @this);

		// Token: 0x02000409 RID: 1033
		// (Invoke) Token: 0x060025D9 RID: 9689
		private delegate void set_boxProjectionDelegate(IntPtr @this, bool value);

		// Token: 0x0200040A RID: 1034
		// (Invoke) Token: 0x060025DB RID: 9691
		private delegate UnityEngine.Rendering.ReflectionProbeMode get_modeDelegate(IntPtr @this);

		// Token: 0x0200040B RID: 1035
		// (Invoke) Token: 0x060025DD RID: 9693
		private delegate void set_modeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeMode value);

		// Token: 0x0200040C RID: 1036
		// (Invoke) Token: 0x060025DF RID: 9695
		private delegate int get_importanceDelegate(IntPtr @this);

		// Token: 0x0200040D RID: 1037
		// (Invoke) Token: 0x060025E1 RID: 9697
		private delegate void set_importanceDelegate(IntPtr @this, int value);

		// Token: 0x0200040E RID: 1038
		// (Invoke) Token: 0x060025E3 RID: 9699
		private delegate UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshModeDelegate(IntPtr @this);

		// Token: 0x0200040F RID: 1039
		// (Invoke) Token: 0x060025E5 RID: 9701
		private delegate void set_refreshModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeRefreshMode value);

		// Token: 0x02000410 RID: 1040
		// (Invoke) Token: 0x060025E7 RID: 9703
		private delegate UnityEngine.Rendering.ReflectionProbeTimeSlicingMode get_timeSlicingModeDelegate(IntPtr @this);

		// Token: 0x02000411 RID: 1041
		// (Invoke) Token: 0x060025E9 RID: 9705
		private delegate void set_timeSlicingModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode value);

		// Token: 0x02000412 RID: 1042
		// (Invoke) Token: 0x060025EB RID: 9707
		private delegate IntPtr get_bakedTextureDelegate(IntPtr @this);

		// Token: 0x02000413 RID: 1043
		// (Invoke) Token: 0x060025ED RID: 9709
		private delegate void set_bakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000414 RID: 1044
		// (Invoke) Token: 0x060025EF RID: 9711
		private delegate IntPtr get_customBakedTextureDelegate(IntPtr @this);

		// Token: 0x02000415 RID: 1045
		// (Invoke) Token: 0x060025F1 RID: 9713
		private delegate void set_customBakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000416 RID: 1046
		// (Invoke) Token: 0x060025F3 RID: 9715
		private delegate IntPtr get_realtimeTextureDelegate(IntPtr @this);

		// Token: 0x02000417 RID: 1047
		// (Invoke) Token: 0x060025F5 RID: 9717
		private delegate void set_realtimeTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000418 RID: 1048
		// (Invoke) Token: 0x060025F7 RID: 9719
		private delegate IntPtr get_textureDelegate(IntPtr @this);

		// Token: 0x02000419 RID: 1049
		// (Invoke) Token: 0x060025F9 RID: 9721
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x0200041A RID: 1050
		// (Invoke) Token: 0x060025FB RID: 9723
		private delegate bool IsFinishedRenderingDelegate(IntPtr @this, int renderId);

		// Token: 0x0200041B RID: 1051
		// (Invoke) Token: 0x060025FD RID: 9725
		private delegate int ScheduleRenderDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, IntPtr targetTexture);

		// Token: 0x0200041C RID: 1052
		// (Invoke) Token: 0x060025FF RID: 9727
		private delegate bool BlendCubemapDelegate(IntPtr src, IntPtr dst, float blend, IntPtr target);

		// Token: 0x0200041D RID: 1053
		// (Invoke) Token: 0x06002601 RID: 9729
		private delegate int get_minBakedCubemapResolutionDelegate();

		// Token: 0x0200041E RID: 1054
		// (Invoke) Token: 0x06002603 RID: 9731
		private delegate int get_maxBakedCubemapResolutionDelegate();

		// Token: 0x0200041F RID: 1055
		// (Invoke) Token: 0x06002605 RID: 9733
		private delegate IntPtr get_defaultTextureDelegate();

		// Token: 0x02000420 RID: 1056
		// (Invoke) Token: 0x06002607 RID: 9735
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000421 RID: 1057
		// (Invoke) Token: 0x06002609 RID: 9737
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000422 RID: 1058
		// (Invoke) Token: 0x0600260B RID: 9739
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000423 RID: 1059
		// (Invoke) Token: 0x0600260D RID: 9741
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000424 RID: 1060
		// (Invoke) Token: 0x0600260F RID: 9743
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000425 RID: 1061
		// (Invoke) Token: 0x06002611 RID: 9745
		private delegate void get_backgroundColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000426 RID: 1062
		// (Invoke) Token: 0x06002613 RID: 9747
		private delegate void set_backgroundColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000427 RID: 1063
		// (Invoke) Token: 0x06002615 RID: 9749
		private delegate void get_textureHDRDecodeValues_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000428 RID: 1064
		// (Invoke) Token: 0x06002617 RID: 9751
		private delegate void get_defaultTextureHDRDecodeValues_InjectedDelegate([Out] IntPtr ret);
	}
}
