using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000024 RID: 36
	public class DestroyMatchRequest : Request
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000032B0 File Offset: 0x000014B0
		// (set) Token: 0x0600017C RID: 380 RVA: 0x000032BD File Offset: 0x000014BD
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

		// Token: 0x0600017D RID: 381 RVA: 0x000032CA File Offset: 0x000014CA
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000043AC File Offset: 0x000025AC
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != UnityEngine.Networking.Types.NetworkID.Invalid;
		}
	}
}
