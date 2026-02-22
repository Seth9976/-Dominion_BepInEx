using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000113 RID: 275
	public abstract class MouseManipulator : Manipulator
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x00008C08 File Offset: 0x00006E08
		public bool CanStartManipulation(IMouseEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00008C15 File Offset: 0x00006E15
		public bool CanStopManipulation(IMouseEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
