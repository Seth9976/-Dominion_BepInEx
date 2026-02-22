using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015D RID: 349
	public class TwoPaneSplitView : VisualElement
	{
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0000A2F1 File Offset: 0x000084F1
		public VisualElement fixedPane
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0000A2FE File Offset: 0x000084FE
		public VisualElement flexedPane
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0000A30B File Offset: 0x0000850B
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0000A318 File Offset: 0x00008518
		public int fixedPaneIndex
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0000A325 File Offset: 0x00008525
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0000A332 File Offset: 0x00008532
		public float fixedPaneInitialDimension
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0000A33F File Offset: 0x0000853F
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0000A34C File Offset: 0x0000854C
		public TwoPaneSplitViewOrientation orientation
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0000A359 File Offset: 0x00008559
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0000A366 File Offset: 0x00008566
		public float fixedPaneDimension
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

		// Token: 0x06000FEA RID: 4074 RVA: 0x0000A373 File Offset: 0x00008573
		public void CollapseChild(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0000A380 File Offset: 0x00008580
		public void UnCollapse()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0000A38D File Offset: 0x0000858D
		public void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0000A39A File Offset: 0x0000859A
		public void OnPostDisplaySetup(GeometryChangedEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0000A3A7 File Offset: 0x000085A7
		public void PostDisplaySetup()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0000A3B4 File Offset: 0x000085B4
		public void OnSizeChange(GeometryChangedEvent evt)
		{
			this.OnSizeChange();
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0000A3BE File Offset: 0x000085BE
		public void OnSizeChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0000A3CB File Offset: 0x000085CB
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00036F6C File Offset: 0x0003516C
		public override void OnViewDataReady()
		{
			base.OnViewDataReady();
			string fullHierarchicalViewDataKey = base.GetFullHierarchicalViewDataKey();
			base.OverwriteFromViewData(this, fullHierarchicalViewDataKey);
			this.PostDisplaySetup();
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0000A3D8 File Offset: 0x000085D8
		public void SetDragLineOffset(float offset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0000A3E5 File Offset: 0x000085E5
		public void SetFixedPaneDimension(float dimension)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000276 RID: 630
		public new class UxmlFactory : UxmlFactory<TwoPaneSplitView, TwoPaneSplitView.UxmlTraits>
		{
		}

		// Token: 0x02000277 RID: 631
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x020002A8 RID: 680
			public sealed class <get_uxmlChildElementsDescription>d__4
			{
			}
		}
	}
}
