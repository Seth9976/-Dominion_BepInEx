using System;

namespace UnityEngine
{
	// Token: 0x02000238 RID: 568
	public sealed class WaitWhile : CustomYieldInstruction
	{
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00011D81 File Offset: 0x0000FF81
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
