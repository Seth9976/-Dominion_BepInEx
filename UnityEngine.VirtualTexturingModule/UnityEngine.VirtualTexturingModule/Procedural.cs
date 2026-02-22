using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000008 RID: 8
	public static class Procedural
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000022C0 File Offset: 0x000004C0
		public static void SetCPUCacheSize(int sizeInMegabytes)
		{
			Procedural.SetCPUCacheSizeDelegateField(sizeInMegabytes);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000022CD File Offset: 0x000004CD
		public static int GetCPUCacheSize()
		{
			return Procedural.GetCPUCacheSizeDelegateField();
		}

		// Token: 0x0400001A RID: 26
		private static readonly Procedural.SetCPUCacheSizeDelegate SetCPUCacheSizeDelegateField = IL2CPP.ResolveICall<Procedural.SetCPUCacheSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Procedural::SetCPUCacheSize");

		// Token: 0x0400001B RID: 27
		private static readonly Procedural.GetCPUCacheSizeDelegate GetCPUCacheSizeDelegateField = IL2CPP.ResolveICall<Procedural.GetCPUCacheSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Procedural::GetCPUCacheSize");

		// Token: 0x0200001E RID: 30
		public static class Binding
		{
		}

		// Token: 0x0200001F RID: 31
		public enum ProceduralTextureStackRequestStatus
		{
			// Token: 0x0400001D RID: 29
			StatusFree = 65535,
			// Token: 0x0400001E RID: 30
			StatusRequested,
			// Token: 0x0400001F RID: 31
			StatusProcessing,
			// Token: 0x04000020 RID: 32
			StatusComplete,
			// Token: 0x04000021 RID: 33
			StatusDropped
		}

		// Token: 0x02000020 RID: 32
		public enum RequestStatus
		{
			// Token: 0x04000023 RID: 35
			Dropped = 65539,
			// Token: 0x04000024 RID: 36
			Generated = 65538
		}

		// Token: 0x02000021 RID: 33
		public sealed class GPUTextureStack : Procedural.TextureStackBase<Procedural.GPUTextureStackRequestParameters>
		{
		}

		// Token: 0x02000022 RID: 34
		public sealed class CPUTextureStack : Procedural.TextureStackBase<Procedural.CPUTextureStackRequestParameters>
		{
		}

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate void SetCPUCacheSizeDelegate(int sizeInMegabytes);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000057 RID: 87
		private delegate int GetCPUCacheSizeDelegate();
	}
}
