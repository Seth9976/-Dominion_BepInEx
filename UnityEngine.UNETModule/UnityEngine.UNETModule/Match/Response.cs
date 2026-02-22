using System;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200001E RID: 30
	[Serializable]
	public abstract class Response
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00003103 File Offset: 0x00001303
		public void SetSuccess()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00003110 File Offset: 0x00001310
		public void SetFailure(string info)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000311D File Offset: 0x0000131D
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
