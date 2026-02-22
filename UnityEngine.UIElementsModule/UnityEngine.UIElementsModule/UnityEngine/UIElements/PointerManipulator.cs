using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000117 RID: 279
	public abstract class PointerManipulator : MouseManipulator
	{
		// Token: 0x06000DD0 RID: 3536 RVA: 0x00008C22 File Offset: 0x00006E22
		public bool CanStartManipulation(IPointerEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00008C2F File Offset: 0x00006E2F
		public bool CanStopManipulation(IPointerEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
