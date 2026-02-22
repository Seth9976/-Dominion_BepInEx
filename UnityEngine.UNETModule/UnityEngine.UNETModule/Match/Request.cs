using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200001C RID: 28
	public abstract class Request
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000305A File Offset: 0x0000125A
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00003067 File Offset: 0x00001267
		public int version
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00003081 File Offset: 0x00001281
		public UnityEngine.Networking.Types.SourceID sourceId
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000308E File Offset: 0x0000128E
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0000309B File Offset: 0x0000129B
		public string projectId
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000030A8 File Offset: 0x000012A8
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000030B5 File Offset: 0x000012B5
		public UnityEngine.Networking.Types.AppID appId
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000030C2 File Offset: 0x000012C2
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000030CF File Offset: 0x000012CF
		public string accessTokenString
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000030DC File Offset: 0x000012DC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000030E9 File Offset: 0x000012E9
		public int domain
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

		// Token: 0x06000156 RID: 342 RVA: 0x0000431C File Offset: 0x0000251C
		public virtual bool IsValid()
		{
			return this.sourceId != UnityEngine.Networking.Types.SourceID.Invalid;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000030F6 File Offset: 0x000012F6
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
