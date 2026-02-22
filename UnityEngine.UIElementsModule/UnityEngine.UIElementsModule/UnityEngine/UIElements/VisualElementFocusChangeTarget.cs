using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000125 RID: 293
	public class VisualElementFocusChangeTarget : FocusChangeDirection
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x00008DF7 File Offset: 0x00006FF7
		public static VisualElementFocusChangeTarget GetPooled(Focusable target)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00008E04 File Offset: 0x00007004
		public override void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00008E11 File Offset: 0x00007011
		public override void ApplyTo(FocusController focusController, Focusable f)
		{
			f.Focus();
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00008E1B File Offset: 0x0000701B
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00008E28 File Offset: 0x00007028
		public Focusable target
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
	}
}
