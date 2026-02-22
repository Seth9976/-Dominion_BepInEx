using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct AudioPlayableOutput
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0000544C File Offset: 0x0000364C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPlayableOutput()
		{
			Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr);
			AudioPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, "m_Handle");
			AudioPlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalGetTargetDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetTarget");
			AudioPlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalSetTargetDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalSetTarget");
			AudioPlayableOutput.InternalGetEvaluateOnSeekDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalGetEvaluateOnSeekDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetEvaluateOnSeek");
			AudioPlayableOutput.InternalSetEvaluateOnSeekDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalSetEvaluateOnSeekDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalSetEvaluateOnSeek");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000029C4 File Offset: 0x00000BC4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000054CC File Offset: 0x000036CC
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !AudioPlayableGraphExtensions.InternalCreateAudioOutput(ref graph, name, out playableOutputHandle);
			AudioPlayableOutput audioPlayableOutput;
			if (flag)
			{
				audioPlayableOutput = AudioPlayableOutput.Null;
			}
			else
			{
				AudioPlayableOutput audioPlayableOutput2 = new AudioPlayableOutput(playableOutputHandle);
				audioPlayableOutput2.SetTarget(target);
				audioPlayableOutput = audioPlayableOutput2;
			}
			return audioPlayableOutput;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000550C File Offset: 0x0000370C
		public static AudioPlayableOutput Null
		{
			get
			{
				return new AudioPlayableOutput(PlayableOutputHandle.Null);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005528 File Offset: 0x00003728
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005540 File Offset: 0x00003740
		public static implicit operator PlayableOutput(AudioPlayableOutput output)
		{
			return new PlayableOutput(output.GetHandle());
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005560 File Offset: 0x00003760
		public static explicit operator AudioPlayableOutput(PlayableOutput output)
		{
			return new AudioPlayableOutput(output.GetHandle());
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005580 File Offset: 0x00003780
		public AudioSource GetTarget()
		{
			return AudioPlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000029D6 File Offset: 0x00000BD6
		public void SetTarget(AudioSource value)
		{
			AudioPlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000055A0 File Offset: 0x000037A0
		public bool GetEvaluateOnSeek()
		{
			return AudioPlayableOutput.InternalGetEvaluateOnSeek(ref this.m_Handle);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000029E6 File Offset: 0x00000BE6
		public void SetEvaluateOnSeek(bool value)
		{
			AudioPlayableOutput.InternalSetEvaluateOnSeek(ref this.m_Handle, value);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000055C0 File Offset: 0x000037C0
		public static AudioSource InternalGetTarget(ref PlayableOutputHandle output)
		{
			IntPtr intPtr = AudioPlayableOutput.InternalGetTargetDelegateField(ref output);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000029F6 File Offset: 0x00000BF6
		public static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target)
		{
			AudioPlayableOutput.InternalSetTargetDelegateField(ref output, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002A09 File Offset: 0x00000C09
		public static bool InternalGetEvaluateOnSeek(ref PlayableOutputHandle output)
		{
			return AudioPlayableOutput.InternalGetEvaluateOnSeekDelegateField(ref output);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002A16 File Offset: 0x00000C16
		public static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value)
		{
			AudioPlayableOutput.InternalSetEvaluateOnSeekDelegateField(ref output, value);
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000091 RID: 145
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;

		// Token: 0x04000092 RID: 146
		private static readonly AudioPlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly AudioPlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly AudioPlayableOutput.InternalGetEvaluateOnSeekDelegate InternalGetEvaluateOnSeekDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly AudioPlayableOutput.InternalSetEvaluateOnSeekDelegate InternalSetEvaluateOnSeekDelegateField;

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060002E5 RID: 741
		private delegate IntPtr InternalGetTargetDelegate(IntPtr output);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060002E7 RID: 743
		private delegate void InternalSetTargetDelegate(IntPtr output, IntPtr target);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060002E9 RID: 745
		private delegate bool InternalGetEvaluateOnSeekDelegate(IntPtr output);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x060002EB RID: 747
		private delegate void InternalSetEvaluateOnSeekDelegate(IntPtr output, bool value);
	}
}
