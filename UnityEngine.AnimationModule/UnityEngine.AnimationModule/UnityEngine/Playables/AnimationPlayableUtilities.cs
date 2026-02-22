using System;
using UnityEngine.Animations;

namespace UnityEngine.Playables
{
	// Token: 0x02000047 RID: 71
	public static class AnimationPlayableUtilities
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
		public static void Play(Animator animator, Playable playable, PlayableGraph graph)
		{
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimationClip", animator);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, Playable>(animationPlayableOutput, playable, 0);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public static AnimationClipPlayable PlayClip(Animator animator, AnimationClip clip, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimationClip", animator);
			AnimationClipPlayable animationClipPlayable = AnimationClipPlayable.Create(graph, clip);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationClipPlayable>(animationPlayableOutput, animationClipPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationClipPlayable;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000C868 File Offset: 0x0000AA68
		public static AnimationMixerPlayable PlayMixer(Animator animator, int inputCount, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "Mixer", animator);
			AnimationMixerPlayable animationMixerPlayable = AnimationMixerPlayable.Create(graph, inputCount, false);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationMixerPlayable>(animationPlayableOutput, animationMixerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationMixerPlayable;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
		public static AnimationLayerMixerPlayable PlayLayerMixer(Animator animator, int inputCount, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "Mixer", animator);
			AnimationLayerMixerPlayable animationLayerMixerPlayable = AnimationLayerMixerPlayable.Create(graph, inputCount);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationLayerMixerPlayable>(animationPlayableOutput, animationLayerMixerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationLayerMixerPlayable;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000C920 File Offset: 0x0000AB20
		public static AnimatorControllerPlayable PlayAnimatorController(Animator animator, RuntimeAnimatorController controller, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimatorControllerPlayable", animator);
			AnimatorControllerPlayable animatorControllerPlayable = AnimatorControllerPlayable.Create(graph, controller);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimatorControllerPlayable>(animationPlayableOutput, animatorControllerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animatorControllerPlayable;
		}
	}
}
