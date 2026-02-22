using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015B RID: 347
	public class TreeView : VisualElement
	{
		// Token: 0x06000FAB RID: 4011 RVA: 0x0000A05B File Offset: 0x0000825B
		public void add_onItemsChosen(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0000A068 File Offset: 0x00008268
		public void remove_onItemsChosen(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0000A075 File Offset: 0x00008275
		public void add_onSelectionChange(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0000A082 File Offset: 0x00008282
		public void remove_onSelectionChange(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x0000A08F File Offset: 0x0000828F
		public ITreeViewItem selectedItem
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0000A09C File Offset: 0x0000829C
		public IEnumerable<ITreeViewItem> selectedItems
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0000A0A9 File Offset: 0x000082A9
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0000A0B6 File Offset: 0x000082B6
		public IList<ITreeViewItem> rootItems
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0000A0C3 File Offset: 0x000082C3
		public IEnumerable<ITreeViewItem> items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0000A0D0 File Offset: 0x000082D0
		public float resolvedItemHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x0000A0DD File Offset: 0x000082DD
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x0000A0EA File Offset: 0x000082EA
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x0000A0F7 File Offset: 0x000082F7
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x0000A104 File Offset: 0x00008304
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0000A111 File Offset: 0x00008311
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x0000A11E File Offset: 0x0000831E
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x0000A12B File Offset: 0x0000832B
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x0000A138 File Offset: 0x00008338
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x0000A145 File Offset: 0x00008345
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x0000A152 File Offset: 0x00008352
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

		// Token: 0x06000FBF RID: 4031 RVA: 0x0000A15F File Offset: 0x0000835F
		public void Refresh()
		{
			this.RegenerateWrappers();
			this.ListViewRefresh();
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00036EE0 File Offset: 0x000350E0
		public override void OnViewDataReady()
		{
			base.OnViewDataReady();
			string fullHierarchicalViewDataKey = base.GetFullHierarchicalViewDataKey();
			base.OverwriteFromViewData(this, fullHierarchicalViewDataKey);
			this.Refresh();
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0000A170 File Offset: 0x00008370
		public static IEnumerable<ITreeViewItem> GetAllItems(IEnumerable<ITreeViewItem> rootItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0000A17D File Offset: 0x0000837D
		public void OnKeyDown(KeyDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0000A18A File Offset: 0x0000838A
		public void SetSelection(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0000A197 File Offset: 0x00008397
		public void SetSelection(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, true);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0000A1A3 File Offset: 0x000083A3
		public void SetSelectionWithoutNotify(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, false);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0000A1AF File Offset: 0x000083AF
		public void SetSelectionInternal(IEnumerable<int> ids, bool sendNotification)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0000A1BC File Offset: 0x000083BC
		public void AddToSelection(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public void RemoveFromSelection(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0000A1D6 File Offset: 0x000083D6
		public int GetItemIndex(int id, [Optional] bool expand)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0000A1E3 File Offset: 0x000083E3
		public void ClearSelection()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0000A1F0 File Offset: 0x000083F0
		public void ScrollTo(VisualElement visualElement)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0000A1FD File Offset: 0x000083FD
		public void ScrollToItem(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0000A20A File Offset: 0x0000840A
		public bool IsExpanded(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0000A217 File Offset: 0x00008417
		public void CollapseItem(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0000A224 File Offset: 0x00008424
		public void ExpandItem(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00036F0C File Offset: 0x0003510C
		public ITreeViewItem FindItem(int id)
		{
			foreach (ITreeViewItem treeViewItem in this.items)
			{
				bool flag = treeViewItem.id == id;
				if (flag)
				{
					return treeViewItem;
				}
			}
			return null;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0000A231 File Offset: 0x00008431
		public void ListViewRefresh()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0000A23E File Offset: 0x0000843E
		public void OnItemsChosen(IEnumerable<Object> chosenItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0000A24B File Offset: 0x0000844B
		public void OnSelectionChange(IEnumerable<Object> selectedListItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0000A258 File Offset: 0x00008458
		public void OnTreeViewMouseUp(MouseUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0000A265 File Offset: 0x00008465
		public void OnItemMouseUp(MouseUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0000A272 File Offset: 0x00008472
		public VisualElement MakeTreeItem()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0000A27F File Offset: 0x0000847F
		public void UnbindTreeItem(VisualElement element, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0000A28C File Offset: 0x0000848C
		public void BindTreeItem(VisualElement element, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0000A299 File Offset: 0x00008499
		public int GetItemId(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0000A2A6 File Offset: 0x000084A6
		public bool IsExpandedByIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0000A2B3 File Offset: 0x000084B3
		public void CollapseItemByIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0000A2C0 File Offset: 0x000084C0
		public void ExpandItemByIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0000A2CD File Offset: 0x000084CD
		public void RegenerateWrappers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0000A2DA File Offset: 0x000084DA
		public void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0000A2E7 File Offset: 0x000084E7
		public int <SetSelectionInternal>b__68_0(int id)
		{
			return this.GetItemIndex(id, true);
		}

		// Token: 0x02000273 RID: 627
		public new class UxmlFactory : UxmlFactory<TreeView, TreeView.UxmlTraits>
		{
		}

		// Token: 0x02000274 RID: 628
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x020002A7 RID: 679
			public sealed class <get_uxmlChildElementsDescription>d__5
			{
			}
		}

		// Token: 0x02000275 RID: 629
		public sealed class <GetAllItems>d__63
		{
		}
	}
}
