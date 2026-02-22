using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001C3 RID: 451
	public class VectorImageManager
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0000BB81 File Offset: 0x00009D81
		public Texture2D atlas
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0000BB8E File Offset: 0x00009D8E
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000BB9B File Offset: 0x00009D9B
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

		// Token: 0x06001228 RID: 4648 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0000BBBA File Offset: 0x00009DBA
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0000BBC7 File Offset: 0x00009DC7
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public void Commit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0000BBE1 File Offset: 0x00009DE1
		public GradientRemap AddUser(VectorImage vi, VisualElement context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0000BBEE File Offset: 0x00009DEE
		public void RemoveUser(VectorImage vi)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0000BBFB File Offset: 0x00009DFB
		public VectorImageRenderInfo Register(VectorImage vi, VisualElement context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0000BC08 File Offset: 0x00009E08
		public void Unregister(VectorImage vi, VectorImageRenderInfo renderInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
