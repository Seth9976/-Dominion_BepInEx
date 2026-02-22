using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000160 RID: 352
	public static class SteamMusic : Object
	{
		// Token: 0x06001B57 RID: 6999 RVA: 0x0007CAFC File Offset: 0x0007ACFC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMusic()
		{
			Il2CppClassPointerStore<SteamMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamMusic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr);
			SteamMusic.NativeMethodInfoPtr_BIsEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100666995);
			SteamMusic.NativeMethodInfoPtr_BIsPlaying_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100666996);
			SteamMusic.NativeMethodInfoPtr_GetPlaybackStatus_Public_Static_AudioPlayback_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100666997);
			SteamMusic.NativeMethodInfoPtr_Play_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100666998);
			SteamMusic.NativeMethodInfoPtr_Pause_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100666999);
			SteamMusic.NativeMethodInfoPtr_PlayPrevious_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100667000);
			SteamMusic.NativeMethodInfoPtr_PlayNext_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100667001);
			SteamMusic.NativeMethodInfoPtr_SetVolume_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100667002);
			SteamMusic.NativeMethodInfoPtr_GetVolume_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100667003);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0007CBE0 File Offset: 0x0007ADE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200384, XrefRangeEnd = 200388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_BIsEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0007CC10 File Offset: 0x0007AE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200388, XrefRangeEnd = 200392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsPlaying()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_BIsPlaying_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0007CC40 File Offset: 0x0007AE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200392, XrefRangeEnd = 200396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioPlayback_Status GetPlaybackStatus()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_GetPlaybackStatus_Public_Static_AudioPlayback_Status_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0007CC70 File Offset: 0x0007AE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200396, XrefRangeEnd = 200400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Play()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_Play_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0007CC98 File Offset: 0x0007AE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200400, XrefRangeEnd = 200404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_Pause_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0007CCC0 File Offset: 0x0007AEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200404, XrefRangeEnd = 200408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayPrevious()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_PlayPrevious_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0007CCE8 File Offset: 0x0007AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200408, XrefRangeEnd = 200412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayNext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_PlayNext_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0007CD10 File Offset: 0x0007AF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200412, XrefRangeEnd = 200416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVolume(float flVolume)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flVolume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_SetVolume_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0007CD44 File Offset: 0x0007AF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200416, XrefRangeEnd = 200420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetVolume()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_GetVolume_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		public SteamMusic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_BIsEnabled_Public_Static_Boolean_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_BIsPlaying_Public_Static_Boolean_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaybackStatus_Public_Static_AudioPlayback_Status_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_PlayPrevious_Public_Static_Void_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_PlayNext_Public_Static_Void_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Static_Void_Single_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_GetVolume_Public_Static_Single_0;
	}
}
