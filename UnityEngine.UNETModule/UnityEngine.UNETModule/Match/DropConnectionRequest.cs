using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x02000025 RID: 37
	public class DropConnectionRequest : Request
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000032D7 File Offset: 0x000014D7
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000032E4 File Offset: 0x000014E4
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000032F1 File Offset: 0x000014F1
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000032FE File Offset: 0x000014FE
		public UnityEngine.Networking.Types.NodeID nodeId
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

		// Token: 0x06000183 RID: 387 RVA: 0x0000330B File Offset: 0x0000150B
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000043D8 File Offset: 0x000025D8
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != UnityEngine.Networking.Types.NetworkID.Invalid && this.nodeId > UnityEngine.Networking.Types.NodeID.Invalid;
		}
	}
}
