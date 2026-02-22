using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200002C RID: 44
	public class SetMatchAttributesRequest : Request
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00003429 File Offset: 0x00001629
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00003436 File Offset: 0x00001636
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00003443 File Offset: 0x00001643
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00003450 File Offset: 0x00001650
		public bool isListed
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

		// Token: 0x0600019F RID: 415 RVA: 0x0000345D File Offset: 0x0000165D
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000448C File Offset: 0x0000268C
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != UnityEngine.Networking.Types.NetworkID.Invalid;
		}
	}
}
