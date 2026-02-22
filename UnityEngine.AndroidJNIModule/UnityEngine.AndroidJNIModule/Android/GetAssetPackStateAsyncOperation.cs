using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x02000015 RID: 21
	public class GetAssetPackStateAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000028AC File Offset: 0x00000AAC
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000028B9 File Offset: 0x00000AB9
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000028C4 File Offset: 0x00000AC4
		public ulong size
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000028D1 File Offset: 0x00000AD1
		public Il2CppReferenceArray<AndroidAssetPackState> states
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000028DE File Offset: 0x00000ADE
		public void OnResult(ulong size, Il2CppReferenceArray<AndroidAssetPackState> states)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
