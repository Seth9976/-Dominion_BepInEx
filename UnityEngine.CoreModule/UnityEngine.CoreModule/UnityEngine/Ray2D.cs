using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020001D5 RID: 469
	public struct Ray2D
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x000625AC File Offset: 0x000607AC
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0000FA73 File Offset: 0x0000DC73
		public Vector2 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x000625C4 File Offset: 0x000607C4
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x0000FA7D File Offset: 0x0000DC7D
		public Vector2 direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000625DC File Offset: 0x000607DC
		public Vector2 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00062608 File Offset: 0x00060808
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00062624 File Offset: 0x00060824
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0000FA8D File Offset: 0x0000DC8D
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001675 RID: 5749
		public Vector2 m_Origin;

		// Token: 0x04001676 RID: 5750
		public Vector2 m_Direction;
	}
}
