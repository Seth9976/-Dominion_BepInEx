using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000026 RID: 38
	public static class AudioPlayableGraphExtensions
	{
		// Token: 0x060001EF RID: 495 RVA: 0x0000377A File Offset: 0x0000197A
		public static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			return AudioPlayableGraphExtensions.InternalCreateAudioOutputDelegateField(ref graph, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x04000197 RID: 407
		private static readonly AudioPlayableGraphExtensions.InternalCreateAudioOutputDelegate InternalCreateAudioOutputDelegateField = IL2CPP.ResolveICall<AudioPlayableGraphExtensions.InternalCreateAudioOutputDelegate>("UnityEngine.Audio.AudioPlayableGraphExtensions::InternalCreateAudioOutput");

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x0600043C RID: 1084
		private delegate bool InternalCreateAudioOutputDelegate(IntPtr graph, IntPtr name, [Out] IntPtr handle);
	}
}
