using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Windows
{
	// Token: 0x02000259 RID: 601
	public static class CrashReporting
	{
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00066FAC File Offset: 0x000651AC
		public static string crashReportFolder
		{
			get
			{
				IntPtr intPtr = CrashReporting.get_crashReportFolderDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x04001943 RID: 6467
		private static readonly CrashReporting.get_crashReportFolderDelegate get_crashReportFolderDelegateField = IL2CPP.ResolveICall<CrashReporting.get_crashReportFolderDelegate>("UnityEngine.Windows.CrashReporting::get_crashReportFolder");

		// Token: 0x02000C69 RID: 3177
		// (Invoke) Token: 0x060036BA RID: 14010
		private delegate IntPtr get_crashReportFolderDelegate();
	}
}
