using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.TestTools
{
	// Token: 0x020002DE RID: 734
	public static class Coverage
	{
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x00014F60 File Offset: 0x00013160
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x00014F6C File Offset: 0x0001316C
		public static bool enabled
		{
			get
			{
				return Coverage.get_enabledDelegateField();
			}
			set
			{
				Coverage.set_enabledDelegateField(value);
			}
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00014F79 File Offset: 0x00013179
		public static void ResetFor_Internal(MethodBase method)
		{
			Coverage.ResetFor_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x0006AD84 File Offset: 0x00068F84
		public static void ResetFor(MethodBase method)
		{
			bool flag = method == null;
			if (flag)
			{
				throw new ArgumentNullException("method");
			}
			Coverage.ResetFor_Internal(method);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00014F8B File Offset: 0x0001318B
		public static void ResetAll()
		{
			Coverage.ResetAllDelegateField();
		}

		// Token: 0x04001C0F RID: 7183
		private static readonly Coverage.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Coverage.get_enabledDelegate>("UnityEngine.TestTools.Coverage::get_enabled");

		// Token: 0x04001C10 RID: 7184
		private static readonly Coverage.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Coverage.set_enabledDelegate>("UnityEngine.TestTools.Coverage::set_enabled");

		// Token: 0x04001C11 RID: 7185
		private static readonly Coverage.ResetFor_InternalDelegate ResetFor_InternalDelegateField = IL2CPP.ResolveICall<Coverage.ResetFor_InternalDelegate>("UnityEngine.TestTools.Coverage::ResetFor_Internal");

		// Token: 0x04001C12 RID: 7186
		private static readonly Coverage.ResetAllDelegate ResetAllDelegateField = IL2CPP.ResolveICall<Coverage.ResetAllDelegate>("UnityEngine.TestTools.Coverage::ResetAll");

		// Token: 0x02000D49 RID: 3401
		// (Invoke) Token: 0x06003872 RID: 14450
		private delegate bool get_enabledDelegate();

		// Token: 0x02000D4A RID: 3402
		// (Invoke) Token: 0x06003874 RID: 14452
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000D4B RID: 3403
		// (Invoke) Token: 0x06003876 RID: 14454
		private delegate void ResetFor_InternalDelegate(IntPtr method);

		// Token: 0x02000D4C RID: 3404
		// (Invoke) Token: 0x06003878 RID: 14456
		private delegate void ResetAllDelegate();
	}
}
