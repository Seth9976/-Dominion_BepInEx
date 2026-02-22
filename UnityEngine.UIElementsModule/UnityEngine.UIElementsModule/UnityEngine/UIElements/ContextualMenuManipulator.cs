using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F9 RID: 249
	public class ContextualMenuManipulator : MouseManipulator
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x00034550 File Offset: 0x00032750
		public override void RegisterCallbacksOnTarget()
		{
			bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
			if (flag)
			{
				base.target.RegisterCallback<MouseDownEvent>(new EventCallback<MouseDownEvent>(this.OnMouseDownEventOSX), TrickleDown.NoTrickleDown);
				base.target.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUpEventOSX), TrickleDown.NoTrickleDown);
			}
			else
			{
				base.target.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUpDownEvent), TrickleDown.NoTrickleDown);
			}
			base.target.RegisterCallback<KeyUpEvent>(new EventCallback<KeyUpEvent>(this.OnKeyUpEvent), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<ContextualMenuPopulateEvent>(new EventCallback<ContextualMenuPopulateEvent>(this.OnContextualMenuEvent), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000345F8 File Offset: 0x000327F8
		public override void UnregisterCallbacksFromTarget()
		{
			bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
			if (flag)
			{
				base.target.UnregisterCallback<MouseDownEvent>(new EventCallback<MouseDownEvent>(this.OnMouseDownEventOSX), TrickleDown.NoTrickleDown);
				base.target.UnregisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUpEventOSX), TrickleDown.NoTrickleDown);
			}
			else
			{
				base.target.UnregisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUpDownEvent), TrickleDown.NoTrickleDown);
			}
			base.target.UnregisterCallback<KeyUpEvent>(new EventCallback<KeyUpEvent>(this.OnKeyUpEvent), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<ContextualMenuPopulateEvent>(new EventCallback<ContextualMenuPopulateEvent>(this.OnContextualMenuEvent), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000346A0 File Offset: 0x000328A0
		public void OnMouseUpDownEvent(IMouseEvent evt)
		{
			bool flag = base.CanStartManipulation(evt);
			if (flag)
			{
				this.DoDisplayMenu(evt.TryCast<EventBase>());
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000346C8 File Offset: 0x000328C8
		public void OnMouseDownEventOSX(MouseDownEvent evt)
		{
			BaseVisualElementPanel elementPanel = base.target.elementPanel;
			bool flag = ((elementPanel != null) ? elementPanel.contextualMenuManager : null) != null;
			if (flag)
			{
				base.target.elementPanel.contextualMenuManager.displayMenuHandledOSX = false;
			}
			bool isDefaultPrevented = evt.isDefaultPrevented;
			if (!isDefaultPrevented)
			{
				this.OnMouseUpDownEvent(evt);
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00034724 File Offset: 0x00032924
		public void OnMouseUpEventOSX(MouseUpEvent evt)
		{
			BaseVisualElementPanel elementPanel = base.target.elementPanel;
			bool flag = ((elementPanel != null) ? elementPanel.contextualMenuManager : null) != null && base.target.elementPanel.contextualMenuManager.displayMenuHandledOSX;
			if (!flag)
			{
				this.OnMouseUpDownEvent(evt);
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00034774 File Offset: 0x00032974
		public void OnKeyUpEvent(KeyUpEvent evt)
		{
			bool flag = evt.keyCode == KeyCode.Menu;
			if (flag)
			{
				this.DoDisplayMenu(evt);
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000347A0 File Offset: 0x000329A0
		public void DoDisplayMenu(EventBase evt)
		{
			BaseVisualElementPanel elementPanel = base.target.elementPanel;
			bool flag = ((elementPanel != null) ? elementPanel.contextualMenuManager : null) != null;
			if (flag)
			{
				base.target.elementPanel.contextualMenuManager.DisplayMenu(evt, base.target);
				evt.StopPropagation();
				evt.PreventDefault();
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000088EA File Offset: 0x00006AEA
		public void OnContextualMenuEvent(ContextualMenuPopulateEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
