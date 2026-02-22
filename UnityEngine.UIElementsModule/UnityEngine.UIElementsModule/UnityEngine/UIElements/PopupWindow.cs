using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000149 RID: 329
	public class PopupWindow : TextElement
	{
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00009A83 File Offset: 0x00007C83
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0200025B RID: 603
		public new class UxmlFactory : UxmlFactory<PopupWindow, PopupWindow.UxmlTraits>
		{
		}

		// Token: 0x0200025C RID: 604
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x020002A5 RID: 677
			public sealed class <get_uxmlChildElementsDescription>d__1
			{
			}
		}
	}
}
