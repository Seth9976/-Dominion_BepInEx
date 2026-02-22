using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016E RID: 366
	public class ListViewReorderableDragAndDropController
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0000A61F File Offset: 0x0000881F
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x0000A62C File Offset: 0x0000882C
		public bool enableReordering
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

		// Token: 0x06001029 RID: 4137 RVA: 0x000371BC File Offset: 0x000353BC
		public virtual bool CanStartDrag(IEnumerable<Object> items)
		{
			return this.enableReordering;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0000A639 File Offset: 0x00008839
		public virtual StartDragArgs SetupDragAndDrop(IEnumerable<Object> items)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0000A646 File Offset: 0x00008846
		public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0000A653 File Offset: 0x00008853
		public virtual void OnDrop(IListDragAndDropArgs args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0000A660 File Offset: 0x00008860
		public void InsertRange(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000278 RID: 632
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
