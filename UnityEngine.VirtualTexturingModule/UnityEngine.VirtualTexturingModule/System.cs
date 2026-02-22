using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000002 RID: 2
	public static class System
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000207F File Offset: 0x0000027F
		public static bool enabled
		{
			get
			{
				return UnityEngine.Rendering.VirtualTexturing.System.get_enabledDelegateField();
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000208B File Offset: 0x0000028B
		public static void Update()
		{
			UnityEngine.Rendering.VirtualTexturing.System.UpdateDelegateField();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002097 File Offset: 0x00000297
		public static void SetDebugFlag(Guid guid, bool enabled)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlag(guid.ToByteArray(), enabled);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A8 File Offset: 0x000002A8
		public static void SetDebugFlag(Il2CppStructArray<byte> guid, bool enabled)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDelegateField(IL2CPP.Il2CppObjectBaseToPtr(guid), enabled);
		}

		// Token: 0x04000001 RID: 1
		public const int AllMips = 2147483647;

		// Token: 0x04000002 RID: 2
		private static readonly UnityEngine.Rendering.VirtualTexturing.System.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<UnityEngine.Rendering.VirtualTexturing.System.get_enabledDelegate>("UnityEngine.Rendering.VirtualTexturing.System::get_enabled");

		// Token: 0x04000003 RID: 3
		private static readonly UnityEngine.Rendering.VirtualTexturing.System.UpdateDelegate UpdateDelegateField = IL2CPP.ResolveICall<UnityEngine.Rendering.VirtualTexturing.System.UpdateDelegate>("UnityEngine.Rendering.VirtualTexturing.System::Update");

		// Token: 0x04000004 RID: 4
		private static readonly UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDelegate SetDebugFlagDelegateField = IL2CPP.ResolveICall<UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDelegate>("UnityEngine.Rendering.VirtualTexturing.System::SetDebugFlag");

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600002B RID: 43
		private delegate bool get_enabledDelegate();

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600002D RID: 45
		private delegate void UpdateDelegate();

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600002F RID: 47
		private delegate void SetDebugFlagDelegate(IntPtr guid, bool enabled);
	}
}
