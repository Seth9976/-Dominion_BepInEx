using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x0200025F RID: 607
	public class WebCam
	{
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00012705 File Offset: 0x00010905
		public static WebCamMode Mode
		{
			get
			{
				return WebCam.get_ModeDelegateField();
			}
		}

		// Token: 0x0400194F RID: 6479
		private static readonly WebCam.get_ModeDelegate get_ModeDelegateField = IL2CPP.ResolveICall<WebCam.get_ModeDelegate>("UnityEngine.Windows.WebCam.WebCam::get_Mode");

		// Token: 0x02000C6A RID: 3178
		// (Invoke) Token: 0x060036BC RID: 14012
		private delegate WebCamMode get_ModeDelegate();
	}
}
