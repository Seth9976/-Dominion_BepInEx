using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200004F RID: 79
	public sealed class LightmapSettings : Object
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x00024788 File Offset: 0x00022988
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapSettings()
		{
			Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightmapSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr);
			LightmapSettings.get_lightmapsDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightmapsDelegate>("UnityEngine.LightmapSettings::get_lightmaps");
			LightmapSettings.set_lightmapsDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightmapsDelegate>("UnityEngine.LightmapSettings::set_lightmaps");
			LightmapSettings.get_lightmapsModeDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightmapsModeDelegate>("UnityEngine.LightmapSettings::get_lightmapsMode");
			LightmapSettings.set_lightmapsModeDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightmapsModeDelegate>("UnityEngine.LightmapSettings::set_lightmapsMode");
			LightmapSettings.get_lightProbesDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightProbesDelegate>("UnityEngine.LightmapSettings::get_lightProbes");
			LightmapSettings.set_lightProbesDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightProbesDelegate>("UnityEngine.LightmapSettings::set_lightProbes");
			LightmapSettings.ResetDelegateField = IL2CPP.ResolveICall<LightmapSettings.ResetDelegate>("UnityEngine.LightmapSettings::Reset");
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000055F4 File Offset: 0x000037F4
		public LightmapSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00024824 File Offset: 0x00022A24
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x000055FD File Offset: 0x000037FD
		public static Il2CppReferenceArray<LightmapData> lightmaps
		{
			get
			{
				IntPtr intPtr = LightmapSettings.get_lightmapsDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightmapData>>(intPtr2) : null;
			}
			set
			{
				LightmapSettings.set_lightmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0000560F File Offset: 0x0000380F
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0000561B File Offset: 0x0000381B
		public static LightmapsMode lightmapsMode
		{
			get
			{
				return LightmapSettings.get_lightmapsModeDelegateField();
			}
			set
			{
				LightmapSettings.set_lightmapsModeDelegateField(value);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0002484C File Offset: 0x00022A4C
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00005628 File Offset: 0x00003828
		public static LightProbes lightProbes
		{
			get
			{
				IntPtr intPtr = LightmapSettings.get_lightProbesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightProbes>(intPtr2) : null;
			}
			set
			{
				LightmapSettings.set_lightProbesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000563A File Offset: 0x0000383A
		public static void Reset()
		{
			LightmapSettings.ResetDelegateField();
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00024874 File Offset: 0x00022A74
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00005646 File Offset: 0x00003846
		public static LightmapsModeLegacy lightmapsModeLegacy
		{
			get
			{
				return LightmapsModeLegacy.Single;
			}
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00024888 File Offset: 0x00022A88
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00005649 File Offset: 0x00003849
		public static ColorSpace bakedColorSpace
		{
			get
			{
				return QualitySettings.desiredColorSpace;
			}
			set
			{
			}
		}

		// Token: 0x040003BD RID: 957
		private static readonly LightmapSettings.get_lightmapsDelegate get_lightmapsDelegateField;

		// Token: 0x040003BE RID: 958
		private static readonly LightmapSettings.set_lightmapsDelegate set_lightmapsDelegateField;

		// Token: 0x040003BF RID: 959
		private static readonly LightmapSettings.get_lightmapsModeDelegate get_lightmapsModeDelegateField;

		// Token: 0x040003C0 RID: 960
		private static readonly LightmapSettings.set_lightmapsModeDelegate set_lightmapsModeDelegateField;

		// Token: 0x040003C1 RID: 961
		private static readonly LightmapSettings.get_lightProbesDelegate get_lightProbesDelegateField;

		// Token: 0x040003C2 RID: 962
		private static readonly LightmapSettings.set_lightProbesDelegate set_lightProbesDelegateField;

		// Token: 0x040003C3 RID: 963
		private static readonly LightmapSettings.ResetDelegate ResetDelegateField;

		// Token: 0x02000495 RID: 1173
		// (Invoke) Token: 0x060026F9 RID: 9977
		private delegate IntPtr get_lightmapsDelegate();

		// Token: 0x02000496 RID: 1174
		// (Invoke) Token: 0x060026FB RID: 9979
		private delegate void set_lightmapsDelegate(IntPtr value);

		// Token: 0x02000497 RID: 1175
		// (Invoke) Token: 0x060026FD RID: 9981
		private delegate LightmapsMode get_lightmapsModeDelegate();

		// Token: 0x02000498 RID: 1176
		// (Invoke) Token: 0x060026FF RID: 9983
		private delegate void set_lightmapsModeDelegate(LightmapsMode value);

		// Token: 0x02000499 RID: 1177
		// (Invoke) Token: 0x06002701 RID: 9985
		private delegate IntPtr get_lightProbesDelegate();

		// Token: 0x0200049A RID: 1178
		// (Invoke) Token: 0x06002703 RID: 9987
		private delegate void set_lightProbesDelegate(IntPtr value);

		// Token: 0x0200049B RID: 1179
		// (Invoke) Token: 0x06002705 RID: 9989
		private delegate void ResetDelegate();
	}
}
