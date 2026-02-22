using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FC RID: 252
	public class DisposeHelper
	{
		// Token: 0x06000D90 RID: 3472 RVA: 0x00034A70 File Offset: 0x00032C70
		public static void NotifyMissingDispose(IDisposable disposable)
		{
			bool flag = disposable == null;
			if (!flag)
			{
				Debug.LogError(String.Concat("An IDisposable instance of type '", disposable.GetType().FullName, "' has not been disposed."));
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00008969 File Offset: 0x00006B69
		public static void NotifyDisposedUsed(IDisposable disposable)
		{
			Debug.LogError(String.Concat("An instance of type '", disposable.GetType().FullName, "' is being used although it has been disposed."));
		}
	}
}
