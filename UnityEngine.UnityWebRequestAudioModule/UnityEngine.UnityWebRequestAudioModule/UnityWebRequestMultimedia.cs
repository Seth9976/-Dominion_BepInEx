using System;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	public static class UnityWebRequestMultimedia
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002234 File Offset: 0x00000434
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAudioClip(uri, audioType), null);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000225C File Offset: 0x0000045C
		public static UnityWebRequest GetAudioClip(Uri uri, AudioType audioType)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAudioClip(uri, audioType), null);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002284 File Offset: 0x00000484
		public static UnityWebRequest GetMovieTexture(string uri)
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002298 File Offset: 0x00000498
		public static UnityWebRequest GetMovieTexture(Uri uri)
		{
			return null;
		}
	}
}
