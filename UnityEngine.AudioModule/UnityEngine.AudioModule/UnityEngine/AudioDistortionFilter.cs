using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public sealed class AudioDistortionFilter : Behaviour
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00003004 File Offset: 0x00001204
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00003016 File Offset: 0x00001216
		public float distortionLevel
		{
			get
			{
				return AudioDistortionFilter.get_distortionLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioDistortionFilter.set_distortionLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000127 RID: 295
		private static readonly AudioDistortionFilter.get_distortionLevelDelegate get_distortionLevelDelegateField = IL2CPP.ResolveICall<AudioDistortionFilter.get_distortionLevelDelegate>("UnityEngine.AudioDistortionFilter::get_distortionLevel");

		// Token: 0x04000128 RID: 296
		private static readonly AudioDistortionFilter.set_distortionLevelDelegate set_distortionLevelDelegateField = IL2CPP.ResolveICall<AudioDistortionFilter.set_distortionLevelDelegate>("UnityEngine.AudioDistortionFilter::set_distortionLevel");

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x06000372 RID: 882
		private delegate float get_distortionLevelDelegate(IntPtr @this);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x06000374 RID: 884
		private delegate void set_distortionLevelDelegate(IntPtr @this, float value);
	}
}
