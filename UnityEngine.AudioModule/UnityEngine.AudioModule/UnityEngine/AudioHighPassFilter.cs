using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	public sealed class AudioHighPassFilter : Behaviour
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002F9A File Offset: 0x0000119A
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002FAC File Offset: 0x000011AC
		public float cutoffFrequency
		{
			get
			{
				return AudioHighPassFilter.get_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioHighPassFilter.set_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002FBF File Offset: 0x000011BF
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002FD1 File Offset: 0x000011D1
		public float highpassResonanceQ
		{
			get
			{
				return AudioHighPassFilter.get_highpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioHighPassFilter.set_highpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000123 RID: 291
		private static readonly AudioHighPassFilter.get_cutoffFrequencyDelegate get_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.get_cutoffFrequencyDelegate>("UnityEngine.AudioHighPassFilter::get_cutoffFrequency");

		// Token: 0x04000124 RID: 292
		private static readonly AudioHighPassFilter.set_cutoffFrequencyDelegate set_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.set_cutoffFrequencyDelegate>("UnityEngine.AudioHighPassFilter::set_cutoffFrequency");

		// Token: 0x04000125 RID: 293
		private static readonly AudioHighPassFilter.get_highpassResonanceQDelegate get_highpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.get_highpassResonanceQDelegate>("UnityEngine.AudioHighPassFilter::get_highpassResonanceQ");

		// Token: 0x04000126 RID: 294
		private static readonly AudioHighPassFilter.set_highpassResonanceQDelegate set_highpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.set_highpassResonanceQDelegate>("UnityEngine.AudioHighPassFilter::set_highpassResonanceQ");

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x0600036A RID: 874
		private delegate float get_cutoffFrequencyDelegate(IntPtr @this);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x0600036C RID: 876
		private delegate void set_cutoffFrequencyDelegate(IntPtr @this, float value);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x0600036E RID: 878
		private delegate float get_highpassResonanceQDelegate(IntPtr @this);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000370 RID: 880
		private delegate void set_highpassResonanceQDelegate(IntPtr @this, float value);
	}
}
