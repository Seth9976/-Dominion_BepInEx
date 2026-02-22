using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000054 RID: 84
	public sealed class RenderSettings : Object
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x00025DB0 File Offset: 0x00023FB0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderSettings()
		{
			Il2CppClassPointerStore<RenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr);
			RenderSettings.get_fogDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogDelegate>("UnityEngine.RenderSettings::get_fog");
			RenderSettings.set_fogDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogDelegate>("UnityEngine.RenderSettings::set_fog");
			RenderSettings.get_fogStartDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogStartDistanceDelegate>("UnityEngine.RenderSettings::get_fogStartDistance");
			RenderSettings.set_fogStartDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogStartDistanceDelegate>("UnityEngine.RenderSettings::set_fogStartDistance");
			RenderSettings.get_fogEndDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogEndDistanceDelegate>("UnityEngine.RenderSettings::get_fogEndDistance");
			RenderSettings.set_fogEndDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogEndDistanceDelegate>("UnityEngine.RenderSettings::set_fogEndDistance");
			RenderSettings.get_fogModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogModeDelegate>("UnityEngine.RenderSettings::get_fogMode");
			RenderSettings.set_fogModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogModeDelegate>("UnityEngine.RenderSettings::set_fogMode");
			RenderSettings.get_fogDensityDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogDensityDelegate>("UnityEngine.RenderSettings::get_fogDensity");
			RenderSettings.set_fogDensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogDensityDelegate>("UnityEngine.RenderSettings::set_fogDensity");
			RenderSettings.get_ambientModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientModeDelegate>("UnityEngine.RenderSettings::get_ambientMode");
			RenderSettings.set_ambientModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientModeDelegate>("UnityEngine.RenderSettings::set_ambientMode");
			RenderSettings.get_ambientIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientIntensityDelegate>("UnityEngine.RenderSettings::get_ambientIntensity");
			RenderSettings.set_ambientIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientIntensityDelegate>("UnityEngine.RenderSettings::set_ambientIntensity");
			RenderSettings.get_skyboxDelegateField = IL2CPP.ResolveICall<RenderSettings.get_skyboxDelegate>("UnityEngine.RenderSettings::get_skybox");
			RenderSettings.set_skyboxDelegateField = IL2CPP.ResolveICall<RenderSettings.set_skyboxDelegate>("UnityEngine.RenderSettings::set_skybox");
			RenderSettings.get_sunDelegateField = IL2CPP.ResolveICall<RenderSettings.get_sunDelegate>("UnityEngine.RenderSettings::get_sun");
			RenderSettings.set_sunDelegateField = IL2CPP.ResolveICall<RenderSettings.set_sunDelegate>("UnityEngine.RenderSettings::set_sun");
			RenderSettings.get_customReflectionDelegateField = IL2CPP.ResolveICall<RenderSettings.get_customReflectionDelegate>("UnityEngine.RenderSettings::get_customReflection");
			RenderSettings.set_customReflectionDelegateField = IL2CPP.ResolveICall<RenderSettings.set_customReflectionDelegate>("UnityEngine.RenderSettings::set_customReflection");
			RenderSettings.get_reflectionIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.get_reflectionIntensityDelegate>("UnityEngine.RenderSettings::get_reflectionIntensity");
			RenderSettings.set_reflectionIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_reflectionIntensityDelegate>("UnityEngine.RenderSettings::set_reflectionIntensity");
			RenderSettings.get_reflectionBouncesDelegateField = IL2CPP.ResolveICall<RenderSettings.get_reflectionBouncesDelegate>("UnityEngine.RenderSettings::get_reflectionBounces");
			RenderSettings.set_reflectionBouncesDelegateField = IL2CPP.ResolveICall<RenderSettings.set_reflectionBouncesDelegate>("UnityEngine.RenderSettings::set_reflectionBounces");
			RenderSettings.get_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::get_defaultReflectionMode");
			RenderSettings.set_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::set_defaultReflectionMode");
			RenderSettings.get_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<RenderSettings.get_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::get_defaultReflectionResolution");
			RenderSettings.set_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<RenderSettings.set_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::set_defaultReflectionResolution");
			RenderSettings.get_haloStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.get_haloStrengthDelegate>("UnityEngine.RenderSettings::get_haloStrength");
			RenderSettings.set_haloStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.set_haloStrengthDelegate>("UnityEngine.RenderSettings::set_haloStrength");
			RenderSettings.get_flareStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.get_flareStrengthDelegate>("UnityEngine.RenderSettings::get_flareStrength");
			RenderSettings.set_flareStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.set_flareStrengthDelegate>("UnityEngine.RenderSettings::set_flareStrength");
			RenderSettings.get_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::get_flareFadeSpeed");
			RenderSettings.set_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::set_flareFadeSpeed");
			RenderSettings.GetRenderSettingsDelegateField = IL2CPP.ResolveICall<RenderSettings.GetRenderSettingsDelegate>("UnityEngine.RenderSettings::GetRenderSettings");
			RenderSettings.ResetDelegateField = IL2CPP.ResolveICall<RenderSettings.ResetDelegate>("UnityEngine.RenderSettings::Reset");
			RenderSettings.get_fogColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogColor_InjectedDelegate>("UnityEngine.RenderSettings::get_fogColor_Injected");
			RenderSettings.set_fogColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogColor_InjectedDelegate>("UnityEngine.RenderSettings::set_fogColor_Injected");
			RenderSettings.get_ambientSkyColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientSkyColor_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientSkyColor_Injected");
			RenderSettings.set_ambientSkyColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientSkyColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientSkyColor_Injected");
			RenderSettings.get_ambientEquatorColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientEquatorColor_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientEquatorColor_Injected");
			RenderSettings.set_ambientEquatorColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientEquatorColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientEquatorColor_Injected");
			RenderSettings.get_ambientGroundColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientGroundColor_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientGroundColor_Injected");
			RenderSettings.set_ambientGroundColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientGroundColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientGroundColor_Injected");
			RenderSettings.get_ambientLight_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientLight_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientLight_Injected");
			RenderSettings.set_ambientLight_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientLight_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientLight_Injected");
			RenderSettings.get_subtractiveShadowColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_subtractiveShadowColor_InjectedDelegate>("UnityEngine.RenderSettings::get_subtractiveShadowColor_Injected");
			RenderSettings.set_subtractiveShadowColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_subtractiveShadowColor_InjectedDelegate>("UnityEngine.RenderSettings::set_subtractiveShadowColor_Injected");
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00005F84 File Offset: 0x00004184
		public RenderSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000260B0 File Offset: 0x000242B0
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00005F8D File Offset: 0x0000418D
		public static float ambientSkyboxAmount
		{
			get
			{
				return RenderSettings.ambientIntensity;
			}
			set
			{
				RenderSettings.ambientIntensity = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00005F97 File Offset: 0x00004197
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00005FA3 File Offset: 0x000041A3
		public static bool fog
		{
			get
			{
				return RenderSettings.get_fogDelegateField();
			}
			set
			{
				RenderSettings.set_fogDelegateField(value);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00005FB0 File Offset: 0x000041B0
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00005FBC File Offset: 0x000041BC
		public static float fogStartDistance
		{
			get
			{
				return RenderSettings.get_fogStartDistanceDelegateField();
			}
			set
			{
				RenderSettings.set_fogStartDistanceDelegateField(value);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00005FC9 File Offset: 0x000041C9
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00005FD5 File Offset: 0x000041D5
		public static float fogEndDistance
		{
			get
			{
				return RenderSettings.get_fogEndDistanceDelegateField();
			}
			set
			{
				RenderSettings.set_fogEndDistanceDelegateField(value);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00005FE2 File Offset: 0x000041E2
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00005FEE File Offset: 0x000041EE
		public static FogMode fogMode
		{
			get
			{
				return RenderSettings.get_fogModeDelegateField();
			}
			set
			{
				RenderSettings.set_fogModeDelegateField(value);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x000260C8 File Offset: 0x000242C8
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00005FFB File Offset: 0x000041FB
		public static Color fogColor
		{
			get
			{
				Color color;
				RenderSettings.get_fogColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_fogColor_Injected(ref value);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00006004 File Offset: 0x00004204
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00006010 File Offset: 0x00004210
		public static float fogDensity
		{
			get
			{
				return RenderSettings.get_fogDensityDelegateField();
			}
			set
			{
				RenderSettings.set_fogDensityDelegateField(value);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0000601D File Offset: 0x0000421D
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00006029 File Offset: 0x00004229
		public static UnityEngine.Rendering.AmbientMode ambientMode
		{
			get
			{
				return RenderSettings.get_ambientModeDelegateField();
			}
			set
			{
				RenderSettings.set_ambientModeDelegateField(value);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000260E0 File Offset: 0x000242E0
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00006036 File Offset: 0x00004236
		public static Color ambientSkyColor
		{
			get
			{
				Color color;
				RenderSettings.get_ambientSkyColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientSkyColor_Injected(ref value);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000260F8 File Offset: 0x000242F8
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0000603F File Offset: 0x0000423F
		public static Color ambientEquatorColor
		{
			get
			{
				Color color;
				RenderSettings.get_ambientEquatorColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientEquatorColor_Injected(ref value);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00026110 File Offset: 0x00024310
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00006048 File Offset: 0x00004248
		public static Color ambientGroundColor
		{
			get
			{
				Color color;
				RenderSettings.get_ambientGroundColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientGroundColor_Injected(ref value);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00006051 File Offset: 0x00004251
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x0000605D File Offset: 0x0000425D
		public static float ambientIntensity
		{
			get
			{
				return RenderSettings.get_ambientIntensityDelegateField();
			}
			set
			{
				RenderSettings.set_ambientIntensityDelegateField(value);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00026128 File Offset: 0x00024328
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x0000606A File Offset: 0x0000426A
		public static Color ambientLight
		{
			get
			{
				Color color;
				RenderSettings.get_ambientLight_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientLight_Injected(ref value);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00026140 File Offset: 0x00024340
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00006073 File Offset: 0x00004273
		public static Color subtractiveShadowColor
		{
			get
			{
				Color color;
				RenderSettings.get_subtractiveShadowColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_subtractiveShadowColor_Injected(ref value);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00026158 File Offset: 0x00024358
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x0000607C File Offset: 0x0000427C
		public static Material skybox
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_skyboxDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				RenderSettings.set_skyboxDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00026180 File Offset: 0x00024380
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x0000608E File Offset: 0x0000428E
		public static Light sun
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_sunDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				RenderSettings.set_sunDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x000261A8 File Offset: 0x000243A8
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x000060A0 File Offset: 0x000042A0
		public static Cubemap customReflection
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_customReflectionDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				RenderSettings.set_customReflectionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x000060B2 File Offset: 0x000042B2
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x000060BE File Offset: 0x000042BE
		public static float reflectionIntensity
		{
			get
			{
				return RenderSettings.get_reflectionIntensityDelegateField();
			}
			set
			{
				RenderSettings.set_reflectionIntensityDelegateField(value);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000060CB File Offset: 0x000042CB
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x000060D7 File Offset: 0x000042D7
		public static int reflectionBounces
		{
			get
			{
				return RenderSettings.get_reflectionBouncesDelegateField();
			}
			set
			{
				RenderSettings.set_reflectionBouncesDelegateField(value);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x000060E4 File Offset: 0x000042E4
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x000060F0 File Offset: 0x000042F0
		public static UnityEngine.Rendering.DefaultReflectionMode defaultReflectionMode
		{
			get
			{
				return RenderSettings.get_defaultReflectionModeDelegateField();
			}
			set
			{
				RenderSettings.set_defaultReflectionModeDelegateField(value);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x000060FD File Offset: 0x000042FD
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00006109 File Offset: 0x00004309
		public static int defaultReflectionResolution
		{
			get
			{
				return RenderSettings.get_defaultReflectionResolutionDelegateField();
			}
			set
			{
				RenderSettings.set_defaultReflectionResolutionDelegateField(value);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00006116 File Offset: 0x00004316
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00006122 File Offset: 0x00004322
		public static float haloStrength
		{
			get
			{
				return RenderSettings.get_haloStrengthDelegateField();
			}
			set
			{
				RenderSettings.set_haloStrengthDelegateField(value);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0000612F File Offset: 0x0000432F
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x0000613B File Offset: 0x0000433B
		public static float flareStrength
		{
			get
			{
				return RenderSettings.get_flareStrengthDelegateField();
			}
			set
			{
				RenderSettings.set_flareStrengthDelegateField(value);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00006148 File Offset: 0x00004348
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00006154 File Offset: 0x00004354
		public static float flareFadeSpeed
		{
			get
			{
				return RenderSettings.get_flareFadeSpeedDelegateField();
			}
			set
			{
				RenderSettings.set_flareFadeSpeedDelegateField(value);
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000261D0 File Offset: 0x000243D0
		public static Object GetRenderSettings()
		{
			IntPtr intPtr = RenderSettings.GetRenderSettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00006161 File Offset: 0x00004361
		public static void Reset()
		{
			RenderSettings.ResetDelegateField();
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000616D File Offset: 0x0000436D
		public static void get_fogColor_Injected(out Color ret)
		{
			RenderSettings.get_fogColor_InjectedDelegateField(out ret);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000617A File Offset: 0x0000437A
		public static void set_fogColor_Injected(ref Color value)
		{
			RenderSettings.set_fogColor_InjectedDelegateField(ref value);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00006187 File Offset: 0x00004387
		public static void get_ambientSkyColor_Injected(out Color ret)
		{
			RenderSettings.get_ambientSkyColor_InjectedDelegateField(out ret);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00006194 File Offset: 0x00004394
		public static void set_ambientSkyColor_Injected(ref Color value)
		{
			RenderSettings.set_ambientSkyColor_InjectedDelegateField(ref value);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000061A1 File Offset: 0x000043A1
		public static void get_ambientEquatorColor_Injected(out Color ret)
		{
			RenderSettings.get_ambientEquatorColor_InjectedDelegateField(out ret);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000061AE File Offset: 0x000043AE
		public static void set_ambientEquatorColor_Injected(ref Color value)
		{
			RenderSettings.set_ambientEquatorColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000061BB File Offset: 0x000043BB
		public static void get_ambientGroundColor_Injected(out Color ret)
		{
			RenderSettings.get_ambientGroundColor_InjectedDelegateField(out ret);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000061C8 File Offset: 0x000043C8
		public static void set_ambientGroundColor_Injected(ref Color value)
		{
			RenderSettings.set_ambientGroundColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000061D5 File Offset: 0x000043D5
		public static void get_ambientLight_Injected(out Color ret)
		{
			RenderSettings.get_ambientLight_InjectedDelegateField(out ret);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000061E2 File Offset: 0x000043E2
		public static void set_ambientLight_Injected(ref Color value)
		{
			RenderSettings.set_ambientLight_InjectedDelegateField(ref value);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000061EF File Offset: 0x000043EF
		public static void get_subtractiveShadowColor_Injected(out Color ret)
		{
			RenderSettings.get_subtractiveShadowColor_InjectedDelegateField(out ret);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000061FC File Offset: 0x000043FC
		public static void set_subtractiveShadowColor_Injected(ref Color value)
		{
			RenderSettings.set_subtractiveShadowColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0400046A RID: 1130
		private static readonly RenderSettings.get_fogDelegate get_fogDelegateField;

		// Token: 0x0400046B RID: 1131
		private static readonly RenderSettings.set_fogDelegate set_fogDelegateField;

		// Token: 0x0400046C RID: 1132
		private static readonly RenderSettings.get_fogStartDistanceDelegate get_fogStartDistanceDelegateField;

		// Token: 0x0400046D RID: 1133
		private static readonly RenderSettings.set_fogStartDistanceDelegate set_fogStartDistanceDelegateField;

		// Token: 0x0400046E RID: 1134
		private static readonly RenderSettings.get_fogEndDistanceDelegate get_fogEndDistanceDelegateField;

		// Token: 0x0400046F RID: 1135
		private static readonly RenderSettings.set_fogEndDistanceDelegate set_fogEndDistanceDelegateField;

		// Token: 0x04000470 RID: 1136
		private static readonly RenderSettings.get_fogModeDelegate get_fogModeDelegateField;

		// Token: 0x04000471 RID: 1137
		private static readonly RenderSettings.set_fogModeDelegate set_fogModeDelegateField;

		// Token: 0x04000472 RID: 1138
		private static readonly RenderSettings.get_fogDensityDelegate get_fogDensityDelegateField;

		// Token: 0x04000473 RID: 1139
		private static readonly RenderSettings.set_fogDensityDelegate set_fogDensityDelegateField;

		// Token: 0x04000474 RID: 1140
		private static readonly RenderSettings.get_ambientModeDelegate get_ambientModeDelegateField;

		// Token: 0x04000475 RID: 1141
		private static readonly RenderSettings.set_ambientModeDelegate set_ambientModeDelegateField;

		// Token: 0x04000476 RID: 1142
		private static readonly RenderSettings.get_ambientIntensityDelegate get_ambientIntensityDelegateField;

		// Token: 0x04000477 RID: 1143
		private static readonly RenderSettings.set_ambientIntensityDelegate set_ambientIntensityDelegateField;

		// Token: 0x04000478 RID: 1144
		private static readonly RenderSettings.get_skyboxDelegate get_skyboxDelegateField;

		// Token: 0x04000479 RID: 1145
		private static readonly RenderSettings.set_skyboxDelegate set_skyboxDelegateField;

		// Token: 0x0400047A RID: 1146
		private static readonly RenderSettings.get_sunDelegate get_sunDelegateField;

		// Token: 0x0400047B RID: 1147
		private static readonly RenderSettings.set_sunDelegate set_sunDelegateField;

		// Token: 0x0400047C RID: 1148
		private static readonly RenderSettings.get_customReflectionDelegate get_customReflectionDelegateField;

		// Token: 0x0400047D RID: 1149
		private static readonly RenderSettings.set_customReflectionDelegate set_customReflectionDelegateField;

		// Token: 0x0400047E RID: 1150
		private static readonly RenderSettings.get_reflectionIntensityDelegate get_reflectionIntensityDelegateField;

		// Token: 0x0400047F RID: 1151
		private static readonly RenderSettings.set_reflectionIntensityDelegate set_reflectionIntensityDelegateField;

		// Token: 0x04000480 RID: 1152
		private static readonly RenderSettings.get_reflectionBouncesDelegate get_reflectionBouncesDelegateField;

		// Token: 0x04000481 RID: 1153
		private static readonly RenderSettings.set_reflectionBouncesDelegate set_reflectionBouncesDelegateField;

		// Token: 0x04000482 RID: 1154
		private static readonly RenderSettings.get_defaultReflectionModeDelegate get_defaultReflectionModeDelegateField;

		// Token: 0x04000483 RID: 1155
		private static readonly RenderSettings.set_defaultReflectionModeDelegate set_defaultReflectionModeDelegateField;

		// Token: 0x04000484 RID: 1156
		private static readonly RenderSettings.get_defaultReflectionResolutionDelegate get_defaultReflectionResolutionDelegateField;

		// Token: 0x04000485 RID: 1157
		private static readonly RenderSettings.set_defaultReflectionResolutionDelegate set_defaultReflectionResolutionDelegateField;

		// Token: 0x04000486 RID: 1158
		private static readonly RenderSettings.get_haloStrengthDelegate get_haloStrengthDelegateField;

		// Token: 0x04000487 RID: 1159
		private static readonly RenderSettings.set_haloStrengthDelegate set_haloStrengthDelegateField;

		// Token: 0x04000488 RID: 1160
		private static readonly RenderSettings.get_flareStrengthDelegate get_flareStrengthDelegateField;

		// Token: 0x04000489 RID: 1161
		private static readonly RenderSettings.set_flareStrengthDelegate set_flareStrengthDelegateField;

		// Token: 0x0400048A RID: 1162
		private static readonly RenderSettings.get_flareFadeSpeedDelegate get_flareFadeSpeedDelegateField;

		// Token: 0x0400048B RID: 1163
		private static readonly RenderSettings.set_flareFadeSpeedDelegate set_flareFadeSpeedDelegateField;

		// Token: 0x0400048C RID: 1164
		private static readonly RenderSettings.GetRenderSettingsDelegate GetRenderSettingsDelegateField;

		// Token: 0x0400048D RID: 1165
		private static readonly RenderSettings.ResetDelegate ResetDelegateField;

		// Token: 0x0400048E RID: 1166
		private static readonly RenderSettings.get_fogColor_InjectedDelegate get_fogColor_InjectedDelegateField;

		// Token: 0x0400048F RID: 1167
		private static readonly RenderSettings.set_fogColor_InjectedDelegate set_fogColor_InjectedDelegateField;

		// Token: 0x04000490 RID: 1168
		private static readonly RenderSettings.get_ambientSkyColor_InjectedDelegate get_ambientSkyColor_InjectedDelegateField;

		// Token: 0x04000491 RID: 1169
		private static readonly RenderSettings.set_ambientSkyColor_InjectedDelegate set_ambientSkyColor_InjectedDelegateField;

		// Token: 0x04000492 RID: 1170
		private static readonly RenderSettings.get_ambientEquatorColor_InjectedDelegate get_ambientEquatorColor_InjectedDelegateField;

		// Token: 0x04000493 RID: 1171
		private static readonly RenderSettings.set_ambientEquatorColor_InjectedDelegate set_ambientEquatorColor_InjectedDelegateField;

		// Token: 0x04000494 RID: 1172
		private static readonly RenderSettings.get_ambientGroundColor_InjectedDelegate get_ambientGroundColor_InjectedDelegateField;

		// Token: 0x04000495 RID: 1173
		private static readonly RenderSettings.set_ambientGroundColor_InjectedDelegate set_ambientGroundColor_InjectedDelegateField;

		// Token: 0x04000496 RID: 1174
		private static readonly RenderSettings.get_ambientLight_InjectedDelegate get_ambientLight_InjectedDelegateField;

		// Token: 0x04000497 RID: 1175
		private static readonly RenderSettings.set_ambientLight_InjectedDelegate set_ambientLight_InjectedDelegateField;

		// Token: 0x04000498 RID: 1176
		private static readonly RenderSettings.get_subtractiveShadowColor_InjectedDelegate get_subtractiveShadowColor_InjectedDelegateField;

		// Token: 0x04000499 RID: 1177
		private static readonly RenderSettings.set_subtractiveShadowColor_InjectedDelegate set_subtractiveShadowColor_InjectedDelegateField;

		// Token: 0x02000521 RID: 1313
		// (Invoke) Token: 0x06002811 RID: 10257
		private delegate bool get_fogDelegate();

		// Token: 0x02000522 RID: 1314
		// (Invoke) Token: 0x06002813 RID: 10259
		private delegate void set_fogDelegate(bool value);

		// Token: 0x02000523 RID: 1315
		// (Invoke) Token: 0x06002815 RID: 10261
		private delegate float get_fogStartDistanceDelegate();

		// Token: 0x02000524 RID: 1316
		// (Invoke) Token: 0x06002817 RID: 10263
		private delegate void set_fogStartDistanceDelegate(float value);

		// Token: 0x02000525 RID: 1317
		// (Invoke) Token: 0x06002819 RID: 10265
		private delegate float get_fogEndDistanceDelegate();

		// Token: 0x02000526 RID: 1318
		// (Invoke) Token: 0x0600281B RID: 10267
		private delegate void set_fogEndDistanceDelegate(float value);

		// Token: 0x02000527 RID: 1319
		// (Invoke) Token: 0x0600281D RID: 10269
		private delegate FogMode get_fogModeDelegate();

		// Token: 0x02000528 RID: 1320
		// (Invoke) Token: 0x0600281F RID: 10271
		private delegate void set_fogModeDelegate(FogMode value);

		// Token: 0x02000529 RID: 1321
		// (Invoke) Token: 0x06002821 RID: 10273
		private delegate float get_fogDensityDelegate();

		// Token: 0x0200052A RID: 1322
		// (Invoke) Token: 0x06002823 RID: 10275
		private delegate void set_fogDensityDelegate(float value);

		// Token: 0x0200052B RID: 1323
		// (Invoke) Token: 0x06002825 RID: 10277
		private delegate UnityEngine.Rendering.AmbientMode get_ambientModeDelegate();

		// Token: 0x0200052C RID: 1324
		// (Invoke) Token: 0x06002827 RID: 10279
		private delegate void set_ambientModeDelegate(UnityEngine.Rendering.AmbientMode value);

		// Token: 0x0200052D RID: 1325
		// (Invoke) Token: 0x06002829 RID: 10281
		private delegate float get_ambientIntensityDelegate();

		// Token: 0x0200052E RID: 1326
		// (Invoke) Token: 0x0600282B RID: 10283
		private delegate void set_ambientIntensityDelegate(float value);

		// Token: 0x0200052F RID: 1327
		// (Invoke) Token: 0x0600282D RID: 10285
		private delegate IntPtr get_skyboxDelegate();

		// Token: 0x02000530 RID: 1328
		// (Invoke) Token: 0x0600282F RID: 10287
		private delegate void set_skyboxDelegate(IntPtr value);

		// Token: 0x02000531 RID: 1329
		// (Invoke) Token: 0x06002831 RID: 10289
		private delegate IntPtr get_sunDelegate();

		// Token: 0x02000532 RID: 1330
		// (Invoke) Token: 0x06002833 RID: 10291
		private delegate void set_sunDelegate(IntPtr value);

		// Token: 0x02000533 RID: 1331
		// (Invoke) Token: 0x06002835 RID: 10293
		private delegate IntPtr get_customReflectionDelegate();

		// Token: 0x02000534 RID: 1332
		// (Invoke) Token: 0x06002837 RID: 10295
		private delegate void set_customReflectionDelegate(IntPtr value);

		// Token: 0x02000535 RID: 1333
		// (Invoke) Token: 0x06002839 RID: 10297
		private delegate float get_reflectionIntensityDelegate();

		// Token: 0x02000536 RID: 1334
		// (Invoke) Token: 0x0600283B RID: 10299
		private delegate void set_reflectionIntensityDelegate(float value);

		// Token: 0x02000537 RID: 1335
		// (Invoke) Token: 0x0600283D RID: 10301
		private delegate int get_reflectionBouncesDelegate();

		// Token: 0x02000538 RID: 1336
		// (Invoke) Token: 0x0600283F RID: 10303
		private delegate void set_reflectionBouncesDelegate(int value);

		// Token: 0x02000539 RID: 1337
		// (Invoke) Token: 0x06002841 RID: 10305
		private delegate UnityEngine.Rendering.DefaultReflectionMode get_defaultReflectionModeDelegate();

		// Token: 0x0200053A RID: 1338
		// (Invoke) Token: 0x06002843 RID: 10307
		private delegate void set_defaultReflectionModeDelegate(UnityEngine.Rendering.DefaultReflectionMode value);

		// Token: 0x0200053B RID: 1339
		// (Invoke) Token: 0x06002845 RID: 10309
		private delegate int get_defaultReflectionResolutionDelegate();

		// Token: 0x0200053C RID: 1340
		// (Invoke) Token: 0x06002847 RID: 10311
		private delegate void set_defaultReflectionResolutionDelegate(int value);

		// Token: 0x0200053D RID: 1341
		// (Invoke) Token: 0x06002849 RID: 10313
		private delegate float get_haloStrengthDelegate();

		// Token: 0x0200053E RID: 1342
		// (Invoke) Token: 0x0600284B RID: 10315
		private delegate void set_haloStrengthDelegate(float value);

		// Token: 0x0200053F RID: 1343
		// (Invoke) Token: 0x0600284D RID: 10317
		private delegate float get_flareStrengthDelegate();

		// Token: 0x02000540 RID: 1344
		// (Invoke) Token: 0x0600284F RID: 10319
		private delegate void set_flareStrengthDelegate(float value);

		// Token: 0x02000541 RID: 1345
		// (Invoke) Token: 0x06002851 RID: 10321
		private delegate float get_flareFadeSpeedDelegate();

		// Token: 0x02000542 RID: 1346
		// (Invoke) Token: 0x06002853 RID: 10323
		private delegate void set_flareFadeSpeedDelegate(float value);

		// Token: 0x02000543 RID: 1347
		// (Invoke) Token: 0x06002855 RID: 10325
		private delegate IntPtr GetRenderSettingsDelegate();

		// Token: 0x02000544 RID: 1348
		// (Invoke) Token: 0x06002857 RID: 10327
		private delegate void ResetDelegate();

		// Token: 0x02000545 RID: 1349
		// (Invoke) Token: 0x06002859 RID: 10329
		private delegate void get_fogColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000546 RID: 1350
		// (Invoke) Token: 0x0600285B RID: 10331
		private delegate void set_fogColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000547 RID: 1351
		// (Invoke) Token: 0x0600285D RID: 10333
		private delegate void get_ambientSkyColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000548 RID: 1352
		// (Invoke) Token: 0x0600285F RID: 10335
		private delegate void set_ambientSkyColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000549 RID: 1353
		// (Invoke) Token: 0x06002861 RID: 10337
		private delegate void get_ambientEquatorColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200054A RID: 1354
		// (Invoke) Token: 0x06002863 RID: 10339
		private delegate void set_ambientEquatorColor_InjectedDelegate(IntPtr value);

		// Token: 0x0200054B RID: 1355
		// (Invoke) Token: 0x06002865 RID: 10341
		private delegate void get_ambientGroundColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200054C RID: 1356
		// (Invoke) Token: 0x06002867 RID: 10343
		private delegate void set_ambientGroundColor_InjectedDelegate(IntPtr value);

		// Token: 0x0200054D RID: 1357
		// (Invoke) Token: 0x06002869 RID: 10345
		private delegate void get_ambientLight_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200054E RID: 1358
		// (Invoke) Token: 0x0600286B RID: 10347
		private delegate void set_ambientLight_InjectedDelegate(IntPtr value);

		// Token: 0x0200054F RID: 1359
		// (Invoke) Token: 0x0600286D RID: 10349
		private delegate void get_subtractiveShadowColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000550 RID: 1360
		// (Invoke) Token: 0x0600286F RID: 10351
		private delegate void set_subtractiveShadowColor_InjectedDelegate(IntPtr value);
	}
}
