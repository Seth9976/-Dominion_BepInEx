using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x02000275 RID: 629
	public static class AsyncGPUReadback
	{
		// Token: 0x06002012 RID: 8210 RVA: 0x0006722C File Offset: 0x0006542C
		public static void ValidateFormat(Texture src, UnityEngine.Experimental.Rendering.GraphicsFormat dstformat)
		{
			UnityEngine.Experimental.Rendering.GraphicsFormat format = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetFormat(src);
			bool flag = !SystemInfo.IsFormatSupported(format, UnityEngine.Experimental.Rendering.FormatUsage.ReadPixels);
			if (flag)
			{
				Debug.LogError(String.Format("'{0}' doesn't support ReadPixels usage on this platform. Async GPU readback failed.", format));
			}
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00012896 File Offset: 0x00010A96
		public static void WaitAllRequests()
		{
			AsyncGPUReadback.WaitAllRequestsDelegateField();
		}

		// Token: 0x04001960 RID: 6496
		private static readonly AsyncGPUReadback.WaitAllRequestsDelegate WaitAllRequestsDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.WaitAllRequestsDelegate>("UnityEngine.Rendering.AsyncGPUReadback::WaitAllRequests");

		// Token: 0x02000C77 RID: 3191
		// (Invoke) Token: 0x060036D4 RID: 14036
		private delegate void WaitAllRequestsDelegate();
	}
}
