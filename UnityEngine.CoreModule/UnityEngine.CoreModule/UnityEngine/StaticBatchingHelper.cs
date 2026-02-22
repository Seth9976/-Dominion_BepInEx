using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200021A RID: 538
	public struct StaticBatchingHelper
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x000119E6 File Offset: 0x0000FBE6
		public static bool IsMeshBatchable(Mesh mesh)
		{
			return StaticBatchingHelper.IsMeshBatchableDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh));
		}

		// Token: 0x04001869 RID: 6249
		private static readonly StaticBatchingHelper.IsMeshBatchableDelegate IsMeshBatchableDelegateField = IL2CPP.ResolveICall<StaticBatchingHelper.IsMeshBatchableDelegate>("UnityEngine.StaticBatchingHelper::IsMeshBatchable");

		// Token: 0x02000BEE RID: 3054
		// (Invoke) Token: 0x060035CE RID: 13774
		private delegate bool IsMeshBatchableDelegate(IntPtr mesh);
	}
}
