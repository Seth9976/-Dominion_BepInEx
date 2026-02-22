using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000129 RID: 297
	public abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x06000E1B RID: 3611 RVA: 0x00008F15 File Offset: 0x00007115
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00008F22 File Offset: 0x00007122
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00008F2F File Offset: 0x0000712F
		public void ProcessNewChange(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00008F3C File Offset: 0x0000713C
		public void ProcessAddOrMove(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00008F49 File Offset: 0x00007149
		public void ProcessRemove(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000242 RID: 578
		public enum State
		{
			// Token: 0x04000915 RID: 2325
			Waiting,
			// Token: 0x04000916 RID: 2326
			TrackingAddOrMove,
			// Token: 0x04000917 RID: 2327
			TrackingRemove
		}
	}
}
