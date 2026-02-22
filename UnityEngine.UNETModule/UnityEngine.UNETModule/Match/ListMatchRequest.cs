using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000027 RID: 39
	public class ListMatchRequest : Request
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003325 File Offset: 0x00001525
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00003332 File Offset: 0x00001532
		public int pageSize
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000333F File Offset: 0x0000153F
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0000334C File Offset: 0x0000154C
		public int pageNum
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00003359 File Offset: 0x00001559
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00003366 File Offset: 0x00001566
		public string nameFilter
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00003373 File Offset: 0x00001573
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00003380 File Offset: 0x00001580
		public bool filterOutPrivateMatches
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000338D File Offset: 0x0000158D
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000339A File Offset: 0x0000159A
		public int eloScore
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000033A7 File Offset: 0x000015A7
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000033B4 File Offset: 0x000015B4
		public Dictionary<string, long> matchAttributeFilterLessThan
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000033C1 File Offset: 0x000015C1
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000033CE File Offset: 0x000015CE
		public Dictionary<string, long> matchAttributeFilterEqualTo
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000033DB File Offset: 0x000015DB
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000033E8 File Offset: 0x000015E8
		public Dictionary<string, long> matchAttributeFilterGreaterThan
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

		// Token: 0x06000196 RID: 406 RVA: 0x000033F5 File Offset: 0x000015F5
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00004408 File Offset: 0x00002608
		public override bool IsValid()
		{
			int num = ((this.matchAttributeFilterLessThan == null) ? 0 : this.matchAttributeFilterLessThan.Count);
			num += ((this.matchAttributeFilterEqualTo == null) ? 0 : this.matchAttributeFilterEqualTo.Count);
			num += ((this.matchAttributeFilterGreaterThan == null) ? 0 : this.matchAttributeFilterGreaterThan.Count);
			return base.IsValid() && this.pageSize >= 1 && this.pageSize <= 1000 && num <= 10;
		}
	}
}
