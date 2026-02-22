using System;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000130 RID: 304
	public class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x000090BB File Offset: 0x000072BB
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000090C8 File Offset: 0x000072C8
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000090D5 File Offset: 0x000072D5
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000090E2 File Offset: 0x000072E2
		public void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000090EF File Offset: 0x000072EF
		public void PropagateToParents(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007A5 RID: 1957
		public const int kMaxValidatePersistentDataCount = 5;
	}
}
