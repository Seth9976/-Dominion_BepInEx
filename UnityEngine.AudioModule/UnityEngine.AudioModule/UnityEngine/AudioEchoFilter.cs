using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	public sealed class AudioEchoFilter : Behaviour
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00003029 File Offset: 0x00001229
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000303B File Offset: 0x0000123B
		public float delay
		{
			get
			{
				return AudioEchoFilter.get_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000304E File Offset: 0x0000124E
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00003060 File Offset: 0x00001260
		public float decayRatio
		{
			get
			{
				return AudioEchoFilter.get_decayRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_decayRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00003073 File Offset: 0x00001273
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00003085 File Offset: 0x00001285
		public float dryMix
		{
			get
			{
				return AudioEchoFilter.get_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00003098 File Offset: 0x00001298
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000030AA File Offset: 0x000012AA
		public float wetMix
		{
			get
			{
				return AudioEchoFilter.get_wetMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_wetMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000129 RID: 297
		private static readonly AudioEchoFilter.get_delayDelegate get_delayDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_delayDelegate>("UnityEngine.AudioEchoFilter::get_delay");

		// Token: 0x0400012A RID: 298
		private static readonly AudioEchoFilter.set_delayDelegate set_delayDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_delayDelegate>("UnityEngine.AudioEchoFilter::set_delay");

		// Token: 0x0400012B RID: 299
		private static readonly AudioEchoFilter.get_decayRatioDelegate get_decayRatioDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_decayRatioDelegate>("UnityEngine.AudioEchoFilter::get_decayRatio");

		// Token: 0x0400012C RID: 300
		private static readonly AudioEchoFilter.set_decayRatioDelegate set_decayRatioDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_decayRatioDelegate>("UnityEngine.AudioEchoFilter::set_decayRatio");

		// Token: 0x0400012D RID: 301
		private static readonly AudioEchoFilter.get_dryMixDelegate get_dryMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_dryMixDelegate>("UnityEngine.AudioEchoFilter::get_dryMix");

		// Token: 0x0400012E RID: 302
		private static readonly AudioEchoFilter.set_dryMixDelegate set_dryMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_dryMixDelegate>("UnityEngine.AudioEchoFilter::set_dryMix");

		// Token: 0x0400012F RID: 303
		private static readonly AudioEchoFilter.get_wetMixDelegate get_wetMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_wetMixDelegate>("UnityEngine.AudioEchoFilter::get_wetMix");

		// Token: 0x04000130 RID: 304
		private static readonly AudioEchoFilter.set_wetMixDelegate set_wetMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_wetMixDelegate>("UnityEngine.AudioEchoFilter::set_wetMix");

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x06000376 RID: 886
		private delegate float get_delayDelegate(IntPtr @this);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x06000378 RID: 888
		private delegate void set_delayDelegate(IntPtr @this, float value);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x0600037A RID: 890
		private delegate float get_decayRatioDelegate(IntPtr @this);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x0600037C RID: 892
		private delegate void set_decayRatioDelegate(IntPtr @this, float value);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x0600037E RID: 894
		private delegate float get_dryMixDelegate(IntPtr @this);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x06000380 RID: 896
		private delegate void set_dryMixDelegate(IntPtr @this, float value);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x06000382 RID: 898
		private delegate float get_wetMixDelegate(IntPtr @this);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x06000384 RID: 900
		private delegate void set_wetMixDelegate(IntPtr @this, float value);
	}
}
