using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000156 RID: 342
	public class TextEditorEngine : TextEditor
	{
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00036E80 File Offset: 0x00035080
		public override Rect localPosition
		{
			get
			{
				return new Rect(0f, 0f, base.position.width, base.position.height);
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00009F98 File Offset: 0x00008198
		public override void OnDetectFocusChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00009FA5 File Offset: 0x000081A5
		public override void OnCursorIndexChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00009FB2 File Offset: 0x000081B2
		public override void OnSelectIndexChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
