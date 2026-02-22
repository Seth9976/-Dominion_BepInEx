using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001D RID: 29
	public sealed class MovieTexture : Texture
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00003496 File Offset: 0x00001696
		public static void FeatureRemoved()
		{
			throw new Exception("MovieTexture has been removed from Unity. Use VideoPlayer instead.");
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000034A3 File Offset: 0x000016A3
		public void Play()
		{
			MovieTexture.FeatureRemoved();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000034AC File Offset: 0x000016AC
		public void Stop()
		{
			MovieTexture.FeatureRemoved();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000034B5 File Offset: 0x000016B5
		public void Pause()
		{
			MovieTexture.FeatureRemoved();
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006430 File Offset: 0x00004630
		public AudioClip audioClip
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000644C File Offset: 0x0000464C
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000034BE File Offset: 0x000016BE
		public bool loop
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return false;
			}
			set
			{
				MovieTexture.FeatureRemoved();
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00006468 File Offset: 0x00004668
		public bool isPlaying
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return false;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00006484 File Offset: 0x00004684
		public bool isReadyToPlay
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return false;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000064A0 File Offset: 0x000046A0
		public float duration
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return 1f;
			}
		}
	}
}
