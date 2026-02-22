using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013D RID: 317
	public class GenericDropdownMenu
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00009366 File Offset: 0x00007566
		public VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00009373 File Offset: 0x00007573
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00009380 File Offset: 0x00007580
		public void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0000938D File Offset: 0x0000758D
		public void Hide()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00035B84 File Offset: 0x00033D84
		public void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
			bool flag = this.Apply(op);
			if (flag)
			{
				sourceEvent.StopPropagation();
				sourceEvent.PreventDefault();
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0000939A File Offset: 0x0000759A
		public bool Apply(KeyboardNavigationOperation op)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000093A7 File Offset: 0x000075A7
		public void OnPointerMove(PointerMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000093B4 File Offset: 0x000075B4
		public void OnPointerUp(PointerUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000093C1 File Offset: 0x000075C1
		public void OnFocusOut(FocusOutEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000093CE File Offset: 0x000075CE
		public void OnParentResized(GeometryChangedEvent evt)
		{
			this.Hide();
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000093D8 File Offset: 0x000075D8
		public void ChangeSelectedIndex(int newIndex, int previousIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000093E5 File Offset: 0x000075E5
		public int GetSelectedIndex()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000093F2 File Offset: 0x000075F2
		public void AddItem(string itemName, bool isChecked, Action<Object> action, Object data)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000093FF File Offset: 0x000075FF
		public void AddDisabledItem(string itemName, bool isChecked)
		{
			this.AddItem(itemName, isChecked, false, null);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0000940D File Offset: 0x0000760D
		public void AddSeparator(string path)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0000941A File Offset: 0x0000761A
		public GenericDropdownMenu.MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, [Optional] Object data)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00009427 File Offset: 0x00007627
		public void DropDown(Rect position, [Optional] VisualElement targetElement, [Optional] bool anchored)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00009434 File Offset: 0x00007634
		public void OnContainerGeometryChanged(GeometryChangedEvent evt)
		{
			this.EnsureVisibilityInParent();
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0000943E File Offset: 0x0000763E
		public void EnsureVisibilityInParent()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0200024C RID: 588
		public class MenuItem
		{
		}
	}
}
