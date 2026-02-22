using System;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012E RID: 302
	public class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x0000904B File Offset: 0x0000724B
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00009058 File Offset: 0x00007258
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00035830 File Offset: 0x00033A30
		public static void DirtyHierarchy(VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip)
		{
			if (mustDirtyWorldTransform)
			{
				ve.isWorldTransformDirty = true;
				ve.isWorldBoundingBoxDirty = true;
			}
			if (mustDirtyWorldClip)
			{
				ve.isWorldClipDirty = true;
			}
			VisualElement.Hierarchy hierarchy = ve.hierarchy;
			int childCount = hierarchy.childCount;
			for (int i = 0; i < childCount; i++)
			{
				hierarchy = ve.hierarchy;
				VisualElement visualElement = hierarchy[i];
				bool flag = (mustDirtyWorldTransform && !visualElement.isWorldTransformDirty) || (mustDirtyWorldClip && !visualElement.isWorldClipDirty);
				if (flag)
				{
					VisualTreeTransformClipUpdater.DirtyHierarchy(visualElement, mustDirtyWorldTransform, mustDirtyWorldClip);
				}
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000358CC File Offset: 0x00033ACC
		public static void DirtyBoundingBoxHierarchy(VisualElement ve)
		{
			ve.isBoundingBoxDirty = true;
			ve.isWorldBoundingBoxDirty = true;
			VisualElement.Hierarchy hierarchy = ve.hierarchy;
			VisualElement visualElement = hierarchy.parent;
			while (visualElement != null && !visualElement.isBoundingBoxDirty)
			{
				visualElement.isBoundingBoxDirty = true;
				visualElement.isWorldBoundingBoxDirty = true;
				hierarchy = visualElement.hierarchy;
				visualElement = hierarchy.parent;
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00009065 File Offset: 0x00007265
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
