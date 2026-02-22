using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class ScreenCapture
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000207F File Offset: 0x0000027F
		public static void CaptureScreenshot(string filename)
		{
			ScreenCapture.CaptureScreenshot(filename, 1, ScreenCapture.StereoScreenCaptureMode.LeftEye);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000208B File Offset: 0x0000028B
		public static void CaptureScreenshot(string filename, int superSize)
		{
			ScreenCapture.CaptureScreenshot(filename, superSize, ScreenCapture.StereoScreenCaptureMode.LeftEye);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002097 File Offset: 0x00000297
		public static void CaptureScreenshot(string filename, ScreenCapture.StereoScreenCaptureMode stereoCaptureMode)
		{
			ScreenCapture.CaptureScreenshot(filename, 1, stereoCaptureMode);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020CC File Offset: 0x000002CC
		public static Texture2D CaptureScreenshotAsTexture()
		{
			return ScreenCapture.CaptureScreenshotAsTexture(1, ScreenCapture.StereoScreenCaptureMode.LeftEye);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020E8 File Offset: 0x000002E8
		public static Texture2D CaptureScreenshotAsTexture(int superSize)
		{
			return ScreenCapture.CaptureScreenshotAsTexture(superSize, ScreenCapture.StereoScreenCaptureMode.LeftEye);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002104 File Offset: 0x00000304
		public static Texture2D CaptureScreenshotAsTexture(ScreenCapture.StereoScreenCaptureMode stereoCaptureMode)
		{
			return ScreenCapture.CaptureScreenshotAsTexture(1, stereoCaptureMode);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020A3 File Offset: 0x000002A3
		public static void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture)
		{
			ScreenCapture.CaptureScreenshotIntoRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderTexture));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020B5 File Offset: 0x000002B5
		public static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode)
		{
			ScreenCapture.CaptureScreenshotDelegateField(IL2CPP.ManagedStringToIl2Cpp(filename), superSize, CaptureMode);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002120 File Offset: 0x00000320
		public static Texture2D CaptureScreenshotAsTexture(int superSize, ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode)
		{
			IntPtr intPtr = ScreenCapture.CaptureScreenshotAsTextureDelegateField(superSize, stereoScreenCaptureMode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x04000001 RID: 1
		private static readonly ScreenCapture.CaptureScreenshotIntoRenderTextureDelegate CaptureScreenshotIntoRenderTextureDelegateField = IL2CPP.ResolveICall<ScreenCapture.CaptureScreenshotIntoRenderTextureDelegate>("UnityEngine.ScreenCapture::CaptureScreenshotIntoRenderTexture");

		// Token: 0x04000002 RID: 2
		private static readonly ScreenCapture.CaptureScreenshotDelegate CaptureScreenshotDelegateField = IL2CPP.ResolveICall<ScreenCapture.CaptureScreenshotDelegate>("UnityEngine.ScreenCapture::CaptureScreenshot");

		// Token: 0x04000003 RID: 3
		private static readonly ScreenCapture.CaptureScreenshotAsTextureDelegate CaptureScreenshotAsTextureDelegateField = IL2CPP.ResolveICall<ScreenCapture.CaptureScreenshotAsTextureDelegate>("UnityEngine.ScreenCapture::CaptureScreenshotAsTexture");

		// Token: 0x02000003 RID: 3
		public enum StereoScreenCaptureMode
		{
			// Token: 0x04000005 RID: 5
			LeftEye = 1,
			// Token: 0x04000006 RID: 6
			RightEye,
			// Token: 0x04000007 RID: 7
			BothEyes
		}

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000C RID: 12
		private delegate void CaptureScreenshotIntoRenderTextureDelegate(IntPtr renderTexture);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000E RID: 14
		private delegate void CaptureScreenshotDelegate(IntPtr filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000010 RID: 16
		private delegate IntPtr CaptureScreenshotAsTextureDelegate(int superSize, ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode);
	}
}
