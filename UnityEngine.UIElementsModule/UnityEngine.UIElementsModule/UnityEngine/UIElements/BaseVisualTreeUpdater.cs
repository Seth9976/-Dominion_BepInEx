using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012F RID: 303
	public abstract class BaseVisualTreeUpdater
	{
		// Token: 0x06000E38 RID: 3640 RVA: 0x00009072 File Offset: 0x00007272
		public void add_panelChanged(Action<BaseVisualElementPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0000907F File Offset: 0x0000727F
		public void remove_panelChanged(Action<BaseVisualElementPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0000908C File Offset: 0x0000728C
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00009099 File Offset: 0x00007299
		public BaseVisualElementPanel panel
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

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00035930 File Offset: 0x00033B30
		public VisualElement visualTree
		{
			get
			{
				return this.panel.visualTree;
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000090A6 File Offset: 0x000072A6
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x000090B8 File Offset: 0x000072B8
		public virtual void Dispose(bool disposing)
		{
		}
	}
}
