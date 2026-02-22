using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	public sealed class Animation : Behaviour
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000BECC File Offset: 0x0000A0CC
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000459D File Offset: 0x0000279D
		public AnimationClip clip
		{
			get
			{
				IntPtr intPtr = Animation.get_clipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				Animation.set_clipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000045B5 File Offset: 0x000027B5
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000045C7 File Offset: 0x000027C7
		public bool playAutomatically
		{
			get
			{
				return Animation.get_playAutomaticallyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_playAutomaticallyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000045DA File Offset: 0x000027DA
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000045EC File Offset: 0x000027EC
		public WrapMode wrapMode
		{
			get
			{
				return Animation.get_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000045FF File Offset: 0x000027FF
		public void Stop()
		{
			Animation.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00004611 File Offset: 0x00002811
		public void Stop(string name)
		{
			this.StopNamed(name);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000461C File Offset: 0x0000281C
		public void StopNamed(string name)
		{
			Animation.StopNamedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00004634 File Offset: 0x00002834
		public void Rewind()
		{
			Animation.RewindDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00004646 File Offset: 0x00002846
		public void Rewind(string name)
		{
			this.RewindNamed(name);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00004651 File Offset: 0x00002851
		public void RewindNamed(string name)
		{
			Animation.RewindNamedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00004669 File Offset: 0x00002869
		public void Sample()
		{
			Animation.SampleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000467B File Offset: 0x0000287B
		public bool isPlaying
		{
			get
			{
				return Animation.get_isPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000468D File Offset: 0x0000288D
		public bool IsPlaying(string name)
		{
			return Animation.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		public AnimationState Item
		{
			get
			{
				return this.GetState(name);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000BF14 File Offset: 0x0000A114
		public bool Play()
		{
			return this.Play(PlayMode.StopSameLayer);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000BF30 File Offset: 0x0000A130
		public bool Play(PlayMode mode)
		{
			return this.PlayDefaultAnimation(mode);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000046A5 File Offset: 0x000028A5
		public bool PlayDefaultAnimation(PlayMode mode)
		{
			return Animation.PlayDefaultAnimationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000BF4C File Offset: 0x0000A14C
		public bool Play(string animation)
		{
			return this.Play(animation, PlayMode.StopSameLayer);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000046B8 File Offset: 0x000028B8
		public bool Play(string animation, PlayMode mode)
		{
			return Animation.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), mode);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000046D1 File Offset: 0x000028D1
		public void CrossFade(string animation)
		{
			this.CrossFade(animation, 0.3f);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000046E1 File Offset: 0x000028E1
		public void CrossFade(string animation, float fadeLength)
		{
			this.CrossFade(animation, fadeLength, PlayMode.StopSameLayer);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000046EE File Offset: 0x000028EE
		public void CrossFade(string animation, float fadeLength, PlayMode mode)
		{
			Animation.CrossFadeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), fadeLength, mode);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004708 File Offset: 0x00002908
		public void Blend(string animation)
		{
			this.Blend(animation, 1f);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00004718 File Offset: 0x00002918
		public void Blend(string animation, float targetWeight)
		{
			this.Blend(animation, targetWeight, 0.3f);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00004729 File Offset: 0x00002929
		public void Blend(string animation, float targetWeight, float fadeLength)
		{
			Animation.BlendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), targetWeight, fadeLength);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000BF68 File Offset: 0x0000A168
		public AnimationState CrossFadeQueued(string animation)
		{
			return this.CrossFadeQueued(animation, 0.3f);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000BF88 File Offset: 0x0000A188
		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			return this.CrossFadeQueued(animation, fadeLength, QueueMode.CompleteOthers);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			return this.CrossFadeQueued(animation, fadeLength, queue, PlayMode.StopSameLayer);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode)
		{
			IntPtr intPtr = Animation.CrossFadeQueuedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), fadeLength, queue, mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		public AnimationState PlayQueued(string animation)
		{
			return this.PlayQueued(animation, QueueMode.CompleteOthers);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000C014 File Offset: 0x0000A214
		public AnimationState PlayQueued(string animation, QueueMode queue)
		{
			return this.PlayQueued(animation, queue, PlayMode.StopSameLayer);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000C030 File Offset: 0x0000A230
		public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode)
		{
			IntPtr intPtr = Animation.PlayQueuedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), queue, mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00004743 File Offset: 0x00002943
		public void AddClip(AnimationClip clip, string newName)
		{
			this.AddClip(clip, newName, int.MinValue, int.MaxValue);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00004759 File Offset: 0x00002959
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
			this.AddClip(clip, newName, firstFrame, lastFrame, false);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00004769 File Offset: 0x00002969
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame)
		{
			Animation.AddClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(clip), IL2CPP.ManagedStringToIl2Cpp(newName), firstFrame, lastFrame, addLoopFrame);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000478C File Offset: 0x0000298C
		public void RemoveClip(AnimationClip clip)
		{
			Animation.RemoveClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000047A4 File Offset: 0x000029A4
		public void RemoveClip(string clipName)
		{
			this.RemoveClipNamed(clipName);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000047AF File Offset: 0x000029AF
		public void RemoveClipNamed(string clipName)
		{
			Animation.RemoveClipNamedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(clipName));
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000047C7 File Offset: 0x000029C7
		public int GetClipCount()
		{
			return Animation.GetClipCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000C064 File Offset: 0x0000A264
		public bool Play(AnimationPlayMode mode)
		{
			return this.PlayDefaultAnimation((PlayMode)mode);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000C080 File Offset: 0x0000A280
		public bool Play(string animation, AnimationPlayMode mode)
		{
			return this.Play(animation, (PlayMode)mode);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000047D9 File Offset: 0x000029D9
		public void SyncLayer(int layer)
		{
			Animation.SyncLayerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layer);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000C09C File Offset: 0x0000A29C
		public IEnumerator GetEnumerator()
		{
			return new Animation.Enumerator(this);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		public AnimationState GetState(string name)
		{
			IntPtr intPtr = Animation.GetStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		public AnimationState GetStateAtIndex(int index)
		{
			IntPtr intPtr = Animation.GetStateAtIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000047EC File Offset: 0x000029EC
		public int GetStateCount()
		{
			return Animation.GetStateCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000C118 File Offset: 0x0000A318
		public AnimationClip GetClip(string name)
		{
			AnimationState state = this.GetState(name);
			bool flag = state;
			AnimationClip animationClip;
			if (flag)
			{
				animationClip = state.clip;
			}
			else
			{
				animationClip = null;
			}
			return animationClip;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000047FE File Offset: 0x000029FE
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00004810 File Offset: 0x00002A10
		public bool animatePhysics
		{
			get
			{
				return Animation.get_animatePhysicsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_animatePhysicsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00004823 File Offset: 0x00002A23
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00004835 File Offset: 0x00002A35
		public bool animateOnlyIfVisible
		{
			get
			{
				return Animation.get_animateOnlyIfVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_animateOnlyIfVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00004848 File Offset: 0x00002A48
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000485A File Offset: 0x00002A5A
		public AnimationCullingType cullingType
		{
			get
			{
				return Animation.get_cullingTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_cullingTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0000C148 File Offset: 0x0000A348
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x0000486D File Offset: 0x00002A6D
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.get_localBounds_Injected(out bounds);
				return bounds;
			}
			set
			{
				this.set_localBounds_Injected(ref value);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00004877 File Offset: 0x00002A77
		public void get_localBounds_Injected(out Bounds ret)
		{
			Animation.get_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000488A File Offset: 0x00002A8A
		public void set_localBounds_Injected(ref Bounds value)
		{
			Animation.set_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400021D RID: 541
		private static readonly Animation.get_clipDelegate get_clipDelegateField = IL2CPP.ResolveICall<Animation.get_clipDelegate>("UnityEngine.Animation::get_clip");

		// Token: 0x0400021E RID: 542
		private static readonly Animation.set_clipDelegate set_clipDelegateField = IL2CPP.ResolveICall<Animation.set_clipDelegate>("UnityEngine.Animation::set_clip");

		// Token: 0x0400021F RID: 543
		private static readonly Animation.get_playAutomaticallyDelegate get_playAutomaticallyDelegateField = IL2CPP.ResolveICall<Animation.get_playAutomaticallyDelegate>("UnityEngine.Animation::get_playAutomatically");

		// Token: 0x04000220 RID: 544
		private static readonly Animation.set_playAutomaticallyDelegate set_playAutomaticallyDelegateField = IL2CPP.ResolveICall<Animation.set_playAutomaticallyDelegate>("UnityEngine.Animation::set_playAutomatically");

		// Token: 0x04000221 RID: 545
		private static readonly Animation.get_wrapModeDelegate get_wrapModeDelegateField = IL2CPP.ResolveICall<Animation.get_wrapModeDelegate>("UnityEngine.Animation::get_wrapMode");

		// Token: 0x04000222 RID: 546
		private static readonly Animation.set_wrapModeDelegate set_wrapModeDelegateField = IL2CPP.ResolveICall<Animation.set_wrapModeDelegate>("UnityEngine.Animation::set_wrapMode");

		// Token: 0x04000223 RID: 547
		private static readonly Animation.StopDelegate StopDelegateField = IL2CPP.ResolveICall<Animation.StopDelegate>("UnityEngine.Animation::Stop");

		// Token: 0x04000224 RID: 548
		private static readonly Animation.StopNamedDelegate StopNamedDelegateField = IL2CPP.ResolveICall<Animation.StopNamedDelegate>("UnityEngine.Animation::StopNamed");

		// Token: 0x04000225 RID: 549
		private static readonly Animation.RewindDelegate RewindDelegateField = IL2CPP.ResolveICall<Animation.RewindDelegate>("UnityEngine.Animation::Rewind");

		// Token: 0x04000226 RID: 550
		private static readonly Animation.RewindNamedDelegate RewindNamedDelegateField = IL2CPP.ResolveICall<Animation.RewindNamedDelegate>("UnityEngine.Animation::RewindNamed");

		// Token: 0x04000227 RID: 551
		private static readonly Animation.SampleDelegate SampleDelegateField = IL2CPP.ResolveICall<Animation.SampleDelegate>("UnityEngine.Animation::Sample");

		// Token: 0x04000228 RID: 552
		private static readonly Animation.get_isPlayingDelegate get_isPlayingDelegateField = IL2CPP.ResolveICall<Animation.get_isPlayingDelegate>("UnityEngine.Animation::get_isPlaying");

		// Token: 0x04000229 RID: 553
		private static readonly Animation.IsPlayingDelegate IsPlayingDelegateField = IL2CPP.ResolveICall<Animation.IsPlayingDelegate>("UnityEngine.Animation::IsPlaying");

		// Token: 0x0400022A RID: 554
		private static readonly Animation.PlayDefaultAnimationDelegate PlayDefaultAnimationDelegateField = IL2CPP.ResolveICall<Animation.PlayDefaultAnimationDelegate>("UnityEngine.Animation::PlayDefaultAnimation");

		// Token: 0x0400022B RID: 555
		private static readonly Animation.PlayDelegate PlayDelegateField = IL2CPP.ResolveICall<Animation.PlayDelegate>("UnityEngine.Animation::Play");

		// Token: 0x0400022C RID: 556
		private static readonly Animation.CrossFadeDelegate CrossFadeDelegateField = IL2CPP.ResolveICall<Animation.CrossFadeDelegate>("UnityEngine.Animation::CrossFade");

		// Token: 0x0400022D RID: 557
		private static readonly Animation.BlendDelegate BlendDelegateField = IL2CPP.ResolveICall<Animation.BlendDelegate>("UnityEngine.Animation::Blend");

		// Token: 0x0400022E RID: 558
		private static readonly Animation.CrossFadeQueuedDelegate CrossFadeQueuedDelegateField = IL2CPP.ResolveICall<Animation.CrossFadeQueuedDelegate>("UnityEngine.Animation::CrossFadeQueued");

		// Token: 0x0400022F RID: 559
		private static readonly Animation.PlayQueuedDelegate PlayQueuedDelegateField = IL2CPP.ResolveICall<Animation.PlayQueuedDelegate>("UnityEngine.Animation::PlayQueued");

		// Token: 0x04000230 RID: 560
		private static readonly Animation.AddClipDelegate AddClipDelegateField = IL2CPP.ResolveICall<Animation.AddClipDelegate>("UnityEngine.Animation::AddClip");

		// Token: 0x04000231 RID: 561
		private static readonly Animation.RemoveClipDelegate RemoveClipDelegateField = IL2CPP.ResolveICall<Animation.RemoveClipDelegate>("UnityEngine.Animation::RemoveClip");

		// Token: 0x04000232 RID: 562
		private static readonly Animation.RemoveClipNamedDelegate RemoveClipNamedDelegateField = IL2CPP.ResolveICall<Animation.RemoveClipNamedDelegate>("UnityEngine.Animation::RemoveClipNamed");

		// Token: 0x04000233 RID: 563
		private static readonly Animation.GetClipCountDelegate GetClipCountDelegateField = IL2CPP.ResolveICall<Animation.GetClipCountDelegate>("UnityEngine.Animation::GetClipCount");

		// Token: 0x04000234 RID: 564
		private static readonly Animation.SyncLayerDelegate SyncLayerDelegateField = IL2CPP.ResolveICall<Animation.SyncLayerDelegate>("UnityEngine.Animation::SyncLayer");

		// Token: 0x04000235 RID: 565
		private static readonly Animation.GetStateDelegate GetStateDelegateField = IL2CPP.ResolveICall<Animation.GetStateDelegate>("UnityEngine.Animation::GetState");

		// Token: 0x04000236 RID: 566
		private static readonly Animation.GetStateAtIndexDelegate GetStateAtIndexDelegateField = IL2CPP.ResolveICall<Animation.GetStateAtIndexDelegate>("UnityEngine.Animation::GetStateAtIndex");

		// Token: 0x04000237 RID: 567
		private static readonly Animation.GetStateCountDelegate GetStateCountDelegateField = IL2CPP.ResolveICall<Animation.GetStateCountDelegate>("UnityEngine.Animation::GetStateCount");

		// Token: 0x04000238 RID: 568
		private static readonly Animation.get_animatePhysicsDelegate get_animatePhysicsDelegateField = IL2CPP.ResolveICall<Animation.get_animatePhysicsDelegate>("UnityEngine.Animation::get_animatePhysics");

		// Token: 0x04000239 RID: 569
		private static readonly Animation.set_animatePhysicsDelegate set_animatePhysicsDelegateField = IL2CPP.ResolveICall<Animation.set_animatePhysicsDelegate>("UnityEngine.Animation::set_animatePhysics");

		// Token: 0x0400023A RID: 570
		private static readonly Animation.get_animateOnlyIfVisibleDelegate get_animateOnlyIfVisibleDelegateField = IL2CPP.ResolveICall<Animation.get_animateOnlyIfVisibleDelegate>("UnityEngine.Animation::get_animateOnlyIfVisible");

		// Token: 0x0400023B RID: 571
		private static readonly Animation.set_animateOnlyIfVisibleDelegate set_animateOnlyIfVisibleDelegateField = IL2CPP.ResolveICall<Animation.set_animateOnlyIfVisibleDelegate>("UnityEngine.Animation::set_animateOnlyIfVisible");

		// Token: 0x0400023C RID: 572
		private static readonly Animation.get_cullingTypeDelegate get_cullingTypeDelegateField = IL2CPP.ResolveICall<Animation.get_cullingTypeDelegate>("UnityEngine.Animation::get_cullingType");

		// Token: 0x0400023D RID: 573
		private static readonly Animation.set_cullingTypeDelegate set_cullingTypeDelegateField = IL2CPP.ResolveICall<Animation.set_cullingTypeDelegate>("UnityEngine.Animation::set_cullingType");

		// Token: 0x0400023E RID: 574
		private static readonly Animation.get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Animation.get_localBounds_InjectedDelegate>("UnityEngine.Animation::get_localBounds_Injected");

		// Token: 0x0400023F RID: 575
		private static readonly Animation.set_localBounds_InjectedDelegate set_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Animation.set_localBounds_InjectedDelegate>("UnityEngine.Animation::set_localBounds_Injected");

		// Token: 0x020001AF RID: 431
		public sealed class Enumerator
		{
		}

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x06000804 RID: 2052
		private delegate IntPtr get_clipDelegate(IntPtr @this);

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x06000806 RID: 2054
		private delegate void set_clipDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001B2 RID: 434
		// (Invoke) Token: 0x06000808 RID: 2056
		private delegate bool get_playAutomaticallyDelegate(IntPtr @this);

		// Token: 0x020001B3 RID: 435
		// (Invoke) Token: 0x0600080A RID: 2058
		private delegate void set_playAutomaticallyDelegate(IntPtr @this, bool value);

		// Token: 0x020001B4 RID: 436
		// (Invoke) Token: 0x0600080C RID: 2060
		private delegate WrapMode get_wrapModeDelegate(IntPtr @this);

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x0600080E RID: 2062
		private delegate void set_wrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06000810 RID: 2064
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06000812 RID: 2066
		private delegate void StopNamedDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x06000814 RID: 2068
		private delegate void RewindDelegate(IntPtr @this);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x06000816 RID: 2070
		private delegate void RewindNamedDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x06000818 RID: 2072
		private delegate void SampleDelegate(IntPtr @this);

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x0600081A RID: 2074
		private delegate bool get_isPlayingDelegate(IntPtr @this);

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x0600081C RID: 2076
		private delegate bool IsPlayingDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020001BD RID: 445
		// (Invoke) Token: 0x0600081E RID: 2078
		private delegate bool PlayDefaultAnimationDelegate(IntPtr @this, PlayMode mode);

		// Token: 0x020001BE RID: 446
		// (Invoke) Token: 0x06000820 RID: 2080
		private delegate bool PlayDelegate(IntPtr @this, IntPtr animation, PlayMode mode);

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x06000822 RID: 2082
		private delegate void CrossFadeDelegate(IntPtr @this, IntPtr animation, float fadeLength, PlayMode mode);

		// Token: 0x020001C0 RID: 448
		// (Invoke) Token: 0x06000824 RID: 2084
		private delegate void BlendDelegate(IntPtr @this, IntPtr animation, float targetWeight, float fadeLength);

		// Token: 0x020001C1 RID: 449
		// (Invoke) Token: 0x06000826 RID: 2086
		private delegate IntPtr CrossFadeQueuedDelegate(IntPtr @this, IntPtr animation, float fadeLength, QueueMode queue, PlayMode mode);

		// Token: 0x020001C2 RID: 450
		// (Invoke) Token: 0x06000828 RID: 2088
		private delegate IntPtr PlayQueuedDelegate(IntPtr @this, IntPtr animation, QueueMode queue, PlayMode mode);

		// Token: 0x020001C3 RID: 451
		// (Invoke) Token: 0x0600082A RID: 2090
		private delegate void AddClipDelegate(IntPtr @this, IntPtr clip, IntPtr newName, int firstFrame, int lastFrame, bool addLoopFrame);

		// Token: 0x020001C4 RID: 452
		// (Invoke) Token: 0x0600082C RID: 2092
		private delegate void RemoveClipDelegate(IntPtr @this, IntPtr clip);

		// Token: 0x020001C5 RID: 453
		// (Invoke) Token: 0x0600082E RID: 2094
		private delegate void RemoveClipNamedDelegate(IntPtr @this, IntPtr clipName);

		// Token: 0x020001C6 RID: 454
		// (Invoke) Token: 0x06000830 RID: 2096
		private delegate int GetClipCountDelegate(IntPtr @this);

		// Token: 0x020001C7 RID: 455
		// (Invoke) Token: 0x06000832 RID: 2098
		private delegate void SyncLayerDelegate(IntPtr @this, int layer);

		// Token: 0x020001C8 RID: 456
		// (Invoke) Token: 0x06000834 RID: 2100
		private delegate IntPtr GetStateDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020001C9 RID: 457
		// (Invoke) Token: 0x06000836 RID: 2102
		private delegate IntPtr GetStateAtIndexDelegate(IntPtr @this, int index);

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x06000838 RID: 2104
		private delegate int GetStateCountDelegate(IntPtr @this);

		// Token: 0x020001CB RID: 459
		// (Invoke) Token: 0x0600083A RID: 2106
		private delegate bool get_animatePhysicsDelegate(IntPtr @this);

		// Token: 0x020001CC RID: 460
		// (Invoke) Token: 0x0600083C RID: 2108
		private delegate void set_animatePhysicsDelegate(IntPtr @this, bool value);

		// Token: 0x020001CD RID: 461
		// (Invoke) Token: 0x0600083E RID: 2110
		private delegate bool get_animateOnlyIfVisibleDelegate(IntPtr @this);

		// Token: 0x020001CE RID: 462
		// (Invoke) Token: 0x06000840 RID: 2112
		private delegate void set_animateOnlyIfVisibleDelegate(IntPtr @this, bool value);

		// Token: 0x020001CF RID: 463
		// (Invoke) Token: 0x06000842 RID: 2114
		private delegate AnimationCullingType get_cullingTypeDelegate(IntPtr @this);

		// Token: 0x020001D0 RID: 464
		// (Invoke) Token: 0x06000844 RID: 2116
		private delegate void set_cullingTypeDelegate(IntPtr @this, AnimationCullingType value);

		// Token: 0x020001D1 RID: 465
		// (Invoke) Token: 0x06000846 RID: 2118
		private delegate void get_localBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001D2 RID: 466
		// (Invoke) Token: 0x06000848 RID: 2120
		private delegate void set_localBounds_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
