using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AF RID: 431
	public class UxmlValueBounds : UxmlTypeRestriction
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0000B34B File Offset: 0x0000954B
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0000B358 File Offset: 0x00009558
		public string min
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0000B365 File Offset: 0x00009565
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0000B372 File Offset: 0x00009572
		public string max
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0000B37F File Offset: 0x0000957F
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0000B38C File Offset: 0x0000958C
		public bool excludeMin
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0000B399 File Offset: 0x00009599
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0000B3A6 File Offset: 0x000095A6
		public bool excludeMax
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

		// Token: 0x06001177 RID: 4471 RVA: 0x000388CC File Offset: 0x00036ACC
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueBounds uxmlValueBounds = other.TryCast<UxmlValueBounds>();
			bool flag = uxmlValueBounds == null;
			return !flag && (this.min == uxmlValueBounds.min && this.max == uxmlValueBounds.max && this.excludeMin == uxmlValueBounds.excludeMin) && this.excludeMax == uxmlValueBounds.excludeMax;
		}
	}
}
