using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x02000023 RID: 35
	public class AudioMixerGroup : Object
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000689C File Offset: 0x00004A9C
		public AudioMixer audioMixer
		{
			get
			{
				IntPtr intPtr = AudioMixerGroup.get_audioMixerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
			}
		}

		// Token: 0x04000195 RID: 405
		private static readonly AudioMixerGroup.get_audioMixerDelegate get_audioMixerDelegateField = IL2CPP.ResolveICall<AudioMixerGroup.get_audioMixerDelegate>("UnityEngine.Audio.AudioMixerGroup::get_audioMixer");

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x06000438 RID: 1080
		private delegate IntPtr get_audioMixerDelegate(IntPtr @this);
	}
}
