using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public static class SubsystemBindings
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00002524 File Offset: 0x00000724
		public static void DestroySubsystem(IntPtr nativePtr)
		{
			SubsystemBindings.DestroySubsystemDelegateField(nativePtr);
		}

		// Token: 0x0400002F RID: 47
		private static readonly SubsystemBindings.DestroySubsystemDelegate DestroySubsystemDelegateField = IL2CPP.ResolveICall<SubsystemBindings.DestroySubsystemDelegate>("UnityEngine.SubsystemBindings::DestroySubsystem");

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x0600009C RID: 156
		private delegate void DestroySubsystemDelegate(IntPtr nativePtr);
	}
}
