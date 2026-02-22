using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x0200000A RID: 10
	public class AudioSampleProvider : Object
	{
		// Token: 0x060000EE RID: 238 RVA: 0x000055E8 File Offset: 0x000037E8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSampleProvider()
		{
			Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Experimental.Audio", "AudioSampleProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr);
			AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesAvailable");
			AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesOverflow");
			AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663331);
			AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663332);
			AudioSampleProvider.InternalCreateSampleProviderDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalCreateSampleProviderDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalCreateSampleProvider");
			AudioSampleProvider.InternalRemoveDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalRemoveDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalRemove");
			AudioSampleProvider.InternalGetFormatInfoDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFormatInfoDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFormatInfo");
			AudioSampleProvider.InternalGetScriptingPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetScriptingPtr");
			AudioSampleProvider.InternalSetScriptingPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetScriptingPtr");
			AudioSampleProvider.InternalIsValidDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalIsValidDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalIsValid");
			AudioSampleProvider.InternalGetMaxSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetMaxSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetMaxSampleFrameCount");
			AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetAvailableSampleFrameCount");
			AudioSampleProvider.InternalGetFreeSampleFrameCountDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFreeSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCount");
			AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCountLowThreshold");
			AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetFreeSampleFrameCountLowThreshold");
			AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSampleFramesAvailableEvents");
			AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSampleFramesAvailableEvents");
			AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesAvailableNativeHandler");
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesAvailableNativeHandler");
			AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesOverflowNativeHandler");
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesOverflowNativeHandler");
			AudioSampleProvider.InternalGetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSilencePadding");
			AudioSampleProvider.InternalSetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalSetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSilencePadding");
			AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetConsumeSampleFramesNativeFunctionPtr");
			AudioSampleProvider.InternalQueueSampleFramesDelegateField = IL2CPP.ResolveICall<AudioSampleProvider.InternalQueueSampleFramesDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalQueueSampleFrames");
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000057A4 File Offset: 0x000039A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90249, XrefRangeEnd = 90250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeSampleFramesAvailable(int sampleFrameCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000057E4 File Offset: 0x000039E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90250, XrefRangeEnd = 90251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref droppedSampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002A24 File Offset: 0x00000C24
		public AudioSampleProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005824 File Offset: 0x00003A24
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002A2D File Offset: 0x00000C2D
		public unsafe AudioSampleProvider.SampleFramesHandler sampleFramesAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider.SampleFramesHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00005854 File Offset: 0x00003A54
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002A4C File Offset: 0x00000C4C
		public unsafe AudioSampleProvider.SampleFramesHandler sampleFramesOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider.SampleFramesHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSampleProvider.NativeFieldInfoPtr_sampleFramesOverflow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005884 File Offset: 0x00003A84
		public static AudioSampleProvider Lookup(uint providerId, Object ownerObj, ushort trackIndex)
		{
			AudioSampleProvider audioSampleProvider = AudioSampleProvider.InternalGetScriptingPtr(providerId);
			bool flag = audioSampleProvider != null || !AudioSampleProvider.InternalIsValid(providerId);
			AudioSampleProvider audioSampleProvider2;
			if (flag)
			{
				audioSampleProvider2 = audioSampleProvider;
			}
			else
			{
				audioSampleProvider2 = new AudioSampleProvider(providerId, ownerObj, trackIndex);
			}
			return audioSampleProvider2;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000058BC File Offset: 0x00003ABC
		public static AudioSampleProvider Create(ushort channelCount, uint sampleRate)
		{
			uint num = AudioSampleProvider.InternalCreateSampleProvider(channelCount, sampleRate);
			bool flag = !AudioSampleProvider.InternalIsValid(num);
			AudioSampleProvider audioSampleProvider;
			if (flag)
			{
				audioSampleProvider = null;
			}
			else
			{
				audioSampleProvider = new AudioSampleProvider(num, null, 0);
			}
			return audioSampleProvider;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000058F0 File Offset: 0x00003AF0
		public ~AudioSampleProvider()
		{
			this.owner = null;
			this.Dispose();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005928 File Offset: 0x00003B28
		public void Dispose()
		{
			bool flag = this.id > 0U;
			if (flag)
			{
				AudioSampleProvider.InternalSetScriptingPtr(this.id, null);
				bool flag2 = this.owner == null;
				if (flag2)
				{
					AudioSampleProvider.InternalRemove(this.id);
				}
				this.id = 0U;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002A6B File Offset: 0x00000C6B
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002A78 File Offset: 0x00000C78
		public uint id
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002A85 File Offset: 0x00000C85
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002A92 File Offset: 0x00000C92
		public ushort trackIndex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002A9F File Offset: 0x00000C9F
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002AAC File Offset: 0x00000CAC
		public Object owner
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00005980 File Offset: 0x00003B80
		public bool valid
		{
			get
			{
				return AudioSampleProvider.InternalIsValid(this.id);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002AB9 File Offset: 0x00000CB9
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002AC6 File Offset: 0x00000CC6
		public ushort channelCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002AD3 File Offset: 0x00000CD3
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public uint sampleRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000059A0 File Offset: 0x00003BA0
		public uint maxSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetMaxSampleFrameCount(this.id);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000059C0 File Offset: 0x00003BC0
		public uint availableSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetAvailableSampleFrameCount(this.id);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000059E0 File Offset: 0x00003BE0
		public uint freeSampleFrameCount
		{
			get
			{
				return AudioSampleProvider.InternalGetFreeSampleFrameCount(this.id);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00005A00 File Offset: 0x00003C00
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002AED File Offset: 0x00000CED
		public uint freeSampleFrameCountLowThreshold
		{
			get
			{
				return AudioSampleProvider.InternalGetFreeSampleFrameCountLowThreshold(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetFreeSampleFrameCountLowThreshold(this.id, value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00005A20 File Offset: 0x00003C20
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002AFD File Offset: 0x00000CFD
		public bool enableSampleFramesAvailableEvents
		{
			get
			{
				return AudioSampleProvider.InternalGetEnableSampleFramesAvailableEvents(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetEnableSampleFramesAvailableEvents(this.id, value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00005A40 File Offset: 0x00003C40
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002B0D File Offset: 0x00000D0D
		public bool enableSilencePadding
		{
			get
			{
				return AudioSampleProvider.InternalGetEnableSilencePadding(this.id);
			}
			set
			{
				AudioSampleProvider.InternalSetEnableSilencePadding(this.id, value);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002B1D File Offset: 0x00000D1D
		public uint ConsumeSampleFrames(NativeArray<float> sampleFrames)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00005A60 File Offset: 0x00003C60
		public uint QueueSampleFrames(NativeArray<float> sampleFrames)
		{
			bool flag = this.channelCount == 0;
			uint num;
			if (flag)
			{
				num = 0U;
			}
			else
			{
				num = AudioSampleProvider.InternalQueueSampleFrames(this.id, (IntPtr)sampleFrames.GetUnsafeReadOnlyPtr<float>(), (uint)(sampleFrames.Length / (int)this.channelCount));
			}
			return num;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002B2A File Offset: 0x00000D2A
		public void add_sampleFramesAvailable(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002B37 File Offset: 0x00000D37
		public void remove_sampleFramesAvailable(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002B44 File Offset: 0x00000D44
		public void add_sampleFramesOverflow(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002B51 File Offset: 0x00000D51
		public void remove_sampleFramesOverflow(AudioSampleProvider.SampleFramesHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002B5E File Offset: 0x00000D5E
		public void ClearSampleFramesAvailableNativeHandler()
		{
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandler(this.id);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002B6D File Offset: 0x00000D6D
		public void ClearSampleFramesOverflowNativeHandler()
		{
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandler(this.id);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002B7C File Offset: 0x00000D7C
		public static uint InternalCreateSampleProvider(ushort channelCount, uint sampleRate)
		{
			return AudioSampleProvider.InternalCreateSampleProviderDelegateField(channelCount, sampleRate);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002B8A File Offset: 0x00000D8A
		public static void InternalRemove(uint providerId)
		{
			AudioSampleProvider.InternalRemoveDelegateField(providerId);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002B97 File Offset: 0x00000D97
		public static void InternalGetFormatInfo(uint providerId, out ushort chCount, out uint sRate)
		{
			AudioSampleProvider.InternalGetFormatInfoDelegateField(providerId, out chCount, out sRate);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public static AudioSampleProvider InternalGetScriptingPtr(uint providerId)
		{
			IntPtr intPtr = AudioSampleProvider.InternalGetScriptingPtrDelegateField(providerId);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSampleProvider>(intPtr2) : null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002BA6 File Offset: 0x00000DA6
		public static void InternalSetScriptingPtr(uint providerId, AudioSampleProvider provider)
		{
			AudioSampleProvider.InternalSetScriptingPtrDelegateField(providerId, IL2CPP.Il2CppObjectBaseToPtr(provider));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002BB9 File Offset: 0x00000DB9
		public static bool InternalIsValid(uint providerId)
		{
			return AudioSampleProvider.InternalIsValidDelegateField(providerId);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public static uint InternalGetMaxSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetMaxSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002BD3 File Offset: 0x00000DD3
		public static uint InternalGetAvailableSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public static uint InternalGetFreeSampleFrameCount(uint providerId)
		{
			return AudioSampleProvider.InternalGetFreeSampleFrameCountDelegateField(providerId);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002BED File Offset: 0x00000DED
		public static uint InternalGetFreeSampleFrameCountLowThreshold(uint providerId)
		{
			return AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegateField(providerId);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002BFA File Offset: 0x00000DFA
		public static void InternalSetFreeSampleFrameCountLowThreshold(uint providerId, uint sampleFrameCount)
		{
			AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegateField(providerId, sampleFrameCount);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002C08 File Offset: 0x00000E08
		public static bool InternalGetEnableSampleFramesAvailableEvents(uint providerId)
		{
			return AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegateField(providerId);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002C15 File Offset: 0x00000E15
		public static void InternalSetEnableSampleFramesAvailableEvents(uint providerId, bool enable)
		{
			AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegateField(providerId, enable);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002C23 File Offset: 0x00000E23
		public static void InternalSetSampleFramesAvailableNativeHandler(uint providerId, IntPtr handler, IntPtr userData)
		{
			AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegateField(providerId, handler, userData);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002C32 File Offset: 0x00000E32
		public static void InternalClearSampleFramesAvailableNativeHandler(uint providerId)
		{
			AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegateField(providerId);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002C3F File Offset: 0x00000E3F
		public static void InternalSetSampleFramesOverflowNativeHandler(uint providerId, IntPtr handler, IntPtr userData)
		{
			AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegateField(providerId, handler, userData);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002C4E File Offset: 0x00000E4E
		public static void InternalClearSampleFramesOverflowNativeHandler(uint providerId)
		{
			AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegateField(providerId);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002C5B File Offset: 0x00000E5B
		public static bool InternalGetEnableSilencePadding(uint id)
		{
			return AudioSampleProvider.InternalGetEnableSilencePaddingDelegateField(id);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002C68 File Offset: 0x00000E68
		public static void InternalSetEnableSilencePadding(uint id, bool enabled)
		{
			AudioSampleProvider.InternalSetEnableSilencePaddingDelegateField(id, enabled);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002C76 File Offset: 0x00000E76
		public static IntPtr InternalGetConsumeSampleFramesNativeFunctionPtr()
		{
			return AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002C82 File Offset: 0x00000E82
		public static uint InternalQueueSampleFrames(uint id, IntPtr interleavedSampleFrames, uint sampleFrameCount)
		{
			return AudioSampleProvider.InternalQueueSampleFramesDelegateField(id, interleavedSampleFrames, sampleFrameCount);
		}

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_sampleFramesAvailable;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_sampleFramesOverflow;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly AudioSampleProvider.InternalCreateSampleProviderDelegate InternalCreateSampleProviderDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly AudioSampleProvider.InternalRemoveDelegate InternalRemoveDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly AudioSampleProvider.InternalGetFormatInfoDelegate InternalGetFormatInfoDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly AudioSampleProvider.InternalGetScriptingPtrDelegate InternalGetScriptingPtrDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly AudioSampleProvider.InternalSetScriptingPtrDelegate InternalSetScriptingPtrDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly AudioSampleProvider.InternalIsValidDelegate InternalIsValidDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly AudioSampleProvider.InternalGetMaxSampleFrameCountDelegate InternalGetMaxSampleFrameCountDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly AudioSampleProvider.InternalGetAvailableSampleFrameCountDelegate InternalGetAvailableSampleFrameCountDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly AudioSampleProvider.InternalGetFreeSampleFrameCountDelegate InternalGetFreeSampleFrameCountDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly AudioSampleProvider.InternalGetFreeSampleFrameCountLowThresholdDelegate InternalGetFreeSampleFrameCountLowThresholdDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly AudioSampleProvider.InternalSetFreeSampleFrameCountLowThresholdDelegate InternalSetFreeSampleFrameCountLowThresholdDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly AudioSampleProvider.InternalGetEnableSampleFramesAvailableEventsDelegate InternalGetEnableSampleFramesAvailableEventsDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly AudioSampleProvider.InternalSetEnableSampleFramesAvailableEventsDelegate InternalSetEnableSampleFramesAvailableEventsDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly AudioSampleProvider.InternalSetSampleFramesAvailableNativeHandlerDelegate InternalSetSampleFramesAvailableNativeHandlerDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly AudioSampleProvider.InternalClearSampleFramesAvailableNativeHandlerDelegate InternalClearSampleFramesAvailableNativeHandlerDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly AudioSampleProvider.InternalSetSampleFramesOverflowNativeHandlerDelegate InternalSetSampleFramesOverflowNativeHandlerDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly AudioSampleProvider.InternalClearSampleFramesOverflowNativeHandlerDelegate InternalClearSampleFramesOverflowNativeHandlerDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly AudioSampleProvider.InternalGetEnableSilencePaddingDelegate InternalGetEnableSilencePaddingDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly AudioSampleProvider.InternalSetEnableSilencePaddingDelegate InternalSetEnableSilencePaddingDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly AudioSampleProvider.InternalGetConsumeSampleFramesNativeFunctionPtrDelegate InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly AudioSampleProvider.InternalQueueSampleFramesDelegate InternalQueueSampleFramesDelegateField;

		// Token: 0x0200009E RID: 158
		public sealed class SampleFramesHandler : MulticastDelegate
		{
			// Token: 0x060002EC RID: 748 RVA: 0x00003968 File Offset: 0x00001B68
			// Note: this type is marked as 'beforefieldinit'.
			static SampleFramesHandler()
			{
				Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "SampleFramesHandler");
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663333);
				AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr, 100663334);
			}

			// Token: 0x060002ED RID: 749 RVA: 0x00006B1C File Offset: 0x00004D1C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SampleFramesHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSampleProvider.SampleFramesHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EE RID: 750 RVA: 0x00006B78 File Offset: 0x00004D78
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 90246, RefRangeEnd = 90249, XrefRangeStart = 90227, XrefRangeEnd = 90246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(AudioSampleProvider provider, uint sampleFrameCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleFrameCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSampleProvider.SampleFramesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EF RID: 751 RVA: 0x000039A6 File Offset: 0x00001BA6
			public SampleFramesHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x000039AF File Offset: 0x00001BAF
			public static implicit operator AudioSampleProvider.SampleFramesHandler(Action<AudioSampleProvider, uint> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioSampleProvider.SampleFramesHandler>(A_0);
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x000039B7 File Offset: 0x00001BB7
			public static AudioSampleProvider.SampleFramesHandler operator +(AudioSampleProvider.SampleFramesHandler A_0, AudioSampleProvider.SampleFramesHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioSampleProvider.SampleFramesHandler>();
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x000039C5 File Offset: 0x00001BC5
			public static AudioSampleProvider.SampleFramesHandler operator -(AudioSampleProvider.SampleFramesHandler A_0, AudioSampleProvider.SampleFramesHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioSampleProvider.SampleFramesHandler>();
				}
				return delegate2;
			}

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0;
		}

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x060002F4 RID: 756
		private delegate uint InternalCreateSampleProviderDelegate(ushort channelCount, uint sampleRate);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x060002F6 RID: 758
		private delegate void InternalRemoveDelegate(uint providerId);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x060002F8 RID: 760
		private delegate void InternalGetFormatInfoDelegate(uint providerId, [Out] IntPtr chCount, [Out] IntPtr sRate);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x060002FA RID: 762
		private delegate IntPtr InternalGetScriptingPtrDelegate(uint providerId);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060002FC RID: 764
		private delegate void InternalSetScriptingPtrDelegate(uint providerId, IntPtr provider);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060002FE RID: 766
		private delegate bool InternalIsValidDelegate(uint providerId);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000300 RID: 768
		private delegate uint InternalGetMaxSampleFrameCountDelegate(uint providerId);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000302 RID: 770
		private delegate uint InternalGetAvailableSampleFrameCountDelegate(uint providerId);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000304 RID: 772
		private delegate uint InternalGetFreeSampleFrameCountDelegate(uint providerId);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000306 RID: 774
		private delegate uint InternalGetFreeSampleFrameCountLowThresholdDelegate(uint providerId);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000308 RID: 776
		private delegate void InternalSetFreeSampleFrameCountLowThresholdDelegate(uint providerId, uint sampleFrameCount);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x0600030A RID: 778
		private delegate bool InternalGetEnableSampleFramesAvailableEventsDelegate(uint providerId);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x0600030C RID: 780
		private delegate void InternalSetEnableSampleFramesAvailableEventsDelegate(uint providerId, bool enable);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x0600030E RID: 782
		private delegate void InternalSetSampleFramesAvailableNativeHandlerDelegate(uint providerId, IntPtr handler, IntPtr userData);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000310 RID: 784
		private delegate void InternalClearSampleFramesAvailableNativeHandlerDelegate(uint providerId);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000312 RID: 786
		private delegate void InternalSetSampleFramesOverflowNativeHandlerDelegate(uint providerId, IntPtr handler, IntPtr userData);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000314 RID: 788
		private delegate void InternalClearSampleFramesOverflowNativeHandlerDelegate(uint providerId);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000316 RID: 790
		private delegate bool InternalGetEnableSilencePaddingDelegate(uint id);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x06000318 RID: 792
		private delegate void InternalSetEnableSilencePaddingDelegate(uint id, bool enabled);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x0600031A RID: 794
		private delegate IntPtr InternalGetConsumeSampleFramesNativeFunctionPtrDelegate();

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x0600031C RID: 796
		private delegate uint InternalQueueSampleFramesDelegate(uint id, IntPtr interleavedSampleFrames, uint sampleFrameCount);
	}
}
