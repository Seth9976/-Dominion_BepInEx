using System;
using System.Runtime.InteropServices;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x0200017F RID: 383
	public struct ErrorState
	{
		// Token: 0x06001BAB RID: 7083 RVA: 0x0006163C File Offset: 0x0005F83C
		public void ThrowIfFailed()
		{
			bool flag = this.ErrorCode > Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode.Success;
			if (flag)
			{
				throw new BaselibException(this);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x0000F266 File Offset: 0x0000D466
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0000F273 File Offset: 0x0000D473
		public string Explain([Optional] Unity.Baselib.LowLevel.Binding.Baselib_ErrorState_ExplainVerbosity verbosity)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
