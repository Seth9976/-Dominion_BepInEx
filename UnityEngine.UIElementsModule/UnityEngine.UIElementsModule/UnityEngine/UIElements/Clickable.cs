using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F8 RID: 248
	public class Clickable : PointerManipulator
	{
		// Token: 0x06000D66 RID: 3430 RVA: 0x00008837 File Offset: 0x00006A37
		public void add_clickedWithEventInfo(Action<EventBase> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00008844 File Offset: 0x00006A44
		public void remove_clickedWithEventInfo(Action<EventBase> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00008851 File Offset: 0x00006A51
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0000885E File Offset: 0x00006A5E
		public bool active
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

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0000886B File Offset: 0x00006A6B
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00008878 File Offset: 0x00006A78
		public Vector2 lastMousePosition
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

		// Token: 0x06000D6C RID: 3436 RVA: 0x00008885 File Offset: 0x00006A85
		public bool IsRepeatable()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000343B0 File Offset: 0x000325B0
		public override void RegisterCallbacksOnTarget()
		{
			base.target.RegisterCallback<MouseDownEvent>(new EventCallback<MouseDownEvent>(this.OnMouseDown), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<MouseMoveEvent>(new EventCallback<MouseMoveEvent>(this.OnMouseMove), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUp), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0003440C File Offset: 0x0003260C
		public override void UnregisterCallbacksFromTarget()
		{
			base.target.UnregisterCallback<MouseDownEvent>(new EventCallback<MouseDownEvent>(this.OnMouseDown), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<MouseMoveEvent>(new EventCallback<MouseMoveEvent>(this.OnMouseMove), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUp), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00008892 File Offset: 0x00006A92
		public void Invoke(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00034468 File Offset: 0x00032668
		public void OnMouseDown(MouseDownEvent evt)
		{
			bool flag = base.CanStartManipulation(evt);
			if (flag)
			{
				this.ProcessDownEvent(evt, evt.localMousePosition, PointerId.mousePointerId);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00034494 File Offset: 0x00032694
		public void OnMouseMove(MouseMoveEvent evt)
		{
			bool active = this.active;
			if (active)
			{
				this.ProcessMoveEvent(evt, evt.localMousePosition);
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000344BC File Offset: 0x000326BC
		public void OnMouseUp(MouseUpEvent evt)
		{
			bool flag = this.active && base.CanStopManipulation(evt);
			if (flag)
			{
				this.ProcessUpEvent(evt, evt.localMousePosition, PointerId.mousePointerId);
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0000889F File Offset: 0x00006A9F
		public void SimulateSingleClick(EventBase evt, [Optional] int delayMs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000088AC File Offset: 0x00006AAC
		public virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000344F4 File Offset: 0x000326F4
		public virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
		{
			this.lastMousePosition = localPosition;
			bool flag = base.target.ContainsPoint(localPosition);
			if (flag)
			{
				base.target.pseudoStates |= PseudoStates.Active;
			}
			else
			{
				base.target.pseudoStates &= ~PseudoStates.Active;
			}
			evt.StopPropagation();
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000088B9 File Offset: 0x00006AB9
		public virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000088C6 File Offset: 0x00006AC6
		public virtual void ProcessCancelEvent(EventBase evt, int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000088D3 File Offset: 0x00006AD3
		public void <SimulateSingleClick>b__28_0()
		{
			base.target.pseudoStates &= ~PseudoStates.Active;
		}
	}
}
