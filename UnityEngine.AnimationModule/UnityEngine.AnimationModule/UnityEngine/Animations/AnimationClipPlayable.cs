using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000015 RID: 21
	[StructLayout(2)]
	public struct AnimationClipPlayable
	{
		// Token: 0x06000202 RID: 514 RVA: 0x000091C4 File Offset: 0x000073C4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationClipPlayable()
		{
			Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationClipPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr);
			AnimationClipPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, "m_Handle");
			AnimationClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663336);
			AnimationClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663337);
			AnimationClipPlayable.GetAnimationClipInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetAnimationClipInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetAnimationClipInternal");
			AnimationClipPlayable.GetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIKInternal");
			AnimationClipPlayable.SetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetApplyFootIKInternal");
			AnimationClipPlayable.GetApplyPlayableIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetApplyPlayableIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIKInternal");
			AnimationClipPlayable.SetApplyPlayableIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetApplyPlayableIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIKInternal");
			AnimationClipPlayable.GetRemoveStartOffsetInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetRemoveStartOffsetInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetRemoveStartOffsetInternal");
			AnimationClipPlayable.SetRemoveStartOffsetInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetRemoveStartOffsetInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetRemoveStartOffsetInternal");
			AnimationClipPlayable.GetOverrideLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetOverrideLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetOverrideLoopTimeInternal");
			AnimationClipPlayable.SetOverrideLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetOverrideLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetOverrideLoopTimeInternal");
			AnimationClipPlayable.GetLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetLoopTimeInternal");
			AnimationClipPlayable.SetLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetLoopTimeInternal");
			AnimationClipPlayable.GetSampleRateInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetSampleRateInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetSampleRateInternal");
			AnimationClipPlayable.SetSampleRateInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetSampleRateInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetSampleRateInternal");
			AnimationClipPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationClipPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00009304 File Offset: 0x00007504
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009334 File Offset: 0x00007534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89989, XrefRangeEnd = 89993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationClipPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000359D File Offset: 0x0000179D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00009374 File Offset: 0x00007574
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip)
		{
			PlayableHandle playableHandle = AnimationClipPlayable.CreateHandle(graph, clip);
			return new AnimationClipPlayable(playableHandle);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00009394 File Offset: 0x00007594
		public static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationClipPlayable.CreateHandleInternal(graph, clip, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000093C8 File Offset: 0x000075C8
		public static implicit operator Playable(AnimationClipPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000093E8 File Offset: 0x000075E8
		public static explicit operator AnimationClipPlayable(Playable playable)
		{
			return new AnimationClipPlayable(playable.GetHandle());
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00009408 File Offset: 0x00007608
		public AnimationClip GetAnimationClip()
		{
			return AnimationClipPlayable.GetAnimationClipInternal(ref this.m_Handle);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00009428 File Offset: 0x00007628
		public bool GetApplyFootIK()
		{
			return AnimationClipPlayable.GetApplyFootIKInternal(ref this.m_Handle);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000035AF File Offset: 0x000017AF
		public void SetApplyFootIK(bool value)
		{
			AnimationClipPlayable.SetApplyFootIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00009448 File Offset: 0x00007648
		public bool GetApplyPlayableIK()
		{
			return AnimationClipPlayable.GetApplyPlayableIKInternal(ref this.m_Handle);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000035BF File Offset: 0x000017BF
		public void SetApplyPlayableIK(bool value)
		{
			AnimationClipPlayable.SetApplyPlayableIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00009468 File Offset: 0x00007668
		public bool GetRemoveStartOffset()
		{
			return AnimationClipPlayable.GetRemoveStartOffsetInternal(ref this.m_Handle);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000035CF File Offset: 0x000017CF
		public void SetRemoveStartOffset(bool value)
		{
			AnimationClipPlayable.SetRemoveStartOffsetInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00009488 File Offset: 0x00007688
		public bool GetOverrideLoopTime()
		{
			return AnimationClipPlayable.GetOverrideLoopTimeInternal(ref this.m_Handle);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000035DF File Offset: 0x000017DF
		public void SetOverrideLoopTime(bool value)
		{
			AnimationClipPlayable.SetOverrideLoopTimeInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000094A8 File Offset: 0x000076A8
		public bool GetLoopTime()
		{
			return AnimationClipPlayable.GetLoopTimeInternal(ref this.m_Handle);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000035EF File Offset: 0x000017EF
		public void SetLoopTime(bool value)
		{
			AnimationClipPlayable.SetLoopTimeInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000094C8 File Offset: 0x000076C8
		public float GetSampleRate()
		{
			return AnimationClipPlayable.GetSampleRateInternal(ref this.m_Handle);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000035FF File Offset: 0x000017FF
		public void SetSampleRate(float value)
		{
			AnimationClipPlayable.SetSampleRateInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000360F File Offset: 0x0000180F
		public static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			return AnimationClipPlayable.CreateHandleInternal_Injected(ref graph, clip, ref handle);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000094E8 File Offset: 0x000076E8
		public static AnimationClip GetAnimationClipInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimationClipPlayable.GetAnimationClipInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000361A File Offset: 0x0000181A
		public static bool GetApplyFootIKInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetApplyFootIKInternalDelegateField(ref handle);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003627 File Offset: 0x00001827
		public static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetApplyFootIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003635 File Offset: 0x00001835
		public static bool GetApplyPlayableIKInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetApplyPlayableIKInternalDelegateField(ref handle);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00003642 File Offset: 0x00001842
		public static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetApplyPlayableIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003650 File Offset: 0x00001850
		public static bool GetRemoveStartOffsetInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetRemoveStartOffsetInternalDelegateField(ref handle);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000365D File Offset: 0x0000185D
		public static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetRemoveStartOffsetInternalDelegateField(ref handle, value);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000366B File Offset: 0x0000186B
		public static bool GetOverrideLoopTimeInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetOverrideLoopTimeInternalDelegateField(ref handle);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00003678 File Offset: 0x00001878
		public static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetOverrideLoopTimeInternalDelegateField(ref handle, value);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00003686 File Offset: 0x00001886
		public static bool GetLoopTimeInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetLoopTimeInternalDelegateField(ref handle);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003693 File Offset: 0x00001893
		public static void SetLoopTimeInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetLoopTimeInternalDelegateField(ref handle, value);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000036A1 File Offset: 0x000018A1
		public static float GetSampleRateInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetSampleRateInternalDelegateField(ref handle);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000036AE File Offset: 0x000018AE
		public static void SetSampleRateInternal(ref PlayableHandle handle, float value)
		{
			AnimationClipPlayable.SetSampleRateInternalDelegateField(ref handle, value);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000036BC File Offset: 0x000018BC
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			return AnimationClipPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(clip), ref handle);
		}

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0;

		// Token: 0x04000140 RID: 320
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000141 RID: 321
		private static readonly AnimationClipPlayable.GetAnimationClipInternalDelegate GetAnimationClipInternalDelegateField;

		// Token: 0x04000142 RID: 322
		private static readonly AnimationClipPlayable.GetApplyFootIKInternalDelegate GetApplyFootIKInternalDelegateField;

		// Token: 0x04000143 RID: 323
		private static readonly AnimationClipPlayable.SetApplyFootIKInternalDelegate SetApplyFootIKInternalDelegateField;

		// Token: 0x04000144 RID: 324
		private static readonly AnimationClipPlayable.GetApplyPlayableIKInternalDelegate GetApplyPlayableIKInternalDelegateField;

		// Token: 0x04000145 RID: 325
		private static readonly AnimationClipPlayable.SetApplyPlayableIKInternalDelegate SetApplyPlayableIKInternalDelegateField;

		// Token: 0x04000146 RID: 326
		private static readonly AnimationClipPlayable.GetRemoveStartOffsetInternalDelegate GetRemoveStartOffsetInternalDelegateField;

		// Token: 0x04000147 RID: 327
		private static readonly AnimationClipPlayable.SetRemoveStartOffsetInternalDelegate SetRemoveStartOffsetInternalDelegateField;

		// Token: 0x04000148 RID: 328
		private static readonly AnimationClipPlayable.GetOverrideLoopTimeInternalDelegate GetOverrideLoopTimeInternalDelegateField;

		// Token: 0x04000149 RID: 329
		private static readonly AnimationClipPlayable.SetOverrideLoopTimeInternalDelegate SetOverrideLoopTimeInternalDelegateField;

		// Token: 0x0400014A RID: 330
		private static readonly AnimationClipPlayable.GetLoopTimeInternalDelegate GetLoopTimeInternalDelegateField;

		// Token: 0x0400014B RID: 331
		private static readonly AnimationClipPlayable.SetLoopTimeInternalDelegate SetLoopTimeInternalDelegateField;

		// Token: 0x0400014C RID: 332
		private static readonly AnimationClipPlayable.GetSampleRateInternalDelegate GetSampleRateInternalDelegateField;

		// Token: 0x0400014D RID: 333
		private static readonly AnimationClipPlayable.SetSampleRateInternalDelegate SetSampleRateInternalDelegateField;

		// Token: 0x0400014E RID: 334
		private static readonly AnimationClipPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x060006F8 RID: 1784
		private delegate IntPtr GetAnimationClipInternalDelegate(IntPtr handle);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x060006FA RID: 1786
		private delegate bool GetApplyFootIKInternalDelegate(IntPtr handle);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x060006FC RID: 1788
		private delegate void SetApplyFootIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x060006FE RID: 1790
		private delegate bool GetApplyPlayableIKInternalDelegate(IntPtr handle);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000700 RID: 1792
		private delegate void SetApplyPlayableIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000702 RID: 1794
		private delegate bool GetRemoveStartOffsetInternalDelegate(IntPtr handle);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000704 RID: 1796
		private delegate void SetRemoveStartOffsetInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x06000706 RID: 1798
		private delegate bool GetOverrideLoopTimeInternalDelegate(IntPtr handle);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x06000708 RID: 1800
		private delegate void SetOverrideLoopTimeInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x0600070A RID: 1802
		private delegate bool GetLoopTimeInternalDelegate(IntPtr handle);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate void SetLoopTimeInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate float GetSampleRateInternalDelegate(IntPtr handle);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000710 RID: 1808
		private delegate void SetSampleRateInternalDelegate(IntPtr handle, float value);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000712 RID: 1810
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr clip, IntPtr handle);
	}
}
