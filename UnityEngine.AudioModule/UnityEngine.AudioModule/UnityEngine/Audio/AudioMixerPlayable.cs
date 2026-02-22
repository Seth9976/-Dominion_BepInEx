using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000008 RID: 8
	[StructLayout(2)]
	public struct AudioMixerPlayable
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x000052C0 File Offset: 0x000034C0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixerPlayable()
		{
			Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr);
			AudioMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, "m_Handle");
			AudioMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663329);
			AudioMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663330);
			AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegate>("UnityEngine.Audio.AudioMixerPlayable::CreateAudioMixerPlayableInternal");
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000533C File Offset: 0x0000353C
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000536C File Offset: 0x0000356C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90223, XrefRangeEnd = 90227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AudioMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000029A3 File Offset: 0x00000BA3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000053AC File Offset: 0x000035AC
		public static AudioMixerPlayable Create(PlayableGraph graph, [Optional] int inputCount, [Optional] bool normalizeInputVolumes)
		{
			PlayableHandle playableHandle = AudioMixerPlayable.CreateHandle(graph, inputCount, normalizeInputVolumes);
			return new AudioMixerPlayable(playableHandle);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000053D0 File Offset: 0x000035D0
		public static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AudioMixerPlayable.CreateAudioMixerPlayableInternal(ref graph, normalizeInputVolumes, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				@null.SetInputCount(inputCount);
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000540C File Offset: 0x0000360C
		public static implicit operator Playable(AudioMixerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000542C File Offset: 0x0000362C
		public static explicit operator AudioMixerPlayable(Playable playable)
		{
			return new AudioMixerPlayable(playable.GetHandle());
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000029B5 File Offset: 0x00000BB5
		public static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle)
		{
			return AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegateField(ref graph, normalizeInputVolumes, ref handle);
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0;

		// Token: 0x0400008E RID: 142
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400008F RID: 143
		private static readonly AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegate CreateAudioMixerPlayableInternalDelegateField;

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060002E3 RID: 739
		private delegate bool CreateAudioMixerPlayableInternalDelegate(IntPtr graph, bool normalizeInputVolumes, IntPtr handle);
	}
}
