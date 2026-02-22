using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001B RID: 27
	[StructLayout(2)]
	public struct AnimationPlayableOutput
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x0000A620 File Offset: 0x00008820
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlayableOutput()
		{
			Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr);
			AnimationPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, "m_Handle");
			AnimationPlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutput.InternalGetTargetDelegate>("UnityEngine.Animations.AnimationPlayableOutput::InternalGetTarget");
			AnimationPlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutput.InternalSetTargetDelegate>("UnityEngine.Animations.AnimationPlayableOutput::InternalSetTarget");
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003CE7 File Offset: 0x00001EE7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000A684 File Offset: 0x00008884
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !AnimationPlayableGraphExtensions.InternalCreateAnimationOutput(ref graph, name, out playableOutputHandle);
			AnimationPlayableOutput animationPlayableOutput;
			if (flag)
			{
				animationPlayableOutput = AnimationPlayableOutput.Null;
			}
			else
			{
				AnimationPlayableOutput animationPlayableOutput2 = new AnimationPlayableOutput(playableOutputHandle);
				animationPlayableOutput2.SetTarget(target);
				animationPlayableOutput = animationPlayableOutput2;
			}
			return animationPlayableOutput;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000A6C4 File Offset: 0x000088C4
		public static AnimationPlayableOutput Null
		{
			get
			{
				return new AnimationPlayableOutput(PlayableOutputHandle.Null);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000A6E0 File Offset: 0x000088E0
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000A6F8 File Offset: 0x000088F8
		public static implicit operator PlayableOutput(AnimationPlayableOutput output)
		{
			return new PlayableOutput(output.GetHandle());
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000A718 File Offset: 0x00008918
		public static explicit operator AnimationPlayableOutput(PlayableOutput output)
		{
			return new AnimationPlayableOutput(output.GetHandle());
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000A738 File Offset: 0x00008938
		public Animator GetTarget()
		{
			return AnimationPlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00003CF9 File Offset: 0x00001EF9
		public void SetTarget(Animator value)
		{
			AnimationPlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000A758 File Offset: 0x00008958
		public static Animator InternalGetTarget(ref PlayableOutputHandle handle)
		{
			IntPtr intPtr = AnimationPlayableOutput.InternalGetTargetDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003D09 File Offset: 0x00001F09
		public static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target)
		{
			AnimationPlayableOutput.InternalSetTargetDelegateField(ref handle, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400019C RID: 412
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;

		// Token: 0x0400019D RID: 413
		private static readonly AnimationPlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x0400019E RID: 414
		private static readonly AnimationPlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x06000778 RID: 1912
		private delegate IntPtr InternalGetTargetDelegate(IntPtr handle);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x0600077A RID: 1914
		private delegate void InternalSetTargetDelegate(IntPtr handle, IntPtr target);
	}
}
