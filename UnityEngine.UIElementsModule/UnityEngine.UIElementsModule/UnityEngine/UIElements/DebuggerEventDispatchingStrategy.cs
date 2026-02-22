using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000172 RID: 370
	public class DebuggerEventDispatchingStrategy
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x000371D4 File Offset: 0x000353D4
		public bool CanDispatchEvent(EventBase evt)
		{
			return false;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0000A66D File Offset: 0x0000886D
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0000A670 File Offset: 0x00008870
		public void PostDispatch(EventBase evt, IPanel panel)
		{
		}
	}
}
