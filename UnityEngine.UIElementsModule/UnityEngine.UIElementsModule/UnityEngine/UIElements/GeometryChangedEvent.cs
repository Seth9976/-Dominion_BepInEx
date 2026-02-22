using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000175 RID: 373
	public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
	{
		// Token: 0x06001038 RID: 4152 RVA: 0x00037214 File Offset: 0x00035414
		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect)
		{
			GeometryChangedEvent pooled = EventBase<GeometryChangedEvent>.GetPooled();
			pooled.oldRect = oldRect;
			pooled.newRect = newRect;
			return pooled;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0000A6D3 File Offset: 0x000088D3
		public override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public new void LocalInit()
		{
			this.oldRect = Rect.zero;
			this.newRect = Rect.zero;
			this.layoutPass = 0;
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0000A707 File Offset: 0x00008907
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x0000A714 File Offset: 0x00008914
		public Rect oldRect
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0000A721 File Offset: 0x00008921
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x0000A72E File Offset: 0x0000892E
		public Rect newRect
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x0000A73B File Offset: 0x0000893B
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x0000A748 File Offset: 0x00008948
		public int layoutPass
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
	}
}
