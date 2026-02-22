using System;

namespace UnityEngine
{
	// Token: 0x02000237 RID: 567
	public sealed class WaitUntil : CustomYieldInstruction
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x00011D74 File Offset: 0x0000FF74
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
