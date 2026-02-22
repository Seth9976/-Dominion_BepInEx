using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001BD RID: 445
	public class TextureBlitter
	{
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0000BA6B File Offset: 0x00009C6B
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x0000BA78 File Offset: 0x00009C78
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

		// Token: 0x06001212 RID: 4626 RVA: 0x0000BA85 File Offset: 0x00009C85
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0000BA97 File Offset: 0x00009C97
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0000BAB1 File Offset: 0x00009CB1
		public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x0000BABE File Offset: 0x00009CBE
		public int queueLength
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0000BACB File Offset: 0x00009CCB
		public void Commit(RenderTexture dst)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0000BAE5 File Offset: 0x00009CE5
		public void BeginBlit(RenderTexture dst)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0000BAF2 File Offset: 0x00009CF2
		public void EndBlit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007FF RID: 2047
		public const int k_TextureSlotCount = 8;
	}
}
