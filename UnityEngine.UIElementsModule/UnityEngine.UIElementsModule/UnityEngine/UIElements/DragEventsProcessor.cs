using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000164 RID: 356
	public abstract class DragEventsProcessor
	{
		// Token: 0x0600100B RID: 4107 RVA: 0x0000A4DF File Offset: 0x000086DF
		public void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0000A4EC File Offset: 0x000086EC
		public void OnPointerUp()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0000A4F9 File Offset: 0x000086F9
		public void OnPointerDownEvent(PointerDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0000A506 File Offset: 0x00008706
		public void OnPointerUpEvent(PointerUpEvent evt)
		{
			this.OnPointerUp();
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0000A510 File Offset: 0x00008710
		public void OnPointerLeaveEvent(PointerLeaveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0000A51D File Offset: 0x0000871D
		public void OnPointerMoveEvent(PointerMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007CF RID: 1999
		public const int k_DistanceToActivation = 5;
	}
}
