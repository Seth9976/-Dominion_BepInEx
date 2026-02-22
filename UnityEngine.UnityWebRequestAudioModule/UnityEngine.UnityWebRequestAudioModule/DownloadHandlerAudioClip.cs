using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public sealed class DownloadHandlerAudioClip : DownloadHandler
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020F4 File Offset: 0x000002F4
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandlerAudioClip()
		{
			Il2CppClassPointerStore<DownloadHandlerAudioClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestAudioModule.dll", "UnityEngine.Networking", "DownloadHandlerAudioClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandlerAudioClip>.NativeClassPtr);
			DownloadHandlerAudioClip.NativeMethodInfoPtr_get_audioClip_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAudioClip>.NativeClassPtr, 100663297);
			DownloadHandlerAudioClip.NativeMethodInfoPtr_GetContent_Public_Static_AudioClip_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAudioClip>.NativeClassPtr, 100663298);
			DownloadHandlerAudioClip.CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.CreateDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::Create");
			DownloadHandlerAudioClip.get_streamAudioDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.get_streamAudioDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_streamAudio");
			DownloadHandlerAudioClip.set_streamAudioDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.set_streamAudioDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::set_streamAudio");
			DownloadHandlerAudioClip.get_compressedDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.get_compressedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_compressed");
			DownloadHandlerAudioClip.set_compressedDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.set_compressedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::set_compressed");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002198 File Offset: 0x00000398
		public unsafe AudioClip audioClip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158117, XrefRangeEnd = 158119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAudioClip.NativeMethodInfoPtr_get_audioClip_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021D8 File Offset: 0x000003D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158125, RefRangeEnd = 158126, XrefRangeStart = 158119, XrefRangeEnd = 158125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClip GetContent(UnityWebRequest www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAudioClip.NativeMethodInfoPtr_GetContent_Public_Static_AudioClip_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public DownloadHandlerAudioClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public static IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType)
		{
			return DownloadHandlerAudioClip.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(url), audioType);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002072 File Offset: 0x00000272
		public void InternalCreateAudioClip(string url, AudioType audioType)
		{
			base.m_Ptr = DownloadHandlerAudioClip.Create(this, url, audioType);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000221C File Offset: 0x0000041C
		public override Il2CppStructArray<byte> GetData()
		{
			return DownloadHandler.InternalGetByteArray(this);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002083 File Offset: 0x00000283
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported for audio clips");
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002090 File Offset: 0x00000290
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020A2 File Offset: 0x000002A2
		public bool streamAudio
		{
			get
			{
				return DownloadHandlerAudioClip.get_streamAudioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerAudioClip.set_streamAudioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020B5 File Offset: 0x000002B5
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020C7 File Offset: 0x000002C7
		public bool compressed
		{
			get
			{
				return DownloadHandlerAudioClip.get_compressedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerAudioClip.set_compressedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_get_audioClip_Public_get_AudioClip_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_GetContent_Public_Static_AudioClip_UnityWebRequest_0;

		// Token: 0x04000003 RID: 3
		private static readonly DownloadHandlerAudioClip.CreateDelegate CreateDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly DownloadHandlerAudioClip.get_streamAudioDelegate get_streamAudioDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly DownloadHandlerAudioClip.set_streamAudioDelegate set_streamAudioDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly DownloadHandlerAudioClip.get_compressedDelegate get_compressedDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly DownloadHandlerAudioClip.set_compressedDelegate set_compressedDelegateField;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000017 RID: 23
		private delegate IntPtr CreateDelegate(IntPtr obj, IntPtr url, AudioType audioType);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000019 RID: 25
		private delegate bool get_streamAudioDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate void set_streamAudioDelegate(IntPtr @this, bool value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001D RID: 29
		private delegate bool get_compressedDelegate(IntPtr @this);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600001F RID: 31
		private delegate void set_compressedDelegate(IntPtr @this, bool value);
	}
}
