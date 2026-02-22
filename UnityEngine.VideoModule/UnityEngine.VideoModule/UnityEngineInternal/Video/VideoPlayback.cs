using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Experimental.Audio;

namespace UnityEngineInternal.Video
{
	// Token: 0x02000010 RID: 16
	public class VideoPlayback
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00002990 File Offset: 0x00000B90
		public void StartPlayback()
		{
			VideoPlayback.StartPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000029A2 File Offset: 0x00000BA2
		public void PausePlayback()
		{
			VideoPlayback.PausePlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000029B4 File Offset: 0x00000BB4
		public void StopPlayback()
		{
			VideoPlayback.StopPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000029C6 File Offset: 0x00000BC6
		public VideoError GetStatus()
		{
			return VideoPlayback.GetStatusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000029D8 File Offset: 0x00000BD8
		public bool IsReady()
		{
			return VideoPlayback.IsReadyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000029EA File Offset: 0x00000BEA
		public bool IsPlaying()
		{
			return VideoPlayback.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000029FC File Offset: 0x00000BFC
		public void Step()
		{
			VideoPlayback.StepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002A0E File Offset: 0x00000C0E
		public bool CanStep()
		{
			return VideoPlayback.CanStepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002A20 File Offset: 0x00000C20
		public uint GetWidth()
		{
			return VideoPlayback.GetWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002A32 File Offset: 0x00000C32
		public uint GetHeight()
		{
			return VideoPlayback.GetHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002A44 File Offset: 0x00000C44
		public float GetFrameRate()
		{
			return VideoPlayback.GetFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002A56 File Offset: 0x00000C56
		public float GetDuration()
		{
			return VideoPlayback.GetDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002A68 File Offset: 0x00000C68
		public ulong GetFrameCount()
		{
			return VideoPlayback.GetFrameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002A7A File Offset: 0x00000C7A
		public uint GetPixelAspectRatioNumerator()
		{
			return VideoPlayback.GetPixelAspectRatioNumeratorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002A8C File Offset: 0x00000C8C
		public uint GetPixelAspectRatioDenominator()
		{
			return VideoPlayback.GetPixelAspectRatioDenominatorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002A9E File Offset: 0x00000C9E
		public VideoPixelFormat GetPixelFormat()
		{
			return VideoPlayback.GetPixelFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002AB0 File Offset: 0x00000CB0
		public bool CanNotSkipOnDrop()
		{
			return VideoPlayback.CanNotSkipOnDropDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002AC2 File Offset: 0x00000CC2
		public void SetSkipOnDrop(bool skipOnDrop)
		{
			VideoPlayback.SetSkipOnDropDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), skipOnDrop);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002AD5 File Offset: 0x00000CD5
		public bool GetTexture(Texture texture, out long outputFrameNum)
		{
			return VideoPlayback.GetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(texture), out outputFrameNum);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002AEE File Offset: 0x00000CEE
		public float GetPlaybackSpeed()
		{
			return VideoPlayback.GetPlaybackSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002B00 File Offset: 0x00000D00
		public void SetPlaybackSpeed(float value)
		{
			VideoPlayback.SetPlaybackSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002B13 File Offset: 0x00000D13
		public bool GetLoop()
		{
			return VideoPlayback.GetLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002B25 File Offset: 0x00000D25
		public void SetLoop(bool value)
		{
			VideoPlayback.SetLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002B38 File Offset: 0x00000D38
		public void SetAdjustToLinearSpace(bool enable)
		{
			VideoPlayback.SetAdjustToLinearSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), enable);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002B4B File Offset: 0x00000D4B
		public ushort GetAudioTrackCount()
		{
			return VideoPlayback.GetAudioTrackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002B5D File Offset: 0x00000D5D
		public ushort GetAudioChannelCount(ushort trackIdx)
		{
			return VideoPlayback.GetAudioChannelCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIdx);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002B70 File Offset: 0x00000D70
		public uint GetAudioSampleRate(ushort trackIdx)
		{
			return VideoPlayback.GetAudioSampleRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIdx);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002B83 File Offset: 0x00000D83
		public void SetAudioTarget(ushort trackIdx, bool enabled, bool softwareOutput, AudioSource audioSource)
		{
			VideoPlayback.SetAudioTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIdx, enabled, softwareOutput, IL2CPP.Il2CppObjectBaseToPtr(audioSource));
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002B9F File Offset: 0x00000D9F
		public uint GetAudioSampleProviderId(ushort trackIndex)
		{
			return VideoPlayback.GetAudioSampleProviderIdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), trackIndex);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000421C File Offset: 0x0000241C
		public AudioSampleProvider GetAudioSampleProvider(ushort trackIndex)
		{
			bool flag = trackIndex >= this.GetAudioTrackCount();
			if (flag)
			{
				throw new ArgumentOutOfRangeException("trackIndex", trackIndex, String.Concat("VideoPlayback has ", this.GetAudioTrackCount().ToString(), " tracks."));
			}
			AudioSampleProvider audioSampleProvider = AudioSampleProvider.Lookup(this.GetAudioSampleProviderId(trackIndex), null, trackIndex);
			bool flag2 = audioSampleProvider == null;
			if (flag2)
			{
				throw new InvalidOperationException("VideoPlayback.GetAudioSampleProvider got null provider.");
			}
			bool flag3 = audioSampleProvider.owner != null;
			if (flag3)
			{
				throw new InvalidOperationException("Internal error: VideoPlayback.GetAudioSampleProvider got unexpected non-null provider owner.");
			}
			bool flag4 = audioSampleProvider.trackIndex != trackIndex;
			if (flag4)
			{
				throw new InvalidOperationException(String.Concat("Internal error: VideoPlayback.GetAudioSampleProvider got provider for track ", audioSampleProvider.trackIndex.ToString(), " instead of ", trackIndex.ToString()));
			}
			return audioSampleProvider;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002BB2 File Offset: 0x00000DB2
		public static bool PlatformSupportsH265()
		{
			return VideoPlayback.PlatformSupportsH265DelegateField();
		}

		// Token: 0x040000B5 RID: 181
		private static readonly VideoPlayback.StartPlaybackDelegate StartPlaybackDelegateField = IL2CPP.ResolveICall<VideoPlayback.StartPlaybackDelegate>("UnityEngineInternal.Video.VideoPlayback::StartPlayback");

		// Token: 0x040000B6 RID: 182
		private static readonly VideoPlayback.PausePlaybackDelegate PausePlaybackDelegateField = IL2CPP.ResolveICall<VideoPlayback.PausePlaybackDelegate>("UnityEngineInternal.Video.VideoPlayback::PausePlayback");

		// Token: 0x040000B7 RID: 183
		private static readonly VideoPlayback.StopPlaybackDelegate StopPlaybackDelegateField = IL2CPP.ResolveICall<VideoPlayback.StopPlaybackDelegate>("UnityEngineInternal.Video.VideoPlayback::StopPlayback");

		// Token: 0x040000B8 RID: 184
		private static readonly VideoPlayback.GetStatusDelegate GetStatusDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetStatusDelegate>("UnityEngineInternal.Video.VideoPlayback::GetStatus");

		// Token: 0x040000B9 RID: 185
		private static readonly VideoPlayback.IsReadyDelegate IsReadyDelegateField = IL2CPP.ResolveICall<VideoPlayback.IsReadyDelegate>("UnityEngineInternal.Video.VideoPlayback::IsReady");

		// Token: 0x040000BA RID: 186
		private static readonly VideoPlayback.IsPlayingDelegate IsPlayingDelegateField = IL2CPP.ResolveICall<VideoPlayback.IsPlayingDelegate>("UnityEngineInternal.Video.VideoPlayback::IsPlaying");

		// Token: 0x040000BB RID: 187
		private static readonly VideoPlayback.StepDelegate StepDelegateField = IL2CPP.ResolveICall<VideoPlayback.StepDelegate>("UnityEngineInternal.Video.VideoPlayback::Step");

		// Token: 0x040000BC RID: 188
		private static readonly VideoPlayback.CanStepDelegate CanStepDelegateField = IL2CPP.ResolveICall<VideoPlayback.CanStepDelegate>("UnityEngineInternal.Video.VideoPlayback::CanStep");

		// Token: 0x040000BD RID: 189
		private static readonly VideoPlayback.GetWidthDelegate GetWidthDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetWidthDelegate>("UnityEngineInternal.Video.VideoPlayback::GetWidth");

		// Token: 0x040000BE RID: 190
		private static readonly VideoPlayback.GetHeightDelegate GetHeightDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetHeightDelegate>("UnityEngineInternal.Video.VideoPlayback::GetHeight");

		// Token: 0x040000BF RID: 191
		private static readonly VideoPlayback.GetFrameRateDelegate GetFrameRateDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetFrameRateDelegate>("UnityEngineInternal.Video.VideoPlayback::GetFrameRate");

		// Token: 0x040000C0 RID: 192
		private static readonly VideoPlayback.GetDurationDelegate GetDurationDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetDurationDelegate>("UnityEngineInternal.Video.VideoPlayback::GetDuration");

		// Token: 0x040000C1 RID: 193
		private static readonly VideoPlayback.GetFrameCountDelegate GetFrameCountDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetFrameCountDelegate>("UnityEngineInternal.Video.VideoPlayback::GetFrameCount");

		// Token: 0x040000C2 RID: 194
		private static readonly VideoPlayback.GetPixelAspectRatioNumeratorDelegate GetPixelAspectRatioNumeratorDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPixelAspectRatioNumeratorDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioNumerator");

		// Token: 0x040000C3 RID: 195
		private static readonly VideoPlayback.GetPixelAspectRatioDenominatorDelegate GetPixelAspectRatioDenominatorDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPixelAspectRatioDenominatorDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioDenominator");

		// Token: 0x040000C4 RID: 196
		private static readonly VideoPlayback.GetPixelFormatDelegate GetPixelFormatDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPixelFormatDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelFormat");

		// Token: 0x040000C5 RID: 197
		private static readonly VideoPlayback.CanNotSkipOnDropDelegate CanNotSkipOnDropDelegateField = IL2CPP.ResolveICall<VideoPlayback.CanNotSkipOnDropDelegate>("UnityEngineInternal.Video.VideoPlayback::CanNotSkipOnDrop");

		// Token: 0x040000C6 RID: 198
		private static readonly VideoPlayback.SetSkipOnDropDelegate SetSkipOnDropDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetSkipOnDropDelegate>("UnityEngineInternal.Video.VideoPlayback::SetSkipOnDrop");

		// Token: 0x040000C7 RID: 199
		private static readonly VideoPlayback.GetTextureDelegate GetTextureDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetTextureDelegate>("UnityEngineInternal.Video.VideoPlayback::GetTexture");

		// Token: 0x040000C8 RID: 200
		private static readonly VideoPlayback.GetPlaybackSpeedDelegate GetPlaybackSpeedDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetPlaybackSpeedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPlaybackSpeed");

		// Token: 0x040000C9 RID: 201
		private static readonly VideoPlayback.SetPlaybackSpeedDelegate SetPlaybackSpeedDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetPlaybackSpeedDelegate>("UnityEngineInternal.Video.VideoPlayback::SetPlaybackSpeed");

		// Token: 0x040000CA RID: 202
		private static readonly VideoPlayback.GetLoopDelegate GetLoopDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetLoopDelegate>("UnityEngineInternal.Video.VideoPlayback::GetLoop");

		// Token: 0x040000CB RID: 203
		private static readonly VideoPlayback.SetLoopDelegate SetLoopDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetLoopDelegate>("UnityEngineInternal.Video.VideoPlayback::SetLoop");

		// Token: 0x040000CC RID: 204
		private static readonly VideoPlayback.SetAdjustToLinearSpaceDelegate SetAdjustToLinearSpaceDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetAdjustToLinearSpaceDelegate>("UnityEngineInternal.Video.VideoPlayback::SetAdjustToLinearSpace");

		// Token: 0x040000CD RID: 205
		private static readonly VideoPlayback.GetAudioTrackCountDelegate GetAudioTrackCountDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioTrackCountDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioTrackCount");

		// Token: 0x040000CE RID: 206
		private static readonly VideoPlayback.GetAudioChannelCountDelegate GetAudioChannelCountDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioChannelCountDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioChannelCount");

		// Token: 0x040000CF RID: 207
		private static readonly VideoPlayback.GetAudioSampleRateDelegate GetAudioSampleRateDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioSampleRateDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioSampleRate");

		// Token: 0x040000D0 RID: 208
		private static readonly VideoPlayback.SetAudioTargetDelegate SetAudioTargetDelegateField = IL2CPP.ResolveICall<VideoPlayback.SetAudioTargetDelegate>("UnityEngineInternal.Video.VideoPlayback::SetAudioTarget");

		// Token: 0x040000D1 RID: 209
		private static readonly VideoPlayback.GetAudioSampleProviderIdDelegate GetAudioSampleProviderIdDelegateField = IL2CPP.ResolveICall<VideoPlayback.GetAudioSampleProviderIdDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioSampleProviderId");

		// Token: 0x040000D2 RID: 210
		private static readonly VideoPlayback.PlatformSupportsH265Delegate PlatformSupportsH265DelegateField = IL2CPP.ResolveICall<VideoPlayback.PlatformSupportsH265Delegate>("UnityEngineInternal.Video.VideoPlayback::PlatformSupportsH265");

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060001D1 RID: 465
		private delegate void StartPlaybackDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060001D3 RID: 467
		private delegate void PausePlaybackDelegate(IntPtr @this);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060001D5 RID: 469
		private delegate void StopPlaybackDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060001D7 RID: 471
		private delegate VideoError GetStatusDelegate(IntPtr @this);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060001D9 RID: 473
		private delegate bool IsReadyDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060001DB RID: 475
		private delegate bool IsPlayingDelegate(IntPtr @this);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060001DD RID: 477
		private delegate void StepDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060001DF RID: 479
		private delegate bool CanStepDelegate(IntPtr @this);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060001E1 RID: 481
		private delegate uint GetWidthDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060001E3 RID: 483
		private delegate uint GetHeightDelegate(IntPtr @this);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060001E5 RID: 485
		private delegate float GetFrameRateDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060001E7 RID: 487
		private delegate float GetDurationDelegate(IntPtr @this);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060001E9 RID: 489
		private delegate ulong GetFrameCountDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060001EB RID: 491
		private delegate uint GetPixelAspectRatioNumeratorDelegate(IntPtr @this);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060001ED RID: 493
		private delegate uint GetPixelAspectRatioDenominatorDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060001EF RID: 495
		private delegate VideoPixelFormat GetPixelFormatDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060001F1 RID: 497
		private delegate bool CanNotSkipOnDropDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060001F3 RID: 499
		private delegate void SetSkipOnDropDelegate(IntPtr @this, bool skipOnDrop);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060001F5 RID: 501
		private delegate bool GetTextureDelegate(IntPtr @this, IntPtr texture, [Out] IntPtr outputFrameNum);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060001F7 RID: 503
		private delegate float GetPlaybackSpeedDelegate(IntPtr @this);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060001F9 RID: 505
		private delegate void SetPlaybackSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060001FB RID: 507
		private delegate bool GetLoopDelegate(IntPtr @this);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060001FD RID: 509
		private delegate void SetLoopDelegate(IntPtr @this, bool value);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060001FF RID: 511
		private delegate void SetAdjustToLinearSpaceDelegate(IntPtr @this, bool enable);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000201 RID: 513
		private delegate ushort GetAudioTrackCountDelegate(IntPtr @this);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000203 RID: 515
		private delegate ushort GetAudioChannelCountDelegate(IntPtr @this, ushort trackIdx);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000205 RID: 517
		private delegate uint GetAudioSampleRateDelegate(IntPtr @this, ushort trackIdx);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000207 RID: 519
		private delegate void SetAudioTargetDelegate(IntPtr @this, ushort trackIdx, bool enabled, bool softwareOutput, IntPtr audioSource);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000209 RID: 521
		private delegate uint GetAudioSampleProviderIdDelegate(IntPtr @this, ushort trackIndex);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600020B RID: 523
		private delegate bool PlatformSupportsH265Delegate();
	}
}
