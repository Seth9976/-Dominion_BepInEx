using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000025 RID: 37
	public static class AudioPlayableBinding
	{
		// Token: 0x060001EC RID: 492 RVA: 0x000068F4 File Offset: 0x00004AF4
		public static PlayableBinding Create(string name, Object key)
		{
			return PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AudioSource>()), new PlayableBinding.CreateOutputMethod(AudioPlayableBinding.CreateAudioOutput));
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00006924 File Offset: 0x00004B24
		public static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name)
		{
			return AudioPlayableOutput.Create(graph, name, null);
		}
	}
}
