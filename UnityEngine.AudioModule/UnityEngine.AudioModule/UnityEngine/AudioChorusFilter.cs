using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000019 RID: 25
	public sealed class AudioChorusFilter : Behaviour
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000030BD File Offset: 0x000012BD
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000030CF File Offset: 0x000012CF
		public float dryMix
		{
			get
			{
				return AudioChorusFilter.get_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000030E2 File Offset: 0x000012E2
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000030F4 File Offset: 0x000012F4
		public float wetMix1
		{
			get
			{
				return AudioChorusFilter.get_wetMix1DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_wetMix1DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00003107 File Offset: 0x00001307
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00003119 File Offset: 0x00001319
		public float wetMix2
		{
			get
			{
				return AudioChorusFilter.get_wetMix2DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_wetMix2DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000312C File Offset: 0x0000132C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000313E File Offset: 0x0000133E
		public float wetMix3
		{
			get
			{
				return AudioChorusFilter.get_wetMix3DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_wetMix3DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00003151 File Offset: 0x00001351
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00003163 File Offset: 0x00001363
		public float delay
		{
			get
			{
				return AudioChorusFilter.get_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003176 File Offset: 0x00001376
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00003188 File Offset: 0x00001388
		public float rate
		{
			get
			{
				return AudioChorusFilter.get_rateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_rateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000319B File Offset: 0x0000139B
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000031AD File Offset: 0x000013AD
		public float depth
		{
			get
			{
				return AudioChorusFilter.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00005EF8 File Offset: 0x000040F8
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000031C0 File Offset: 0x000013C0
		public float feedback
		{
			get
			{
				Debug.LogWarning("Warning! Feedback is deprecated. This property does nothing.");
				return 0f;
			}
			set
			{
				Debug.LogWarning("Warning! Feedback is deprecated. This property does nothing.");
			}
		}

		// Token: 0x04000131 RID: 305
		private static readonly AudioChorusFilter.get_dryMixDelegate get_dryMixDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_dryMixDelegate>("UnityEngine.AudioChorusFilter::get_dryMix");

		// Token: 0x04000132 RID: 306
		private static readonly AudioChorusFilter.set_dryMixDelegate set_dryMixDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_dryMixDelegate>("UnityEngine.AudioChorusFilter::set_dryMix");

		// Token: 0x04000133 RID: 307
		private static readonly AudioChorusFilter.get_wetMix1Delegate get_wetMix1DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_wetMix1Delegate>("UnityEngine.AudioChorusFilter::get_wetMix1");

		// Token: 0x04000134 RID: 308
		private static readonly AudioChorusFilter.set_wetMix1Delegate set_wetMix1DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_wetMix1Delegate>("UnityEngine.AudioChorusFilter::set_wetMix1");

		// Token: 0x04000135 RID: 309
		private static readonly AudioChorusFilter.get_wetMix2Delegate get_wetMix2DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_wetMix2Delegate>("UnityEngine.AudioChorusFilter::get_wetMix2");

		// Token: 0x04000136 RID: 310
		private static readonly AudioChorusFilter.set_wetMix2Delegate set_wetMix2DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_wetMix2Delegate>("UnityEngine.AudioChorusFilter::set_wetMix2");

		// Token: 0x04000137 RID: 311
		private static readonly AudioChorusFilter.get_wetMix3Delegate get_wetMix3DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_wetMix3Delegate>("UnityEngine.AudioChorusFilter::get_wetMix3");

		// Token: 0x04000138 RID: 312
		private static readonly AudioChorusFilter.set_wetMix3Delegate set_wetMix3DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_wetMix3Delegate>("UnityEngine.AudioChorusFilter::set_wetMix3");

		// Token: 0x04000139 RID: 313
		private static readonly AudioChorusFilter.get_delayDelegate get_delayDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_delayDelegate>("UnityEngine.AudioChorusFilter::get_delay");

		// Token: 0x0400013A RID: 314
		private static readonly AudioChorusFilter.set_delayDelegate set_delayDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_delayDelegate>("UnityEngine.AudioChorusFilter::set_delay");

		// Token: 0x0400013B RID: 315
		private static readonly AudioChorusFilter.get_rateDelegate get_rateDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_rateDelegate>("UnityEngine.AudioChorusFilter::get_rate");

		// Token: 0x0400013C RID: 316
		private static readonly AudioChorusFilter.set_rateDelegate set_rateDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_rateDelegate>("UnityEngine.AudioChorusFilter::set_rate");

		// Token: 0x0400013D RID: 317
		private static readonly AudioChorusFilter.get_depthDelegate get_depthDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_depthDelegate>("UnityEngine.AudioChorusFilter::get_depth");

		// Token: 0x0400013E RID: 318
		private static readonly AudioChorusFilter.set_depthDelegate set_depthDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_depthDelegate>("UnityEngine.AudioChorusFilter::set_depth");

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x06000386 RID: 902
		private delegate float get_dryMixDelegate(IntPtr @this);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x06000388 RID: 904
		private delegate void set_dryMixDelegate(IntPtr @this, float value);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x0600038A RID: 906
		private delegate float get_wetMix1Delegate(IntPtr @this);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x0600038C RID: 908
		private delegate void set_wetMix1Delegate(IntPtr @this, float value);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x0600038E RID: 910
		private delegate float get_wetMix2Delegate(IntPtr @this);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x06000390 RID: 912
		private delegate void set_wetMix2Delegate(IntPtr @this, float value);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x06000392 RID: 914
		private delegate float get_wetMix3Delegate(IntPtr @this);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x06000394 RID: 916
		private delegate void set_wetMix3Delegate(IntPtr @this, float value);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x06000396 RID: 918
		private delegate float get_delayDelegate(IntPtr @this);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x06000398 RID: 920
		private delegate void set_delayDelegate(IntPtr @this, float value);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x0600039A RID: 922
		private delegate float get_rateDelegate(IntPtr @this);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x0600039C RID: 924
		private delegate void set_rateDelegate(IntPtr @this, float value);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x0600039E RID: 926
		private delegate float get_depthDelegate(IntPtr @this);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x060003A0 RID: 928
		private delegate void set_depthDelegate(IntPtr @this, float value);
	}
}
