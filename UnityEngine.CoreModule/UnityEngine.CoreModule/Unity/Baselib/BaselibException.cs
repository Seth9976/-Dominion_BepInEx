using System;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x02000180 RID: 384
	public class BaselibException : Exception
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x0000F280 File Offset: 0x0000D480
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
