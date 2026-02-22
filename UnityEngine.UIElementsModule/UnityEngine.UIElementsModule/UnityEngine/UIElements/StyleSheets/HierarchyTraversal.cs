using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001CE RID: 462
	public abstract class HierarchyTraversal
	{
		// Token: 0x06001285 RID: 4741 RVA: 0x0000BFDF File Offset: 0x0000A1DF
		public virtual void Traverse(VisualElement element)
		{
			this.TraverseRecursive(element, 0);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00039700 File Offset: 0x00037900
		public void Recurse(VisualElement element, int depth)
		{
			int num = 0;
			for (;;)
			{
				int num2 = num;
				VisualElement.Hierarchy hierarchy = element.hierarchy;
				if (num2 >= hierarchy.childCount)
				{
					break;
				}
				hierarchy = element.hierarchy;
				VisualElement visualElement = hierarchy[num];
				this.TraverseRecursive(visualElement, depth + 1);
				hierarchy = visualElement.hierarchy;
				bool flag = hierarchy.parent != element;
				if (!flag)
				{
					num++;
				}
			}
		}
	}
}
