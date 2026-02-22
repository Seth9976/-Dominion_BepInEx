using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	public sealed class GUITexture
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00004A1B File Offset: 0x00002C1B
		public static void FeatureRemoved()
		{
			throw new Exception("GUITexture has been removed from Unity. Use UI.Image instead.");
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00016D6C File Offset: 0x00014F6C
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00004A28 File Offset: 0x00002C28
		public Color color
		{
			get
			{
				GUITexture.FeatureRemoved();
				return new Color(0f, 0f, 0f);
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00016D98 File Offset: 0x00014F98
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00004A31 File Offset: 0x00002C31
		public Texture texture
		{
			get
			{
				GUITexture.FeatureRemoved();
				return null;
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00016DB4 File Offset: 0x00014FB4
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00004A3A File Offset: 0x00002C3A
		public Rect pixelInset
		{
			get
			{
				GUITexture.FeatureRemoved();
				return default(Rect);
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00016DD8 File Offset: 0x00014FD8
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00004A43 File Offset: 0x00002C43
		public RectOffset border
		{
			get
			{
				GUITexture.FeatureRemoved();
				return null;
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}
	}
}
