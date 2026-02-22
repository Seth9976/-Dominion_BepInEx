using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.AssetBundlePatching
{
	// Token: 0x0200000A RID: 10
	public static class AssetBundleUtility
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002153 File Offset: 0x00000353
		public static void PatchAssetBundles(Il2CppReferenceArray<AssetBundle> bundles, Il2CppStringArray filenames)
		{
			AssetBundleUtility.PatchAssetBundlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(bundles), IL2CPP.Il2CppObjectBaseToPtr(filenames));
		}

		// Token: 0x0400003C RID: 60
		private static readonly AssetBundleUtility.PatchAssetBundlesDelegate PatchAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundleUtility.PatchAssetBundlesDelegate>("UnityEngine.Experimental.AssetBundlePatching.AssetBundleUtility::PatchAssetBundles");

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600009C RID: 156
		private delegate void PatchAssetBundlesDelegate(IntPtr bundles, IntPtr filenames);
	}
}
