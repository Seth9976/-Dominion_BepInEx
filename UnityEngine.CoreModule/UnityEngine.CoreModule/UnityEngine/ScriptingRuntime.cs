using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000232 RID: 562
	public class ScriptingRuntime
	{
		// Token: 0x06001F08 RID: 7944 RVA: 0x000657F8 File Offset: 0x000639F8
		public static Il2CppStringArray GetAllUserAssemblies()
		{
			IntPtr intPtr = ScriptingRuntime.GetAllUserAssembliesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x04001893 RID: 6291
		private static readonly ScriptingRuntime.GetAllUserAssembliesDelegate GetAllUserAssembliesDelegateField = IL2CPP.ResolveICall<ScriptingRuntime.GetAllUserAssembliesDelegate>("UnityEngine.ScriptingRuntime::GetAllUserAssemblies");

		// Token: 0x02000C0D RID: 3085
		// (Invoke) Token: 0x06003608 RID: 13832
		private delegate IntPtr GetAllUserAssembliesDelegate();
	}
}
