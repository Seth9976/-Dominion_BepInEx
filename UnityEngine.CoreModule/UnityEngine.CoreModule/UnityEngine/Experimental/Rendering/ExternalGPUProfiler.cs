using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D1 RID: 721
	public static class ExternalGPUProfiler
	{
		// Token: 0x060022F9 RID: 8953 RVA: 0x00014889 File Offset: 0x00012A89
		public static void BeginGPUCapture()
		{
			ExternalGPUProfiler.BeginGPUCaptureDelegateField();
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00014895 File Offset: 0x00012A95
		public static void EndGPUCapture()
		{
			ExternalGPUProfiler.EndGPUCaptureDelegateField();
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x000148A1 File Offset: 0x00012AA1
		public static bool IsAttached()
		{
			return ExternalGPUProfiler.IsAttachedDelegateField();
		}

		// Token: 0x04001BD8 RID: 7128
		private static readonly ExternalGPUProfiler.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.BeginGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::BeginGPUCapture");

		// Token: 0x04001BD9 RID: 7129
		private static readonly ExternalGPUProfiler.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.EndGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::EndGPUCapture");

		// Token: 0x04001BDA RID: 7130
		private static readonly ExternalGPUProfiler.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.IsAttachedDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::IsAttached");

		// Token: 0x02000D21 RID: 3361
		// (Invoke) Token: 0x06003826 RID: 14374
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000D22 RID: 3362
		// (Invoke) Token: 0x06003828 RID: 14376
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000D23 RID: 3363
		// (Invoke) Token: 0x0600382A RID: 14378
		private delegate bool IsAttachedDelegate();
	}
}
