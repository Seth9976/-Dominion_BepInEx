using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000174 RID: 372
	public class InputEvent : EventBase<InputEvent>
	{
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0000A673 File Offset: 0x00008873
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0000A680 File Offset: 0x00008880
		public string previousData
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0000A68D File Offset: 0x0000888D
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x0000A69A File Offset: 0x0000889A
		public string newData
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

		// Token: 0x06001035 RID: 4149 RVA: 0x0000A6A7 File Offset: 0x000088A7
		public override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0000A6B8 File Offset: 0x000088B8
		public new void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown;
			this.previousData = null;
			this.newData = null;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x000371E8 File Offset: 0x000353E8
		public static InputEvent GetPooled(string previousData, string newData)
		{
			InputEvent pooled = EventBase<InputEvent>.GetPooled();
			pooled.previousData = previousData;
			pooled.newData = newData;
			return pooled;
		}
	}
}
