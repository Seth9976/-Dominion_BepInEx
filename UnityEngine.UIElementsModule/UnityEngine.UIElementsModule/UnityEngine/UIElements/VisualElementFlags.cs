using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003D RID: 61
	[Flags]
	public enum VisualElementFlags
	{
		// Token: 0x040001F2 RID: 498
		WorldTransformDirty = 1,
		// Token: 0x040001F3 RID: 499
		WorldTransformInverseDirty = 2,
		// Token: 0x040001F4 RID: 500
		WorldClipDirty = 4,
		// Token: 0x040001F5 RID: 501
		BoundingBoxDirty = 8,
		// Token: 0x040001F6 RID: 502
		WorldBoundingBoxDirty = 16,
		// Token: 0x040001F7 RID: 503
		LayoutManual = 32,
		// Token: 0x040001F8 RID: 504
		CompositeRoot = 64,
		// Token: 0x040001F9 RID: 505
		RequireMeasureFunction = 128,
		// Token: 0x040001FA RID: 506
		EnableViewDataPersistence = 256,
		// Token: 0x040001FB RID: 507
		DisableClipping = 512,
		// Token: 0x040001FC RID: 508
		NeedsAttachToPanelEvent = 1024,
		// Token: 0x040001FD RID: 509
		Init = 31
	}
}
