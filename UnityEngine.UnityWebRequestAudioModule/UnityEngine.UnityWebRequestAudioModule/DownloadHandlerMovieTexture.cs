using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000004 RID: 4
	public sealed class DownloadHandlerMovieTexture : DownloadHandler
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000022AC File Offset: 0x000004AC
		public override Il2CppStructArray<byte> GetData()
		{
			DownloadHandlerMovieTexture.FeatureRemoved();
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020DA File Offset: 0x000002DA
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported for movies");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000022C8 File Offset: 0x000004C8
		public MovieTexture movieTexture
		{
			get
			{
				DownloadHandlerMovieTexture.FeatureRemoved();
				return null;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022E4 File Offset: 0x000004E4
		public static MovieTexture GetContent(UnityWebRequest uwr)
		{
			DownloadHandlerMovieTexture.FeatureRemoved();
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020E7 File Offset: 0x000002E7
		public static void FeatureRemoved()
		{
			throw new Exception("Movie texture has been removed, use VideoPlayer instead");
		}
	}
}
