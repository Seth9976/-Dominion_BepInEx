using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013A RID: 314
	public class Button : TextElement
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00009250 File Offset: 0x00007450
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x0000925D File Offset: 0x0000745D
		public Clickable clickable
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

		// Token: 0x06000E67 RID: 3687 RVA: 0x0000926A File Offset: 0x0000746A
		public void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			Clickable clickable = this.clickable;
			if (clickable != null)
			{
				clickable.SimulateSingleClick(evt, 100);
			}
			evt.StopPropagation();
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00035B10 File Offset: 0x00033D10
		public void OnKeyDown(KeyDownEvent evt)
		{
			IPanel panel = base.panel;
			bool flag = panel == null || panel.contextType != ContextType.Editor;
			if (!flag)
			{
				bool flag2 = evt.keyCode == KeyCode.KeypadEnter || evt.keyCode == KeyCode.Return || evt.keyCode == KeyCode.Space;
				if (flag2)
				{
					Clickable clickable = this.clickable;
					if (clickable != null)
					{
						clickable.SimulateSingleClick(evt, 100);
					}
					evt.StopPropagation();
				}
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00009289 File Offset: 0x00007489
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000246 RID: 582
		public new class UxmlFactory : UxmlFactory<Button, Button.UxmlTraits>
		{
		}

		// Token: 0x02000247 RID: 583
		public new class UxmlTraits : TextElement.UxmlTraits
		{
		}
	}
}
