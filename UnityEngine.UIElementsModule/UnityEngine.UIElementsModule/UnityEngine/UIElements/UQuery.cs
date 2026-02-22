using System;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011F RID: 287
	public static class UQuery
	{
		// Token: 0x02000239 RID: 569
		public interface IVisualPredicateWrapper
		{
		}

		// Token: 0x0200023A RID: 570
		public abstract class UQueryMatcher : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
		{
			// Token: 0x020002A2 RID: 674
			[Serializable]
			public sealed class <>c
			{
			}
		}

		// Token: 0x0200023B RID: 571
		public abstract class SingleQueryMatcher : UQuery.UQueryMatcher
		{
		}

		// Token: 0x0200023C RID: 572
		public class FirstQueryMatcher : UQuery.SingleQueryMatcher
		{
		}

		// Token: 0x0200023D RID: 573
		public class LastQueryMatcher : UQuery.SingleQueryMatcher
		{
		}

		// Token: 0x0200023E RID: 574
		public class IndexQueryMatcher : UQuery.SingleQueryMatcher
		{
		}
	}
}
