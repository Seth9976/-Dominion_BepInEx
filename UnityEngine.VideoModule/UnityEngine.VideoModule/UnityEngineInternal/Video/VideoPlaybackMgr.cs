using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal.Video
{
	// Token: 0x02000011 RID: 17
	public class VideoPlaybackMgr
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00002BBE File Offset: 0x00000DBE
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002BCB File Offset: 0x00000DCB
		public static IntPtr Internal_Create()
		{
			return VideoPlaybackMgr.Internal_CreateDelegateField();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002BD7 File Offset: 0x00000DD7
		public static void Internal_Destroy(IntPtr ptr)
		{
			VideoPlaybackMgr.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public void ReleaseVideoPlayback(VideoPlayback playback)
		{
			VideoPlaybackMgr.ReleaseVideoPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(playback));
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002BFC File Offset: 0x00000DFC
		public ulong videoPlaybackCount
		{
			get
			{
				return VideoPlaybackMgr.get_videoPlaybackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002C0E File Offset: 0x00000E0E
		public void Update()
		{
			VideoPlaybackMgr.UpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002C20 File Offset: 0x00000E20
		public static void ProcessOSMainLoopMessagesForTesting()
		{
			VideoPlaybackMgr.ProcessOSMainLoopMessagesForTestingDelegateField();
		}

		// Token: 0x040000D3 RID: 211
		private static readonly VideoPlaybackMgr.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.Internal_CreateDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Create");

		// Token: 0x040000D4 RID: 212
		private static readonly VideoPlaybackMgr.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.Internal_DestroyDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Destroy");

		// Token: 0x040000D5 RID: 213
		private static readonly VideoPlaybackMgr.ReleaseVideoPlaybackDelegate ReleaseVideoPlaybackDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.ReleaseVideoPlaybackDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::ReleaseVideoPlayback");

		// Token: 0x040000D6 RID: 214
		private static readonly VideoPlaybackMgr.get_videoPlaybackCountDelegate get_videoPlaybackCountDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.get_videoPlaybackCountDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::get_videoPlaybackCount");

		// Token: 0x040000D7 RID: 215
		private static readonly VideoPlaybackMgr.UpdateDelegate UpdateDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.UpdateDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Update");

		// Token: 0x040000D8 RID: 216
		private static readonly VideoPlaybackMgr.ProcessOSMainLoopMessagesForTestingDelegate ProcessOSMainLoopMessagesForTestingDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.ProcessOSMainLoopMessagesForTestingDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::ProcessOSMainLoopMessagesForTesting");

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600020D RID: 525
		private delegate IntPtr Internal_CreateDelegate();

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x0600020F RID: 527
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000211 RID: 529
		private delegate void ReleaseVideoPlaybackDelegate(IntPtr @this, IntPtr playback);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000213 RID: 531
		private delegate ulong get_videoPlaybackCountDelegate(IntPtr @this);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000215 RID: 533
		private delegate void UpdateDelegate(IntPtr @this);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000217 RID: 535
		private delegate void ProcessOSMainLoopMessagesForTestingDelegate();
	}
}
