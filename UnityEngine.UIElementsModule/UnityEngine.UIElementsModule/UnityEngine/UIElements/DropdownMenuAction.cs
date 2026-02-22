using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000100 RID: 256
	public class DropdownMenuAction : DropdownMenuItem
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000089DA File Offset: 0x00006BDA
		public string name
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000089E7 File Offset: 0x00006BE7
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x000089F4 File Offset: 0x00006BF4
		public DropdownMenuAction.Status status
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00008A01 File Offset: 0x00006C01
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00008A0E File Offset: 0x00006C0E
		public DropdownMenuEventInfo eventInfo
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00008A1B File Offset: 0x00006C1B
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00008A28 File Offset: 0x00006C28
		public Object userData
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

		// Token: 0x06000D9F RID: 3487 RVA: 0x00034AA8 File Offset: 0x00032CA8
		public static DropdownMenuAction.Status AlwaysEnabled(DropdownMenuAction a)
		{
			return DropdownMenuAction.Status.Normal;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00034ABC File Offset: 0x00032CBC
		public static DropdownMenuAction.Status AlwaysDisabled(DropdownMenuAction a)
		{
			return DropdownMenuAction.Status.Disabled;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00008A35 File Offset: 0x00006C35
		public void UpdateActionStatus(DropdownMenuEventInfo eventInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00008A42 File Offset: 0x00006C42
		public void Execute()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000232 RID: 562
		public enum Status
		{
			// Token: 0x0400090B RID: 2315
			None,
			// Token: 0x0400090C RID: 2316
			Normal,
			// Token: 0x0400090D RID: 2317
			Disabled,
			// Token: 0x0400090E RID: 2318
			Checked = 4,
			// Token: 0x0400090F RID: 2319
			Hidden = 8
		}
	}
}
