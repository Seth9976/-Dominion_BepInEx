using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000163 RID: 355
	public static class SteamNetworkingMessages : Object
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x0007E188 File Offset: 0x0007C388
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingMessages()
		{
			Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingMessages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr);
			SteamNetworkingMessages.NativeMethodInfoPtr_SendMessageToUser_Public_Static_EResult_byref_SteamNetworkingIdentity_IntPtr_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr, 100667058);
			SteamNetworkingMessages.NativeMethodInfoPtr_ReceiveMessagesOnChannel_Public_Static_Int32_Int32_Il2CppStructArray_1_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr, 100667059);
			SteamNetworkingMessages.NativeMethodInfoPtr_AcceptSessionWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr, 100667060);
			SteamNetworkingMessages.NativeMethodInfoPtr_CloseSessionWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr, 100667061);
			SteamNetworkingMessages.NativeMethodInfoPtr_CloseChannelWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr, 100667062);
			SteamNetworkingMessages.NativeMethodInfoPtr_GetSessionConnectionInfo_Public_Static_ESteamNetworkingConnectionState_byref_SteamNetworkingIdentity_byref_SteamNetConnectionInfo_t_byref_SteamNetworkingQuickConnectionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessages>.NativeClassPtr, 100667063);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0007E230 File Offset: 0x0007C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200679, XrefRangeEnd = 200683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityRemote);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pubData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessages.NativeMethodInfoPtr_SendMessageToUser_Public_Static_EResult_byref_SteamNetworkingIdentity_IntPtr_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0007E2AC File Offset: 0x0007C4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200683, XrefRangeEnd = 200687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveMessagesOnChannel(int nLocalChannel, Il2CppStructArray<IntPtr> ppOutMessages, int nMaxMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLocalChannel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppOutMessages);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessages.NativeMethodInfoPtr_ReceiveMessagesOnChannel_Public_Static_Int32_Int32_Il2CppStructArray_1_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0007E30C File Offset: 0x0007C50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200687, XrefRangeEnd = 200691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityRemote);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessages.NativeMethodInfoPtr_AcceptSessionWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0007E350 File Offset: 0x0007C550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200691, XrefRangeEnd = 200695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityRemote);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessages.NativeMethodInfoPtr_CloseSessionWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0007E394 File Offset: 0x0007C594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200695, XrefRangeEnd = 200699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityRemote);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLocalChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessages.NativeMethodInfoPtr_CloseChannelWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0007E3E4 File Offset: 0x0007C5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200699, XrefRangeEnd = 200703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetworkingQuickConnectionStatus pQuickStatus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityRemote);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessages.NativeMethodInfoPtr_GetSessionConnectionInfo_Public_Static_ESteamNetworkingConnectionState_byref_SteamNetworkingIdentity_byref_SteamNetConnectionInfo_t_byref_SteamNetworkingQuickConnectionStatus_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			pConnectionInfo = ((intPtr5 == 0) ? null : new SteamNetConnectionInfo_t(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pQuickStatus = ((intPtr6 == 0) ? null : new SteamNetworkingQuickConnectionStatus(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0000BADB File Offset: 0x00009CDB
		public SteamNetworkingMessages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToUser_Public_Static_EResult_byref_SteamNetworkingIdentity_IntPtr_UInt32_Int32_Int32_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnChannel_Public_Static_Int32_Int32_Il2CppStructArray_1_IntPtr_Int32_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_AcceptSessionWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_CloseSessionWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_CloseChannelWithUser_Public_Static_Boolean_byref_SteamNetworkingIdentity_Int32_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionConnectionInfo_Public_Static_ESteamNetworkingConnectionState_byref_SteamNetworkingIdentity_byref_SteamNetConnectionInfo_t_byref_SteamNetworkingQuickConnectionStatus_0;
	}
}
