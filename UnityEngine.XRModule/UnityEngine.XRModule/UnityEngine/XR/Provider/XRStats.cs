using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR.Provider
{
	// Token: 0x02000025 RID: 37
	public static class XRStats
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00005894 File Offset: 0x00003A94
		public static bool TryGetStat(IntegratedSubsystem xrSubsystem, string tag, out float value)
		{
			return XRStats.TryGetStat_Internal(xrSubsystem.m_Ptr, tag, out value);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002D25 File Offset: 0x00000F25
		public static bool TryGetStat_Internal(IntPtr ptr, string tag, out float value)
		{
			return XRStats.TryGetStat_InternalDelegateField(ptr, IL2CPP.ManagedStringToIl2Cpp(tag), out value);
		}

		// Token: 0x0400013B RID: 315
		private static readonly XRStats.TryGetStat_InternalDelegate TryGetStat_InternalDelegateField = IL2CPP.ResolveICall<XRStats.TryGetStat_InternalDelegate>("UnityEngine.XR.Provider.XRStats::TryGetStat_Internal");

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x0600021D RID: 541
		private delegate bool TryGetStat_InternalDelegate(IntPtr ptr, IntPtr tag, [Out] IntPtr value);
	}
}
