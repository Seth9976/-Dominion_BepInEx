using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000176 RID: 374
	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
	{
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0000A755 File Offset: 0x00008955
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x0000A762 File Offset: 0x00008962
		public DropdownMenu menu
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0000A76F File Offset: 0x0000896F
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x0000A77C File Offset: 0x0000897C
		public EventBase triggerEvent
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

		// Token: 0x06001045 RID: 4165 RVA: 0x0000A789 File Offset: 0x00008989
		public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0000A796 File Offset: 0x00008996
		public override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0000A7A7 File Offset: 0x000089A7
		public new void LocalInit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0000A7B4 File Offset: 0x000089B4
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
