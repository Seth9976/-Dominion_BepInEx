using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020002CD RID: 717
	public class RenderSettings
	{
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x00014807 File Offset: 0x00012A07
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00014813 File Offset: 0x00012A13
		public static bool useRadianceAmbientProbe
		{
			get
			{
				return RenderSettings.get_useRadianceAmbientProbeDelegateField();
			}
			set
			{
				RenderSettings.set_useRadianceAmbientProbeDelegateField(value);
			}
		}

		// Token: 0x04001BD5 RID: 7125
		private static readonly RenderSettings.get_useRadianceAmbientProbeDelegate get_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::get_useRadianceAmbientProbe");

		// Token: 0x04001BD6 RID: 7126
		private static readonly RenderSettings.set_useRadianceAmbientProbeDelegate set_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::set_useRadianceAmbientProbe");

		// Token: 0x02000D1E RID: 3358
		// (Invoke) Token: 0x06003820 RID: 14368
		private delegate bool get_useRadianceAmbientProbeDelegate();

		// Token: 0x02000D1F RID: 3359
		// (Invoke) Token: 0x06003822 RID: 14370
		private delegate void set_useRadianceAmbientProbeDelegate(bool value);
	}
}
