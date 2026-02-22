using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000161 RID: 353
	public static class SteamMusicRemote : Object
	{
		// Token: 0x06001B62 RID: 7010 RVA: 0x0007CD74 File Offset: 0x0007AF74
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMusicRemote()
		{
			Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamMusicRemote");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr);
			SteamMusicRemote.NativeMethodInfoPtr_RegisterSteamMusicRemote_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667004);
			SteamMusicRemote.NativeMethodInfoPtr_DeregisterSteamMusicRemote_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667005);
			SteamMusicRemote.NativeMethodInfoPtr_BIsCurrentMusicRemote_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667006);
			SteamMusicRemote.NativeMethodInfoPtr_BActivationSuccess_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667007);
			SteamMusicRemote.NativeMethodInfoPtr_SetDisplayName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667008);
			SteamMusicRemote.NativeMethodInfoPtr_SetPNGIcon_64x64_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667009);
			SteamMusicRemote.NativeMethodInfoPtr_EnablePlayPrevious_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667010);
			SteamMusicRemote.NativeMethodInfoPtr_EnablePlayNext_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667011);
			SteamMusicRemote.NativeMethodInfoPtr_EnableShuffled_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667012);
			SteamMusicRemote.NativeMethodInfoPtr_EnableLooped_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667013);
			SteamMusicRemote.NativeMethodInfoPtr_EnableQueue_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667014);
			SteamMusicRemote.NativeMethodInfoPtr_EnablePlaylists_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667015);
			SteamMusicRemote.NativeMethodInfoPtr_UpdatePlaybackStatus_Public_Static_Boolean_AudioPlayback_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667016);
			SteamMusicRemote.NativeMethodInfoPtr_UpdateShuffled_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667017);
			SteamMusicRemote.NativeMethodInfoPtr_UpdateLooped_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667018);
			SteamMusicRemote.NativeMethodInfoPtr_UpdateVolume_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667019);
			SteamMusicRemote.NativeMethodInfoPtr_CurrentEntryWillChange_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667020);
			SteamMusicRemote.NativeMethodInfoPtr_CurrentEntryIsAvailable_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667021);
			SteamMusicRemote.NativeMethodInfoPtr_UpdateCurrentEntryText_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667022);
			SteamMusicRemote.NativeMethodInfoPtr_UpdateCurrentEntryElapsedSeconds_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667023);
			SteamMusicRemote.NativeMethodInfoPtr_UpdateCurrentEntryCoverArt_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667024);
			SteamMusicRemote.NativeMethodInfoPtr_CurrentEntryDidChange_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667025);
			SteamMusicRemote.NativeMethodInfoPtr_QueueWillChange_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667026);
			SteamMusicRemote.NativeMethodInfoPtr_ResetQueueEntries_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667027);
			SteamMusicRemote.NativeMethodInfoPtr_SetQueueEntry_Public_Static_Boolean_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667028);
			SteamMusicRemote.NativeMethodInfoPtr_SetCurrentQueueEntry_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667029);
			SteamMusicRemote.NativeMethodInfoPtr_QueueDidChange_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667030);
			SteamMusicRemote.NativeMethodInfoPtr_PlaylistWillChange_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667031);
			SteamMusicRemote.NativeMethodInfoPtr_ResetPlaylistEntries_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667032);
			SteamMusicRemote.NativeMethodInfoPtr_SetPlaylistEntry_Public_Static_Boolean_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667033);
			SteamMusicRemote.NativeMethodInfoPtr_SetCurrentPlaylistEntry_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667034);
			SteamMusicRemote.NativeMethodInfoPtr_PlaylistDidChange_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusicRemote>.NativeClassPtr, 100667035);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0007D024 File Offset: 0x0007B224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200420, XrefRangeEnd = 200432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterSteamMusicRemote(string pchName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_RegisterSteamMusicRemote_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0007D068 File Offset: 0x0007B268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200432, XrefRangeEnd = 200436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeregisterSteamMusicRemote()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_DeregisterSteamMusicRemote_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0007D098 File Offset: 0x0007B298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200436, XrefRangeEnd = 200440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsCurrentMusicRemote()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_BIsCurrentMusicRemote_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0007D0C8 File Offset: 0x0007B2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200440, XrefRangeEnd = 200444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BActivationSuccess(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_BActivationSuccess_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0007D108 File Offset: 0x0007B308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200444, XrefRangeEnd = 200456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDisplayName(string pchDisplayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchDisplayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_SetDisplayName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0007D14C File Offset: 0x0007B34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200456, XrefRangeEnd = 200460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetPNGIcon_64x64(Il2CppStructArray<byte> pvBuffer, uint cbBufferLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBufferLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_SetPNGIcon_64x64_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0007D19C File Offset: 0x0007B39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200460, XrefRangeEnd = 200464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnablePlayPrevious(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_EnablePlayPrevious_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0007D1DC File Offset: 0x0007B3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200464, XrefRangeEnd = 200468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnablePlayNext(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_EnablePlayNext_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0007D21C File Offset: 0x0007B41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200468, XrefRangeEnd = 200472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableShuffled(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_EnableShuffled_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0007D25C File Offset: 0x0007B45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200472, XrefRangeEnd = 200476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableLooped(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_EnableLooped_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0007D29C File Offset: 0x0007B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200476, XrefRangeEnd = 200480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableQueue(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_EnableQueue_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0007D2DC File Offset: 0x0007B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200480, XrefRangeEnd = 200484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnablePlaylists(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_EnablePlaylists_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0007D31C File Offset: 0x0007B51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200484, XrefRangeEnd = 200488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nStatus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_UpdatePlaybackStatus_Public_Static_Boolean_AudioPlayback_Status_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0007D35C File Offset: 0x0007B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200488, XrefRangeEnd = 200492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateShuffled(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_UpdateShuffled_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0007D39C File Offset: 0x0007B59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200492, XrefRangeEnd = 200496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateLooped(bool bValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_UpdateLooped_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0007D3DC File Offset: 0x0007B5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200496, XrefRangeEnd = 200500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateVolume(float flValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_UpdateVolume_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0007D41C File Offset: 0x0007B61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200500, XrefRangeEnd = 200504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CurrentEntryWillChange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_CurrentEntryWillChange_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0007D44C File Offset: 0x0007B64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200504, XrefRangeEnd = 200508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAvailable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_CurrentEntryIsAvailable_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0007D48C File Offset: 0x0007B68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200508, XrefRangeEnd = 200520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateCurrentEntryText(string pchText)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_UpdateCurrentEntryText_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0007D4D0 File Offset: 0x0007B6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200520, XrefRangeEnd = 200524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_UpdateCurrentEntryElapsedSeconds_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0007D510 File Offset: 0x0007B710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200524, XrefRangeEnd = 200528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateCurrentEntryCoverArt(Il2CppStructArray<byte> pvBuffer, uint cbBufferLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBufferLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_UpdateCurrentEntryCoverArt_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0007D560 File Offset: 0x0007B760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200528, XrefRangeEnd = 200532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CurrentEntryDidChange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_CurrentEntryDidChange_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0007D590 File Offset: 0x0007B790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200532, XrefRangeEnd = 200536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueWillChange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_QueueWillChange_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0007D5C0 File Offset: 0x0007B7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200536, XrefRangeEnd = 200540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetQueueEntries()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_ResetQueueEntries_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0007D5F0 File Offset: 0x0007B7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200540, XrefRangeEnd = 200552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchEntryText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_SetQueueEntry_Public_Static_Boolean_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0007D650 File Offset: 0x0007B850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200552, XrefRangeEnd = 200556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCurrentQueueEntry(int nID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_SetCurrentQueueEntry_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0007D690 File Offset: 0x0007B890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200556, XrefRangeEnd = 200560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueDidChange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_QueueDidChange_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0007D6C0 File Offset: 0x0007B8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200560, XrefRangeEnd = 200564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlaylistWillChange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_PlaylistWillChange_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0007D6F0 File Offset: 0x0007B8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200564, XrefRangeEnd = 200568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetPlaylistEntries()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_ResetPlaylistEntries_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0007D720 File Offset: 0x0007B920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200568, XrefRangeEnd = 200580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchEntryText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_SetPlaylistEntry_Public_Static_Boolean_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0007D780 File Offset: 0x0007B980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200580, XrefRangeEnd = 200584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCurrentPlaylistEntry(int nID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_SetCurrentPlaylistEntry_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0007D7C0 File Offset: 0x0007B9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200584, XrefRangeEnd = 200588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlaylistDidChange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusicRemote.NativeMethodInfoPtr_PlaylistDidChange_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000BAC9 File Offset: 0x00009CC9
		public SteamMusicRemote(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSteamMusicRemote_Public_Static_Boolean_String_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterSteamMusicRemote_Public_Static_Boolean_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_BIsCurrentMusicRemote_Public_Static_Boolean_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_BActivationSuccess_Public_Static_Boolean_Boolean_0;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayName_Public_Static_Boolean_String_0;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr_SetPNGIcon_64x64_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr_EnablePlayPrevious_Public_Static_Boolean_Boolean_0;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr_EnablePlayNext_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr_EnableShuffled_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeMethodInfoPtr_EnableLooped_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr_EnableQueue_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeMethodInfoPtr_EnablePlaylists_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlaybackStatus_Public_Static_Boolean_AudioPlayback_Status_0;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShuffled_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLooped_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolume_Public_Static_Boolean_Single_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_CurrentEntryWillChange_Public_Static_Boolean_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_CurrentEntryIsAvailable_Public_Static_Boolean_Boolean_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentEntryText_Public_Static_Boolean_String_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentEntryElapsedSeconds_Public_Static_Boolean_Int32_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentEntryCoverArt_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_CurrentEntryDidChange_Public_Static_Boolean_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_QueueWillChange_Public_Static_Boolean_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_ResetQueueEntries_Public_Static_Boolean_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_SetQueueEntry_Public_Static_Boolean_Int32_Int32_String_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentQueueEntry_Public_Static_Boolean_Int32_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_QueueDidChange_Public_Static_Boolean_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_PlaylistWillChange_Public_Static_Boolean_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr_ResetPlaylistEntries_Public_Static_Boolean_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaylistEntry_Public_Static_Boolean_Int32_Int32_String_0;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentPlaylistEntry_Public_Static_Boolean_Int32_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr_PlaylistDidChange_Public_Static_Boolean_0;
	}
}
