using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000007 RID: 7
	public static class XRStats
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002247 File Offset: 0x00000447
		public static bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame)
		{
			return XRStats.TryGetGPUTimeLastFrameDelegateField(out gpuTimeLastFrame);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002254 File Offset: 0x00000454
		public static bool TryGetDroppedFrameCount(out int droppedFrameCount)
		{
			return XRStats.TryGetDroppedFrameCountDelegateField(out droppedFrameCount);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002261 File Offset: 0x00000461
		public static bool TryGetFramePresentCount(out int framePresentCount)
		{
			return XRStats.TryGetFramePresentCountDelegateField(out framePresentCount);
		}

		// Token: 0x0400002B RID: 43
		private static readonly XRStats.TryGetGPUTimeLastFrameDelegate TryGetGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<XRStats.TryGetGPUTimeLastFrameDelegate>("UnityEngine.XR.XRStats::TryGetGPUTimeLastFrame");

		// Token: 0x0400002C RID: 44
		private static readonly XRStats.TryGetDroppedFrameCountDelegate TryGetDroppedFrameCountDelegateField = IL2CPP.ResolveICall<XRStats.TryGetDroppedFrameCountDelegate>("UnityEngine.XR.XRStats::TryGetDroppedFrameCount");

		// Token: 0x0400002D RID: 45
		private static readonly XRStats.TryGetFramePresentCountDelegate TryGetFramePresentCountDelegateField = IL2CPP.ResolveICall<XRStats.TryGetFramePresentCountDelegate>("UnityEngine.XR.XRStats::TryGetFramePresentCount");

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000072 RID: 114
		private delegate bool TryGetGPUTimeLastFrameDelegate([Out] IntPtr gpuTimeLastFrame);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000074 RID: 116
		private delegate bool TryGetDroppedFrameCountDelegate([Out] IntPtr droppedFrameCount);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000076 RID: 118
		private delegate bool TryGetFramePresentCountDelegate([Out] IntPtr framePresentCount);
	}
}
