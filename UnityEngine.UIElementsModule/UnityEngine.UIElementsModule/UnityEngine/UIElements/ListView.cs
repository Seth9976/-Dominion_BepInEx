using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000147 RID: 327
	public class ListView : BindableElement
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x000095F5 File Offset: 0x000077F5
		public void add_onItemChosen(Action<Object> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00009602 File Offset: 0x00007802
		public void remove_onItemChosen(Action<Object> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0000960F File Offset: 0x0000780F
		public void add_onItemsChosen(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0000961C File Offset: 0x0000781C
		public void remove_onItemsChosen(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00009629 File Offset: 0x00007829
		public void add_onSelectionChanged(Action<List<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00009636 File Offset: 0x00007836
		public void remove_onSelectionChanged(Action<List<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00009643 File Offset: 0x00007843
		public void add_onSelectionChange(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00009650 File Offset: 0x00007850
		public void remove_onSelectionChange(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0000965D File Offset: 0x0000785D
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x0000966A File Offset: 0x0000786A
		public IList itemsSource
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00035FD0 File Offset: 0x000341D0
		public float resolvedItemHeight
		{
			get
			{
				float scaledPixelsPerPoint = base.scaledPixelsPerPoint;
				return Mathf.Round((float)this.itemHeight * scaledPixelsPerPoint) / scaledPixelsPerPoint;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00009677 File Offset: 0x00007877
		public List<ListView.RecycledItem> Pool
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00009684 File Offset: 0x00007884
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00009691 File Offset: 0x00007891
		public int itemHeight
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0000969E File Offset: 0x0000789E
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x000096AB File Offset: 0x000078AB
		public bool showBorder
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x000096B8 File Offset: 0x000078B8
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x000096C5 File Offset: 0x000078C5
		public bool reorderable
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x000096D2 File Offset: 0x000078D2
		public List<int> currentSelectionIds
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x000096DF File Offset: 0x000078DF
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x000096EC File Offset: 0x000078EC
		public int selectedIndex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				this.SetSelection(value);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000096F7 File Offset: 0x000078F7
		public IEnumerable<int> selectedIndices
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00009704 File Offset: 0x00007904
		public Object selectedItem
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00009711 File Offset: 0x00007911
		public IEnumerable<Object> selectedItems
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0000971E File Offset: 0x0000791E
		public override VisualElement contentContainer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00009721 File Offset: 0x00007921
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0000972E File Offset: 0x0000792E
		public SelectionType selectionType
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

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0000973B File Offset: 0x0000793B
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00009748 File Offset: 0x00007948
		public AlternatingRowBackground showAlternatingRowBackgrounds
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

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00009755 File Offset: 0x00007955
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00009762 File Offset: 0x00007962
		public bool showBoundCollectionSize
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0000976F File Offset: 0x0000796F
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x0000977C File Offset: 0x0000797C
		public bool horizontalScrollingEnabled
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

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00009789 File Offset: 0x00007989
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00009796 File Offset: 0x00007996
		public void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000097A3 File Offset: 0x000079A3
		public void OnKeyDown(KeyDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000097B0 File Offset: 0x000079B0
		public bool Apply(KeyboardNavigationOperation op, bool shiftKey)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00035FFC File Offset: 0x000341FC
		public void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
			KeyDownEvent keyDownEvent = sourceEvent.TryCast<KeyDownEvent>();
			bool flag = keyDownEvent != null && keyDownEvent.shiftKey;
			bool flag2 = this.Apply(op, flag);
			if (flag2)
			{
				sourceEvent.StopPropagation();
				sourceEvent.PreventDefault();
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000097BD File Offset: 0x000079BD
		public void ScrollToItem(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0003603C File Offset: 0x0003423C
		public void OnPointerMove(PointerMoveEvent evt)
		{
			bool flag = evt.button == 0;
			if (flag)
			{
				bool flag2 = (evt.pressedButtons & 1) == 0;
				if (flag2)
				{
					this.ProcessPointerUp(evt);
				}
				else
				{
					this.ProcessPointerDown(evt);
				}
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000097CA File Offset: 0x000079CA
		public void OnPointerDown(PointerDownEvent evt)
		{
			this.ProcessPointerDown(evt);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000097D5 File Offset: 0x000079D5
		public void OnPointerUp(PointerUpEvent evt)
		{
			this.ProcessPointerUp(evt);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000097E0 File Offset: 0x000079E0
		public void ProcessPointerDown(IPointerEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00036080 File Offset: 0x00034280
		public void OnPointerCancel(PointerCancelEvent evt)
		{
			bool flag = !this.HasValidDataAndBindings();
			if (!flag)
			{
				bool flag2 = !evt.isPrimary;
				if (!flag2)
				{
					this.ClearSelection();
				}
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000097ED File Offset: 0x000079ED
		public void ProcessPointerUp(IPointerEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000097FA File Offset: 0x000079FA
		public void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00009807 File Offset: 0x00007A07
		public void DoRangeSelection(int rangeSelectionFinalIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00009814 File Offset: 0x00007A14
		public void ProcessSingleClick(int clickedIndex)
		{
			this.SetSelection(clickedIndex);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0000981F File Offset: 0x00007A1F
		public void SelectAll()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0000982C File Offset: 0x00007A2C
		public int GetIdFromIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00009839 File Offset: 0x00007A39
		public void AddToSelection(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000360B4 File Offset: 0x000342B4
		public void AddToSelection(IList<int> indexes)
		{
			bool flag = !this.HasValidDataAndBindings() || indexes == null || indexes.Count == 0;
			if (!flag)
			{
				foreach (int num in indexes)
				{
					this.AddToSelectionWithoutValidation(num);
				}
				this.NotifyOfSelectionChange();
				base.SaveViewData();
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00009846 File Offset: 0x00007A46
		public void AddToSelectionWithoutValidation(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00036130 File Offset: 0x00034330
		public void RemoveFromSelection(int index)
		{
			bool flag = !this.HasValidDataAndBindings();
			if (!flag)
			{
				this.RemoveFromSelectionWithoutValidation(index);
				this.NotifyOfSelectionChange();
				base.SaveViewData();
			}
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00009853 File Offset: 0x00007A53
		public void RemoveFromSelectionWithoutValidation(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00009860 File Offset: 0x00007A60
		public void SetSelection(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0000986D File Offset: 0x00007A6D
		public void SetSelection(IEnumerable<int> indices)
		{
			this.SetSelectionInternal(indices, true);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00009879 File Offset: 0x00007A79
		public void SetSelectionWithoutNotify(IEnumerable<int> indices)
		{
			this.SetSelectionInternal(indices, false);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00036164 File Offset: 0x00034364
		public void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
		{
			bool flag = !this.HasValidDataAndBindings() || indices == null;
			if (!flag)
			{
				this.ClearSelectionWithoutValidation();
				foreach (int num in indices)
				{
					this.AddToSelectionWithoutValidation(num);
				}
				if (sendNotification)
				{
					this.NotifyOfSelectionChange();
				}
				base.SaveViewData();
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00009885 File Offset: 0x00007A85
		public void NotifyOfSelectionChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00009892 File Offset: 0x00007A92
		public void ClearSelection()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0000989F File Offset: 0x00007A9F
		public void ClearSelectionWithoutValidation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000098AC File Offset: 0x00007AAC
		public void ScrollTo(VisualElement visualElement)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000098B9 File Offset: 0x00007AB9
		public void SetDragAndDropController(IListViewDragAndDropController dragAndDropController)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000098C6 File Offset: 0x00007AC6
		public IListViewDragAndDropController GetDragAndDropController()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000361E0 File Offset: 0x000343E0
		public override void OnViewDataReady()
		{
			base.OnViewDataReady();
			string fullHierarchicalViewDataKey = base.GetFullHierarchicalViewDataKey();
			base.OverwriteFromViewData(this, fullHierarchicalViewDataKey);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000098D3 File Offset: 0x00007AD3
		public override void ExecuteDefaultAction(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x000098E0 File Offset: 0x00007AE0
		public void OnScroll(float offset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000098ED File Offset: 0x00007AED
		public bool HasValidDataAndBindings()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x000098FA File Offset: 0x00007AFA
		public void Refresh()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00009907 File Offset: 0x00007B07
		public void ResizeHeight(float height)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00009914 File Offset: 0x00007B14
		public void Setup(ListView.RecycledItem recycledItem, int newIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00009921 File Offset: 0x00007B21
		public void UpdateBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00036208 File Offset: 0x00034408
		public void OnSizeChanged(GeometryChangedEvent evt)
		{
			bool flag = !this.HasValidDataAndBindings();
			if (!flag)
			{
				bool flag2 = Mathf.Approximately(evt.newRect.height, evt.oldRect.height);
				if (!flag2)
				{
					this.ResizeHeight(evt.newRect.height);
				}
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0000992E File Offset: 0x00007B2E
		public void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0000993B File Offset: 0x00007B3B
		public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0000993E File Offset: 0x00007B3E
		public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.Refresh();
		}

		// Token: 0x040007BC RID: 1980
		public const int k_ExtraVisibleItems = 2;

		// Token: 0x02000255 RID: 597
		public new class UxmlFactory : UxmlFactory<ListView, ListView.UxmlTraits>
		{
		}

		// Token: 0x02000256 RID: 598
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x020002A4 RID: 676
			public new sealed class <get_uxmlChildElementsDescription>d__8
			{
			}
		}

		// Token: 0x02000257 RID: 599
		public class RecycledItem
		{
		}
	}
}
