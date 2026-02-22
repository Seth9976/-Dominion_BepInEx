using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace UnityEngine.Apple
{
	// Token: 0x020002DC RID: 732
	public class FrameCapture
	{
		// Token: 0x0600235E RID: 9054 RVA: 0x00014EDA File Offset: 0x000130DA
		public static bool IsDestinationSupportedImpl(FrameCaptureDestination dest)
		{
			return FrameCapture.IsDestinationSupportedImplDelegateField(dest);
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00014EE7 File Offset: 0x000130E7
		public static void BeginCaptureImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.BeginCaptureImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00014EFA File Offset: 0x000130FA
		public static void EndCaptureImpl()
		{
			FrameCapture.EndCaptureImplDelegateField();
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00014F06 File Offset: 0x00013106
		public static void CaptureNextFrameImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.CaptureNextFrameImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0006ABF8 File Offset: 0x00068DF8
		public static bool IsDestinationSupported(FrameCaptureDestination dest)
		{
			bool flag = dest != FrameCaptureDestination.DevTools && dest != FrameCaptureDestination.GPUTraceDocument;
			if (flag)
			{
				throw new ArgumentException("dest", "Argument dest has bad value (not one of FrameCaptureDestination enum values)");
			}
			return FrameCapture.IsDestinationSupportedImpl(dest);
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x0006AC34 File Offset: 0x00068E34
		public static void BeginCaptureToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.BeginCaptureImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0006AC64 File Offset: 0x00068E64
		public static void BeginCaptureToFile(string path)
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.GPUTraceDocument);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture to file is not supported.");
			}
			bool flag2 = String.IsNullOrEmpty(path);
			if (flag2)
			{
				throw new ArgumentException("path", "Path must be supplied when capture destination is GPUTraceDocument.");
			}
			bool flag3 = Path.GetExtension(path) != ".gputrace";
			if (flag3)
			{
				throw new ArgumentException("path", "Destination file should have .gputrace extension.");
			}
			FrameCapture.BeginCaptureImpl(FrameCaptureDestination.GPUTraceDocument, new Uri(path).AbsoluteUri);
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00014F19 File Offset: 0x00013119
		public static void EndCapture()
		{
			FrameCapture.EndCaptureImpl();
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0006ACDC File Offset: 0x00068EDC
		public static void CaptureNextFrameToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.CaptureNextFrameImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0006AD0C File Offset: 0x00068F0C
		public static void CaptureNextFrameToFile(string path)
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.GPUTraceDocument);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture to file is not supported.");
			}
			bool flag2 = String.IsNullOrEmpty(path);
			if (flag2)
			{
				throw new ArgumentException("path", "Path must be supplied when capture destination is GPUTraceDocument.");
			}
			bool flag3 = Path.GetExtension(path) != ".gputrace";
			if (flag3)
			{
				throw new ArgumentException("path", "Destination file should have .gputrace extension.");
			}
			FrameCapture.CaptureNextFrameImpl(FrameCaptureDestination.GPUTraceDocument, new Uri(path).AbsoluteUri);
		}

		// Token: 0x04001C0B RID: 7179
		private static readonly FrameCapture.IsDestinationSupportedImplDelegate IsDestinationSupportedImplDelegateField = IL2CPP.ResolveICall<FrameCapture.IsDestinationSupportedImplDelegate>("UnityEngine.Apple.FrameCapture::IsDestinationSupportedImpl");

		// Token: 0x04001C0C RID: 7180
		private static readonly FrameCapture.BeginCaptureImplDelegate BeginCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.BeginCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::BeginCaptureImpl");

		// Token: 0x04001C0D RID: 7181
		private static readonly FrameCapture.EndCaptureImplDelegate EndCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.EndCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::EndCaptureImpl");

		// Token: 0x04001C0E RID: 7182
		private static readonly FrameCapture.CaptureNextFrameImplDelegate CaptureNextFrameImplDelegateField = IL2CPP.ResolveICall<FrameCapture.CaptureNextFrameImplDelegate>("UnityEngine.Apple.FrameCapture::CaptureNextFrameImpl");

		// Token: 0x02000D45 RID: 3397
		// (Invoke) Token: 0x0600386A RID: 14442
		private delegate bool IsDestinationSupportedImplDelegate(FrameCaptureDestination dest);

		// Token: 0x02000D46 RID: 3398
		// (Invoke) Token: 0x0600386C RID: 14444
		private delegate void BeginCaptureImplDelegate(FrameCaptureDestination dest, IntPtr path);

		// Token: 0x02000D47 RID: 3399
		// (Invoke) Token: 0x0600386E RID: 14446
		private delegate void EndCaptureImplDelegate();

		// Token: 0x02000D48 RID: 3400
		// (Invoke) Token: 0x06003870 RID: 14448
		private delegate void CaptureNextFrameImplDelegate(FrameCaptureDestination dest, IntPtr path);
	}
}
