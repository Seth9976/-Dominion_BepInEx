using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x0200017A RID: 378
	public class MemorylessManager
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00061624 File Offset: 0x0005F824
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000F23B File Offset: 0x0000D43B
		public static MemorylessMode depthMemorylessMode
		{
			get
			{
				return MemorylessManager.GetFramebufferDepthMemorylessMode();
			}
			set
			{
				MemorylessManager.SetFramebufferDepthMemorylessMode(value);
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0000F245 File Offset: 0x0000D445
		public static MemorylessMode GetFramebufferDepthMemorylessMode()
		{
			return MemorylessManager.GetFramebufferDepthMemorylessModeDelegateField();
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0000F251 File Offset: 0x0000D451
		public static void SetFramebufferDepthMemorylessMode(MemorylessMode mode)
		{
			MemorylessManager.SetFramebufferDepthMemorylessModeDelegateField(mode);
		}

		// Token: 0x0400154F RID: 5455
		private static readonly MemorylessManager.GetFramebufferDepthMemorylessModeDelegate GetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.GetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::GetFramebufferDepthMemorylessMode");

		// Token: 0x04001550 RID: 5456
		private static readonly MemorylessManager.SetFramebufferDepthMemorylessModeDelegate SetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.SetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::SetFramebufferDepthMemorylessMode");

		// Token: 0x02000A4F RID: 2639
		// (Invoke) Token: 0x060032C4 RID: 12996
		private delegate MemorylessMode GetFramebufferDepthMemorylessModeDelegate();

		// Token: 0x02000A50 RID: 2640
		// (Invoke) Token: 0x060032C6 RID: 12998
		private delegate void SetFramebufferDepthMemorylessModeDelegate(MemorylessMode mode);
	}
}
