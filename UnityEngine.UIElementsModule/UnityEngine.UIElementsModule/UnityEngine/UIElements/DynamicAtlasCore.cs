using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000182 RID: 386
	public class DynamicAtlasCore
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0000AC01 File Offset: 0x00008E01
		public int maxImageSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0000AC0E File Offset: 0x00008E0E
		public RenderTextureFormat format
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0000AC1B File Offset: 0x00008E1B
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x0000AC28 File Offset: 0x00008E28
		public RenderTexture atlas
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0000AC35 File Offset: 0x00008E35
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x0000AC42 File Offset: 0x00008E42
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0000AC4F File Offset: 0x00008E4F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0000AC61 File Offset: 0x00008E61
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0000AC6E File Offset: 0x00008E6E
		public static void LogDisposeError()
		{
			Debug.LogError("An attempt to use a disposed atlas manager has been detected.");
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000375C8 File Offset: 0x000357C8
		public bool IsReleased()
		{
			return this.atlas != null && !this.atlas.IsCreated();
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0000AC7C File Offset: 0x00008E7C
		public void UpdateTexture(Texture2D image)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0000AC89 File Offset: 0x00008E89
		public bool AllocateRect(int width, int height, out RectInt uvs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0000AC96 File Offset: 0x00008E96
		public void EnqueueBlit(Texture image, RectInt srcRect, int x, int y, bool addBorder, Color tint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0000ACA3 File Offset: 0x00008EA3
		public void Commit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		public void UpdateAtlasTexture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0000ACBD File Offset: 0x00008EBD
		public RenderTexture CreateAtlasTexture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
