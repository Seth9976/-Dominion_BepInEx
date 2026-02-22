using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class AssetBundle : Object
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000024BC File Offset: 0x000006BC
		public Object mainAsset
		{
			get
			{
				return AssetBundle.returnMainAsset(this);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024D4 File Offset: 0x000006D4
		public static Object returnMainAsset(AssetBundle bundle)
		{
			IntPtr intPtr = AssetBundle.returnMainAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(bundle));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020AD File Offset: 0x000002AD
		public static void UnloadAllAssetBundles(bool unloadAllObjects)
		{
			AssetBundle.UnloadAllAssetBundlesDelegateField(unloadAllObjects);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002500 File Offset: 0x00000700
		public static Il2CppReferenceArray<AssetBundle> GetAllLoadedAssetBundles_Native()
		{
			IntPtr intPtr = AssetBundle.GetAllLoadedAssetBundles_NativeDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetBundle>>(intPtr2) : null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002528 File Offset: 0x00000728
		public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles()
		{
			return AssetBundle.GetAllLoadedAssetBundles_Native();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002540 File Offset: 0x00000740
		public static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset)
		{
			IntPtr intPtr = AssetBundle.LoadFromFileAsync_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(path), crc, offset);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002570 File Offset: 0x00000770
		public static AssetBundleCreateRequest LoadFromFileAsync(string path)
		{
			return AssetBundle.LoadFromFileAsync_Internal(path, 0U, 0UL);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000258C File Offset: 0x0000078C
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc)
		{
			return AssetBundle.LoadFromFileAsync_Internal(path, crc, 0UL);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025A8 File Offset: 0x000007A8
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset)
		{
			return AssetBundle.LoadFromFileAsync_Internal(path, crc, offset);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025C4 File Offset: 0x000007C4
		public static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset)
		{
			IntPtr intPtr = AssetBundle.LoadFromFile_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(path), crc, offset);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025F4 File Offset: 0x000007F4
		public static AssetBundle LoadFromFile(string path)
		{
			return AssetBundle.LoadFromFile_Internal(path, 0U, 0UL);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002610 File Offset: 0x00000810
		public static AssetBundle LoadFromFile(string path, uint crc)
		{
			return AssetBundle.LoadFromFile_Internal(path, crc, 0UL);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000262C File Offset: 0x0000082C
		public static AssetBundle LoadFromFile(string path, uint crc, ulong offset)
		{
			return AssetBundle.LoadFromFile_Internal(path, crc, offset);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002648 File Offset: 0x00000848
		public static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(Il2CppStructArray<byte> binary, uint crc)
		{
			IntPtr intPtr = AssetBundle.LoadFromMemoryAsync_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(binary), crc);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002678 File Offset: 0x00000878
		public static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary)
		{
			return AssetBundle.LoadFromMemoryAsync_Internal(binary, 0U);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002694 File Offset: 0x00000894
		public static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary, uint crc)
		{
			return AssetBundle.LoadFromMemoryAsync_Internal(binary, crc);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026B0 File Offset: 0x000008B0
		public static AssetBundle LoadFromMemory_Internal(Il2CppStructArray<byte> binary, uint crc)
		{
			IntPtr intPtr = AssetBundle.LoadFromMemory_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(binary), crc);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026E0 File Offset: 0x000008E0
		public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary)
		{
			return AssetBundle.LoadFromMemory_Internal(binary, 0U);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000026FC File Offset: 0x000008FC
		public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary, uint crc)
		{
			return AssetBundle.LoadFromMemory_Internal(binary, crc);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002718 File Offset: 0x00000918
		public static void ValidateLoadFromStream(Stream stream)
		{
			bool flag = stream == null;
			if (flag)
			{
				throw new ArgumentNullException("ManagedStream object must be non-null", "stream");
			}
			bool flag2 = !stream.CanRead;
			if (flag2)
			{
				throw new ArgumentException("ManagedStream object must be readable (stream.CanRead must return true)", "stream");
			}
			bool flag3 = !stream.CanSeek;
			if (flag3)
			{
				throw new ArgumentException("ManagedStream object must be seekable (stream.CanSeek must return true)", "stream");
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002778 File Offset: 0x00000978
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc, uint managedReadBufferSize)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, crc, managedReadBufferSize);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000279C File Offset: 0x0000099C
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, crc, 0U);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027C0 File Offset: 0x000009C0
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, 0U, 0U);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000027E4 File Offset: 0x000009E4
		public static AssetBundle LoadFromStream(Stream stream, uint crc, uint managedReadBufferSize)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, crc, managedReadBufferSize);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002808 File Offset: 0x00000A08
		public static AssetBundle LoadFromStream(Stream stream, uint crc)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, crc, 0U);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000282C File Offset: 0x00000A2C
		public static AssetBundle LoadFromStream(Stream stream)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, 0U, 0U);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002850 File Offset: 0x00000A50
		public static AssetBundleCreateRequest LoadFromStreamAsyncInternal(Stream stream, uint crc, uint managedReadBufferSize)
		{
			IntPtr intPtr = AssetBundle.LoadFromStreamAsyncInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(stream), crc, managedReadBufferSize);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002880 File Offset: 0x00000A80
		public static AssetBundle LoadFromStreamInternal(Stream stream, uint crc, uint managedReadBufferSize)
		{
			IntPtr intPtr = AssetBundle.LoadFromStreamInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(stream), crc, managedReadBufferSize);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000020BA File Offset: 0x000002BA
		public bool isStreamedSceneAssetBundle
		{
			get
			{
				return AssetBundle.get_isStreamedSceneAssetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020CC File Offset: 0x000002CC
		public bool Contains(string name)
		{
			return AssetBundle.ContainsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000028B0 File Offset: 0x00000AB0
		public Object Load(string name)
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000028C4 File Offset: 0x00000AC4
		public Object Load<T>(string name)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000028D8 File Offset: 0x00000AD8
		public Object Load(string name, Type type)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000028EC File Offset: 0x00000AEC
		public AssetBundleRequest LoadAsync(string name, Type type)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002900 File Offset: 0x00000B00
		public Il2CppReferenceArray<Object> LoadAll(Type type)
		{
			return null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002914 File Offset: 0x00000B14
		public Il2CppReferenceArray<Object> LoadAll()
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002928 File Offset: 0x00000B28
		public Il2CppArrayBase<T> LoadAll<T>() where T : Object
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000293C File Offset: 0x00000B3C
		public Object LoadAsset(string name)
		{
			return this.LoadAsset(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002960 File Offset: 0x00000B60
		public T LoadAsset<T>(string name) where T : Object
		{
			return this.LoadAsset(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())).Cast<T>();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002988 File Offset: 0x00000B88
		public Object LoadAsset(string name, Type type)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			bool flag2 = name.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			bool flag3 = type == null;
			if (flag3)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAsset_Internal(name, type);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000029E4 File Offset: 0x00000BE4
		public Object LoadAsset_Internal(string name, Type type)
		{
			IntPtr intPtr = AssetBundle.LoadAsset_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A1C File Offset: 0x00000C1C
		public AssetBundleRequest LoadAssetAsync(string name)
		{
			return this.LoadAssetAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002A40 File Offset: 0x00000C40
		public AssetBundleRequest LoadAssetAsync<T>(string name)
		{
			return this.LoadAssetAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002A64 File Offset: 0x00000C64
		public AssetBundleRequest LoadAssetAsync(string name, Type type)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			bool flag2 = name.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			bool flag3 = type == null;
			if (flag3)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetAsync_Internal(name, type);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name)
		{
			return this.LoadAssetWithSubAssets(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020E4 File Offset: 0x000002E4
		public static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002AE4 File Offset: 0x00000CE4
		public Il2CppArrayBase<T> LoadAssetWithSubAssets<T>(string name) where T : Object
		{
			return AssetBundle.ConvertObjects<T>(this.LoadAssetWithSubAssets(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002B0C File Offset: 0x00000D0C
		public Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name, Type type)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			bool flag2 = name.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			bool flag3 = type == null;
			if (flag3)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal(name, type);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002B68 File Offset: 0x00000D68
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002B8C File Offset: 0x00000D8C
		public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			bool flag2 = name.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			bool flag3 = type == null;
			if (flag3)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal(name, type);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002C0C File Offset: 0x00000E0C
		public Il2CppReferenceArray<Object> LoadAllAssets()
		{
			return this.LoadAllAssets(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002C30 File Offset: 0x00000E30
		public Il2CppArrayBase<T> LoadAllAssets<T>() where T : Object
		{
			return AssetBundle.ConvertObjects<T>(this.LoadAllAssets(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002C58 File Offset: 0x00000E58
		public Il2CppReferenceArray<Object> LoadAllAssets(Type type)
		{
			bool flag = type == null;
			if (flag)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal("", type);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002C8C File Offset: 0x00000E8C
		public AssetBundleRequest LoadAllAssetsAsync()
		{
			return this.LoadAllAssetsAsync(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public AssetBundleRequest LoadAllAssetsAsync<T>()
		{
			return this.LoadAllAssetsAsync(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public AssetBundleRequest LoadAllAssetsAsync(Type type)
		{
			bool flag = type == null;
			if (flag)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal("", type);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002D08 File Offset: 0x00000F08
		public Il2CppStringArray AllAssetNames()
		{
			return this.GetAllAssetNames();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002D20 File Offset: 0x00000F20
		public AssetBundleRequest LoadAssetAsync_Internal(string name, Type type)
		{
			IntPtr intPtr = AssetBundle.LoadAssetAsync_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000020F1 File Offset: 0x000002F1
		public void Unload(bool unloadAllLoadedObjects)
		{
			AssetBundle.UnloadDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), unloadAllLoadedObjects);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002D58 File Offset: 0x00000F58
		public AsyncOperation UnloadAsync(bool unloadAllLoadedObjects)
		{
			IntPtr intPtr = AssetBundle.UnloadAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), unloadAllLoadedObjects);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002D88 File Offset: 0x00000F88
		public Il2CppStringArray GetAllAssetNames()
		{
			IntPtr intPtr = AssetBundle.GetAllAssetNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public Il2CppStringArray GetAllScenePaths()
		{
			IntPtr intPtr = AssetBundle.GetAllScenePathsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public Il2CppReferenceArray<Object> LoadAssetWithSubAssets_Internal(string name, Type type)
		{
			IntPtr intPtr = AssetBundle.LoadAssetWithSubAssets_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002E18 File Offset: 0x00001018
		public AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type)
		{
			IntPtr intPtr = AssetBundle.LoadAssetWithSubAssetsAsync_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
		}

		// Token: 0x04000019 RID: 25
		private static readonly AssetBundle.returnMainAssetDelegate returnMainAssetDelegateField = IL2CPP.ResolveICall<AssetBundle.returnMainAssetDelegate>("UnityEngine.AssetBundle::returnMainAsset");

		// Token: 0x0400001A RID: 26
		private static readonly AssetBundle.UnloadAllAssetBundlesDelegate UnloadAllAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundle.UnloadAllAssetBundlesDelegate>("UnityEngine.AssetBundle::UnloadAllAssetBundles");

		// Token: 0x0400001B RID: 27
		private static readonly AssetBundle.GetAllLoadedAssetBundles_NativeDelegate GetAllLoadedAssetBundles_NativeDelegateField = IL2CPP.ResolveICall<AssetBundle.GetAllLoadedAssetBundles_NativeDelegate>("UnityEngine.AssetBundle::GetAllLoadedAssetBundles_Native");

		// Token: 0x0400001C RID: 28
		private static readonly AssetBundle.LoadFromFileAsync_InternalDelegate LoadFromFileAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromFileAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadFromFileAsync_Internal");

		// Token: 0x0400001D RID: 29
		private static readonly AssetBundle.LoadFromFile_InternalDelegate LoadFromFile_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromFile_InternalDelegate>("UnityEngine.AssetBundle::LoadFromFile_Internal");

		// Token: 0x0400001E RID: 30
		private static readonly AssetBundle.LoadFromMemoryAsync_InternalDelegate LoadFromMemoryAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromMemoryAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadFromMemoryAsync_Internal");

		// Token: 0x0400001F RID: 31
		private static readonly AssetBundle.LoadFromMemory_InternalDelegate LoadFromMemory_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromMemory_InternalDelegate>("UnityEngine.AssetBundle::LoadFromMemory_Internal");

		// Token: 0x04000020 RID: 32
		private static readonly AssetBundle.LoadFromStreamAsyncInternalDelegate LoadFromStreamAsyncInternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromStreamAsyncInternalDelegate>("UnityEngine.AssetBundle::LoadFromStreamAsyncInternal");

		// Token: 0x04000021 RID: 33
		private static readonly AssetBundle.LoadFromStreamInternalDelegate LoadFromStreamInternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromStreamInternalDelegate>("UnityEngine.AssetBundle::LoadFromStreamInternal");

		// Token: 0x04000022 RID: 34
		private static readonly AssetBundle.get_isStreamedSceneAssetBundleDelegate get_isStreamedSceneAssetBundleDelegateField = IL2CPP.ResolveICall<AssetBundle.get_isStreamedSceneAssetBundleDelegate>("UnityEngine.AssetBundle::get_isStreamedSceneAssetBundle");

		// Token: 0x04000023 RID: 35
		private static readonly AssetBundle.ContainsDelegate ContainsDelegateField = IL2CPP.ResolveICall<AssetBundle.ContainsDelegate>("UnityEngine.AssetBundle::Contains");

		// Token: 0x04000024 RID: 36
		private static readonly AssetBundle.LoadAsset_InternalDelegate LoadAsset_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadAsset_InternalDelegate>("UnityEngine.AssetBundle::LoadAsset_Internal");

		// Token: 0x04000025 RID: 37
		private static readonly AssetBundle.LoadAssetAsync_InternalDelegate LoadAssetAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadAssetAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadAssetAsync_Internal");

		// Token: 0x04000026 RID: 38
		private static readonly AssetBundle.UnloadDelegate UnloadDelegateField = IL2CPP.ResolveICall<AssetBundle.UnloadDelegate>("UnityEngine.AssetBundle::Unload");

		// Token: 0x04000027 RID: 39
		private static readonly AssetBundle.UnloadAsyncDelegate UnloadAsyncDelegateField = IL2CPP.ResolveICall<AssetBundle.UnloadAsyncDelegate>("UnityEngine.AssetBundle::UnloadAsync");

		// Token: 0x04000028 RID: 40
		private static readonly AssetBundle.GetAllAssetNamesDelegate GetAllAssetNamesDelegateField = IL2CPP.ResolveICall<AssetBundle.GetAllAssetNamesDelegate>("UnityEngine.AssetBundle::GetAllAssetNames");

		// Token: 0x04000029 RID: 41
		private static readonly AssetBundle.GetAllScenePathsDelegate GetAllScenePathsDelegateField = IL2CPP.ResolveICall<AssetBundle.GetAllScenePathsDelegate>("UnityEngine.AssetBundle::GetAllScenePaths");

		// Token: 0x0400002A RID: 42
		private static readonly AssetBundle.LoadAssetWithSubAssets_InternalDelegate LoadAssetWithSubAssets_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadAssetWithSubAssets_InternalDelegate>("UnityEngine.AssetBundle::LoadAssetWithSubAssets_Internal");

		// Token: 0x0400002B RID: 43
		private static readonly AssetBundle.LoadAssetWithSubAssetsAsync_InternalDelegate LoadAssetWithSubAssetsAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadAssetWithSubAssetsAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadAssetWithSubAssetsAsync_Internal");

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x0600006E RID: 110
		private delegate IntPtr returnMainAssetDelegate(IntPtr bundle);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000070 RID: 112
		private delegate void UnloadAllAssetBundlesDelegate(bool unloadAllObjects);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000072 RID: 114
		private delegate IntPtr GetAllLoadedAssetBundles_NativeDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000074 RID: 116
		private delegate IntPtr LoadFromFileAsync_InternalDelegate(IntPtr path, uint crc, ulong offset);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000076 RID: 118
		private delegate IntPtr LoadFromFile_InternalDelegate(IntPtr path, uint crc, ulong offset);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000078 RID: 120
		private delegate IntPtr LoadFromMemoryAsync_InternalDelegate(IntPtr binary, uint crc);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600007A RID: 122
		private delegate IntPtr LoadFromMemory_InternalDelegate(IntPtr binary, uint crc);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600007C RID: 124
		private delegate IntPtr LoadFromStreamAsyncInternalDelegate(IntPtr stream, uint crc, uint managedReadBufferSize);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x0600007E RID: 126
		private delegate IntPtr LoadFromStreamInternalDelegate(IntPtr stream, uint crc, uint managedReadBufferSize);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000080 RID: 128
		private delegate bool get_isStreamedSceneAssetBundleDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000082 RID: 130
		private delegate bool ContainsDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000084 RID: 132
		private delegate IntPtr LoadAsset_InternalDelegate(IntPtr @this, IntPtr name, IntPtr type);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000086 RID: 134
		private delegate IntPtr LoadAssetAsync_InternalDelegate(IntPtr @this, IntPtr name, IntPtr type);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000088 RID: 136
		private delegate void UnloadDelegate(IntPtr @this, bool unloadAllLoadedObjects);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x0600008A RID: 138
		private delegate IntPtr UnloadAsyncDelegate(IntPtr @this, bool unloadAllLoadedObjects);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x0600008C RID: 140
		private delegate IntPtr GetAllAssetNamesDelegate(IntPtr @this);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x0600008E RID: 142
		private delegate IntPtr GetAllScenePathsDelegate(IntPtr @this);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000090 RID: 144
		private delegate IntPtr LoadAssetWithSubAssets_InternalDelegate(IntPtr @this, IntPtr name, IntPtr type);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000092 RID: 146
		private delegate IntPtr LoadAssetWithSubAssetsAsync_InternalDelegate(IntPtr @this, IntPtr name, IntPtr type);
	}
}
