using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000007 RID: 7
	public static class Streaming
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002259 File Offset: 0x00000459
		public static void RequestRegion(Material mat, int stackNameId, Rect r, int mipMap, int numMips)
		{
			Streaming.RequestRegion_Injected(mat, stackNameId, ref r, mipMap, numMips);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002267 File Offset: 0x00000467
		public static void GetTextureStackSize(Material mat, int stackNameId, out int width, out int height)
		{
			Streaming.GetTextureStackSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mat), stackNameId, out width, out height);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000227C File Offset: 0x0000047C
		public static void SetCPUCacheSize(int sizeInMegabytes)
		{
			Streaming.SetCPUCacheSizeDelegateField(sizeInMegabytes);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002289 File Offset: 0x00000489
		public static void RequestRegion_Injected(Material mat, int stackNameId, ref Rect r, int mipMap, int numMips)
		{
			Streaming.RequestRegion_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mat), stackNameId, ref r, mipMap, numMips);
		}

		// Token: 0x04000017 RID: 23
		private static readonly Streaming.GetTextureStackSizeDelegate GetTextureStackSizeDelegateField = IL2CPP.ResolveICall<Streaming.GetTextureStackSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::GetTextureStackSize");

		// Token: 0x04000018 RID: 24
		private static readonly Streaming.SetCPUCacheSizeDelegate SetCPUCacheSizeDelegateField = IL2CPP.ResolveICall<Streaming.SetCPUCacheSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::SetCPUCacheSize");

		// Token: 0x04000019 RID: 25
		private static readonly Streaming.RequestRegion_InjectedDelegate RequestRegion_InjectedDelegateField = IL2CPP.ResolveICall<Streaming.RequestRegion_InjectedDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::RequestRegion_Injected");

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600004F RID: 79
		private delegate void GetTextureStackSizeDelegate(IntPtr mat, int stackNameId, [Out] IntPtr width, [Out] IntPtr height);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate void SetCPUCacheSizeDelegate(int sizeInMegabytes);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate void RequestRegion_InjectedDelegate(IntPtr mat, int stackNameId, IntPtr r, int mipMap, int numMips);
	}
}
