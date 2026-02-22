using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public sealed class AudioLowPassFilter : Behaviour
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00005D4C File Offset: 0x00003F4C
		public AnimationCurve GetCustomLowpassLevelCurveCopy()
		{
			IntPtr intPtr = AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002EEF File Offset: 0x000010EF
		public static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve)
		{
			AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00005D78 File Offset: 0x00003F78
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002F07 File Offset: 0x00001107
		public AnimationCurve customCutoffCurve
		{
			get
			{
				return this.GetCustomLowpassLevelCurveCopy();
			}
			set
			{
				AudioLowPassFilter.SetCustomLowpassLevelCurveHelper(this, value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002F12 File Offset: 0x00001112
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002F24 File Offset: 0x00001124
		public float cutoffFrequency
		{
			get
			{
				return AudioLowPassFilter.get_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioLowPassFilter.set_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002F37 File Offset: 0x00001137
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002F49 File Offset: 0x00001149
		public float lowpassResonanceQ
		{
			get
			{
				return AudioLowPassFilter.get_lowpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioLowPassFilter.set_lowpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400011D RID: 285
		private static readonly AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegate GetCustomLowpassLevelCurveCopyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegate>("UnityEngine.AudioLowPassFilter::GetCustomLowpassLevelCurveCopy");

		// Token: 0x0400011E RID: 286
		private static readonly AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegate SetCustomLowpassLevelCurveHelperDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegate>("UnityEngine.AudioLowPassFilter::SetCustomLowpassLevelCurveHelper");

		// Token: 0x0400011F RID: 287
		private static readonly AudioLowPassFilter.get_cutoffFrequencyDelegate get_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.get_cutoffFrequencyDelegate>("UnityEngine.AudioLowPassFilter::get_cutoffFrequency");

		// Token: 0x04000120 RID: 288
		private static readonly AudioLowPassFilter.set_cutoffFrequencyDelegate set_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.set_cutoffFrequencyDelegate>("UnityEngine.AudioLowPassFilter::set_cutoffFrequency");

		// Token: 0x04000121 RID: 289
		private static readonly AudioLowPassFilter.get_lowpassResonanceQDelegate get_lowpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.get_lowpassResonanceQDelegate>("UnityEngine.AudioLowPassFilter::get_lowpassResonanceQ");

		// Token: 0x04000122 RID: 290
		private static readonly AudioLowPassFilter.set_lowpassResonanceQDelegate set_lowpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.set_lowpassResonanceQDelegate>("UnityEngine.AudioLowPassFilter::set_lowpassResonanceQ");

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x0600035E RID: 862
		private delegate IntPtr GetCustomLowpassLevelCurveCopyDelegate(IntPtr @this);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x06000360 RID: 864
		private delegate void SetCustomLowpassLevelCurveHelperDelegate(IntPtr source, IntPtr curve);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x06000362 RID: 866
		private delegate float get_cutoffFrequencyDelegate(IntPtr @this);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x06000364 RID: 868
		private delegate void set_cutoffFrequencyDelegate(IntPtr @this, float value);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x06000366 RID: 870
		private delegate float get_lowpassResonanceQDelegate(IntPtr @this);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x06000368 RID: 872
		private delegate void set_lowpassResonanceQDelegate(IntPtr @this, float value);
	}
}
