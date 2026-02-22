using System;

namespace UnityEngine
{
	// Token: 0x0200021E RID: 542
	public static class HashUnsafeUtilities
	{
		// Token: 0x06001ED6 RID: 7894 RVA: 0x00011AE5 File Offset: 0x0000FCE5
		public unsafe static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2)
		{
			SpookyHash.Hash(data, dataSize, hash1, hash2);
		}
	}
}
