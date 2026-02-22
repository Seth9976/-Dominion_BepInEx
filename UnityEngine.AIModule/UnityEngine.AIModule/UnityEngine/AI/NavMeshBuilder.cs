using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x02000007 RID: 7
	public static class NavMeshBuilder
	{
		// Token: 0x06000033 RID: 51 RVA: 0x0000229C File Offset: 0x0000049C
		public static void Cancel(NavMeshData data)
		{
			NavMeshBuilder.CancelDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x04000028 RID: 40
		private static readonly NavMeshBuilder.CancelDelegate CancelDelegateField = IL2CPP.ResolveICall<NavMeshBuilder.CancelDelegate>("UnityEngine.AI.NavMeshBuilder::Cancel");

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000111 RID: 273
		private delegate void CancelDelegate(IntPtr data);
	}
}
