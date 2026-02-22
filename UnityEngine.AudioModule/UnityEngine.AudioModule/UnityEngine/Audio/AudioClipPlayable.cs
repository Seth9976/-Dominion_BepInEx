using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000007 RID: 7
	[StructLayout(2)]
	public struct AudioClipPlayable
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00004CF4 File Offset: 0x00002EF4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClipPlayable()
		{
			Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioClipPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr);
			AudioClipPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, "m_Handle");
			AudioClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663327);
			AudioClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663328);
			AudioClipPlayable.GetClipInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetClipInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetClipInternal");
			AudioClipPlayable.SetClipInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetClipInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetClipInternal");
			AudioClipPlayable.GetLoopedInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetLoopedInternal");
			AudioClipPlayable.SetLoopedInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetLoopedInternal");
			AudioClipPlayable.GetVolumeInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetVolumeInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetVolumeInternal");
			AudioClipPlayable.SetVolumeInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetVolumeInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetVolumeInternal");
			AudioClipPlayable.GetStereoPanInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetStereoPanInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStereoPanInternal");
			AudioClipPlayable.SetStereoPanInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetStereoPanInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetStereoPanInternal");
			AudioClipPlayable.GetSpatialBlendInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetSpatialBlendInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetSpatialBlendInternal");
			AudioClipPlayable.SetSpatialBlendInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetSpatialBlendInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetSpatialBlendInternal");
			AudioClipPlayable.GetIsChannelPlayingInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetIsChannelPlayingInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetIsChannelPlayingInternal");
			AudioClipPlayable.GetStartDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetStartDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStartDelayInternal");
			AudioClipPlayable.SetStartDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetStartDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetStartDelayInternal");
			AudioClipPlayable.GetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetPauseDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetPauseDelayInternal");
			AudioClipPlayable.SetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetPauseDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetPauseDelayInternal");
			AudioClipPlayable.InternalCreateAudioClipPlayableDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.InternalCreateAudioClipPlayableDelegate>("UnityEngine.Audio.AudioClipPlayable::InternalCreateAudioClipPlayable");
			AudioClipPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.ValidateTypeDelegate>("UnityEngine.Audio.AudioClipPlayable::ValidateType");
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004E60 File Offset: 0x00003060
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004E90 File Offset: 0x00003090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90219, XrefRangeEnd = 90223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AudioClipPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002868 File Offset: 0x00000A68
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004ED0 File Offset: 0x000030D0
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping)
		{
			PlayableHandle playableHandle = AudioClipPlayable.CreateHandle(graph, clip, looping);
			AudioClipPlayable audioClipPlayable = new AudioClipPlayable(playableHandle);
			bool flag = clip != null;
			if (flag)
			{
				PlayableExtensions.SetDuration<AudioClipPlayable>(audioClipPlayable, (double)clip.length);
			}
			return audioClipPlayable;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004F10 File Offset: 0x00003110
		public static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AudioClipPlayable.InternalCreateAudioClipPlayable(ref graph, clip, looping, ref @null);
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

		// Token: 0x060000B1 RID: 177 RVA: 0x00004F44 File Offset: 0x00003144
		public static implicit operator Playable(AudioClipPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004F64 File Offset: 0x00003164
		public static explicit operator AudioClipPlayable(Playable playable)
		{
			return new AudioClipPlayable(playable.GetHandle());
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004F84 File Offset: 0x00003184
		public AudioClip GetClip()
		{
			return AudioClipPlayable.GetClipInternal(ref this.m_Handle);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000287A File Offset: 0x00000A7A
		public void SetClip(AudioClip value)
		{
			AudioClipPlayable.SetClipInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004FA4 File Offset: 0x000031A4
		public bool GetLooped()
		{
			return AudioClipPlayable.GetLoopedInternal(ref this.m_Handle);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000288A File Offset: 0x00000A8A
		public void SetLooped(bool value)
		{
			AudioClipPlayable.SetLoopedInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004FC4 File Offset: 0x000031C4
		public float GetVolume()
		{
			return AudioClipPlayable.GetVolumeInternal(ref this.m_Handle);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004FE4 File Offset: 0x000031E4
		public void SetVolume(float value)
		{
			bool flag = value < 0f || value > 1f;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Trying to set AudioClipPlayable volume outside of range (0.0 - 1.0): ", value.ToString()));
			}
			AudioClipPlayable.SetVolumeInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005030 File Offset: 0x00003230
		public float GetStereoPan()
		{
			return AudioClipPlayable.GetStereoPanInternal(ref this.m_Handle);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005050 File Offset: 0x00003250
		public void SetStereoPan(float value)
		{
			bool flag = value < -1f || value > 1f;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Trying to set AudioClipPlayable stereo pan outside of range (-1.0 - 1.0): ", value.ToString()));
			}
			AudioClipPlayable.SetStereoPanInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000509C File Offset: 0x0000329C
		public float GetSpatialBlend()
		{
			return AudioClipPlayable.GetSpatialBlendInternal(ref this.m_Handle);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000050BC File Offset: 0x000032BC
		public void SetSpatialBlend(float value)
		{
			bool flag = value < 0f || value > 1f;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Trying to set AudioClipPlayable spatial blend outside of range (0.0 - 1.0): ", value.ToString()));
			}
			AudioClipPlayable.SetSpatialBlendInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005108 File Offset: 0x00003308
		public bool IsPlaying()
		{
			return this.IsChannelPlaying();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005120 File Offset: 0x00003320
		public bool IsChannelPlaying()
		{
			return AudioClipPlayable.GetIsChannelPlayingInternal(ref this.m_Handle);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005140 File Offset: 0x00003340
		public double GetStartDelay()
		{
			return AudioClipPlayable.GetStartDelayInternal(ref this.m_Handle);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000289A File Offset: 0x00000A9A
		public void SetStartDelay(double value)
		{
			AudioClipPlayable.SetStartDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005160 File Offset: 0x00003360
		public double GetPauseDelay()
		{
			return AudioClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005180 File Offset: 0x00003380
		public void GetPauseDelay(double value)
		{
			double pauseDelayInternal = AudioClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
			bool flag = this.m_Handle.GetPlayState() == PlayState.Playing && (value < 0.05 || (pauseDelayInternal != 0.0 && pauseDelayInternal < 0.05));
			if (flag)
			{
				throw new ArgumentException(String.Concat("AudioClipPlayable.pauseDelay: Setting new delay when existing delay is too small or 0.0 (", pauseDelayInternal.ToString(), "), audio system will not be able to change in time"));
			}
			AudioClipPlayable.SetPauseDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000028AA File Offset: 0x00000AAA
		public void Seek(double startTime, double startDelay)
		{
			this.Seek(startTime, startDelay, 0.0);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005204 File Offset: 0x00003404
		public void Seek(double startTime, double startDelay, double duration)
		{
			AudioClipPlayable.SetStartDelayInternal(ref this.m_Handle, startDelay);
			bool flag = duration > 0.0;
			if (flag)
			{
				this.m_Handle.SetDuration(duration + startTime);
				AudioClipPlayable.SetPauseDelayInternal(ref this.m_Handle, startDelay + duration);
			}
			else
			{
				this.m_Handle.SetDuration(double.MaxValue);
				AudioClipPlayable.SetPauseDelayInternal(ref this.m_Handle, 0.0);
			}
			this.m_Handle.SetTime(startTime);
			this.m_Handle.Play();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005298 File Offset: 0x00003498
		public static AudioClip GetClipInternal(ref PlayableHandle hdl)
		{
			IntPtr intPtr = AudioClipPlayable.GetClipInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000028BF File Offset: 0x00000ABF
		public static void SetClipInternal(ref PlayableHandle hdl, AudioClip clip)
		{
			AudioClipPlayable.SetClipInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000028D2 File Offset: 0x00000AD2
		public static bool GetLoopedInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetLoopedInternalDelegateField(ref hdl);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000028DF File Offset: 0x00000ADF
		public static void SetLoopedInternal(ref PlayableHandle hdl, bool looped)
		{
			AudioClipPlayable.SetLoopedInternalDelegateField(ref hdl, looped);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000028ED File Offset: 0x00000AED
		public static float GetVolumeInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetVolumeInternalDelegateField(ref hdl);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000028FA File Offset: 0x00000AFA
		public static void SetVolumeInternal(ref PlayableHandle hdl, float volume)
		{
			AudioClipPlayable.SetVolumeInternalDelegateField(ref hdl, volume);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002908 File Offset: 0x00000B08
		public static float GetStereoPanInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetStereoPanInternalDelegateField(ref hdl);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002915 File Offset: 0x00000B15
		public static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan)
		{
			AudioClipPlayable.SetStereoPanInternalDelegateField(ref hdl, stereoPan);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002923 File Offset: 0x00000B23
		public static float GetSpatialBlendInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetSpatialBlendInternalDelegateField(ref hdl);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002930 File Offset: 0x00000B30
		public static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend)
		{
			AudioClipPlayable.SetSpatialBlendInternalDelegateField(ref hdl, spatialBlend);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000293E File Offset: 0x00000B3E
		public static bool GetIsChannelPlayingInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetIsChannelPlayingInternalDelegateField(ref hdl);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000294B File Offset: 0x00000B4B
		public static double GetStartDelayInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetStartDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002958 File Offset: 0x00000B58
		public static void SetStartDelayInternal(ref PlayableHandle hdl, double delay)
		{
			AudioClipPlayable.SetStartDelayInternalDelegateField(ref hdl, delay);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002966 File Offset: 0x00000B66
		public static double GetPauseDelayInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetPauseDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002973 File Offset: 0x00000B73
		public static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay)
		{
			AudioClipPlayable.SetPauseDelayInternalDelegateField(ref hdl, delay);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002981 File Offset: 0x00000B81
		public static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle)
		{
			return AudioClipPlayable.InternalCreateAudioClipPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(clip), looping, ref handle);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002996 File Offset: 0x00000B96
		public static bool ValidateType(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0;

		// Token: 0x04000079 RID: 121
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400007A RID: 122
		private static readonly AudioClipPlayable.GetClipInternalDelegate GetClipInternalDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly AudioClipPlayable.SetClipInternalDelegate SetClipInternalDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly AudioClipPlayable.GetLoopedInternalDelegate GetLoopedInternalDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly AudioClipPlayable.SetLoopedInternalDelegate SetLoopedInternalDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly AudioClipPlayable.GetVolumeInternalDelegate GetVolumeInternalDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly AudioClipPlayable.SetVolumeInternalDelegate SetVolumeInternalDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly AudioClipPlayable.GetStereoPanInternalDelegate GetStereoPanInternalDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly AudioClipPlayable.SetStereoPanInternalDelegate SetStereoPanInternalDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly AudioClipPlayable.GetSpatialBlendInternalDelegate GetSpatialBlendInternalDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly AudioClipPlayable.SetSpatialBlendInternalDelegate SetSpatialBlendInternalDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly AudioClipPlayable.GetIsChannelPlayingInternalDelegate GetIsChannelPlayingInternalDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly AudioClipPlayable.GetStartDelayInternalDelegate GetStartDelayInternalDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly AudioClipPlayable.SetStartDelayInternalDelegate SetStartDelayInternalDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly AudioClipPlayable.GetPauseDelayInternalDelegate GetPauseDelayInternalDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly AudioClipPlayable.SetPauseDelayInternalDelegate SetPauseDelayInternalDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly AudioClipPlayable.InternalCreateAudioClipPlayableDelegate InternalCreateAudioClipPlayableDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly AudioClipPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060002C1 RID: 705
		private delegate IntPtr GetClipInternalDelegate(IntPtr hdl);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060002C3 RID: 707
		private delegate void SetClipInternalDelegate(IntPtr hdl, IntPtr clip);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060002C5 RID: 709
		private delegate bool GetLoopedInternalDelegate(IntPtr hdl);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060002C7 RID: 711
		private delegate void SetLoopedInternalDelegate(IntPtr hdl, bool looped);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060002C9 RID: 713
		private delegate float GetVolumeInternalDelegate(IntPtr hdl);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060002CB RID: 715
		private delegate void SetVolumeInternalDelegate(IntPtr hdl, float volume);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060002CD RID: 717
		private delegate float GetStereoPanInternalDelegate(IntPtr hdl);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060002CF RID: 719
		private delegate void SetStereoPanInternalDelegate(IntPtr hdl, float stereoPan);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060002D1 RID: 721
		private delegate float GetSpatialBlendInternalDelegate(IntPtr hdl);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060002D3 RID: 723
		private delegate void SetSpatialBlendInternalDelegate(IntPtr hdl, float spatialBlend);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060002D5 RID: 725
		private delegate bool GetIsChannelPlayingInternalDelegate(IntPtr hdl);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060002D7 RID: 727
		private delegate double GetStartDelayInternalDelegate(IntPtr hdl);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060002D9 RID: 729
		private delegate void SetStartDelayInternalDelegate(IntPtr hdl, double delay);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060002DB RID: 731
		private delegate double GetPauseDelayInternalDelegate(IntPtr hdl);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060002DD RID: 733
		private delegate void SetPauseDelayInternalDelegate(IntPtr hdl, double delay);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060002DF RID: 735
		private delegate bool InternalCreateAudioClipPlayableDelegate(IntPtr graph, IntPtr clip, bool looping, IntPtr handle);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060002E1 RID: 737
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
