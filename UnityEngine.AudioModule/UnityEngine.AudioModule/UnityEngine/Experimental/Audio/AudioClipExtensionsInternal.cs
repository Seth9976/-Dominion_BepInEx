using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000027 RID: 39
	public static class AudioClipExtensionsInternal
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x0000379F File Offset: 0x0000199F
		public static uint Internal_CreateAudioClipSampleProvider(AudioClip audioClip, ulong start, long end, bool loop, bool allowDrop, [Optional] bool loopPointIsStart)
		{
			return AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegateField(IL2CPP.Il2CppObjectBaseToPtr(audioClip), start, end, loop, allowDrop, loopPointIsStart);
		}

		// Token: 0x04000198 RID: 408
		private static readonly AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegate Internal_CreateAudioClipSampleProviderDelegateField = IL2CPP.ResolveICall<AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegate>("UnityEngine.Experimental.Audio.AudioClipExtensionsInternal::Internal_CreateAudioClipSampleProvider");

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x0600043E RID: 1086
		private delegate uint Internal_CreateAudioClipSampleProviderDelegate(IntPtr audioClip, ulong start, long end, bool loop, bool allowDrop, bool loopPointIsStart);
	}
}
