using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010F RID: 271
	public class KeyboardNavigationManipulator : Manipulator
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x00034AD0 File Offset: 0x00032CD0
		public override void RegisterCallbacksOnTarget()
		{
			base.target.RegisterCallback<NavigationMoveEvent>(new EventCallback<NavigationMoveEvent>(this.OnNavigationMove), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<NavigationSubmitEvent>(new EventCallback<NavigationSubmitEvent>(this.OnNavigationSubmit), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<NavigationCancelEvent>(new EventCallback<NavigationCancelEvent>(this.OnNavigationCancel), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<KeyDownEvent>(new EventCallback<KeyDownEvent>(this.OnKeyDown), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00034B44 File Offset: 0x00032D44
		public override void UnregisterCallbacksFromTarget()
		{
			base.target.UnregisterCallback<NavigationMoveEvent>(new EventCallback<NavigationMoveEvent>(this.OnNavigationMove), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<NavigationSubmitEvent>(new EventCallback<NavigationSubmitEvent>(this.OnNavigationSubmit), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<NavigationCancelEvent>(new EventCallback<NavigationCancelEvent>(this.OnNavigationCancel), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<KeyDownEvent>(new EventCallback<KeyDownEvent>(this.OnKeyDown), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00034BB8 File Offset: 0x00032DB8
		public void OnKeyDown(KeyDownEvent evt)
		{
			IPanel panel = base.target.panel;
			bool flag = panel != null && panel.contextType == ContextType.Editor;
			if (flag)
			{
				this.OnEditorKeyDown(evt);
			}
			else
			{
				this.OnRuntimeKeyDown(evt);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00008BAF File Offset: 0x00006DAF
		public void OnRuntimeKeyDown(KeyDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00008BBC File Offset: 0x00006DBC
		public void OnEditorKeyDown(KeyDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00008BC9 File Offset: 0x00006DC9
		public void OnNavigationCancel(NavigationCancelEvent evt)
		{
			this.Invoke(KeyboardNavigationOperation.Cancel, evt);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00008BD5 File Offset: 0x00006DD5
		public void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			this.Invoke(KeyboardNavigationOperation.Submit, evt);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00034BF8 File Offset: 0x00032DF8
		public void OnNavigationMove(NavigationMoveEvent evt)
		{
			NavigationMoveEvent.Direction direction = evt.direction;
			NavigationMoveEvent.Direction direction2 = direction;
			if (direction2 != NavigationMoveEvent.Direction.Up)
			{
				if (direction2 == NavigationMoveEvent.Direction.Down)
				{
					this.Invoke(KeyboardNavigationOperation.Next, evt);
				}
			}
			else
			{
				this.Invoke(KeyboardNavigationOperation.Previous, evt);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00008BE1 File Offset: 0x00006DE1
		public void Invoke(KeyboardNavigationOperation operation, EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
