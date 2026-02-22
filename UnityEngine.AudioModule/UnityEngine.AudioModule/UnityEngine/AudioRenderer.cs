using System;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Audio;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public class AudioRenderer
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x0000639C File Offset: 0x0000459C
		public static bool Start()
		{
			return AudioRenderer.Internal_AudioRenderer_Start();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000063B4 File Offset: 0x000045B4
		public static bool Stop()
		{
			return AudioRenderer.Internal_AudioRenderer_Stop();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000063CC File Offset: 0x000045CC
		public static int GetSampleCountForCaptureFrame()
		{
			return AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrame();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000063E4 File Offset: 0x000045E4
		public static bool AddMixerGroupSink(AudioMixerGroup mixerGroup, NativeArray<float> buffer, bool excludeFromMix)
		{
			return AudioRenderer.Internal_AudioRenderer_AddMixerGroupSink(mixerGroup, NativeArrayUnsafeUtility.GetUnsafePtr<float>(buffer), buffer.Length, excludeFromMix);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000640C File Offset: 0x0000460C
		public static bool Render(NativeArray<float> buffer)
		{
			return AudioRenderer.Internal_AudioRenderer_Render(NativeArrayUnsafeUtility.GetUnsafePtr<float>(buffer), buffer.Length);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000344F File Offset: 0x0000164F
		public static bool Internal_AudioRenderer_Start()
		{
			return AudioRenderer.Internal_AudioRenderer_StartDelegateField();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000345B File Offset: 0x0000165B
		public static bool Internal_AudioRenderer_Stop()
		{
			return AudioRenderer.Internal_AudioRenderer_StopDelegateField();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00003467 File Offset: 0x00001667
		public static int Internal_AudioRenderer_GetSampleCountForCaptureFrame()
		{
			return AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00003473 File Offset: 0x00001673
		public unsafe static bool Internal_AudioRenderer_AddMixerGroupSink(AudioMixerGroup mixerGroup, void* ptr, int length, bool excludeFromMix)
		{
			return AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mixerGroup), ptr, length, excludeFromMix);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00003488 File Offset: 0x00001688
		public unsafe static bool Internal_AudioRenderer_Render(void* ptr, int length)
		{
			return AudioRenderer.Internal_AudioRenderer_RenderDelegateField(ptr, length);
		}

		// Token: 0x04000164 RID: 356
		private static readonly AudioRenderer.Internal_AudioRenderer_StartDelegate Internal_AudioRenderer_StartDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_StartDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Start");

		// Token: 0x04000165 RID: 357
		private static readonly AudioRenderer.Internal_AudioRenderer_StopDelegate Internal_AudioRenderer_StopDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_StopDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Stop");

		// Token: 0x04000166 RID: 358
		private static readonly AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_GetSampleCountForCaptureFrame");

		// Token: 0x04000167 RID: 359
		private static readonly AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegate Internal_AudioRenderer_AddMixerGroupSinkDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_AddMixerGroupSink");

		// Token: 0x04000168 RID: 360
		private static readonly AudioRenderer.Internal_AudioRenderer_RenderDelegate Internal_AudioRenderer_RenderDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_RenderDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Render");

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x060003EC RID: 1004
		private delegate bool Internal_AudioRenderer_StartDelegate();

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x060003EE RID: 1006
		private delegate bool Internal_AudioRenderer_StopDelegate();

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x060003F0 RID: 1008
		private delegate int Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate();

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x060003F2 RID: 1010
		private delegate bool Internal_AudioRenderer_AddMixerGroupSinkDelegate(IntPtr mixerGroup, IntPtr ptr, int length, bool excludeFromMix);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x060003F4 RID: 1012
		private delegate bool Internal_AudioRenderer_RenderDelegate(IntPtr ptr, int length);
	}
}
