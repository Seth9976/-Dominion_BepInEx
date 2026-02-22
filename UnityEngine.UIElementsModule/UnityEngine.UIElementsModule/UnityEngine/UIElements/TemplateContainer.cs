using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011C RID: 284
	public class TemplateContainer : BindableElement
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00008C7D File Offset: 0x00006E7D
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x00008C8A File Offset: 0x00006E8A
		public string templateId
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

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00008C97 File Offset: 0x00006E97
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00008CA4 File Offset: 0x00006EA4
		public void SetContentContainer(VisualElement content)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000235 RID: 565
		public new class UxmlFactory : UxmlFactory<TemplateContainer, TemplateContainer.UxmlTraits>
		{
		}

		// Token: 0x02000236 RID: 566
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x020002A0 RID: 672
			public sealed class <get_uxmlChildElementsDescription>d__3
			{
			}
		}
	}
}
