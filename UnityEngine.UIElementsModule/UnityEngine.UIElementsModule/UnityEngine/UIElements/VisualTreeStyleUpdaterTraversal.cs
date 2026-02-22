using System;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012D RID: 301
	public class VisualTreeStyleUpdaterTraversal : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00008FCB File Offset: 0x000071CB
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00008FD8 File Offset: 0x000071D8
		public float currentPixelsPerPoint
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

		// Token: 0x06000E2B RID: 3627 RVA: 0x00008FE5 File Offset: 0x000071E5
		public void PrepareTraversal(float pixelsPerPoint)
		{
			this.currentPixelsPerPoint = pixelsPerPoint;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00008FF0 File Offset: 0x000071F0
		public void AddChangedElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00008FFD File Offset: 0x000071FD
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0000900A File Offset: 0x0000720A
		public void PropagateToChildren(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00009017 File Offset: 0x00007217
		public void PropagateToParents(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00009024 File Offset: 0x00007224
		public override void TraverseRecursive(VisualElement element, int depth)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00009031 File Offset: 0x00007231
		public bool ShouldSkipElement(VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0000903E File Offset: 0x0000723E
		public void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000243 RID: 579
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
