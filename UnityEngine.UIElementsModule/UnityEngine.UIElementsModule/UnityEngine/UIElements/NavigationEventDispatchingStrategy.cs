using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000177 RID: 375
	public class NavigationEventDispatchingStrategy
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x00037240 File Offset: 0x00035440
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt.TryCast<INavigationEvent>() != null;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0003725C File Offset: 0x0003545C
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			bool flag = panel != null;
			if (flag)
			{
				evt.target = panel.focusController.GetLeafFocusedElement() ?? panel.visualTree;
				EventDispatchUtilities.PropagateEvent(evt);
			}
			evt.propagateToIMGUI = false;
			evt.stopDispatch = true;
		}
	}
}
