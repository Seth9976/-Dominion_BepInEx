using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020001DF RID: 479
	public static class FrameTimingManager
	{
		// Token: 0x06001CF5 RID: 7413 RVA: 0x000100C3 File Offset: 0x0000E2C3
		public static void CaptureFrameTimings()
		{
			FrameTimingManager.CaptureFrameTimingsDelegateField();
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000100CF File Offset: 0x0000E2CF
		public static float GetVSyncsPerSecond()
		{
			return FrameTimingManager.GetVSyncsPerSecondDelegateField();
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000100DB File Offset: 0x0000E2DB
		public static ulong GetGpuTimerFrequency()
		{
			return FrameTimingManager.GetGpuTimerFrequencyDelegateField();
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000100E7 File Offset: 0x0000E2E7
		public static ulong GetCpuTimerFrequency()
		{
			return FrameTimingManager.GetCpuTimerFrequencyDelegateField();
		}

		// Token: 0x040016D6 RID: 5846
		private static readonly FrameTimingManager.CaptureFrameTimingsDelegate CaptureFrameTimingsDelegateField = IL2CPP.ResolveICall<FrameTimingManager.CaptureFrameTimingsDelegate>("UnityEngine.FrameTimingManager::CaptureFrameTimings");

		// Token: 0x040016D7 RID: 5847
		private static readonly FrameTimingManager.GetVSyncsPerSecondDelegate GetVSyncsPerSecondDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetVSyncsPerSecondDelegate>("UnityEngine.FrameTimingManager::GetVSyncsPerSecond");

		// Token: 0x040016D8 RID: 5848
		private static readonly FrameTimingManager.GetGpuTimerFrequencyDelegate GetGpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetGpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetGpuTimerFrequency");

		// Token: 0x040016D9 RID: 5849
		private static readonly FrameTimingManager.GetCpuTimerFrequencyDelegate GetCpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetCpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetCpuTimerFrequency");

		// Token: 0x02000AF7 RID: 2807
		// (Invoke) Token: 0x060033EE RID: 13294
		private delegate void CaptureFrameTimingsDelegate();

		// Token: 0x02000AF8 RID: 2808
		// (Invoke) Token: 0x060033F0 RID: 13296
		private delegate float GetVSyncsPerSecondDelegate();

		// Token: 0x02000AF9 RID: 2809
		// (Invoke) Token: 0x060033F2 RID: 13298
		private delegate ulong GetGpuTimerFrequencyDelegate();

		// Token: 0x02000AFA RID: 2810
		// (Invoke) Token: 0x060033F4 RID: 13300
		private delegate ulong GetCpuTimerFrequencyDelegate();
	}
}
