using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace UnityEngine
{
	// Token: 0x02000220 RID: 544
	public static class HotReloadDeserializer
	{
		// Token: 0x06001EE2 RID: 7906 RVA: 0x00011B23 File Offset: 0x0000FD23
		public static void PrepareHotReload()
		{
			HotReloadDeserializer.PrepareHotReloadDelegateField();
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00011B2F File Offset: 0x0000FD2F
		public static void FinishHotReload(Il2CppReferenceArray<Type> typesToReset)
		{
			HotReloadDeserializer.FinishHotReloadDelegateField(IL2CPP.Il2CppObjectBaseToPtr(typesToReset));
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00065628 File Offset: 0x00063828
		public static Object CreateEmptyAsset(Type type)
		{
			IntPtr intPtr = HotReloadDeserializer.CreateEmptyAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00011B41 File Offset: 0x0000FD41
		public static void DeserializeAsset(Object asset, Il2CppStructArray<byte> data)
		{
			HotReloadDeserializer.DeserializeAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset), IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00011B59 File Offset: 0x0000FD59
		public static void RemapInstanceIds(Object editorAsset, Il2CppStructArray<int> editorToPlayerInstanceIdMapKeys, Il2CppStructArray<int> editorToPlayerInstanceIdMapValues)
		{
			HotReloadDeserializer.RemapInstanceIdsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(editorAsset), IL2CPP.Il2CppObjectBaseToPtr(editorToPlayerInstanceIdMapKeys), IL2CPP.Il2CppObjectBaseToPtr(editorToPlayerInstanceIdMapValues));
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00011B77 File Offset: 0x0000FD77
		public static void RemapInstanceIds(Object editorAsset, Dictionary<int, int> editorToPlayerInstanceIdMap)
		{
			HotReloadDeserializer.RemapInstanceIds(editorAsset, editorToPlayerInstanceIdMap.Keys.ToArray<int>(), editorToPlayerInstanceIdMap.Values.ToArray<int>());
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00011B97 File Offset: 0x0000FD97
		public static void FinalizeAssetCreation(Object asset)
		{
			HotReloadDeserializer.FinalizeAssetCreationDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset));
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00065654 File Offset: 0x00063854
		public static Il2CppReferenceArray<Object> GetDependencies(Object asset)
		{
			IntPtr intPtr = HotReloadDeserializer.GetDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00065680 File Offset: 0x00063880
		public static Il2CppStructArray<int> GetNullDependencies(Object asset)
		{
			IntPtr intPtr = HotReloadDeserializer.GetNullDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x04001879 RID: 6265
		private static readonly HotReloadDeserializer.PrepareHotReloadDelegate PrepareHotReloadDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.PrepareHotReloadDelegate>("UnityEngine.HotReloadDeserializer::PrepareHotReload");

		// Token: 0x0400187A RID: 6266
		private static readonly HotReloadDeserializer.FinishHotReloadDelegate FinishHotReloadDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.FinishHotReloadDelegate>("UnityEngine.HotReloadDeserializer::FinishHotReload");

		// Token: 0x0400187B RID: 6267
		private static readonly HotReloadDeserializer.CreateEmptyAssetDelegate CreateEmptyAssetDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.CreateEmptyAssetDelegate>("UnityEngine.HotReloadDeserializer::CreateEmptyAsset");

		// Token: 0x0400187C RID: 6268
		private static readonly HotReloadDeserializer.DeserializeAssetDelegate DeserializeAssetDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.DeserializeAssetDelegate>("UnityEngine.HotReloadDeserializer::DeserializeAsset");

		// Token: 0x0400187D RID: 6269
		private static readonly HotReloadDeserializer.RemapInstanceIdsDelegate RemapInstanceIdsDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.RemapInstanceIdsDelegate>("UnityEngine.HotReloadDeserializer::RemapInstanceIds");

		// Token: 0x0400187E RID: 6270
		private static readonly HotReloadDeserializer.FinalizeAssetCreationDelegate FinalizeAssetCreationDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.FinalizeAssetCreationDelegate>("UnityEngine.HotReloadDeserializer::FinalizeAssetCreation");

		// Token: 0x0400187F RID: 6271
		private static readonly HotReloadDeserializer.GetDependenciesDelegate GetDependenciesDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.GetDependenciesDelegate>("UnityEngine.HotReloadDeserializer::GetDependencies");

		// Token: 0x04001880 RID: 6272
		private static readonly HotReloadDeserializer.GetNullDependenciesDelegate GetNullDependenciesDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.GetNullDependenciesDelegate>("UnityEngine.HotReloadDeserializer::GetNullDependencies");

		// Token: 0x02000BFA RID: 3066
		// (Invoke) Token: 0x060035E6 RID: 13798
		private delegate void PrepareHotReloadDelegate();

		// Token: 0x02000BFB RID: 3067
		// (Invoke) Token: 0x060035E8 RID: 13800
		private delegate void FinishHotReloadDelegate(IntPtr typesToReset);

		// Token: 0x02000BFC RID: 3068
		// (Invoke) Token: 0x060035EA RID: 13802
		private delegate IntPtr CreateEmptyAssetDelegate(IntPtr type);

		// Token: 0x02000BFD RID: 3069
		// (Invoke) Token: 0x060035EC RID: 13804
		private delegate void DeserializeAssetDelegate(IntPtr asset, IntPtr data);

		// Token: 0x02000BFE RID: 3070
		// (Invoke) Token: 0x060035EE RID: 13806
		private delegate void RemapInstanceIdsDelegate(IntPtr editorAsset, IntPtr editorToPlayerInstanceIdMapKeys, IntPtr editorToPlayerInstanceIdMapValues);

		// Token: 0x02000BFF RID: 3071
		// (Invoke) Token: 0x060035F0 RID: 13808
		private delegate void FinalizeAssetCreationDelegate(IntPtr asset);

		// Token: 0x02000C00 RID: 3072
		// (Invoke) Token: 0x060035F2 RID: 13810
		private delegate IntPtr GetDependenciesDelegate(IntPtr asset);

		// Token: 0x02000C01 RID: 3073
		// (Invoke) Token: 0x060035F4 RID: 13812
		private delegate IntPtr GetNullDependenciesDelegate(IntPtr asset);
	}
}
