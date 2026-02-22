using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000245 RID: 581
	public class UnityEventQueueSystem
	{
		// Token: 0x06001F5E RID: 8030 RVA: 0x00012070 File Offset: 0x00010270
		public static string GenerateEventIdForPayload(string eventPayloadName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0001207D File Offset: 0x0001027D
		public static IntPtr GetGlobalEventQueue()
		{
			return UnityEventQueueSystem.GetGlobalEventQueueDelegateField();
		}

		// Token: 0x040018C5 RID: 6341
		private static readonly UnityEventQueueSystem.GetGlobalEventQueueDelegate GetGlobalEventQueueDelegateField = IL2CPP.ResolveICall<UnityEventQueueSystem.GetGlobalEventQueueDelegate>("UnityEngine.UnityEventQueueSystem::GetGlobalEventQueue");

		// Token: 0x02000C29 RID: 3113
		// (Invoke) Token: 0x0600363A RID: 13882
		private delegate IntPtr GetGlobalEventQueueDelegate();
	}
}
