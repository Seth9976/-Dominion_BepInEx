using System;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public static class UnityWebRequestTexture
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020A0 File Offset: 0x000002A0
		public static UnityWebRequest GetTexture(string uri)
		{
			return UnityWebRequestTexture.GetTexture(uri, false);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020BC File Offset: 0x000002BC
		public static UnityWebRequest GetTexture(Uri uri)
		{
			return UnityWebRequestTexture.GetTexture(uri, false);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020D8 File Offset: 0x000002D8
		public static UnityWebRequest GetTexture(string uri, bool nonReadable)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerTexture(!nonReadable), null);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002100 File Offset: 0x00000300
		public static UnityWebRequest GetTexture(Uri uri, bool nonReadable)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerTexture(!nonReadable), null);
		}
	}
}
