using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Linq;

namespace UnityEngine.Rendering
{
	// Token: 0x0200013A RID: 314
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x06001799 RID: 6041 RVA: 0x00058A80 File Offset: 0x00056C80
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665088);
			GraphicsSettings.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortMode");
			GraphicsSettings.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortMode");
			GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::get_realtimeDirectRectangularAreaLights");
			GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::set_realtimeDirectRectangularAreaLights");
			GraphicsSettings.set_lightsUseLinearIntensityDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightsUseLinearIntensityDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightsUseLinearIntensity");
			GraphicsSettings.get_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightsUseColorTemperature");
			GraphicsSettings.set_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightsUseColorTemperature");
			GraphicsSettings.get_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultRenderingLayerMask");
			GraphicsSettings.set_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::set_defaultRenderingLayerMask");
			GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_useScriptableRenderPipelineBatching");
			GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_useScriptableRenderPipelineBatching");
			GraphicsSettings.get_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::get_logWhenShaderIsCompiled");
			GraphicsSettings.set_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::set_logWhenShaderIsCompiled");
			GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::get_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::set_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.get_videoShadersIncludeModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_videoShadersIncludeModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_videoShadersIncludeMode");
			GraphicsSettings.HasShaderDefineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.HasShaderDefineDelegate>("UnityEngine.Rendering.GraphicsSettings::HasShaderDefine");
			GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_currentRenderPipeline");
			GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_defaultRenderPipeline");
			GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline");
			GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate>("UnityEngine.Rendering.GraphicsSettings::GetAllConfiguredRenderPipelines");
			GraphicsSettings.GetGraphicsSettingsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetGraphicsSettingsDelegate>("UnityEngine.Rendering.GraphicsSettings::GetGraphicsSettings");
			GraphicsSettings.SetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::SetShaderMode");
			GraphicsSettings.GetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::GetShaderMode");
			GraphicsSettings.SetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::SetCustomShader");
			GraphicsSettings.GetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::GetCustomShader");
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortAxis_Injected");
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortAxis_Injected");
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00058C68 File Offset: 0x00056E68
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0000D39F File Offset: 0x0000B59F
		public unsafe static bool lightsUseLinearIntensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82222, XrefRangeEnd = 82224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GraphicsSettings.set_lightsUseLinearIntensityDelegateField(value);
			}
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0000D35B File Offset: 0x0000B55B
		public GraphicsSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0000D364 File Offset: 0x0000B564
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0000D370 File Offset: 0x0000B570
		public static TransparencySortMode transparencySortMode
		{
			get
			{
				return GraphicsSettings.get_transparencySortModeDelegateField();
			}
			set
			{
				GraphicsSettings.set_transparencySortModeDelegateField(value);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00058C98 File Offset: 0x00056E98
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x0000D37D File Offset: 0x0000B57D
		public static Vector3 transparencySortAxis
		{
			get
			{
				Vector3 vector;
				GraphicsSettings.get_transparencySortAxis_Injected(out vector);
				return vector;
			}
			set
			{
				GraphicsSettings.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0000D386 File Offset: 0x0000B586
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x0000D392 File Offset: 0x0000B592
		public static bool realtimeDirectRectangularAreaLights
		{
			get
			{
				return GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField();
			}
			set
			{
				GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField(value);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
		public static bool lightsUseColorTemperature
		{
			get
			{
				return GraphicsSettings.get_lightsUseColorTemperatureDelegateField();
			}
			set
			{
				GraphicsSettings.set_lightsUseColorTemperatureDelegateField(value);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0000D3C5 File Offset: 0x0000B5C5
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0000D3D1 File Offset: 0x0000B5D1
		public static uint defaultRenderingLayerMask
		{
			get
			{
				return GraphicsSettings.get_defaultRenderingLayerMaskDelegateField();
			}
			set
			{
				GraphicsSettings.set_defaultRenderingLayerMaskDelegateField(value);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0000D3DE File Offset: 0x0000B5DE
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0000D3EA File Offset: 0x0000B5EA
		public static bool useScriptableRenderPipelineBatching
		{
			get
			{
				return GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField();
			}
			set
			{
				GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegateField(value);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x0000D403 File Offset: 0x0000B603
		public static bool logWhenShaderIsCompiled
		{
			get
			{
				return GraphicsSettings.get_logWhenShaderIsCompiledDelegateField();
			}
			set
			{
				GraphicsSettings.set_logWhenShaderIsCompiledDelegateField(value);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x0000D410 File Offset: 0x0000B610
		// (set) Token: 0x060017AC RID: 6060 RVA: 0x0000D41C File Offset: 0x0000B61C
		public static bool disableBuiltinCustomRenderTextureUpdate
		{
			get
			{
				return GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField();
			}
			set
			{
				GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField(value);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x0000D429 File Offset: 0x0000B629
		public static VideoShadersIncludeMode videoShadersIncludeMode
		{
			get
			{
				return GraphicsSettings.get_videoShadersIncludeModeDelegateField();
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0000D435 File Offset: 0x0000B635
		public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
		{
			return GraphicsSettings.HasShaderDefineDelegateField(tier, defineHash);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00058CB0 File Offset: 0x00056EB0
		public static bool HasShaderDefine(BuiltinShaderDefine defineHash)
		{
			return GraphicsSettings.HasShaderDefine(Graphics.activeTier, defineHash);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00058CD0 File Offset: 0x00056ED0
		public static ScriptableObject INTERNAL_currentRenderPipeline
		{
			get
			{
				IntPtr intPtr = GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00058CF8 File Offset: 0x00056EF8
		public static RenderPipelineAsset currentRenderPipeline
		{
			get
			{
				return GraphicsSettings.INTERNAL_currentRenderPipeline.TryCast<RenderPipelineAsset>();
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00058D14 File Offset: 0x00056F14
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0000D443 File Offset: 0x0000B643
		public static RenderPipelineAsset renderPipelineAsset
		{
			get
			{
				return GraphicsSettings.defaultRenderPipeline;
			}
			set
			{
				GraphicsSettings.defaultRenderPipeline = value;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00058D2C File Offset: 0x00056F2C
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000D44D File Offset: 0x0000B64D
		public static ScriptableObject INTERNAL_defaultRenderPipeline
		{
			get
			{
				IntPtr intPtr = GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00058D54 File Offset: 0x00056F54
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0000D45F File Offset: 0x0000B65F
		public static RenderPipelineAsset defaultRenderPipeline
		{
			get
			{
				return GraphicsSettings.INTERNAL_defaultRenderPipeline.TryCast<RenderPipelineAsset>();
			}
			set
			{
				GraphicsSettings.INTERNAL_defaultRenderPipeline = value;
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00058D70 File Offset: 0x00056F70
		public static Il2CppReferenceArray<ScriptableObject> GetAllConfiguredRenderPipelines()
		{
			IntPtr intPtr = GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr2) : null;
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00058D98 File Offset: 0x00056F98
		public static Il2CppReferenceArray<RenderPipelineAsset> allConfiguredRenderPipelines
		{
			get
			{
				return GraphicsSettings.GetAllConfiguredRenderPipelines().Cast<RenderPipelineAsset>().ToArray<RenderPipelineAsset>();
			}
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00058DBC File Offset: 0x00056FBC
		public static Object GetGraphicsSettings()
		{
			IntPtr intPtr = GraphicsSettings.GetGraphicsSettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0000D469 File Offset: 0x0000B669
		public static void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode)
		{
			GraphicsSettings.SetShaderModeDelegateField(type, mode);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0000D477 File Offset: 0x0000B677
		public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
		{
			return GraphicsSettings.GetShaderModeDelegateField(type);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0000D484 File Offset: 0x0000B684
		public static void SetCustomShader(BuiltinShaderType type, Shader shader)
		{
			GraphicsSettings.SetCustomShaderDelegateField(type, IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00058DE4 File Offset: 0x00056FE4
		public static Shader GetCustomShader(BuiltinShaderType type)
		{
			IntPtr intPtr = GraphicsSettings.GetCustomShaderDelegateField(type);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0000D497 File Offset: 0x0000B697
		public static void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField(out ret);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public static void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField(ref value);
		}

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0;

		// Token: 0x0400118F RID: 4495
		private static readonly GraphicsSettings.get_transparencySortModeDelegate get_transparencySortModeDelegateField;

		// Token: 0x04001190 RID: 4496
		private static readonly GraphicsSettings.set_transparencySortModeDelegate set_transparencySortModeDelegateField;

		// Token: 0x04001191 RID: 4497
		private static readonly GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate get_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x04001192 RID: 4498
		private static readonly GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate set_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x04001193 RID: 4499
		private static readonly GraphicsSettings.set_lightsUseLinearIntensityDelegate set_lightsUseLinearIntensityDelegateField;

		// Token: 0x04001194 RID: 4500
		private static readonly GraphicsSettings.get_lightsUseColorTemperatureDelegate get_lightsUseColorTemperatureDelegateField;

		// Token: 0x04001195 RID: 4501
		private static readonly GraphicsSettings.set_lightsUseColorTemperatureDelegate set_lightsUseColorTemperatureDelegateField;

		// Token: 0x04001196 RID: 4502
		private static readonly GraphicsSettings.get_defaultRenderingLayerMaskDelegate get_defaultRenderingLayerMaskDelegateField;

		// Token: 0x04001197 RID: 4503
		private static readonly GraphicsSettings.set_defaultRenderingLayerMaskDelegate set_defaultRenderingLayerMaskDelegateField;

		// Token: 0x04001198 RID: 4504
		private static readonly GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate get_useScriptableRenderPipelineBatchingDelegateField;

		// Token: 0x04001199 RID: 4505
		private static readonly GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegate set_useScriptableRenderPipelineBatchingDelegateField;

		// Token: 0x0400119A RID: 4506
		private static readonly GraphicsSettings.get_logWhenShaderIsCompiledDelegate get_logWhenShaderIsCompiledDelegateField;

		// Token: 0x0400119B RID: 4507
		private static readonly GraphicsSettings.set_logWhenShaderIsCompiledDelegate set_logWhenShaderIsCompiledDelegateField;

		// Token: 0x0400119C RID: 4508
		private static readonly GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate get_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x0400119D RID: 4509
		private static readonly GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate set_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x0400119E RID: 4510
		private static readonly GraphicsSettings.get_videoShadersIncludeModeDelegate get_videoShadersIncludeModeDelegateField;

		// Token: 0x0400119F RID: 4511
		private static readonly GraphicsSettings.HasShaderDefineDelegate HasShaderDefineDelegateField;

		// Token: 0x040011A0 RID: 4512
		private static readonly GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegate get_INTERNAL_currentRenderPipelineDelegateField;

		// Token: 0x040011A1 RID: 4513
		private static readonly GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegate get_INTERNAL_defaultRenderPipelineDelegateField;

		// Token: 0x040011A2 RID: 4514
		private static readonly GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate set_INTERNAL_defaultRenderPipelineDelegateField;

		// Token: 0x040011A3 RID: 4515
		private static readonly GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate GetAllConfiguredRenderPipelinesDelegateField;

		// Token: 0x040011A4 RID: 4516
		private static readonly GraphicsSettings.GetGraphicsSettingsDelegate GetGraphicsSettingsDelegateField;

		// Token: 0x040011A5 RID: 4517
		private static readonly GraphicsSettings.SetShaderModeDelegate SetShaderModeDelegateField;

		// Token: 0x040011A6 RID: 4518
		private static readonly GraphicsSettings.GetShaderModeDelegate GetShaderModeDelegateField;

		// Token: 0x040011A7 RID: 4519
		private static readonly GraphicsSettings.SetCustomShaderDelegate SetCustomShaderDelegateField;

		// Token: 0x040011A8 RID: 4520
		private static readonly GraphicsSettings.GetCustomShaderDelegate GetCustomShaderDelegateField;

		// Token: 0x040011A9 RID: 4521
		private static readonly GraphicsSettings.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

		// Token: 0x040011AA RID: 4522
		private static readonly GraphicsSettings.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

		// Token: 0x02000968 RID: 2408
		// (Invoke) Token: 0x060030EE RID: 12526
		private delegate TransparencySortMode get_transparencySortModeDelegate();

		// Token: 0x02000969 RID: 2409
		// (Invoke) Token: 0x060030F0 RID: 12528
		private delegate void set_transparencySortModeDelegate(TransparencySortMode value);

		// Token: 0x0200096A RID: 2410
		// (Invoke) Token: 0x060030F2 RID: 12530
		private delegate bool get_realtimeDirectRectangularAreaLightsDelegate();

		// Token: 0x0200096B RID: 2411
		// (Invoke) Token: 0x060030F4 RID: 12532
		private delegate void set_realtimeDirectRectangularAreaLightsDelegate(bool value);

		// Token: 0x0200096C RID: 2412
		// (Invoke) Token: 0x060030F6 RID: 12534
		private delegate void set_lightsUseLinearIntensityDelegate(bool value);

		// Token: 0x0200096D RID: 2413
		// (Invoke) Token: 0x060030F8 RID: 12536
		private delegate bool get_lightsUseColorTemperatureDelegate();

		// Token: 0x0200096E RID: 2414
		// (Invoke) Token: 0x060030FA RID: 12538
		private delegate void set_lightsUseColorTemperatureDelegate(bool value);

		// Token: 0x0200096F RID: 2415
		// (Invoke) Token: 0x060030FC RID: 12540
		private delegate uint get_defaultRenderingLayerMaskDelegate();

		// Token: 0x02000970 RID: 2416
		// (Invoke) Token: 0x060030FE RID: 12542
		private delegate void set_defaultRenderingLayerMaskDelegate(uint value);

		// Token: 0x02000971 RID: 2417
		// (Invoke) Token: 0x06003100 RID: 12544
		private delegate bool get_useScriptableRenderPipelineBatchingDelegate();

		// Token: 0x02000972 RID: 2418
		// (Invoke) Token: 0x06003102 RID: 12546
		private delegate void set_useScriptableRenderPipelineBatchingDelegate(bool value);

		// Token: 0x02000973 RID: 2419
		// (Invoke) Token: 0x06003104 RID: 12548
		private delegate bool get_logWhenShaderIsCompiledDelegate();

		// Token: 0x02000974 RID: 2420
		// (Invoke) Token: 0x06003106 RID: 12550
		private delegate void set_logWhenShaderIsCompiledDelegate(bool value);

		// Token: 0x02000975 RID: 2421
		// (Invoke) Token: 0x06003108 RID: 12552
		private delegate bool get_disableBuiltinCustomRenderTextureUpdateDelegate();

		// Token: 0x02000976 RID: 2422
		// (Invoke) Token: 0x0600310A RID: 12554
		private delegate void set_disableBuiltinCustomRenderTextureUpdateDelegate(bool value);

		// Token: 0x02000977 RID: 2423
		// (Invoke) Token: 0x0600310C RID: 12556
		private delegate VideoShadersIncludeMode get_videoShadersIncludeModeDelegate();

		// Token: 0x02000978 RID: 2424
		// (Invoke) Token: 0x0600310E RID: 12558
		private delegate bool HasShaderDefineDelegate(GraphicsTier tier, BuiltinShaderDefine defineHash);

		// Token: 0x02000979 RID: 2425
		// (Invoke) Token: 0x06003110 RID: 12560
		private delegate IntPtr get_INTERNAL_currentRenderPipelineDelegate();

		// Token: 0x0200097A RID: 2426
		// (Invoke) Token: 0x06003112 RID: 12562
		private delegate IntPtr get_INTERNAL_defaultRenderPipelineDelegate();

		// Token: 0x0200097B RID: 2427
		// (Invoke) Token: 0x06003114 RID: 12564
		private delegate void set_INTERNAL_defaultRenderPipelineDelegate(IntPtr value);

		// Token: 0x0200097C RID: 2428
		// (Invoke) Token: 0x06003116 RID: 12566
		private delegate IntPtr GetAllConfiguredRenderPipelinesDelegate();

		// Token: 0x0200097D RID: 2429
		// (Invoke) Token: 0x06003118 RID: 12568
		private delegate IntPtr GetGraphicsSettingsDelegate();

		// Token: 0x0200097E RID: 2430
		// (Invoke) Token: 0x0600311A RID: 12570
		private delegate void SetShaderModeDelegate(BuiltinShaderType type, BuiltinShaderMode mode);

		// Token: 0x0200097F RID: 2431
		// (Invoke) Token: 0x0600311C RID: 12572
		private delegate BuiltinShaderMode GetShaderModeDelegate(BuiltinShaderType type);

		// Token: 0x02000980 RID: 2432
		// (Invoke) Token: 0x0600311E RID: 12574
		private delegate void SetCustomShaderDelegate(BuiltinShaderType type, IntPtr shader);

		// Token: 0x02000981 RID: 2433
		// (Invoke) Token: 0x06003120 RID: 12576
		private delegate IntPtr GetCustomShaderDelegate(BuiltinShaderType type);

		// Token: 0x02000982 RID: 2434
		// (Invoke) Token: 0x06003122 RID: 12578
		private delegate void get_transparencySortAxis_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000983 RID: 2435
		// (Invoke) Token: 0x06003124 RID: 12580
		private delegate void set_transparencySortAxis_InjectedDelegate(IntPtr value);
	}
}
