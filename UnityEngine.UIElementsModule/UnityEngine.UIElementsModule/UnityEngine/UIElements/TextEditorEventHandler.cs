using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000155 RID: 341
	public class TextEditorEventHandler
	{
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00009F61 File Offset: 0x00008161
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00009F6E File Offset: 0x0000816E
		public TextEditorEngine editorEngine
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00009F7B File Offset: 0x0000817B
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00009F88 File Offset: 0x00008188
		public ITextInputField textInputField
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

		// Token: 0x06000F97 RID: 3991 RVA: 0x00009F95 File Offset: 0x00008195
		public virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00036E18 File Offset: 0x00035018
		public virtual void ExecuteDefaultAction(EventBase evt)
		{
			bool flag = evt.eventTypeId == EventBase<FocusEvent>.TypeId();
			if (flag)
			{
				this.editorEngine.OnFocus();
				this.editorEngine.SelectAll();
			}
			else
			{
				bool flag2 = evt.eventTypeId == EventBase<BlurEvent>.TypeId();
				if (flag2)
				{
					this.editorEngine.OnLostFocus();
					this.editorEngine.SelectNone();
				}
			}
		}
	}
}
