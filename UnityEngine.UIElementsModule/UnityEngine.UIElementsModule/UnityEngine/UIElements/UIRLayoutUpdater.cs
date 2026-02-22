using System;
using Il2CppSystem;
using Unity.Profiling;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x02000184 RID: 388
	public class UIRLayoutUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000375FC File Offset: 0x000357FC
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			bool flag = (versionChangeType & (VersionChangeType.Hierarchy | VersionChangeType.Layout)) == (VersionChangeType)0;
			if (!flag)
			{
				bool flag2 = (versionChangeType & VersionChangeType.Hierarchy) != (VersionChangeType)0 && base.panel.duringLayoutPhase;
				if (flag2)
				{
					throw new InvalidOperationException("Hierarchy change detected while computing layout, this is not supported.");
				}
				YogaNode yogaNode = ve.yogaNode;
				bool flag3 = yogaNode != null && yogaNode.IsMeasureDefined;
				if (flag3)
				{
					yogaNode.MarkDirty();
				}
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0003765C File Offset: 0x0003585C
		public override void Update()
		{
			int num = 0;
			while (base.visualTree.yogaNode.IsDirty)
			{
				bool flag = num > 0;
				if (flag)
				{
					base.panel.ApplyStyles();
				}
				base.panel.duringLayoutPhase = true;
				base.visualTree.yogaNode.CalculateLayout(float.NaN, float.NaN);
				base.panel.duringLayoutPhase = false;
				EventDispatcherGate eventDispatcherGate;
				eventDispatcherGate..ctor(base.visualTree.panel.dispatcher);
				try
				{
					this.UpdateSubTree(base.visualTree, num);
				}
				finally
				{
					eventDispatcherGate.Dispose();
				}
				bool flag2 = num++ >= 5;
				if (flag2)
				{
					string text = "Layout update is struggling to process current layout (consider simplifying to avoid recursive layout): ";
					VisualElement visualTree = base.visualTree;
					Debug.LogError(String.Concat(text, (visualTree != null) ? visualTree.ToString() : null));
					break;
				}
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00037754 File Offset: 0x00035954
		public void UpdateSubTree(VisualElement ve, int currentLayoutPass)
		{
			Rect rect = new Rect(ve.yogaNode.LayoutX, ve.yogaNode.LayoutY, ve.yogaNode.LayoutWidth, ve.yogaNode.LayoutHeight);
			Rect rect2 = new Rect(ve.yogaNode.LayoutPaddingLeft, ve.yogaNode.LayoutPaddingTop, ve.yogaNode.LayoutWidth - (ve.yogaNode.LayoutPaddingLeft + ve.yogaNode.LayoutPaddingRight), ve.yogaNode.LayoutHeight - (ve.yogaNode.LayoutPaddingTop + ve.yogaNode.LayoutPaddingBottom));
			Rect lastLayout = ve.lastLayout;
			Rect lastPadding = ve.lastPadding;
			VersionChangeType versionChangeType = (VersionChangeType)0;
			bool flag = lastLayout.size != rect.size;
			bool flag2 = lastPadding.size != rect2.size;
			bool flag3 = flag || flag2;
			if (flag3)
			{
				versionChangeType |= VersionChangeType.Size | VersionChangeType.Repaint;
			}
			bool flag4 = rect.position != lastLayout.position;
			bool flag5 = rect2.position != lastPadding.position;
			bool flag6 = flag4 || flag5;
			if (flag6)
			{
				versionChangeType |= VersionChangeType.Transform;
			}
			bool flag7 = versionChangeType > (VersionChangeType)0;
			if (flag7)
			{
				ve.IncrementVersion(versionChangeType);
			}
			ve.lastLayout = rect;
			ve.lastPadding = rect2;
			bool hasNewLayout = ve.yogaNode.HasNewLayout;
			bool flag8 = hasNewLayout;
			if (flag8)
			{
				VisualElement.Hierarchy hierarchy = ve.hierarchy;
				int childCount = hierarchy.childCount;
				for (int i = 0; i < childCount; i++)
				{
					hierarchy = ve.hierarchy;
					this.UpdateSubTree(hierarchy[i], currentLayoutPass);
				}
			}
			bool flag9 = flag || flag4;
			if (flag9)
			{
				using (GeometryChangedEvent pooled = GeometryChangedEvent.GetPooled(lastLayout, rect))
				{
					pooled.layoutPass = currentLayoutPass;
					pooled.target = ve;
					ve.SendEvent(pooled);
				}
			}
			bool flag10 = hasNewLayout;
			if (flag10)
			{
				ve.yogaNode.MarkLayoutSeen();
			}
		}

		// Token: 0x040007DE RID: 2014
		public const int kMaxValidateLayoutCount = 5;
	}
}
