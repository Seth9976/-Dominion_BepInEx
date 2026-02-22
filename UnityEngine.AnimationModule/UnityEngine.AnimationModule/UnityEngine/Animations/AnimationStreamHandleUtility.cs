using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Animations
{
	// Token: 0x02000053 RID: 83
	public static class AnimationStreamHandleUtility
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x000050C4 File Offset: 0x000032C4
		public unsafe static void ReadStreamIntsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count)
		{
			AnimationStreamHandleUtility.ReadStreamIntsInternalDelegateField(ref stream, propertyStreamHandles, intBuffer, count);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000050D4 File Offset: 0x000032D4
		public unsafe static void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count)
		{
			AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegateField(ref stream, propertyStreamHandles, floatBuffer, count);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000050E4 File Offset: 0x000032E4
		public unsafe static void WriteStreamIntsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count, bool useMask)
		{
			AnimationStreamHandleUtility.WriteStreamIntsInternalDelegateField(ref stream, propertyStreamHandles, intBuffer, count, useMask);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000050F6 File Offset: 0x000032F6
		public unsafe static void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask)
		{
			AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegateField(ref stream, propertyStreamHandles, floatBuffer, count, useMask);
		}

		// Token: 0x04000379 RID: 889
		private static readonly AnimationStreamHandleUtility.ReadStreamIntsInternalDelegate ReadStreamIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.ReadStreamIntsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamIntsInternal");

		// Token: 0x0400037A RID: 890
		private static readonly AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegate ReadStreamFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamFloatsInternal");

		// Token: 0x0400037B RID: 891
		private static readonly AnimationStreamHandleUtility.WriteStreamIntsInternalDelegate WriteStreamIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.WriteStreamIntsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamIntsInternal");

		// Token: 0x0400037C RID: 892
		private static readonly AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegate WriteStreamFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamFloatsInternal");

		// Token: 0x02000229 RID: 553
		// (Invoke) Token: 0x060008F4 RID: 2292
		private delegate void ReadStreamIntsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr intBuffer, int count);

		// Token: 0x0200022A RID: 554
		// (Invoke) Token: 0x060008F6 RID: 2294
		private delegate void ReadStreamFloatsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr floatBuffer, int count);

		// Token: 0x0200022B RID: 555
		// (Invoke) Token: 0x060008F8 RID: 2296
		private delegate void WriteStreamIntsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr intBuffer, int count, bool useMask);

		// Token: 0x0200022C RID: 556
		// (Invoke) Token: 0x060008FA RID: 2298
		private delegate void WriteStreamFloatsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr floatBuffer, int count, bool useMask);
	}
}
