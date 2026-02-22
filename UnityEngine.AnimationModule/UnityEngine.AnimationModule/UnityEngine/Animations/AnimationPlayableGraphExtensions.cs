using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200004F RID: 79
	public static class AnimationPlayableGraphExtensions
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00004FDC File Offset: 0x000031DC
		public static void SyncUpdateAndTimeMode(PlayableGraph graph, Animator animator)
		{
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeMode(ref graph, animator);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00004FE8 File Offset: 0x000031E8
		public static void DestroyOutput(PlayableGraph graph, PlayableOutputHandle handle)
		{
			AnimationPlayableGraphExtensions.InternalDestroyOutput(ref graph, ref handle);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00004FF5 File Offset: 0x000031F5
		public static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			return AnimationPlayableGraphExtensions.InternalCreateAnimationOutputDelegateField(ref graph, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00005009 File Offset: 0x00003209
		public static void InternalSyncUpdateAndTimeMode(ref PlayableGraph graph, Animator animator)
		{
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000501C File Offset: 0x0000321C
		public static void InternalDestroyOutput(ref PlayableGraph graph, ref PlayableOutputHandle handle)
		{
			AnimationPlayableGraphExtensions.InternalDestroyOutputDelegateField(ref graph, ref handle);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000502A File Offset: 0x0000322A
		public static int InternalAnimationOutputCount(ref PlayableGraph graph)
		{
			return AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegateField(ref graph);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00005037 File Offset: 0x00003237
		public static bool InternalGetAnimationOutput(ref PlayableGraph graph, int index, out PlayableOutputHandle handle)
		{
			return AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegateField(ref graph, index, out handle);
		}

		// Token: 0x04000366 RID: 870
		private static readonly AnimationPlayableGraphExtensions.InternalCreateAnimationOutputDelegate InternalCreateAnimationOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalCreateAnimationOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalCreateAnimationOutput");

		// Token: 0x04000367 RID: 871
		private static readonly AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegate InternalSyncUpdateAndTimeModeDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalSyncUpdateAndTimeMode");

		// Token: 0x04000368 RID: 872
		private static readonly AnimationPlayableGraphExtensions.InternalDestroyOutputDelegate InternalDestroyOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalDestroyOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalDestroyOutput");

		// Token: 0x04000369 RID: 873
		private static readonly AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegate InternalAnimationOutputCountDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalAnimationOutputCount");

		// Token: 0x0400036A RID: 874
		private static readonly AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegate InternalGetAnimationOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalGetAnimationOutput");

		// Token: 0x02000222 RID: 546
		// (Invoke) Token: 0x060008E6 RID: 2278
		private delegate bool InternalCreateAnimationOutputDelegate(IntPtr graph, IntPtr name, [Out] IntPtr handle);

		// Token: 0x02000223 RID: 547
		// (Invoke) Token: 0x060008E8 RID: 2280
		private delegate void InternalSyncUpdateAndTimeModeDelegate(IntPtr graph, IntPtr animator);

		// Token: 0x02000224 RID: 548
		// (Invoke) Token: 0x060008EA RID: 2282
		private delegate void InternalDestroyOutputDelegate(IntPtr graph, IntPtr handle);

		// Token: 0x02000225 RID: 549
		// (Invoke) Token: 0x060008EC RID: 2284
		private delegate int InternalAnimationOutputCountDelegate(IntPtr graph);

		// Token: 0x02000226 RID: 550
		// (Invoke) Token: 0x060008EE RID: 2286
		private delegate bool InternalGetAnimationOutputDelegate(IntPtr graph, int index, [Out] IntPtr handle);
	}
}
