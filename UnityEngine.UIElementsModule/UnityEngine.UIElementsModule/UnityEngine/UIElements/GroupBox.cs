using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013E RID: 318
	public class GroupBox : BindableElement
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0000944B File Offset: 0x0000764B
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00009458 File Offset: 0x00007658
		public string text
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

		// Token: 0x0200024D RID: 589
		public new class UxmlFactory : UxmlFactory<GroupBox, GroupBox.UxmlTraits>
		{
		}

		// Token: 0x0200024E RID: 590
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
		}
	}
}
