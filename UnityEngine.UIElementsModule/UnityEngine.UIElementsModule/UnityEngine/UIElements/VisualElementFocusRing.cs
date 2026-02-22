using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000126 RID: 294
	public class VisualElementFocusRing
	{
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00008E35 File Offset: 0x00007035
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00008E42 File Offset: 0x00007042
		public VisualElementFocusRing.DefaultFocusOrder defaultFocusOrder
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

		// Token: 0x06000E06 RID: 3590 RVA: 0x00008E4F File Offset: 0x0000704F
		public int FocusRingAutoIndexSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00008E5C File Offset: 0x0000705C
		public int FocusRingSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00008E69 File Offset: 0x00007069
		public void DoUpdate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00008E76 File Offset: 0x00007076
		public void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<VisualElementFocusRing.FocusRingRecord> scopeList)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00008E83 File Offset: 0x00007083
		public void SortAndFlattenScopeLists(List<VisualElementFocusRing.FocusRingRecord> rootScopeList)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00008E90 File Offset: 0x00007090
		public int GetFocusableInternalIndex(Focusable f)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00035600 File Offset: 0x00033800
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			bool flag = e == null;
			if (flag)
			{
				throw new ArgumentNullException("e");
			}
			bool flag2 = e.eventTypeId == EventBase<PointerDownEvent>.TypeId();
			if (flag2)
			{
				Focusable focusable = e.target.TryCast<Focusable>();
				bool flag3 = focusable != null;
				if (flag3)
				{
					return VisualElementFocusChangeTarget.GetPooled(focusable);
				}
			}
			bool flag4 = currentFocusable.TryCast<IMGUIContainer>() != null && e.imguiEvent != null;
			FocusChangeDirection focusChangeDirection;
			if (flag4)
			{
				focusChangeDirection = FocusChangeDirection.none;
			}
			else
			{
				focusChangeDirection = VisualElementFocusRing.GetKeyDownFocusChangeDirection(e);
			}
			return focusChangeDirection;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00035684 File Offset: 0x00033884
		public static FocusChangeDirection GetKeyDownFocusChangeDirection(EventBase e)
		{
			bool flag = e.eventTypeId == EventBase<KeyDownEvent>.TypeId();
			if (flag)
			{
				KeyDownEvent keyDownEvent = e.TryCast<KeyDownEvent>();
				bool flag2 = keyDownEvent.character == '\u0019' || keyDownEvent.character == '\t';
				if (flag2)
				{
					bool flag3 = keyDownEvent.modifiers == EventModifiers.Shift;
					if (flag3)
					{
						return VisualElementFocusChangeDirection.left;
					}
					bool flag4 = keyDownEvent.modifiers == EventModifiers.None;
					if (flag4)
					{
						return VisualElementFocusChangeDirection.right;
					}
				}
			}
			return FocusChangeDirection.none;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00008E9D File Offset: 0x0000709D
		public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00035704 File Offset: 0x00033904
		public static Focusable GetNextFocusableInTree(VisualElement currentFocusable)
		{
			bool flag = currentFocusable == null;
			Focusable focusable;
			if (flag)
			{
				focusable = null;
			}
			else
			{
				VisualElement visualElement = currentFocusable.GetNextElementDepthFirst();
				while (!visualElement.canGrabFocus || visualElement.tabIndex < 0 || visualElement.excludeFromFocusRing)
				{
					visualElement = visualElement.GetNextElementDepthFirst();
					bool flag2 = visualElement == null;
					if (flag2)
					{
						visualElement = currentFocusable.GetRoot();
					}
					bool flag3 = visualElement == currentFocusable;
					if (flag3)
					{
						return currentFocusable;
					}
				}
				focusable = visualElement;
			}
			return focusable;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00035778 File Offset: 0x00033978
		public static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable)
		{
			bool flag = currentFocusable == null;
			Focusable focusable;
			if (flag)
			{
				focusable = null;
			}
			else
			{
				VisualElement visualElement = currentFocusable.GetPreviousElementDepthFirst();
				while (!visualElement.canGrabFocus || visualElement.tabIndex < 0 || visualElement.excludeFromFocusRing)
				{
					visualElement = visualElement.GetPreviousElementDepthFirst();
					bool flag2 = visualElement == null;
					if (flag2)
					{
						visualElement = currentFocusable.GetRoot();
						while (visualElement.childCount > 0)
						{
							VisualElement.Hierarchy hierarchy = visualElement.hierarchy;
							visualElement = hierarchy.ElementAt(visualElement.childCount - 1);
						}
					}
					bool flag3 = visualElement == currentFocusable;
					if (flag3)
					{
						return currentFocusable;
					}
				}
				focusable = visualElement;
			}
			return focusable;
		}

		// Token: 0x02000240 RID: 576
		public enum DefaultFocusOrder
		{
			// Token: 0x04000911 RID: 2321
			ChildOrder,
			// Token: 0x04000912 RID: 2322
			PositionXY,
			// Token: 0x04000913 RID: 2323
			PositionYX
		}

		// Token: 0x02000241 RID: 577
		public class FocusRingRecord
		{
		}
	}
}
