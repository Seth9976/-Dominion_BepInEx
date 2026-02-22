using System;

namespace UnityEngine.Android
{
	// Token: 0x02000016 RID: 22
	public class RequestToUseMobileDataAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000028EB File Offset: 0x00000AEB
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000028F8 File Offset: 0x00000AF8
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002903 File Offset: 0x00000B03
		public AndroidAssetPackUseMobileDataRequestResult result
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002910 File Offset: 0x00000B10
		public void OnResult(AndroidAssetPackUseMobileDataRequestResult result)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
