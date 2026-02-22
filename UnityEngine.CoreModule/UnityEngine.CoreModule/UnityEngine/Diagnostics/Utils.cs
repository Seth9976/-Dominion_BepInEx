using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Diagnostics
{
	// Token: 0x020002C8 RID: 712
	public static class Utils
	{
		// Token: 0x06002235 RID: 8757 RVA: 0x000142D4 File Offset: 0x000124D4
		public static void ForceCrash(ForcedCrashCategory crashCategory)
		{
			Utils.ForceCrashDelegateField(crashCategory);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x000142E1 File Offset: 0x000124E1
		public static void NativeAssert(string message)
		{
			Utils.NativeAssertDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x000142F3 File Offset: 0x000124F3
		public static void NativeError(string message)
		{
			Utils.NativeErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00014305 File Offset: 0x00012505
		public static void NativeWarning(string message)
		{
			Utils.NativeWarningDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x04001BD0 RID: 7120
		private static readonly Utils.ForceCrashDelegate ForceCrashDelegateField = IL2CPP.ResolveICall<Utils.ForceCrashDelegate>("UnityEngine.Diagnostics.Utils::ForceCrash");

		// Token: 0x04001BD1 RID: 7121
		private static readonly Utils.NativeAssertDelegate NativeAssertDelegateField = IL2CPP.ResolveICall<Utils.NativeAssertDelegate>("UnityEngine.Diagnostics.Utils::NativeAssert");

		// Token: 0x04001BD2 RID: 7122
		private static readonly Utils.NativeErrorDelegate NativeErrorDelegateField = IL2CPP.ResolveICall<Utils.NativeErrorDelegate>("UnityEngine.Diagnostics.Utils::NativeError");

		// Token: 0x04001BD3 RID: 7123
		private static readonly Utils.NativeWarningDelegate NativeWarningDelegateField = IL2CPP.ResolveICall<Utils.NativeWarningDelegate>("UnityEngine.Diagnostics.Utils::NativeWarning");

		// Token: 0x02000D1A RID: 3354
		// (Invoke) Token: 0x06003818 RID: 14360
		private delegate void ForceCrashDelegate(ForcedCrashCategory crashCategory);

		// Token: 0x02000D1B RID: 3355
		// (Invoke) Token: 0x0600381A RID: 14362
		private delegate void NativeAssertDelegate(IntPtr message);

		// Token: 0x02000D1C RID: 3356
		// (Invoke) Token: 0x0600381C RID: 14364
		private delegate void NativeErrorDelegate(IntPtr message);

		// Token: 0x02000D1D RID: 3357
		// (Invoke) Token: 0x0600381E RID: 14366
		private delegate void NativeWarningDelegate(IntPtr message);
	}
}
