using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000076 RID: 118
	public sealed class CustomRenderTexture : RenderTexture
	{
		// Token: 0x06000BD0 RID: 3024 RVA: 0x00032FD0 File Offset: 0x000311D0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTexture()
		{
			Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr);
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate>("UnityEngine.CustomRenderTexture::Internal_CreateCustomRenderTexture");
			CustomRenderTexture.TriggerUpdateDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerUpdateDelegate>("UnityEngine.CustomRenderTexture::TriggerUpdate");
			CustomRenderTexture.TriggerInitializationDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerInitializationDelegate>("UnityEngine.CustomRenderTexture::TriggerInitialization");
			CustomRenderTexture.ClearUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.ClearUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::ClearUpdateZones");
			CustomRenderTexture.get_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_materialDelegate>("UnityEngine.CustomRenderTexture::get_material");
			CustomRenderTexture.set_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_materialDelegate>("UnityEngine.CustomRenderTexture::set_material");
			CustomRenderTexture.get_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::get_initializationMaterial");
			CustomRenderTexture.set_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::set_initializationMaterial");
			CustomRenderTexture.get_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::get_initializationTexture");
			CustomRenderTexture.set_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::set_initializationTexture");
			CustomRenderTexture.GetUpdateZonesInternalDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetUpdateZonesInternalDelegate>("UnityEngine.CustomRenderTexture::GetUpdateZonesInternal");
			CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetDoubleBufferRenderTextureDelegate>("UnityEngine.CustomRenderTexture::GetDoubleBufferRenderTexture");
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate>("UnityEngine.CustomRenderTexture::EnsureDoubleBufferConsistency");
			CustomRenderTexture.get_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::get_initializationSource");
			CustomRenderTexture.set_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::set_initializationSource");
			CustomRenderTexture.get_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateModeDelegate>("UnityEngine.CustomRenderTexture::get_updateMode");
			CustomRenderTexture.set_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateModeDelegate>("UnityEngine.CustomRenderTexture::set_updateMode");
			CustomRenderTexture.get_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationModeDelegate>("UnityEngine.CustomRenderTexture::get_initializationMode");
			CustomRenderTexture.set_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationModeDelegate>("UnityEngine.CustomRenderTexture::set_initializationMode");
			CustomRenderTexture.get_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::get_updateZoneSpace");
			CustomRenderTexture.set_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::set_updateZoneSpace");
			CustomRenderTexture.get_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_shaderPassDelegate>("UnityEngine.CustomRenderTexture::get_shaderPass");
			CustomRenderTexture.set_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_shaderPassDelegate>("UnityEngine.CustomRenderTexture::set_shaderPass");
			CustomRenderTexture.get_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::get_cubemapFaceMask");
			CustomRenderTexture.set_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::set_cubemapFaceMask");
			CustomRenderTexture.get_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::get_doubleBuffered");
			CustomRenderTexture.set_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::set_doubleBuffered");
			CustomRenderTexture.get_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::get_wrapUpdateZones");
			CustomRenderTexture.set_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::set_wrapUpdateZones");
			CustomRenderTexture.get_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::get_updatePeriod");
			CustomRenderTexture.set_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::set_updatePeriod");
			CustomRenderTexture.get_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationColor_Injected");
			CustomRenderTexture.set_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationColor_Injected");
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00008C15 File Offset: 0x00006E15
		public CustomRenderTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00008C1E File Offset: 0x00006E1E
		public static void Internal_CreateCustomRenderTexture(CustomRenderTexture rt)
		{
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00008C30 File Offset: 0x00006E30
		public void TriggerUpdate(int count)
		{
			CustomRenderTexture.TriggerUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), count);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00008C43 File Offset: 0x00006E43
		public void Update(int count)
		{
			CustomRenderTextureManager.InvokeTriggerUpdate(this, count);
			this.TriggerUpdate(count);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00008C56 File Offset: 0x00006E56
		public void Update()
		{
			this.Update(1);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00008C61 File Offset: 0x00006E61
		public void TriggerInitialization()
		{
			CustomRenderTexture.TriggerInitializationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00008C73 File Offset: 0x00006E73
		public void Initialize()
		{
			this.TriggerInitialization();
			CustomRenderTextureManager.InvokeTriggerInitialize(this);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00008C84 File Offset: 0x00006E84
		public void ClearUpdateZones()
		{
			CustomRenderTexture.ClearUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000331F0 File Offset: 0x000313F0
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00008C96 File Offset: 0x00006E96
		public Material material
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0003321C File Offset: 0x0003141C
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00008CAE File Offset: 0x00006EAE
		public Material initializationMaterial
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00033248 File Offset: 0x00031448
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00008CC6 File Offset: 0x00006EC6
		public Texture initializationTexture
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00008CDE File Offset: 0x00006EDE
		public void GetUpdateZonesInternal(Object updateZones)
		{
			CustomRenderTexture.GetUpdateZonesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(updateZones));
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00033274 File Offset: 0x00031474
		public RenderTexture GetDoubleBufferRenderTexture()
		{
			IntPtr intPtr = CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00008CF6 File Offset: 0x00006EF6
		public void EnsureDoubleBufferConsistency()
		{
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00008D08 File Offset: 0x00006F08
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00008D1A File Offset: 0x00006F1A
		public CustomRenderTextureInitializationSource initializationSource
		{
			get
			{
				return CustomRenderTexture.get_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x000332A0 File Offset: 0x000314A0
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00008D2D File Offset: 0x00006F2D
		public Color initializationColor
		{
			get
			{
				Color color;
				this.get_initializationColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_initializationColor_Injected(ref value);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00008D37 File Offset: 0x00006F37
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00008D49 File Offset: 0x00006F49
		public CustomRenderTextureUpdateMode updateMode
		{
			get
			{
				return CustomRenderTexture.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00008D5C File Offset: 0x00006F5C
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x00008D6E File Offset: 0x00006F6E
		public CustomRenderTextureUpdateMode initializationMode
		{
			get
			{
				return CustomRenderTexture.get_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00008D81 File Offset: 0x00006F81
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00008D93 File Offset: 0x00006F93
		public CustomRenderTextureUpdateZoneSpace updateZoneSpace
		{
			get
			{
				return CustomRenderTexture.get_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00008DA6 File Offset: 0x00006FA6
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00008DB8 File Offset: 0x00006FB8
		public int shaderPass
		{
			get
			{
				return CustomRenderTexture.get_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00008DCB File Offset: 0x00006FCB
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00008DDD File Offset: 0x00006FDD
		public uint cubemapFaceMask
		{
			get
			{
				return CustomRenderTexture.get_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00008DF0 File Offset: 0x00006FF0
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00008E02 File Offset: 0x00007002
		public bool doubleBuffered
		{
			get
			{
				return CustomRenderTexture.get_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00008E15 File Offset: 0x00007015
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00008E27 File Offset: 0x00007027
		public bool wrapUpdateZones
		{
			get
			{
				return CustomRenderTexture.get_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00008E3A File Offset: 0x0000703A
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00008E4C File Offset: 0x0000704C
		public float updatePeriod
		{
			get
			{
				return CustomRenderTexture.get_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00008E5F File Offset: 0x0000705F
		public void get_initializationColor_Injected(out Color ret)
		{
			CustomRenderTexture.get_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00008E72 File Offset: 0x00007072
		public void set_initializationColor_Injected(ref Color value)
		{
			CustomRenderTexture.set_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000829 RID: 2089
		private static readonly CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate Internal_CreateCustomRenderTextureDelegateField;

		// Token: 0x0400082A RID: 2090
		private static readonly CustomRenderTexture.TriggerUpdateDelegate TriggerUpdateDelegateField;

		// Token: 0x0400082B RID: 2091
		private static readonly CustomRenderTexture.TriggerInitializationDelegate TriggerInitializationDelegateField;

		// Token: 0x0400082C RID: 2092
		private static readonly CustomRenderTexture.ClearUpdateZonesDelegate ClearUpdateZonesDelegateField;

		// Token: 0x0400082D RID: 2093
		private static readonly CustomRenderTexture.get_materialDelegate get_materialDelegateField;

		// Token: 0x0400082E RID: 2094
		private static readonly CustomRenderTexture.set_materialDelegate set_materialDelegateField;

		// Token: 0x0400082F RID: 2095
		private static readonly CustomRenderTexture.get_initializationMaterialDelegate get_initializationMaterialDelegateField;

		// Token: 0x04000830 RID: 2096
		private static readonly CustomRenderTexture.set_initializationMaterialDelegate set_initializationMaterialDelegateField;

		// Token: 0x04000831 RID: 2097
		private static readonly CustomRenderTexture.get_initializationTextureDelegate get_initializationTextureDelegateField;

		// Token: 0x04000832 RID: 2098
		private static readonly CustomRenderTexture.set_initializationTextureDelegate set_initializationTextureDelegateField;

		// Token: 0x04000833 RID: 2099
		private static readonly CustomRenderTexture.GetUpdateZonesInternalDelegate GetUpdateZonesInternalDelegateField;

		// Token: 0x04000834 RID: 2100
		private static readonly CustomRenderTexture.GetDoubleBufferRenderTextureDelegate GetDoubleBufferRenderTextureDelegateField;

		// Token: 0x04000835 RID: 2101
		private static readonly CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate EnsureDoubleBufferConsistencyDelegateField;

		// Token: 0x04000836 RID: 2102
		private static readonly CustomRenderTexture.get_initializationSourceDelegate get_initializationSourceDelegateField;

		// Token: 0x04000837 RID: 2103
		private static readonly CustomRenderTexture.set_initializationSourceDelegate set_initializationSourceDelegateField;

		// Token: 0x04000838 RID: 2104
		private static readonly CustomRenderTexture.get_updateModeDelegate get_updateModeDelegateField;

		// Token: 0x04000839 RID: 2105
		private static readonly CustomRenderTexture.set_updateModeDelegate set_updateModeDelegateField;

		// Token: 0x0400083A RID: 2106
		private static readonly CustomRenderTexture.get_initializationModeDelegate get_initializationModeDelegateField;

		// Token: 0x0400083B RID: 2107
		private static readonly CustomRenderTexture.set_initializationModeDelegate set_initializationModeDelegateField;

		// Token: 0x0400083C RID: 2108
		private static readonly CustomRenderTexture.get_updateZoneSpaceDelegate get_updateZoneSpaceDelegateField;

		// Token: 0x0400083D RID: 2109
		private static readonly CustomRenderTexture.set_updateZoneSpaceDelegate set_updateZoneSpaceDelegateField;

		// Token: 0x0400083E RID: 2110
		private static readonly CustomRenderTexture.get_shaderPassDelegate get_shaderPassDelegateField;

		// Token: 0x0400083F RID: 2111
		private static readonly CustomRenderTexture.set_shaderPassDelegate set_shaderPassDelegateField;

		// Token: 0x04000840 RID: 2112
		private static readonly CustomRenderTexture.get_cubemapFaceMaskDelegate get_cubemapFaceMaskDelegateField;

		// Token: 0x04000841 RID: 2113
		private static readonly CustomRenderTexture.set_cubemapFaceMaskDelegate set_cubemapFaceMaskDelegateField;

		// Token: 0x04000842 RID: 2114
		private static readonly CustomRenderTexture.get_doubleBufferedDelegate get_doubleBufferedDelegateField;

		// Token: 0x04000843 RID: 2115
		private static readonly CustomRenderTexture.set_doubleBufferedDelegate set_doubleBufferedDelegateField;

		// Token: 0x04000844 RID: 2116
		private static readonly CustomRenderTexture.get_wrapUpdateZonesDelegate get_wrapUpdateZonesDelegateField;

		// Token: 0x04000845 RID: 2117
		private static readonly CustomRenderTexture.set_wrapUpdateZonesDelegate set_wrapUpdateZonesDelegateField;

		// Token: 0x04000846 RID: 2118
		private static readonly CustomRenderTexture.get_updatePeriodDelegate get_updatePeriodDelegateField;

		// Token: 0x04000847 RID: 2119
		private static readonly CustomRenderTexture.set_updatePeriodDelegate set_updatePeriodDelegateField;

		// Token: 0x04000848 RID: 2120
		private static readonly CustomRenderTexture.get_initializationColor_InjectedDelegate get_initializationColor_InjectedDelegateField;

		// Token: 0x04000849 RID: 2121
		private static readonly CustomRenderTexture.set_initializationColor_InjectedDelegate set_initializationColor_InjectedDelegateField;

		// Token: 0x02000716 RID: 1814
		// (Invoke) Token: 0x06002BEF RID: 11247
		private delegate void Internal_CreateCustomRenderTextureDelegate(IntPtr rt);

		// Token: 0x02000717 RID: 1815
		// (Invoke) Token: 0x06002BF1 RID: 11249
		private delegate void TriggerUpdateDelegate(IntPtr @this, int count);

		// Token: 0x02000718 RID: 1816
		// (Invoke) Token: 0x06002BF3 RID: 11251
		private delegate void TriggerInitializationDelegate(IntPtr @this);

		// Token: 0x02000719 RID: 1817
		// (Invoke) Token: 0x06002BF5 RID: 11253
		private delegate void ClearUpdateZonesDelegate(IntPtr @this);

		// Token: 0x0200071A RID: 1818
		// (Invoke) Token: 0x06002BF7 RID: 11255
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x0200071B RID: 1819
		// (Invoke) Token: 0x06002BF9 RID: 11257
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200071C RID: 1820
		// (Invoke) Token: 0x06002BFB RID: 11259
		private delegate IntPtr get_initializationMaterialDelegate(IntPtr @this);

		// Token: 0x0200071D RID: 1821
		// (Invoke) Token: 0x06002BFD RID: 11261
		private delegate void set_initializationMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200071E RID: 1822
		// (Invoke) Token: 0x06002BFF RID: 11263
		private delegate IntPtr get_initializationTextureDelegate(IntPtr @this);

		// Token: 0x0200071F RID: 1823
		// (Invoke) Token: 0x06002C01 RID: 11265
		private delegate void set_initializationTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000720 RID: 1824
		// (Invoke) Token: 0x06002C03 RID: 11267
		private delegate void GetUpdateZonesInternalDelegate(IntPtr @this, IntPtr updateZones);

		// Token: 0x02000721 RID: 1825
		// (Invoke) Token: 0x06002C05 RID: 11269
		private delegate IntPtr GetDoubleBufferRenderTextureDelegate(IntPtr @this);

		// Token: 0x02000722 RID: 1826
		// (Invoke) Token: 0x06002C07 RID: 11271
		private delegate void EnsureDoubleBufferConsistencyDelegate(IntPtr @this);

		// Token: 0x02000723 RID: 1827
		// (Invoke) Token: 0x06002C09 RID: 11273
		private delegate CustomRenderTextureInitializationSource get_initializationSourceDelegate(IntPtr @this);

		// Token: 0x02000724 RID: 1828
		// (Invoke) Token: 0x06002C0B RID: 11275
		private delegate void set_initializationSourceDelegate(IntPtr @this, CustomRenderTextureInitializationSource value);

		// Token: 0x02000725 RID: 1829
		// (Invoke) Token: 0x06002C0D RID: 11277
		private delegate CustomRenderTextureUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x02000726 RID: 1830
		// (Invoke) Token: 0x06002C0F RID: 11279
		private delegate void set_updateModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x02000727 RID: 1831
		// (Invoke) Token: 0x06002C11 RID: 11281
		private delegate CustomRenderTextureUpdateMode get_initializationModeDelegate(IntPtr @this);

		// Token: 0x02000728 RID: 1832
		// (Invoke) Token: 0x06002C13 RID: 11283
		private delegate void set_initializationModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x02000729 RID: 1833
		// (Invoke) Token: 0x06002C15 RID: 11285
		private delegate CustomRenderTextureUpdateZoneSpace get_updateZoneSpaceDelegate(IntPtr @this);

		// Token: 0x0200072A RID: 1834
		// (Invoke) Token: 0x06002C17 RID: 11287
		private delegate void set_updateZoneSpaceDelegate(IntPtr @this, CustomRenderTextureUpdateZoneSpace value);

		// Token: 0x0200072B RID: 1835
		// (Invoke) Token: 0x06002C19 RID: 11289
		private delegate int get_shaderPassDelegate(IntPtr @this);

		// Token: 0x0200072C RID: 1836
		// (Invoke) Token: 0x06002C1B RID: 11291
		private delegate void set_shaderPassDelegate(IntPtr @this, int value);

		// Token: 0x0200072D RID: 1837
		// (Invoke) Token: 0x06002C1D RID: 11293
		private delegate uint get_cubemapFaceMaskDelegate(IntPtr @this);

		// Token: 0x0200072E RID: 1838
		// (Invoke) Token: 0x06002C1F RID: 11295
		private delegate void set_cubemapFaceMaskDelegate(IntPtr @this, uint value);

		// Token: 0x0200072F RID: 1839
		// (Invoke) Token: 0x06002C21 RID: 11297
		private delegate bool get_doubleBufferedDelegate(IntPtr @this);

		// Token: 0x02000730 RID: 1840
		// (Invoke) Token: 0x06002C23 RID: 11299
		private delegate void set_doubleBufferedDelegate(IntPtr @this, bool value);

		// Token: 0x02000731 RID: 1841
		// (Invoke) Token: 0x06002C25 RID: 11301
		private delegate bool get_wrapUpdateZonesDelegate(IntPtr @this);

		// Token: 0x02000732 RID: 1842
		// (Invoke) Token: 0x06002C27 RID: 11303
		private delegate void set_wrapUpdateZonesDelegate(IntPtr @this, bool value);

		// Token: 0x02000733 RID: 1843
		// (Invoke) Token: 0x06002C29 RID: 11305
		private delegate float get_updatePeriodDelegate(IntPtr @this);

		// Token: 0x02000734 RID: 1844
		// (Invoke) Token: 0x06002C2B RID: 11307
		private delegate void set_updatePeriodDelegate(IntPtr @this, float value);

		// Token: 0x02000735 RID: 1845
		// (Invoke) Token: 0x06002C2D RID: 11309
		private delegate void get_initializationColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000736 RID: 1846
		// (Invoke) Token: 0x06002C2F RID: 11311
		private delegate void set_initializationColor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
