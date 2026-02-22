using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public class GUIDebugger
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x00004963 File Offset: 0x00002B63
		public static void LogLayoutEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style)
		{
			GUIDebugger.LogLayoutEntry_Injected(ref rect, left, right, top, bottom, style);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00004973 File Offset: 0x00002B73
		public static void LogLayoutGroupEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style, bool isVertical)
		{
			GUIDebugger.LogLayoutGroupEntry_Injected(ref rect, left, right, top, bottom, style, isVertical);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00004985 File Offset: 0x00002B85
		public static void LogLayoutEndGroup()
		{
			GUIDebugger.LogLayoutEndGroupDelegateField();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00004991 File Offset: 0x00002B91
		public static void LogBeginProperty(string targetTypeAssemblyQualifiedName, string path, Rect position)
		{
			GUIDebugger.LogBeginProperty_Injected(targetTypeAssemblyQualifiedName, path, ref position);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000499C File Offset: 0x00002B9C
		public static void LogEndProperty()
		{
			GUIDebugger.LogEndPropertyDelegateField();
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000049A8 File Offset: 0x00002BA8
		public static bool active
		{
			get
			{
				return GUIDebugger.get_activeDelegateField();
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000049B4 File Offset: 0x00002BB4
		public static void LogLayoutEntry_Injected(ref Rect rect, int left, int right, int top, int bottom, GUIStyle style)
		{
			GUIDebugger.LogLayoutEntry_InjectedDelegateField(ref rect, left, right, top, bottom, IL2CPP.Il2CppObjectBaseToPtr(style));
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000049CD File Offset: 0x00002BCD
		public static void LogLayoutGroupEntry_Injected(ref Rect rect, int left, int right, int top, int bottom, GUIStyle style, bool isVertical)
		{
			GUIDebugger.LogLayoutGroupEntry_InjectedDelegateField(ref rect, left, right, top, bottom, IL2CPP.Il2CppObjectBaseToPtr(style), isVertical);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000049E8 File Offset: 0x00002BE8
		public static void LogBeginProperty_Injected(string targetTypeAssemblyQualifiedName, string path, ref Rect position)
		{
			GUIDebugger.LogBeginProperty_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(targetTypeAssemblyQualifiedName), IL2CPP.ManagedStringToIl2Cpp(path), ref position);
		}

		// Token: 0x0400033A RID: 826
		private static readonly GUIDebugger.LogLayoutEndGroupDelegate LogLayoutEndGroupDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutEndGroupDelegate>("UnityEngine.GUIDebugger::LogLayoutEndGroup");

		// Token: 0x0400033B RID: 827
		private static readonly GUIDebugger.LogEndPropertyDelegate LogEndPropertyDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogEndPropertyDelegate>("UnityEngine.GUIDebugger::LogEndProperty");

		// Token: 0x0400033C RID: 828
		private static readonly GUIDebugger.get_activeDelegate get_activeDelegateField = IL2CPP.ResolveICall<GUIDebugger.get_activeDelegate>("UnityEngine.GUIDebugger::get_active");

		// Token: 0x0400033D RID: 829
		private static readonly GUIDebugger.LogLayoutEntry_InjectedDelegate LogLayoutEntry_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutEntry_Injected");

		// Token: 0x0400033E RID: 830
		private static readonly GUIDebugger.LogLayoutGroupEntry_InjectedDelegate LogLayoutGroupEntry_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutGroupEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutGroupEntry_Injected");

		// Token: 0x0400033F RID: 831
		private static readonly GUIDebugger.LogBeginProperty_InjectedDelegate LogBeginProperty_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogBeginProperty_InjectedDelegate>("UnityEngine.GUIDebugger::LogBeginProperty_Injected");

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x0600071B RID: 1819
		private delegate void LogLayoutEndGroupDelegate();

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x0600071D RID: 1821
		private delegate void LogEndPropertyDelegate();

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x0600071F RID: 1823
		private delegate bool get_activeDelegate();

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000721 RID: 1825
		private delegate void LogLayoutEntry_InjectedDelegate(IntPtr rect, int left, int right, int top, int bottom, IntPtr style);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000723 RID: 1827
		private delegate void LogLayoutGroupEntry_InjectedDelegate(IntPtr rect, int left, int right, int top, int bottom, IntPtr style, bool isVertical);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000725 RID: 1829
		private delegate void LogBeginProperty_InjectedDelegate(IntPtr targetTypeAssemblyQualifiedName, IntPtr path, IntPtr position);
	}
}
