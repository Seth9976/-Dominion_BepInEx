using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000278 RID: 632
	public class PIX
	{
		// Token: 0x06002016 RID: 8214 RVA: 0x000128D1 File Offset: 0x00010AD1
		public static void BeginGPUCapture()
		{
			PIX.BeginGPUCaptureDelegateField();
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000128DD File Offset: 0x00010ADD
		public static void EndGPUCapture()
		{
			PIX.EndGPUCaptureDelegateField();
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000128E9 File Offset: 0x00010AE9
		public static bool IsAttached()
		{
			return PIX.IsAttachedDelegateField();
		}

		// Token: 0x04001964 RID: 6500
		private static readonly PIX.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.BeginGPUCaptureDelegate>("UnityEngine.Rendering.PIX::BeginGPUCapture");

		// Token: 0x04001965 RID: 6501
		private static readonly PIX.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.EndGPUCaptureDelegate>("UnityEngine.Rendering.PIX::EndGPUCapture");

		// Token: 0x04001966 RID: 6502
		private static readonly PIX.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<PIX.IsAttachedDelegate>("UnityEngine.Rendering.PIX::IsAttached");

		// Token: 0x02000C78 RID: 3192
		// (Invoke) Token: 0x060036D6 RID: 14038
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000C79 RID: 3193
		// (Invoke) Token: 0x060036D8 RID: 14040
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000C7A RID: 3194
		// (Invoke) Token: 0x060036DA RID: 14042
		private delegate bool IsAttachedDelegate();
	}
}
