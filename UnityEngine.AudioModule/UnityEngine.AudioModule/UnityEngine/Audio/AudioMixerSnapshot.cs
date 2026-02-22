using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x02000024 RID: 36
	public class AudioMixerSnapshot : Object
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000068C8 File Offset: 0x00004AC8
		public AudioMixer audioMixer
		{
			get
			{
				IntPtr intPtr = AudioMixerSnapshot.get_audioMixerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00003758 File Offset: 0x00001958
		public void TransitionTo(float timeToReach)
		{
			this.audioMixer.TransitionToSnapshot(this, timeToReach);
		}

		// Token: 0x04000196 RID: 406
		private static readonly AudioMixerSnapshot.get_audioMixerDelegate get_audioMixerDelegateField = IL2CPP.ResolveICall<AudioMixerSnapshot.get_audioMixerDelegate>("UnityEngine.Audio.AudioMixerSnapshot::get_audioMixer");

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x0600043A RID: 1082
		private delegate IntPtr get_audioMixerDelegate(IntPtr @this);
	}
}
