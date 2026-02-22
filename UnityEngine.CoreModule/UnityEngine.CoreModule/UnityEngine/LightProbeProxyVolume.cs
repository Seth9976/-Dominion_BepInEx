using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200020F RID: 527
	public sealed class LightProbeProxyVolume : Behaviour
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x000115FD File Offset: 0x0000F7FD
		public static bool isFeatureSupported
		{
			get
			{
				return LightProbeProxyVolume.get_isFeatureSupportedDelegateField();
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000649D0 File Offset: 0x00062BD0
		public Bounds boundsGlobal
		{
			get
			{
				Bounds bounds;
				this.get_boundsGlobal_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000649E8 File Offset: 0x00062BE8
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x00011609 File Offset: 0x0000F809
		public Vector3 sizeCustom
		{
			get
			{
				Vector3 vector;
				this.get_sizeCustom_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_sizeCustom_Injected(ref value);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00064A00 File Offset: 0x00062C00
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x00011613 File Offset: 0x0000F813
		public Vector3 originCustom
		{
			get
			{
				Vector3 vector;
				this.get_originCustom_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_originCustom_Injected(ref value);
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x0001161D File Offset: 0x0000F81D
		// (set) Token: 0x06001E8C RID: 7820 RVA: 0x0001162F File Offset: 0x0000F82F
		public float probeDensity
		{
			get
			{
				return LightProbeProxyVolume.get_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x00011642 File Offset: 0x0000F842
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x00011654 File Offset: 0x0000F854
		public int gridResolutionX
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00011667 File Offset: 0x0000F867
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x00011679 File Offset: 0x0000F879
		public int gridResolutionY
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x0001168C File Offset: 0x0000F88C
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x0001169E File Offset: 0x0000F89E
		public int gridResolutionZ
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x000116B1 File Offset: 0x0000F8B1
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x000116C3 File Offset: 0x0000F8C3
		public LightProbeProxyVolume.BoundingBoxMode boundingBoxMode
		{
			get
			{
				return LightProbeProxyVolume.get_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x000116D6 File Offset: 0x0000F8D6
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x000116E8 File Offset: 0x0000F8E8
		public LightProbeProxyVolume.ResolutionMode resolutionMode
		{
			get
			{
				return LightProbeProxyVolume.get_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x000116FB File Offset: 0x0000F8FB
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x0001170D File Offset: 0x0000F90D
		public LightProbeProxyVolume.ProbePositionMode probePositionMode
		{
			get
			{
				return LightProbeProxyVolume.get_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x00011720 File Offset: 0x0000F920
		// (set) Token: 0x06001E9A RID: 7834 RVA: 0x00011732 File Offset: 0x0000F932
		public LightProbeProxyVolume.RefreshMode refreshMode
		{
			get
			{
				return LightProbeProxyVolume.get_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x00011745 File Offset: 0x0000F945
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x00011757 File Offset: 0x0000F957
		public LightProbeProxyVolume.QualityMode qualityMode
		{
			get
			{
				return LightProbeProxyVolume.get_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0001176A File Offset: 0x0000F96A
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0001177C File Offset: 0x0000F97C
		public LightProbeProxyVolume.DataFormat dataFormat
		{
			get
			{
				return LightProbeProxyVolume.get_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0001178F File Offset: 0x0000F98F
		public void Update()
		{
			this.SetDirtyFlag(true);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0001179A File Offset: 0x0000F99A
		public void SetDirtyFlag(bool flag)
		{
			LightProbeProxyVolume.SetDirtyFlagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flag);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000117AD File Offset: 0x0000F9AD
		public void get_boundsGlobal_Injected(out Bounds ret)
		{
			LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000117C0 File Offset: 0x0000F9C0
		public void get_sizeCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x000117D3 File Offset: 0x0000F9D3
		public void set_sizeCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000117E6 File Offset: 0x0000F9E6
		public void get_originCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000117F9 File Offset: 0x0000F9F9
		public void set_originCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400181F RID: 6175
		private static readonly LightProbeProxyVolume.get_isFeatureSupportedDelegate get_isFeatureSupportedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_isFeatureSupportedDelegate>("UnityEngine.LightProbeProxyVolume::get_isFeatureSupported");

		// Token: 0x04001820 RID: 6176
		private static readonly LightProbeProxyVolume.get_probeDensityDelegate get_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::get_probeDensity");

		// Token: 0x04001821 RID: 6177
		private static readonly LightProbeProxyVolume.set_probeDensityDelegate set_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::set_probeDensity");

		// Token: 0x04001822 RID: 6178
		private static readonly LightProbeProxyVolume.get_gridResolutionXDelegate get_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionX");

		// Token: 0x04001823 RID: 6179
		private static readonly LightProbeProxyVolume.set_gridResolutionXDelegate set_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionX");

		// Token: 0x04001824 RID: 6180
		private static readonly LightProbeProxyVolume.get_gridResolutionYDelegate get_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionY");

		// Token: 0x04001825 RID: 6181
		private static readonly LightProbeProxyVolume.set_gridResolutionYDelegate set_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionY");

		// Token: 0x04001826 RID: 6182
		private static readonly LightProbeProxyVolume.get_gridResolutionZDelegate get_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionZ");

		// Token: 0x04001827 RID: 6183
		private static readonly LightProbeProxyVolume.set_gridResolutionZDelegate set_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionZ");

		// Token: 0x04001828 RID: 6184
		private static readonly LightProbeProxyVolume.get_boundingBoxModeDelegate get_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::get_boundingBoxMode");

		// Token: 0x04001829 RID: 6185
		private static readonly LightProbeProxyVolume.set_boundingBoxModeDelegate set_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::set_boundingBoxMode");

		// Token: 0x0400182A RID: 6186
		private static readonly LightProbeProxyVolume.get_resolutionModeDelegate get_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_resolutionMode");

		// Token: 0x0400182B RID: 6187
		private static readonly LightProbeProxyVolume.set_resolutionModeDelegate set_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_resolutionMode");

		// Token: 0x0400182C RID: 6188
		private static readonly LightProbeProxyVolume.get_probePositionModeDelegate get_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_probePositionMode");

		// Token: 0x0400182D RID: 6189
		private static readonly LightProbeProxyVolume.set_probePositionModeDelegate set_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_probePositionMode");

		// Token: 0x0400182E RID: 6190
		private static readonly LightProbeProxyVolume.get_refreshModeDelegate get_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::get_refreshMode");

		// Token: 0x0400182F RID: 6191
		private static readonly LightProbeProxyVolume.set_refreshModeDelegate set_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::set_refreshMode");

		// Token: 0x04001830 RID: 6192
		private static readonly LightProbeProxyVolume.get_qualityModeDelegate get_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::get_qualityMode");

		// Token: 0x04001831 RID: 6193
		private static readonly LightProbeProxyVolume.set_qualityModeDelegate set_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::set_qualityMode");

		// Token: 0x04001832 RID: 6194
		private static readonly LightProbeProxyVolume.get_dataFormatDelegate get_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::get_dataFormat");

		// Token: 0x04001833 RID: 6195
		private static readonly LightProbeProxyVolume.set_dataFormatDelegate set_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::set_dataFormat");

		// Token: 0x04001834 RID: 6196
		private static readonly LightProbeProxyVolume.SetDirtyFlagDelegate SetDirtyFlagDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.SetDirtyFlagDelegate>("UnityEngine.LightProbeProxyVolume::SetDirtyFlag");

		// Token: 0x04001835 RID: 6197
		private static readonly LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate get_boundsGlobal_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundsGlobal_Injected");

		// Token: 0x04001836 RID: 6198
		private static readonly LightProbeProxyVolume.get_sizeCustom_InjectedDelegate get_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_sizeCustom_Injected");

		// Token: 0x04001837 RID: 6199
		private static readonly LightProbeProxyVolume.set_sizeCustom_InjectedDelegate set_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_sizeCustom_Injected");

		// Token: 0x04001838 RID: 6200
		private static readonly LightProbeProxyVolume.get_originCustom_InjectedDelegate get_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_originCustom_Injected");

		// Token: 0x04001839 RID: 6201
		private static readonly LightProbeProxyVolume.set_originCustom_InjectedDelegate set_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_originCustom_Injected");

		// Token: 0x02000BB9 RID: 3001
		public enum ResolutionMode
		{
			// Token: 0x04001D9E RID: 7582
			Automatic,
			// Token: 0x04001D9F RID: 7583
			Custom
		}

		// Token: 0x02000BBA RID: 3002
		public enum BoundingBoxMode
		{
			// Token: 0x04001DA1 RID: 7585
			AutomaticLocal,
			// Token: 0x04001DA2 RID: 7586
			AutomaticWorld,
			// Token: 0x04001DA3 RID: 7587
			Custom
		}

		// Token: 0x02000BBB RID: 3003
		public enum ProbePositionMode
		{
			// Token: 0x04001DA5 RID: 7589
			CellCorner,
			// Token: 0x04001DA6 RID: 7590
			CellCenter
		}

		// Token: 0x02000BBC RID: 3004
		public enum RefreshMode
		{
			// Token: 0x04001DA8 RID: 7592
			Automatic,
			// Token: 0x04001DA9 RID: 7593
			EveryFrame,
			// Token: 0x04001DAA RID: 7594
			ViaScripting
		}

		// Token: 0x02000BBD RID: 3005
		public enum QualityMode
		{
			// Token: 0x04001DAC RID: 7596
			Low,
			// Token: 0x04001DAD RID: 7597
			Normal
		}

		// Token: 0x02000BBE RID: 3006
		public enum DataFormat
		{
			// Token: 0x04001DAF RID: 7599
			HalfFloat,
			// Token: 0x04001DB0 RID: 7600
			Float
		}

		// Token: 0x02000BBF RID: 3007
		// (Invoke) Token: 0x06003570 RID: 13680
		private delegate bool get_isFeatureSupportedDelegate();

		// Token: 0x02000BC0 RID: 3008
		// (Invoke) Token: 0x06003572 RID: 13682
		private delegate float get_probeDensityDelegate(IntPtr @this);

		// Token: 0x02000BC1 RID: 3009
		// (Invoke) Token: 0x06003574 RID: 13684
		private delegate void set_probeDensityDelegate(IntPtr @this, float value);

		// Token: 0x02000BC2 RID: 3010
		// (Invoke) Token: 0x06003576 RID: 13686
		private delegate int get_gridResolutionXDelegate(IntPtr @this);

		// Token: 0x02000BC3 RID: 3011
		// (Invoke) Token: 0x06003578 RID: 13688
		private delegate void set_gridResolutionXDelegate(IntPtr @this, int value);

		// Token: 0x02000BC4 RID: 3012
		// (Invoke) Token: 0x0600357A RID: 13690
		private delegate int get_gridResolutionYDelegate(IntPtr @this);

		// Token: 0x02000BC5 RID: 3013
		// (Invoke) Token: 0x0600357C RID: 13692
		private delegate void set_gridResolutionYDelegate(IntPtr @this, int value);

		// Token: 0x02000BC6 RID: 3014
		// (Invoke) Token: 0x0600357E RID: 13694
		private delegate int get_gridResolutionZDelegate(IntPtr @this);

		// Token: 0x02000BC7 RID: 3015
		// (Invoke) Token: 0x06003580 RID: 13696
		private delegate void set_gridResolutionZDelegate(IntPtr @this, int value);

		// Token: 0x02000BC8 RID: 3016
		// (Invoke) Token: 0x06003582 RID: 13698
		private delegate LightProbeProxyVolume.BoundingBoxMode get_boundingBoxModeDelegate(IntPtr @this);

		// Token: 0x02000BC9 RID: 3017
		// (Invoke) Token: 0x06003584 RID: 13700
		private delegate void set_boundingBoxModeDelegate(IntPtr @this, LightProbeProxyVolume.BoundingBoxMode value);

		// Token: 0x02000BCA RID: 3018
		// (Invoke) Token: 0x06003586 RID: 13702
		private delegate LightProbeProxyVolume.ResolutionMode get_resolutionModeDelegate(IntPtr @this);

		// Token: 0x02000BCB RID: 3019
		// (Invoke) Token: 0x06003588 RID: 13704
		private delegate void set_resolutionModeDelegate(IntPtr @this, LightProbeProxyVolume.ResolutionMode value);

		// Token: 0x02000BCC RID: 3020
		// (Invoke) Token: 0x0600358A RID: 13706
		private delegate LightProbeProxyVolume.ProbePositionMode get_probePositionModeDelegate(IntPtr @this);

		// Token: 0x02000BCD RID: 3021
		// (Invoke) Token: 0x0600358C RID: 13708
		private delegate void set_probePositionModeDelegate(IntPtr @this, LightProbeProxyVolume.ProbePositionMode value);

		// Token: 0x02000BCE RID: 3022
		// (Invoke) Token: 0x0600358E RID: 13710
		private delegate LightProbeProxyVolume.RefreshMode get_refreshModeDelegate(IntPtr @this);

		// Token: 0x02000BCF RID: 3023
		// (Invoke) Token: 0x06003590 RID: 13712
		private delegate void set_refreshModeDelegate(IntPtr @this, LightProbeProxyVolume.RefreshMode value);

		// Token: 0x02000BD0 RID: 3024
		// (Invoke) Token: 0x06003592 RID: 13714
		private delegate LightProbeProxyVolume.QualityMode get_qualityModeDelegate(IntPtr @this);

		// Token: 0x02000BD1 RID: 3025
		// (Invoke) Token: 0x06003594 RID: 13716
		private delegate void set_qualityModeDelegate(IntPtr @this, LightProbeProxyVolume.QualityMode value);

		// Token: 0x02000BD2 RID: 3026
		// (Invoke) Token: 0x06003596 RID: 13718
		private delegate LightProbeProxyVolume.DataFormat get_dataFormatDelegate(IntPtr @this);

		// Token: 0x02000BD3 RID: 3027
		// (Invoke) Token: 0x06003598 RID: 13720
		private delegate void set_dataFormatDelegate(IntPtr @this, LightProbeProxyVolume.DataFormat value);

		// Token: 0x02000BD4 RID: 3028
		// (Invoke) Token: 0x0600359A RID: 13722
		private delegate void SetDirtyFlagDelegate(IntPtr @this, bool flag);

		// Token: 0x02000BD5 RID: 3029
		// (Invoke) Token: 0x0600359C RID: 13724
		private delegate void get_boundsGlobal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000BD6 RID: 3030
		// (Invoke) Token: 0x0600359E RID: 13726
		private delegate void get_sizeCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000BD7 RID: 3031
		// (Invoke) Token: 0x060035A0 RID: 13728
		private delegate void set_sizeCustom_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000BD8 RID: 3032
		// (Invoke) Token: 0x060035A2 RID: 13730
		private delegate void get_originCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000BD9 RID: 3033
		// (Invoke) Token: 0x060035A4 RID: 13732
		private delegate void set_originCustom_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
