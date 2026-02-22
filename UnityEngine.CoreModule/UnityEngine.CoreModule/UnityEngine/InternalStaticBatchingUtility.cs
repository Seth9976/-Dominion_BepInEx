using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x02000242 RID: 578
	public class InternalStaticBatchingUtility
	{
		// Token: 0x06001F58 RID: 8024 RVA: 0x0001201E File Offset: 0x0001021E
		public static void CombineRoot(GameObject staticBatchRoot, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			InternalStaticBatchingUtility.Combine(staticBatchRoot, false, false, sorter);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0001202B File Offset: 0x0001022B
		public static void Combine(GameObject staticBatchRoot, bool combineOnlyStatic, bool isEditorPostprocessScene, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00012038 File Offset: 0x00010238
		public static uint GetMeshFormatHash(Mesh mesh)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00012045 File Offset: 0x00010245
		public static Il2CppReferenceArray<GameObject> SortGameObjectsForStaticBatching(Il2CppReferenceArray<GameObject> gos, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00012052 File Offset: 0x00010252
		public static void CombineGameObjects(Il2CppReferenceArray<GameObject> gos, GameObject staticBatchRoot, bool isEditorPostprocessScene, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040018BD RID: 6333
		public const int MaxVerticesInBatch = 64000;

		// Token: 0x040018BE RID: 6334
		public const string CombinedMeshPrefix = "Combined Mesh";

		// Token: 0x02000C26 RID: 3110
		public class StaticBatcherGOSorter
		{
		}

		// Token: 0x02000C27 RID: 3111
		public sealed class <>c__DisplayClass5_0
		{
		}

		// Token: 0x02000C28 RID: 3112
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
