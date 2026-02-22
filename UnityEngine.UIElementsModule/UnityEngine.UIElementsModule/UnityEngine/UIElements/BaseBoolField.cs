using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000133 RID: 307
	public abstract class BaseBoolField : BaseField<bool>
	{
		// Token: 0x06000E5B RID: 3675 RVA: 0x000091F1 File Offset: 0x000073F1
		public void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			this.ToggleValue();
			evt.StopPropagation();
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00035A04 File Offset: 0x00033C04
		public void OnKeyDown(KeyDownEvent evt)
		{
			IPanel panel = base.panel;
			bool flag = panel == null || panel.contextType != ContextType.Editor;
			if (!flag)
			{
				bool flag2 = evt.keyCode == KeyCode.KeypadEnter || evt.keyCode == KeyCode.Return || evt.keyCode == KeyCode.Space;
				if (flag2)
				{
					this.ToggleValue();
					evt.StopPropagation();
				}
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00009202 File Offset: 0x00007402
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x0000920F File Offset: 0x0000740F
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

		// Token: 0x06000E5F RID: 3679 RVA: 0x0000921C File Offset: 0x0000741C
		public virtual void InitLabel()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00009229 File Offset: 0x00007429
		public override void SetValueWithoutNotify(bool newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00035A68 File Offset: 0x00033C68
		public void OnClickEvent(EventBase evt)
		{
			bool flag = evt.eventTypeId == EventBase<MouseUpEvent>.TypeId();
			if (flag)
			{
				IMouseEvent mouseEvent = evt.Cast<IMouseEvent>();
				bool flag2 = mouseEvent.button == 0;
				if (flag2)
				{
					this.ToggleValue();
				}
			}
			else
			{
				bool flag3 = evt.eventTypeId == EventBase<PointerUpEvent>.TypeId() || evt.eventTypeId == EventBase<ClickEvent>.TypeId();
				if (flag3)
				{
					IPointerEvent pointerEvent = evt.Cast<IPointerEvent>();
					bool flag4 = pointerEvent.button == 0;
					if (flag4)
					{
						this.ToggleValue();
					}
				}
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00009236 File Offset: 0x00007436
		public virtual void ToggleValue()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00009243 File Offset: 0x00007443
		public override void UpdateMixedValueContent()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
