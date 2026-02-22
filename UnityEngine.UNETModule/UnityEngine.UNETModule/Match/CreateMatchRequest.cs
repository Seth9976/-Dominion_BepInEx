using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000020 RID: 32
	public class CreateMatchRequest : Request
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000312A File Offset: 0x0000132A
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00003137 File Offset: 0x00001337
		public string name
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00003144 File Offset: 0x00001344
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00003151 File Offset: 0x00001351
		public uint size
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000315E File Offset: 0x0000135E
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000316B File Offset: 0x0000136B
		public string publicAddress
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00003178 File Offset: 0x00001378
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00003185 File Offset: 0x00001385
		public string privateAddress
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00003192 File Offset: 0x00001392
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000319F File Offset: 0x0000139F
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000031AC File Offset: 0x000013AC
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000031B9 File Offset: 0x000013B9
		public bool advertise
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000031C6 File Offset: 0x000013C6
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000031D3 File Offset: 0x000013D3
		public string password
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000031ED File Offset: 0x000013ED
		public Dictionary<string, long> matchAttributes
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

		// Token: 0x0600016B RID: 363 RVA: 0x000031FA File Offset: 0x000013FA
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000433C File Offset: 0x0000253C
		public override bool IsValid()
		{
			return base.IsValid() && this.size >= 2U && (this.matchAttributes == null || this.matchAttributes.Count <= 10);
		}
	}
}
