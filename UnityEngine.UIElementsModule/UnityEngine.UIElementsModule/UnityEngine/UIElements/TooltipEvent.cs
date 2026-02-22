using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017B RID: 379
	public class TooltipEvent : EventBase<TooltipEvent>
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0000A7C1 File Offset: 0x000089C1
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0000A7CE File Offset: 0x000089CE
		public string tooltip
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0000A7DB File Offset: 0x000089DB
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0000A7E8 File Offset: 0x000089E8
		public Rect rect
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

		// Token: 0x06001050 RID: 4176 RVA: 0x0000A7F5 File Offset: 0x000089F5
		public override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x000372D4 File Offset: 0x000354D4
		public new void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown;
			this.rect = default(Rect);
			this.tooltip = String.Empty;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00037308 File Offset: 0x00035508
		public static TooltipEvent GetPooled(string tooltip, Rect rect)
		{
			TooltipEvent pooled = EventBase<TooltipEvent>.GetPooled();
			pooled.tooltip = tooltip;
			pooled.rect = rect;
			return pooled;
		}
	}
}
