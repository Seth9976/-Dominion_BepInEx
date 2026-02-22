using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000028 RID: 40
	public static class AudioSourceExtensionsInternal
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000037D8 File Offset: 0x000019D8
		public static void RegisterSampleProvider(AudioSource source, AudioSampleProvider provider)
		{
			AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSource(source, provider.id);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000037E8 File Offset: 0x000019E8
		public static void UnregisterSampleProvider(AudioSource source, AudioSampleProvider provider)
		{
			AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSource(source, provider.id);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000037F8 File Offset: 0x000019F8
		public static void Internal_RegisterSampleProviderWithAudioSource(AudioSource source, uint providerId)
		{
			AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), providerId);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000380B File Offset: 0x00001A0B
		public static void Internal_UnregisterSampleProviderFromAudioSource(AudioSource source, uint providerId)
		{
			AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), providerId);
		}

		// Token: 0x04000199 RID: 409
		private static readonly AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegate Internal_RegisterSampleProviderWithAudioSourceDelegateField = IL2CPP.ResolveICall<AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_RegisterSampleProviderWithAudioSource");

		// Token: 0x0400019A RID: 410
		private static readonly AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegate Internal_UnregisterSampleProviderFromAudioSourceDelegateField = IL2CPP.ResolveICall<AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_UnregisterSampleProviderFromAudioSource");

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000440 RID: 1088
		private delegate void Internal_RegisterSampleProviderWithAudioSourceDelegate(IntPtr source, uint providerId);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06000442 RID: 1090
		private delegate void Internal_UnregisterSampleProviderFromAudioSourceDelegate(IntPtr source, uint providerId);
	}
}
