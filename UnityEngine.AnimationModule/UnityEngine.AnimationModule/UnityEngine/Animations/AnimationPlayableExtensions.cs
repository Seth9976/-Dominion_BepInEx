using System;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200004E RID: 78
	public static class AnimationPlayableExtensions
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x0000CC74 File Offset: 0x0000AE74
		public static void SetAnimatedProperties<U>(U playable, AnimationClip clip) where U : struct
		{
			PlayableHandle handle = playable.GetHandle();
			AnimationPlayableExtensions.SetAnimatedPropertiesInternal(ref handle, clip);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00004FC9 File Offset: 0x000031C9
		public static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties)
		{
			AnimationPlayableExtensions.SetAnimatedPropertiesInternalDelegateField(ref playable, IL2CPP.Il2CppObjectBaseToPtr(animatedProperties));
		}

		// Token: 0x04000365 RID: 869
		private static readonly AnimationPlayableExtensions.SetAnimatedPropertiesInternalDelegate SetAnimatedPropertiesInternalDelegateField = IL2CPP.ResolveICall<AnimationPlayableExtensions.SetAnimatedPropertiesInternalDelegate>("UnityEngine.Animations.AnimationPlayableExtensions::SetAnimatedPropertiesInternal");

		// Token: 0x02000221 RID: 545
		// (Invoke) Token: 0x060008E4 RID: 2276
		private delegate void SetAnimatedPropertiesInternalDelegate(IntPtr playable, IntPtr animatedProperties);
	}
}
