using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public static class WWWAudioExtensions
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002954 File Offset: 0x00000B54
		public static AudioClip GetAudioClip(WWW www)
		{
			return www.GetAudioClip();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000296C File Offset: 0x00000B6C
		public static AudioClip GetAudioClip(WWW www, bool threeD)
		{
			return www.GetAudioClip(threeD);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002988 File Offset: 0x00000B88
		public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream)
		{
			return www.GetAudioClip(threeD, stream);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000029A4 File Offset: 0x00000BA4
		public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream, AudioType audioType)
		{
			return www.GetAudioClip(threeD, stream, audioType);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000029C0 File Offset: 0x00000BC0
		public static AudioClip GetAudioClipCompressed(WWW www)
		{
			return www.GetAudioClipCompressed();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000029D8 File Offset: 0x00000BD8
		public static AudioClip GetAudioClipCompressed(WWW www, bool threeD)
		{
			return www.GetAudioClipCompressed(threeD);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029F4 File Offset: 0x00000BF4
		public static AudioClip GetAudioClipCompressed(WWW www, bool threeD, AudioType audioType)
		{
			return www.GetAudioClipCompressed(threeD, audioType);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A10 File Offset: 0x00000C10
		public static MovieTexture GetMovieTexture(WWW www)
		{
			return www.GetMovieTexture();
		}
	}
}
