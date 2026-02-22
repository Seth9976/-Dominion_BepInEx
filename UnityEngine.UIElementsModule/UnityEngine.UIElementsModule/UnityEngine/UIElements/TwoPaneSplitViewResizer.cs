using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015F RID: 351
	public class TwoPaneSplitViewResizer : MouseManipulator
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x0000A3F2 File Offset: 0x000085F2
		public VisualElement fixedPane
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0000A3FF File Offset: 0x000085FF
		public VisualElement flexedPane
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0000A40C File Offset: 0x0000860C
		public float fixedPaneMinDimension
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0000A419 File Offset: 0x00008619
		public float flexedPaneMinDimension
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00036F98 File Offset: 0x00035198
		public override void RegisterCallbacksOnTarget()
		{
			base.target.RegisterCallback<MouseDownEvent>(new EventCallback<MouseDownEvent>(this.OnMouseDown), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<MouseMoveEvent>(new EventCallback<MouseMoveEvent>(this.OnMouseMove), TrickleDown.NoTrickleDown);
			base.target.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUp), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00036FF4 File Offset: 0x000351F4
		public override void UnregisterCallbacksFromTarget()
		{
			base.target.UnregisterCallback<MouseDownEvent>(new EventCallback<MouseDownEvent>(this.OnMouseDown), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<MouseMoveEvent>(new EventCallback<MouseMoveEvent>(this.OnMouseMove), TrickleDown.NoTrickleDown);
			base.target.UnregisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnMouseUp), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0000A426 File Offset: 0x00008626
		public void ApplyDelta(float delta)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0000A433 File Offset: 0x00008633
		public void OnMouseDown(MouseDownEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0000A440 File Offset: 0x00008640
		public void OnMouseMove(MouseMoveEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0000A44D File Offset: 0x0000864D
		public void OnMouseUp(MouseUpEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
