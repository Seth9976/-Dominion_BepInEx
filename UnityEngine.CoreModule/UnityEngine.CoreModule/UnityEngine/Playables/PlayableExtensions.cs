using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x020002C2 RID: 706
	public static class PlayableExtensions
	{
		// Token: 0x060021F3 RID: 8691 RVA: 0x00069CBC File Offset: 0x00067EBC
		public static bool IsNull<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsNull();
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00069CE4 File Offset: 0x00067EE4
		public static bool IsValid<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsValid();
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00069D0C File Offset: 0x00067F0C
		public static void Destroy<U>(U playable) where U : struct
		{
			playable.GetHandle().Destroy();
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00069D30 File Offset: 0x00067F30
		public static PlayableGraph GetGraph<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetGraph();
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00069D58 File Offset: 0x00067F58
		public static void SetPlayState<U>(U playable, PlayState value) where U : struct
		{
			bool flag = value == PlayState.Delayed;
			if (flag)
			{
				throw new ArgumentException("Can't set Delayed: use SetDelay() instead");
			}
			if (value != PlayState.Paused)
			{
				if (value == PlayState.Playing)
				{
					playable.GetHandle().Play();
				}
			}
			else
			{
				playable.GetHandle().Pause();
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00069DB8 File Offset: 0x00067FB8
		public static PlayState GetPlayState<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPlayState();
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00069DE0 File Offset: 0x00067FE0
		public static void Play<U>(U playable) where U : struct
		{
			playable.GetHandle().Play();
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00069E04 File Offset: 0x00068004
		public static void Pause<U>(U playable) where U : struct
		{
			playable.GetHandle().Pause();
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00069E28 File Offset: 0x00068028
		public static void SetSpeed<U>(U playable, double value) where U : struct
		{
			playable.GetHandle().SetSpeed(value);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00069E50 File Offset: 0x00068050
		public static double GetSpeed<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetSpeed();
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00069E78 File Offset: 0x00068078
		public static void SetDuration<U>(U playable, double value) where U : struct
		{
			playable.GetHandle().SetDuration(value);
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00069EA0 File Offset: 0x000680A0
		public static double GetDuration<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetDuration();
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00069EC8 File Offset: 0x000680C8
		public static void SetTime<U>(U playable, double value) where U : struct
		{
			playable.GetHandle().SetTime(value);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00069EF0 File Offset: 0x000680F0
		public static double GetTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTime();
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00069F18 File Offset: 0x00068118
		public static double GetPreviousTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPreviousTime();
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00069F40 File Offset: 0x00068140
		public static void SetDone<U>(U playable, bool value) where U : struct
		{
			playable.GetHandle().SetDone(value);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00069F68 File Offset: 0x00068168
		public static bool IsDone<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsDone();
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00069F90 File Offset: 0x00068190
		public static void SetPropagateSetTime<U>(U playable, bool value) where U : struct
		{
			playable.GetHandle().SetPropagateSetTime(value);
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00069FB8 File Offset: 0x000681B8
		public static bool GetPropagateSetTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPropagateSetTime();
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00069FE0 File Offset: 0x000681E0
		public static bool CanChangeInputs<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanChangeInputs();
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0006A008 File Offset: 0x00068208
		public static bool CanSetWeights<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanSetWeights();
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x0006A030 File Offset: 0x00068230
		public static bool CanDestroy<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanDestroy();
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x0006A058 File Offset: 0x00068258
		public static void SetInputCount<U>(U playable, int value) where U : struct
		{
			playable.GetHandle().SetInputCount(value);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0006A080 File Offset: 0x00068280
		public static int GetInputCount<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetInputCount();
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0006A0A8 File Offset: 0x000682A8
		public static void SetOutputCount<U>(U playable, int value) where U : struct
		{
			playable.GetHandle().SetOutputCount(value);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0006A0D0 File Offset: 0x000682D0
		public static int GetOutputCount<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetOutputCount();
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0006A0F8 File Offset: 0x000682F8
		public static Playable GetInput<U>(U playable, int inputPort) where U : struct
		{
			return playable.GetHandle().GetInput(inputPort);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0006A120 File Offset: 0x00068320
		public static Playable GetOutput<U>(U playable, int outputPort) where U : struct
		{
			return playable.GetHandle().GetOutput(outputPort);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0006A148 File Offset: 0x00068348
		public static void SetInputWeight<U>(U playable, int inputIndex, float weight) where U : struct
		{
			playable.GetHandle().SetInputWeight(inputIndex, weight);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0006A170 File Offset: 0x00068370
		public static void SetInputWeight<U, V>(U playable, V input, float weight) where U : struct where V : struct
		{
			playable.GetHandle().SetInputWeight(input.GetHandle(), weight);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0006A1A4 File Offset: 0x000683A4
		public static float GetInputWeight<U>(U playable, int inputIndex) where U : struct
		{
			return playable.GetHandle().GetInputWeight(inputIndex);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00014262 File Offset: 0x00012462
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) where U : struct where V : struct
		{
			PlayableExtensions.ConnectInput<U, V>(playable, inputIndex, sourcePlayable, sourceOutputIndex, 0f);
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0006A1CC File Offset: 0x000683CC
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) where U : struct where V : struct
		{
			PlayableExtensions.GetGraph<U>(playable).Connect<V, U>(sourcePlayable, sourceOutputIndex, playable, inputIndex);
			PlayableExtensions.SetInputWeight<U>(playable, inputIndex, weight);
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0006A1F8 File Offset: 0x000683F8
		public static void DisconnectInput<U>(U playable, int inputPort) where U : struct
		{
			PlayableExtensions.GetGraph<U>(playable).Disconnect<U>(playable, inputPort);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0006A218 File Offset: 0x00068418
		public static int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, [Optional] float weight) where U : struct where V : struct
		{
			int inputCount = PlayableExtensions.GetInputCount<U>(playable);
			PlayableExtensions.SetInputCount<U>(playable, inputCount + 1);
			PlayableExtensions.ConnectInput<U, V>(playable, inputCount, sourcePlayable, sourceOutputIndex, weight);
			return inputCount;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0006A248 File Offset: 0x00068448
		public static void SetDelay<U>(U playable, double delay) where U : struct
		{
			playable.GetHandle().SetDelay(delay);
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0006A270 File Offset: 0x00068470
		public static double GetDelay<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetDelay();
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0006A298 File Offset: 0x00068498
		public static bool IsDelayed<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsDelayed();
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0006A2C0 File Offset: 0x000684C0
		public static void SetLeadTime<U>(U playable, float value) where U : struct
		{
			playable.GetHandle().SetLeadTime(value);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0006A2E8 File Offset: 0x000684E8
		public static float GetLeadTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetLeadTime();
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0006A310 File Offset: 0x00068510
		public static PlayableTraversalMode GetTraversalMode<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTraversalMode();
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0006A338 File Offset: 0x00068538
		public static void SetTraversalMode<U>(U playable, PlayableTraversalMode mode) where U : struct
		{
			playable.GetHandle().SetTraversalMode(mode);
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0006A360 File Offset: 0x00068560
		public static DirectorWrapMode GetTimeWrapMode<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTimeWrapMode();
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0006A388 File Offset: 0x00068588
		public static void SetTimeWrapMode<U>(U playable, DirectorWrapMode value) where U : struct
		{
			playable.GetHandle().SetTimeWrapMode(value);
		}
	}
}
