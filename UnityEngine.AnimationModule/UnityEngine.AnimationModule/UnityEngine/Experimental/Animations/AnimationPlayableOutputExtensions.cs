using System;
using Il2CppInterop.Runtime;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Animations
{
	// Token: 0x02000046 RID: 70
	public static class AnimationPlayableOutputExtensions
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x0000C798 File Offset: 0x0000A998
		public static AnimationStreamSource GetAnimationStreamSource(AnimationPlayableOutput output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource(output.GetHandle());
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00004D2F File Offset: 0x00002F2F
		public static void SetAnimationStreamSource(AnimationPlayableOutput output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource(output.GetHandle(), streamSource);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		public static ushort GetSortingOrder(AnimationPlayableOutput output)
		{
			return (ushort)AnimationPlayableOutputExtensions.InternalGetSortingOrder(output.GetHandle());
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00004D40 File Offset: 0x00002F40
		public static void SetSortingOrder(AnimationPlayableOutput output, ushort sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder(output.GetHandle(), (int)sortingOrder);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00004D51 File Offset: 0x00002F51
		public static AnimationStreamSource InternalGetAnimationStreamSource(PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_Injected(ref output);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00004D5A File Offset: 0x00002F5A
		public static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_Injected(ref output, streamSource);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00004D64 File Offset: 0x00002F64
		public static int InternalGetSortingOrder(PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetSortingOrder_Injected(ref output);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00004D6D File Offset: 0x00002F6D
		public static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder_Injected(ref output, sortingOrder);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00004D77 File Offset: 0x00002F77
		public static AnimationStreamSource InternalGetAnimationStreamSource_Injected(ref PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegateField(ref output);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00004D84 File Offset: 0x00002F84
		public static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegateField(ref output, streamSource);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00004D92 File Offset: 0x00002F92
		public static int InternalGetSortingOrder_Injected(ref PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegateField(ref output);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00004D9F File Offset: 0x00002F9F
		public static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegateField(ref output, sortingOrder);
		}

		// Token: 0x04000344 RID: 836
		private static readonly AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegate InternalGetAnimationStreamSource_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalGetAnimationStreamSource_Injected");

		// Token: 0x04000345 RID: 837
		private static readonly AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegate InternalSetAnimationStreamSource_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalSetAnimationStreamSource_Injected");

		// Token: 0x04000346 RID: 838
		private static readonly AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegate InternalGetSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalGetSortingOrder_Injected");

		// Token: 0x04000347 RID: 839
		private static readonly AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegate InternalSetSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalSetSortingOrder_Injected");

		// Token: 0x02000203 RID: 515
		// (Invoke) Token: 0x060008AA RID: 2218
		private delegate AnimationStreamSource InternalGetAnimationStreamSource_InjectedDelegate(IntPtr output);

		// Token: 0x02000204 RID: 516
		// (Invoke) Token: 0x060008AC RID: 2220
		private delegate void InternalSetAnimationStreamSource_InjectedDelegate(IntPtr output, AnimationStreamSource streamSource);

		// Token: 0x02000205 RID: 517
		// (Invoke) Token: 0x060008AE RID: 2222
		private delegate int InternalGetSortingOrder_InjectedDelegate(IntPtr output);

		// Token: 0x02000206 RID: 518
		// (Invoke) Token: 0x060008B0 RID: 2224
		private delegate void InternalSetSortingOrder_InjectedDelegate(IntPtr output, int sortingOrder);
	}
}
