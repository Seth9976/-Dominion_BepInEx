using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000048 RID: 72
	public static class AnimationPlayableBinding
	{
		// Token: 0x06000485 RID: 1157 RVA: 0x0000C97C File Offset: 0x0000AB7C
		public static PlayableBinding Create(string name, Object key)
		{
			return PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Animator>()), new PlayableBinding.CreateOutputMethod(AnimationPlayableBinding.CreateAnimationOutput));
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name)
		{
			return AnimationPlayableOutput.Create(graph, name, null);
		}
	}
}
