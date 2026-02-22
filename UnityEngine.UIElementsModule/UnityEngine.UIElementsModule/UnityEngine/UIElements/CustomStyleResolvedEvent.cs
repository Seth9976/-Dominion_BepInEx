using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017A RID: 378
	public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent>
	{
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x000372A8 File Offset: 0x000354A8
		public ICustomStyle customStyle
		{
			get
			{
				VisualElement visualElement = base.target.TryCast<VisualElement>();
				return (visualElement != null) ? visualElement.customStyle : null;
			}
		}
	}
}
