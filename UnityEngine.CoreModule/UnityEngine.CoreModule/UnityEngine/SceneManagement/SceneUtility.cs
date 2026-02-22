using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200026D RID: 621
	public static class SceneUtility
	{
		// Token: 0x06002004 RID: 8196 RVA: 0x00067148 File Offset: 0x00065348
		public static string GetScenePathByBuildIndex(int buildIndex)
		{
			IntPtr intPtr = SceneUtility.GetScenePathByBuildIndexDelegateField(buildIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000127FE File Offset: 0x000109FE
		public static int GetBuildIndexByScenePath(string scenePath)
		{
			return SceneUtility.GetBuildIndexByScenePathDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath));
		}

		// Token: 0x04001957 RID: 6487
		private static readonly SceneUtility.GetScenePathByBuildIndexDelegate GetScenePathByBuildIndexDelegateField = IL2CPP.ResolveICall<SceneUtility.GetScenePathByBuildIndexDelegate>("UnityEngine.SceneManagement.SceneUtility::GetScenePathByBuildIndex");

		// Token: 0x04001958 RID: 6488
		private static readonly SceneUtility.GetBuildIndexByScenePathDelegate GetBuildIndexByScenePathDelegateField = IL2CPP.ResolveICall<SceneUtility.GetBuildIndexByScenePathDelegate>("UnityEngine.SceneManagement.SceneUtility::GetBuildIndexByScenePath");

		// Token: 0x02000C72 RID: 3186
		// (Invoke) Token: 0x060036CA RID: 14026
		private delegate IntPtr GetScenePathByBuildIndexDelegate(int buildIndex);

		// Token: 0x02000C73 RID: 3187
		// (Invoke) Token: 0x060036CC RID: 14028
		private delegate int GetBuildIndexByScenePathDelegate(IntPtr scenePath);
	}
}
