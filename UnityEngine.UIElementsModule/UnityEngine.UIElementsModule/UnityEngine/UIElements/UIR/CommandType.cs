using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000DE RID: 222
	public enum CommandType
	{
		// Token: 0x040006B7 RID: 1719
		Draw,
		// Token: 0x040006B8 RID: 1720
		ImmediateCull,
		// Token: 0x040006B9 RID: 1721
		Immediate,
		// Token: 0x040006BA RID: 1722
		PushView,
		// Token: 0x040006BB RID: 1723
		PopView,
		// Token: 0x040006BC RID: 1724
		PushScissor,
		// Token: 0x040006BD RID: 1725
		PopScissor,
		// Token: 0x040006BE RID: 1726
		PushRenderTexture,
		// Token: 0x040006BF RID: 1727
		PopRenderTexture,
		// Token: 0x040006C0 RID: 1728
		BlitToPreviousRT,
		// Token: 0x040006C1 RID: 1729
		PushDefaultMaterial,
		// Token: 0x040006C2 RID: 1730
		PopDefaultMaterial
	}
}
