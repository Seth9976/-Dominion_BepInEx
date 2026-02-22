using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class AssetBundleManifest : Object
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002E50 File Offset: 0x00001050
		public Il2CppStringArray GetAllAssetBundles()
		{
			IntPtr intPtr = AssetBundleManifest.GetAllAssetBundlesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002E7C File Offset: 0x0000107C
		public Il2CppStringArray GetAllAssetBundlesWithVariant()
		{
			IntPtr intPtr = AssetBundleManifest.GetAllAssetBundlesWithVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002EA8 File Offset: 0x000010A8
		public Il2CppStringArray GetDirectDependencies(string assetBundleName)
		{
			IntPtr intPtr = AssetBundleManifest.GetDirectDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002EDC File Offset: 0x000010DC
		public Il2CppStringArray GetAllDependencies(string assetBundleName)
		{
			IntPtr intPtr = AssetBundleManifest.GetAllDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x0400002C RID: 44
		private static readonly AssetBundleManifest.GetAllAssetBundlesDelegate GetAllAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllAssetBundlesDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundles");

		// Token: 0x0400002D RID: 45
		private static readonly AssetBundleManifest.GetAllAssetBundlesWithVariantDelegate GetAllAssetBundlesWithVariantDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllAssetBundlesWithVariantDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundlesWithVariant");

		// Token: 0x0400002E RID: 46
		private static readonly AssetBundleManifest.GetDirectDependenciesDelegate GetDirectDependenciesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetDirectDependenciesDelegate>("UnityEngine.AssetBundleManifest::GetDirectDependencies");

		// Token: 0x0400002F RID: 47
		private static readonly AssetBundleManifest.GetAllDependenciesDelegate GetAllDependenciesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllDependenciesDelegate>("UnityEngine.AssetBundleManifest::GetAllDependencies");

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000094 RID: 148
		private delegate IntPtr GetAllAssetBundlesDelegate(IntPtr @this);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000096 RID: 150
		private delegate IntPtr GetAllAssetBundlesWithVariantDelegate(IntPtr @this);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000098 RID: 152
		private delegate IntPtr GetDirectDependenciesDelegate(IntPtr @this, IntPtr assetBundleName);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600009A RID: 154
		private delegate IntPtr GetAllDependenciesDelegate(IntPtr @this, IntPtr assetBundleName);
	}
}
