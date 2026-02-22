using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x02000035 RID: 53
	public class AnimatorUtility
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x0000494C File Offset: 0x00002B4C
		public static void OptimizeTransformHierarchy(GameObject go, Il2CppStringArray exposedTransforms)
		{
			AnimatorUtility.OptimizeTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.Il2CppObjectBaseToPtr(exposedTransforms));
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00004964 File Offset: 0x00002B64
		public static void DeoptimizeTransformHierarchy(GameObject go)
		{
			AnimatorUtility.DeoptimizeTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go));
		}

		// Token: 0x04000269 RID: 617
		private static readonly AnimatorUtility.OptimizeTransformHierarchyDelegate OptimizeTransformHierarchyDelegateField = IL2CPP.ResolveICall<AnimatorUtility.OptimizeTransformHierarchyDelegate>("UnityEngine.AnimatorUtility::OptimizeTransformHierarchy");

		// Token: 0x0400026A RID: 618
		private static readonly AnimatorUtility.DeoptimizeTransformHierarchyDelegate DeoptimizeTransformHierarchyDelegateField = IL2CPP.ResolveICall<AnimatorUtility.DeoptimizeTransformHierarchyDelegate>("UnityEngine.AnimatorUtility::DeoptimizeTransformHierarchy");

		// Token: 0x020001D3 RID: 467
		// (Invoke) Token: 0x0600084A RID: 2122
		private delegate void OptimizeTransformHierarchyDelegate(IntPtr go, IntPtr exposedTransforms);

		// Token: 0x020001D4 RID: 468
		// (Invoke) Token: 0x0600084C RID: 2124
		private delegate void DeoptimizeTransformHierarchyDelegate(IntPtr go);
	}
}
