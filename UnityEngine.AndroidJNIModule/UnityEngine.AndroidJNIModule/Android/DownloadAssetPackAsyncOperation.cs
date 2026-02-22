using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x02000014 RID: 20
	public class DownloadAssetPackAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002860 File Offset: 0x00000A60
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000286D File Offset: 0x00000A6D
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002878 File Offset: 0x00000A78
		public float progress
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002885 File Offset: 0x00000A85
		public Il2CppStringArray downloadedAssetPacks
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002892 File Offset: 0x00000A92
		public Il2CppStringArray downloadFailedAssetPacks
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000289F File Offset: 0x00000A9F
		public void OnUpdate(AndroidAssetPackInfo info)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000076 RID: 118
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
