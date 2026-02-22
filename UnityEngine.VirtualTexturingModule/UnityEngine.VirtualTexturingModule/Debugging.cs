using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000004 RID: 4
	public static class Debugging
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000020F6 File Offset: 0x000002F6
		public static int GetNumHandles()
		{
			return Debugging.GetNumHandlesDelegateField();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000023B4 File Offset: 0x000005B4
		public static string GetInfoDump()
		{
			IntPtr intPtr = Debugging.GetInfoDumpDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002102 File Offset: 0x00000302
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000210E File Offset: 0x0000030E
		public static bool debugTilesEnabled
		{
			get
			{
				return Debugging.get_debugTilesEnabledDelegateField();
			}
			set
			{
				Debugging.set_debugTilesEnabledDelegateField(value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000211B File Offset: 0x0000031B
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002127 File Offset: 0x00000327
		public static bool resolvingEnabled
		{
			get
			{
				return Debugging.get_resolvingEnabledDelegateField();
			}
			set
			{
				Debugging.set_resolvingEnabledDelegateField(value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002134 File Offset: 0x00000334
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002140 File Offset: 0x00000340
		public static bool flushEveryTickEnabled
		{
			get
			{
				return Debugging.get_flushEveryTickEnabledDelegateField();
			}
			set
			{
				Debugging.set_flushEveryTickEnabledDelegateField(value);
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly Debugging.GetNumHandlesDelegate GetNumHandlesDelegateField = IL2CPP.ResolveICall<Debugging.GetNumHandlesDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::GetNumHandles");

		// Token: 0x04000009 RID: 9
		private static readonly Debugging.GetInfoDumpDelegate GetInfoDumpDelegateField = IL2CPP.ResolveICall<Debugging.GetInfoDumpDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::GetInfoDump");

		// Token: 0x0400000A RID: 10
		private static readonly Debugging.get_debugTilesEnabledDelegate get_debugTilesEnabledDelegateField = IL2CPP.ResolveICall<Debugging.get_debugTilesEnabledDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::get_debugTilesEnabled");

		// Token: 0x0400000B RID: 11
		private static readonly Debugging.set_debugTilesEnabledDelegate set_debugTilesEnabledDelegateField = IL2CPP.ResolveICall<Debugging.set_debugTilesEnabledDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::set_debugTilesEnabled");

		// Token: 0x0400000C RID: 12
		private static readonly Debugging.get_resolvingEnabledDelegate get_resolvingEnabledDelegateField = IL2CPP.ResolveICall<Debugging.get_resolvingEnabledDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::get_resolvingEnabled");

		// Token: 0x0400000D RID: 13
		private static readonly Debugging.set_resolvingEnabledDelegate set_resolvingEnabledDelegateField = IL2CPP.ResolveICall<Debugging.set_resolvingEnabledDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::set_resolvingEnabled");

		// Token: 0x0400000E RID: 14
		private static readonly Debugging.get_flushEveryTickEnabledDelegate get_flushEveryTickEnabledDelegateField = IL2CPP.ResolveICall<Debugging.get_flushEveryTickEnabledDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::get_flushEveryTickEnabled");

		// Token: 0x0400000F RID: 15
		private static readonly Debugging.set_flushEveryTickEnabledDelegate set_flushEveryTickEnabledDelegateField = IL2CPP.ResolveICall<Debugging.set_flushEveryTickEnabledDelegate>("UnityEngine.Rendering.VirtualTexturing.Debugging::set_flushEveryTickEnabled");

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate int GetNumHandlesDelegate();

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000039 RID: 57
		private delegate IntPtr GetInfoDumpDelegate();

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600003B RID: 59
		private delegate bool get_debugTilesEnabledDelegate();

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600003D RID: 61
		private delegate void set_debugTilesEnabledDelegate(bool value);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600003F RID: 63
		private delegate bool get_resolvingEnabledDelegate();

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000041 RID: 65
		private delegate void set_resolvingEnabledDelegate(bool value);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000043 RID: 67
		private delegate bool get_flushEveryTickEnabledDelegate();

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate void set_flushEveryTickEnabledDelegate(bool value);
	}
}
