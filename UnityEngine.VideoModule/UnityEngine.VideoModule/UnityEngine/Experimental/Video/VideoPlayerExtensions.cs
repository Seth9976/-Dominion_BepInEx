using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Audio;
using UnityEngine.Video;

namespace UnityEngine.Experimental.Video
{
	// Token: 0x0200000C RID: 12
	public static class VideoPlayerExtensions
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00003F4C File Offset: 0x0000214C
		public static AudioSampleProvider GetAudioSampleProvider(VideoPlayer vp, ushort trackIndex)
		{
			ushort controlledAudioTrackCount = vp.controlledAudioTrackCount;
			bool flag = trackIndex >= controlledAudioTrackCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("trackIndex", trackIndex, String.Concat("VideoPlayer is currently configured with ", controlledAudioTrackCount.ToString(), " tracks."));
			}
			VideoAudioOutputMode audioOutputMode = vp.audioOutputMode;
			bool flag2 = audioOutputMode != VideoAudioOutputMode.APIOnly;
			if (flag2)
			{
				throw new InvalidOperationException(String.Concat("VideoPlayer.GetAudioSampleProvider requires audioOutputMode to be APIOnly. Current: ", audioOutputMode.ToString()));
			}
			AudioSampleProvider audioSampleProvider = AudioSampleProvider.Lookup(VideoPlayerExtensions.InternalGetAudioSampleProviderId(vp, trackIndex), vp, trackIndex);
			bool flag3 = audioSampleProvider == null;
			if (flag3)
			{
				throw new InvalidOperationException("VideoPlayer.GetAudioSampleProvider got null provider.");
			}
			bool flag4 = audioSampleProvider.owner != vp;
			if (flag4)
			{
				throw new InvalidOperationException("Internal error: VideoPlayer.GetAudioSampleProvider got provider used by another object.");
			}
			bool flag5 = audioSampleProvider.trackIndex != trackIndex;
			if (flag5)
			{
				throw new InvalidOperationException(String.Concat("Internal error: VideoPlayer.GetAudioSampleProvider got provider for track ", audioSampleProvider.trackIndex.ToString(), " instead of ", trackIndex.ToString()));
			}
			return audioSampleProvider;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000297D File Offset: 0x00000B7D
		public static uint InternalGetAudioSampleProviderId(VideoPlayer vp, ushort trackIndex)
		{
			return VideoPlayerExtensions.InternalGetAudioSampleProviderIdDelegateField(IL2CPP.Il2CppObjectBaseToPtr(vp), trackIndex);
		}

		// Token: 0x040000A1 RID: 161
		private static readonly VideoPlayerExtensions.InternalGetAudioSampleProviderIdDelegate InternalGetAudioSampleProviderIdDelegateField = IL2CPP.ResolveICall<VideoPlayerExtensions.InternalGetAudioSampleProviderIdDelegate>("UnityEngine.Experimental.Video.VideoPlayerExtensions::InternalGetAudioSampleProviderId");

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060001CF RID: 463
		private delegate uint InternalGetAudioSampleProviderIdDelegate(IntPtr vp, ushort trackIndex);
	}
}
