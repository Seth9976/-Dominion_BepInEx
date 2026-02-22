using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016C RID: 364
	public class ListViewDragger : DragEventsProcessor
	{
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0000A583 File Offset: 0x00008783
		public ListView targetListView
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x0000A590 File Offset: 0x00008790
		public ScrollView targetScrollView
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0000A59D File Offset: 0x0000879D
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x0000A5AA File Offset: 0x000087AA
		public IListViewDragAndDropController dragAndDropController
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

		// Token: 0x0600101C RID: 4124 RVA: 0x0000A5B7 File Offset: 0x000087B7
		public override bool CanStartDrag(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0000A5C4 File Offset: 0x000087C4
		public override StartDragArgs StartDrag(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0000A5D1 File Offset: 0x000087D1
		public override DragVisualMode UpdateDrag(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0000A5DE File Offset: 0x000087DE
		public override void OnDrop(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00037064 File Offset: 0x00035264
		public void HandleDragAndScroll(Vector2 pointerPosition)
		{
			bool flag = pointerPosition.y < this.targetScrollView.worldBound.yMin + 5f;
			bool flag2 = pointerPosition.y > this.targetScrollView.worldBound.yMax - 5f;
			bool flag3 = flag || flag2;
			if (flag3)
			{
				this.targetScrollView.scrollOffset += (flag ? Vector2.down : Vector2.up) * 20f;
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000370F0 File Offset: 0x000352F0
		public void PlaceHoverBarAtElement(VisualElement element)
		{
			VisualElement contentViewport = this.targetScrollView.contentViewport;
			this.PlaceHoverBarAt(Mathf.Min(VisualElementExtensions.WorldToLocal(contentViewport, element.worldBound).yMax, contentViewport.localBound.yMax - 2f));
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0000A5EB File Offset: 0x000087EB
		public void PlaceHoverBarAt(float top)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public override void ClearDragAndDropUI()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00037140 File Offset: 0x00035340
		public ListView.RecycledItem GetRecycledItem(Vector3 pointerPosition)
		{
			List<ListView.RecycledItem>.Enumerator enumerator = this.targetListView.Pool.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListView.RecycledItem recycledItem = enumerator.Current;
					bool flag = recycledItem.element.worldBound.Contains(pointerPosition);
					if (flag)
					{
						return recycledItem;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return null;
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0000A605 File Offset: 0x00008805
		public void <.ctor>b__17_0(GeometryChangedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007D9 RID: 2009
		public const int k_EmptyIndex = -1;

		// Token: 0x040007DA RID: 2010
		public const int k_AutoScrollAreaSize = 5;

		// Token: 0x040007DB RID: 2011
		public const int k_BetweenElementsAreaSize = 5;

		// Token: 0x040007DC RID: 2012
		public const int k_PanSpeed = 20;

		// Token: 0x040007DD RID: 2013
		public const int k_DragHoverBarHeight = 2;
	}
}
