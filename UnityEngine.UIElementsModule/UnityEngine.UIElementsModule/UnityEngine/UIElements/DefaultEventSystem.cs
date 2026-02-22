using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FB RID: 251
	public class DefaultEventSystem
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00008907 File Offset: 0x00006B07
		public bool isAppFocused
		{
			get
			{
				return Application.isFocused;
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00034858 File Offset: 0x00032A58
		public bool ShouldIgnoreEventsOnAppNotFocused()
		{
			OperatingSystemFamily operatingSystemFamily = SystemInfo.operatingSystemFamily;
			OperatingSystemFamily operatingSystemFamily2 = operatingSystemFamily;
			return operatingSystemFamily2 - OperatingSystemFamily.MacOSX <= 2;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0000890E File Offset: 0x00006B0E
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0000891B File Offset: 0x00006B1B
		public BaseRuntimePanel focusedPanel
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

		// Token: 0x06000D87 RID: 3463 RVA: 0x00034880 File Offset: 0x00032A80
		public void Update()
		{
			bool flag = !this.isAppFocused && this.ShouldIgnoreEventsOnAppNotFocused();
			if (!flag)
			{
				this.SendIMGUIEvents();
				this.SendInputEvents();
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00008928 File Offset: 0x00006B28
		public void SendIMGUIEvents()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00008935 File Offset: 0x00006B35
		public void SendInputEvents()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000348B4 File Offset: 0x00032AB4
		public void UpdateFocusedPanel(BaseRuntimePanel runtimePanel)
		{
			bool flag = runtimePanel.focusController.focusedElement != null;
			if (flag)
			{
				this.focusedPanel = runtimePanel;
			}
			else
			{
				bool flag2 = this.focusedPanel == runtimePanel;
				if (flag2)
				{
					this.focusedPanel = null;
				}
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000348F8 File Offset: 0x00032AF8
		public static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers)
		{
			touch.position = new Vector2(touch.position.x, (float)Screen.height - touch.position.y);
			touch.rawPosition = new Vector2(touch.rawPosition.x, (float)Screen.height - touch.rawPosition.y);
			touch.deltaPosition = new Vector2(touch.deltaPosition.x, (float)Screen.height - touch.deltaPosition.y);
			EventBase eventBase;
			switch (touch.phase)
			{
			case TouchPhase.Began:
				eventBase = PointerEventBase<PointerDownEvent>.GetPooled(touch, modifiers);
				break;
			case TouchPhase.Moved:
				eventBase = PointerEventBase<PointerMoveEvent>.GetPooled(touch, modifiers);
				break;
			case TouchPhase.Stationary:
				eventBase = PointerEventBase<PointerStationaryEvent>.GetPooled(touch, modifiers);
				break;
			case TouchPhase.Ended:
				eventBase = PointerEventBase<PointerUpEvent>.GetPooled(touch, modifiers);
				break;
			case TouchPhase.Canceled:
				eventBase = PointerEventBase<PointerCancelEvent>.GetPooled(touch, modifiers);
				break;
			default:
				eventBase = null;
				break;
			}
			return eventBase;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00008942 File Offset: 0x00006B42
		public bool ProcessTouchEvents()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0000894F File Offset: 0x00006B4F
		public Vector2 GetRawMoveVector()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0000895C File Offset: 0x00006B5C
		public bool ShouldSendMoveFromInput()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000349E8 File Offset: 0x00032BE8
		public static bool ScreenToPanel(BaseRuntimePanel panel, Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta)
		{
			panelPosition = Vector2.zero;
			panelDelta = Vector2.zero;
			panelPosition = panel.ScreenToPanel(screenPosition);
			bool flag = !panel.visualTree.layout.Contains(panelPosition);
			bool flag2;
			if (flag)
			{
				panelDelta = screenDelta;
				flag2 = false;
			}
			else
			{
				Vector2 vector = panel.ScreenToPanel(screenPosition - screenDelta);
				panelDelta = panelPosition - vector;
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x02000231 RID: 561
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
