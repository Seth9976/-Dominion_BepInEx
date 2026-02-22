using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000116 RID: 278
	public class PointerClickable : Clickable
	{
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00034C34 File Offset: 0x00032E34
		public Vector2 lastPointerPosition
		{
			get
			{
				return base.lastMousePosition;
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00034C4C File Offset: 0x00032E4C
		public override void RegisterCallbacksOnTarget()
		{
			base.target.RegisterCallback<PointerDownEvent>(new EventCallback<PointerDownEvent>(this.OnPointerDown), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<PointerMoveEvent>(new EventCallback<PointerMoveEvent>(this.OnPointerMove), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<PointerUpEvent>(new EventCallback<PointerUpEvent>(this.OnPointerUp), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<PointerCancelEvent>(new EventCallback<PointerCancelEvent>(this.OnPointerCancel), TrickleDown.NoTrickleDown);
			base.RegisterCallbacksOnTarget();
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00034CC8 File Offset: 0x00032EC8
		public override void UnregisterCallbacksFromTarget()
		{
			base.target.UnregisterCallback<PointerDownEvent>(new EventCallback<PointerDownEvent>(this.OnPointerDown), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<PointerMoveEvent>(new EventCallback<PointerMoveEvent>(this.OnPointerMove), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<PointerUpEvent>(new EventCallback<PointerUpEvent>(this.OnPointerUp), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<PointerCancelEvent>(new EventCallback<PointerCancelEvent>(this.OnPointerCancel), TrickleDown.NoTrickleDown);
			base.UnregisterCallbacksFromTarget();
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00034D44 File Offset: 0x00032F44
		public void OnPointerDown(PointerDownEvent evt)
		{
			bool flag = !base.CanStartManipulation(evt);
			if (!flag)
			{
				bool flag2 = PointerClickable.IsNotMouseEvent<PointerDownEvent>(evt);
				if (flag2)
				{
					this.ProcessDownEvent(evt, evt.localPosition, evt.pointerId);
					evt.PreventDefault();
				}
				else
				{
					evt.StopImmediatePropagation();
				}
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00034D9C File Offset: 0x00032F9C
		public void OnPointerMove(PointerMoveEvent evt)
		{
			bool flag = PointerClickable.IsNotMouseEvent<PointerMoveEvent>(evt) && base.active;
			if (flag)
			{
				this.ProcessMoveEvent(evt, evt.localPosition);
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00034DD4 File Offset: 0x00032FD4
		public void OnPointerUp(PointerUpEvent evt)
		{
			bool flag = PointerClickable.IsNotMouseEvent<PointerUpEvent>(evt) && base.active && base.CanStopManipulation(evt);
			if (flag)
			{
				this.ProcessUpEvent(evt, evt.localPosition, evt.pointerId);
			}
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00034E1C File Offset: 0x0003301C
		public void OnPointerCancel(PointerCancelEvent evt)
		{
			bool flag = PointerClickable.IsNotMouseEvent<PointerCancelEvent>(evt) && base.CanStopManipulation(evt);
			if (flag)
			{
				this.ProcessCancelEvent(evt, evt.pointerId);
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00034E50 File Offset: 0x00033050
		public static bool IsNotMouseEvent<T>(T evt) where T : PointerEventBase<T>, new()
		{
			return evt.pointerId != PointerId.mousePointerId;
		}
	}
}
