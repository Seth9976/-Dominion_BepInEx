using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A7 RID: 679
	public static class CommandBufferExtensions
	{
		// Token: 0x060021AC RID: 8620 RVA: 0x0001400A File Offset: 0x0001220A
		public static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchIntoFastMemoryDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cmd), ref rt, fastMemoryFlags, residency, copyContents);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00014021 File Offset: 0x00012221
		public static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchOutOfFastMemoryDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cmd), ref rt, copyContents);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00014035 File Offset: 0x00012235
		public static void SwitchIntoFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchIntoFastMemory(cmd, ref rid, fastMemoryFlags, residency, copyContents);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00014045 File Offset: 0x00012245
		public static void SwitchOutOfFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchOutOfFastMemory(cmd, ref rid, copyContents);
		}

		// Token: 0x04001B3F RID: 6975
		private static readonly CommandBufferExtensions.Internal_SwitchIntoFastMemoryDelegate Internal_SwitchIntoFastMemoryDelegateField = IL2CPP.ResolveICall<CommandBufferExtensions.Internal_SwitchIntoFastMemoryDelegate>("UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchIntoFastMemory");

		// Token: 0x04001B40 RID: 6976
		private static readonly CommandBufferExtensions.Internal_SwitchOutOfFastMemoryDelegate Internal_SwitchOutOfFastMemoryDelegateField = IL2CPP.ResolveICall<CommandBufferExtensions.Internal_SwitchOutOfFastMemoryDelegate>("UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchOutOfFastMemory");

		// Token: 0x02000CF8 RID: 3320
		// (Invoke) Token: 0x060037D6 RID: 14294
		private delegate void Internal_SwitchIntoFastMemoryDelegate(IntPtr cmd, IntPtr rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);

		// Token: 0x02000CF9 RID: 3321
		// (Invoke) Token: 0x060037D8 RID: 14296
		private delegate void Internal_SwitchOutOfFastMemoryDelegate(IntPtr cmd, IntPtr rt, bool copyContents);
	}
}
