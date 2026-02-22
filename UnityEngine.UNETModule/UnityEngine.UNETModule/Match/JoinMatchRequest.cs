using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000022 RID: 34
	public class JoinMatchRequest : Request
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00003214 File Offset: 0x00001414
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00003221 File Offset: 0x00001421
		public UnityEngine.Networking.Types.NetworkID networkId
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000322E File Offset: 0x0000142E
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000323B File Offset: 0x0000143B
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00003248 File Offset: 0x00001448
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00003255 File Offset: 0x00001455
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00003262 File Offset: 0x00001462
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000326F File Offset: 0x0000146F
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000327C File Offset: 0x0000147C
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00003289 File Offset: 0x00001489
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

		// Token: 0x06000178 RID: 376 RVA: 0x00003296 File Offset: 0x00001496
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00004380 File Offset: 0x00002580
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != UnityEngine.Networking.Types.NetworkID.Invalid;
		}
	}
}
