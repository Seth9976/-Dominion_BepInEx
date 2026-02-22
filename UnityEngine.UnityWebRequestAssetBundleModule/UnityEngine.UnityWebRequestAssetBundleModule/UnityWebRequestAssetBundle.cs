using System;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public static class UnityWebRequestAssetBundle
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020B4 File Offset: 0x000002B4
		public static UnityWebRequest GetAssetBundle(string uri)
		{
			return UnityWebRequestAssetBundle.GetAssetBundle(uri, 0U);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D0 File Offset: 0x000002D0
		public static UnityWebRequest GetAssetBundle(Uri uri)
		{
			return UnityWebRequestAssetBundle.GetAssetBundle(uri, 0U);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020EC File Offset: 0x000002EC
		public static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, crc), null);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002114 File Offset: 0x00000314
		public static UnityWebRequest GetAssetBundle(Uri uri, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri.AbsoluteUri, crc), null);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002140 File Offset: 0x00000340
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, version, crc), null);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002168 File Offset: 0x00000368
		public static UnityWebRequest GetAssetBundle(Uri uri, uint version, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri.AbsoluteUri, version, crc), null);
		}
	}
}
