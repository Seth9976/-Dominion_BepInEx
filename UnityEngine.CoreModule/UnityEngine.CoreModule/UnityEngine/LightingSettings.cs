using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000047 RID: 71
	public sealed class LightingSettings : Object
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		// Note: this type is marked as 'beforefieldinit'.
		static LightingSettings()
		{
			Il2CppClassPointerStore<LightingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr);
			LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100663574);
			LightingSettings.Internal_CreateDelegateField = IL2CPP.ResolveICall<LightingSettings.Internal_CreateDelegate>("UnityEngine.LightingSettings::Internal_Create");
			LightingSettings.get_bakedGIDelegateField = IL2CPP.ResolveICall<LightingSettings.get_bakedGIDelegate>("UnityEngine.LightingSettings::get_bakedGI");
			LightingSettings.set_bakedGIDelegateField = IL2CPP.ResolveICall<LightingSettings.set_bakedGIDelegate>("UnityEngine.LightingSettings::set_bakedGI");
			LightingSettings.get_realtimeGIDelegateField = IL2CPP.ResolveICall<LightingSettings.get_realtimeGIDelegate>("UnityEngine.LightingSettings::get_realtimeGI");
			LightingSettings.set_realtimeGIDelegateField = IL2CPP.ResolveICall<LightingSettings.set_realtimeGIDelegate>("UnityEngine.LightingSettings::set_realtimeGI");
			LightingSettings.get_realtimeEnvironmentLightingDelegateField = IL2CPP.ResolveICall<LightingSettings.get_realtimeEnvironmentLightingDelegate>("UnityEngine.LightingSettings::get_realtimeEnvironmentLighting");
			LightingSettings.set_realtimeEnvironmentLightingDelegateField = IL2CPP.ResolveICall<LightingSettings.set_realtimeEnvironmentLightingDelegate>("UnityEngine.LightingSettings::set_realtimeEnvironmentLighting");
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightingSettingsDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public LightingSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00004BA9 File Offset: 0x00002DA9
		public static void Internal_Create(LightingSettings self)
		{
			LightingSettings.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00004BBB File Offset: 0x00002DBB
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00004BCD File Offset: 0x00002DCD
		public bool bakedGI
		{
			get
			{
				return LightingSettings.get_bakedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_bakedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00004BE0 File Offset: 0x00002DE0
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00004BF2 File Offset: 0x00002DF2
		public bool realtimeGI
		{
			get
			{
				return LightingSettings.get_realtimeGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_realtimeGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00004C05 File Offset: 0x00002E05
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00004C17 File Offset: 0x00002E17
		public bool realtimeEnvironmentLighting
		{
			get
			{
				return LightingSettings.get_realtimeEnvironmentLightingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_realtimeEnvironmentLightingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0;

		// Token: 0x0400033A RID: 826
		private static readonly LightingSettings.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x0400033B RID: 827
		private static readonly LightingSettings.get_bakedGIDelegate get_bakedGIDelegateField;

		// Token: 0x0400033C RID: 828
		private static readonly LightingSettings.set_bakedGIDelegate set_bakedGIDelegateField;

		// Token: 0x0400033D RID: 829
		private static readonly LightingSettings.get_realtimeGIDelegate get_realtimeGIDelegateField;

		// Token: 0x0400033E RID: 830
		private static readonly LightingSettings.set_realtimeGIDelegate set_realtimeGIDelegateField;

		// Token: 0x0400033F RID: 831
		private static readonly LightingSettings.get_realtimeEnvironmentLightingDelegate get_realtimeEnvironmentLightingDelegateField;

		// Token: 0x04000340 RID: 832
		private static readonly LightingSettings.set_realtimeEnvironmentLightingDelegate set_realtimeEnvironmentLightingDelegateField;

		// Token: 0x0200043E RID: 1086
		// (Invoke) Token: 0x06002641 RID: 9793
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x0200043F RID: 1087
		// (Invoke) Token: 0x06002643 RID: 9795
		private delegate bool get_bakedGIDelegate(IntPtr @this);

		// Token: 0x02000440 RID: 1088
		// (Invoke) Token: 0x06002645 RID: 9797
		private delegate void set_bakedGIDelegate(IntPtr @this, bool value);

		// Token: 0x02000441 RID: 1089
		// (Invoke) Token: 0x06002647 RID: 9799
		private delegate bool get_realtimeGIDelegate(IntPtr @this);

		// Token: 0x02000442 RID: 1090
		// (Invoke) Token: 0x06002649 RID: 9801
		private delegate void set_realtimeGIDelegate(IntPtr @this, bool value);

		// Token: 0x02000443 RID: 1091
		// (Invoke) Token: 0x0600264B RID: 9803
		private delegate bool get_realtimeEnvironmentLightingDelegate(IntPtr @this);

		// Token: 0x02000444 RID: 1092
		// (Invoke) Token: 0x0600264D RID: 9805
		private delegate void set_realtimeEnvironmentLightingDelegate(IntPtr @this, bool value);
	}
}
