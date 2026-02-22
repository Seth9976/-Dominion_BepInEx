using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017F RID: 383
	public class EventDebuggerDefaultActionTrace : EventDebuggerTrace
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		public PropagationPhase phase
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00037574 File Offset: 0x00035774
		public string targetName
		{
			get
			{
				return base.eventBase.target.GetType().FullName;
			}
		}
	}
}
