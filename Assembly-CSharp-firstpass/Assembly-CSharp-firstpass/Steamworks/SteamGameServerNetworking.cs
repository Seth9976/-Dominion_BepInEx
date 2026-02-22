using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000152 RID: 338
	public static class SteamGameServerNetworking : Object
	{
		// Token: 0x06001995 RID: 6549 RVA: 0x00072294 File Offset: 0x00070494
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerNetworking()
		{
			Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerNetworking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr);
			SteamGameServerNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_UInt32_EP2PSend_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666573);
			SteamGameServerNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666574);
			SteamGameServerNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666575);
			SteamGameServerNetworking.NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666576);
			SteamGameServerNetworking.NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666577);
			SteamGameServerNetworking.NativeMethodInfoPtr_CloseP2PChannelWithUser_Public_Static_Boolean_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666578);
			SteamGameServerNetworking.NativeMethodInfoPtr_GetP2PSessionState_Public_Static_Boolean_CSteamID_byref_P2PSessionState_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666579);
			SteamGameServerNetworking.NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666580);
			SteamGameServerNetworking.NativeMethodInfoPtr_CreateListenSocket_Public_Static_SNetListenSocket_t_Int32_SteamIPAddress_t_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666581);
			SteamGameServerNetworking.NativeMethodInfoPtr_CreateP2PConnectionSocket_Public_Static_SNetSocket_t_CSteamID_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666582);
			SteamGameServerNetworking.NativeMethodInfoPtr_CreateConnectionSocket_Public_Static_SNetSocket_t_SteamIPAddress_t_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666583);
			SteamGameServerNetworking.NativeMethodInfoPtr_DestroySocket_Public_Static_Boolean_SNetSocket_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666584);
			SteamGameServerNetworking.NativeMethodInfoPtr_DestroyListenSocket_Public_Static_Boolean_SNetListenSocket_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666585);
			SteamGameServerNetworking.NativeMethodInfoPtr_SendDataOnSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666586);
			SteamGameServerNetworking.NativeMethodInfoPtr_IsDataAvailableOnSocket_Public_Static_Boolean_SNetSocket_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666587);
			SteamGameServerNetworking.NativeMethodInfoPtr_RetrieveDataFromSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666588);
			SteamGameServerNetworking.NativeMethodInfoPtr_IsDataAvailable_Public_Static_Boolean_SNetListenSocket_t_byref_UInt32_byref_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666589);
			SteamGameServerNetworking.NativeMethodInfoPtr_RetrieveData_Public_Static_Boolean_SNetListenSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666590);
			SteamGameServerNetworking.NativeMethodInfoPtr_GetSocketInfo_Public_Static_Boolean_SNetSocket_t_byref_CSteamID_byref_Int32_byref_SteamIPAddress_t_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666591);
			SteamGameServerNetworking.NativeMethodInfoPtr_GetListenSocketInfo_Public_Static_Boolean_SNetListenSocket_t_byref_SteamIPAddress_t_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666592);
			SteamGameServerNetworking.NativeMethodInfoPtr_GetSocketConnectionType_Public_Static_ESNetSocketConnectionType_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666593);
			SteamGameServerNetworking.NativeMethodInfoPtr_GetMaxPacketSize_Public_Static_Int32_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworking>.NativeClassPtr, 100666594);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0007247C File Offset: 0x0007067C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197452, XrefRangeEnd = 197456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendP2PPacket(CSteamID steamIDRemote, Il2CppStructArray<byte> pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDRemote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eP2PSendType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_UInt32_EP2PSend_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000724F8 File Offset: 0x000706F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197456, XrefRangeEnd = 197460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pcubMsgSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00072544 File Offset: 0x00070744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197460, XrefRangeEnd = 197464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadP2PPacket(Il2CppStructArray<byte> pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pubDest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubMsgSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamIDRemote;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000725C0 File Offset: 0x000707C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197464, XrefRangeEnd = 197468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDRemote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00072600 File Offset: 0x00070800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197468, XrefRangeEnd = 197472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDRemote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00072640 File Offset: 0x00070840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197472, XrefRangeEnd = 197476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDRemote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_CloseP2PChannelWithUser_Public_Static_Boolean_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0007268C File Offset: 0x0007088C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197476, XrefRangeEnd = 197480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDRemote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pConnectionState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_GetP2PSessionState_Public_Static_Boolean_CSteamID_byref_P2PSessionState_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000726D8 File Offset: 0x000708D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197480, XrefRangeEnd = 197484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowP2PPacketRelay(bool bAllow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAllow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00072718 File Offset: 0x00070918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197484, XrefRangeEnd = 197488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nVirtualP2PPort;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowUseOfPacketRelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_CreateListenSocket_Public_Static_SNetListenSocket_t_Int32_SteamIPAddress_t_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00072780 File Offset: 0x00070980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197488, XrefRangeEnd = 197492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDTarget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nVirtualPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTimeoutSec;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowUseOfPacketRelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_CreateP2PConnectionSocket_Public_Static_SNetSocket_t_CSteamID_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x000727E8 File Offset: 0x000709E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197492, XrefRangeEnd = 197496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTimeoutSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_CreateConnectionSocket_Public_Static_SNetSocket_t_SteamIPAddress_t_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00072844 File Offset: 0x00070A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197496, XrefRangeEnd = 197500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bNotifyRemoteEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_DestroySocket_Public_Static_Boolean_SNetSocket_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00072890 File Offset: 0x00070A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197500, XrefRangeEnd = 197504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bNotifyRemoteEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_DestroyListenSocket_Public_Static_Boolean_SNetListenSocket_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x000728DC File Offset: 0x00070ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197504, XrefRangeEnd = 197508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendDataOnSocket(SNetSocket_t hSocket, Il2CppStructArray<byte> pubData, uint cubData, bool bReliable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReliable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_SendDataOnSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00072948 File Offset: 0x00070B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197508, XrefRangeEnd = 197512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubMsgSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_IsDataAvailableOnSocket_Public_Static_Boolean_SNetSocket_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00072994 File Offset: 0x00070B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197512, XrefRangeEnd = 197516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RetrieveDataFromSocket(SNetSocket_t hSocket, Il2CppStructArray<byte> pubDest, uint cubDest, out uint pcubMsgSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubDest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubMsgSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_RetrieveDataFromSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00072A00 File Offset: 0x00070C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197516, XrefRangeEnd = 197520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hListenSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubMsgSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &phSocket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_IsDataAvailable_Public_Static_Boolean_SNetListenSocket_t_byref_UInt32_byref_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00072A5C File Offset: 0x00070C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197520, XrefRangeEnd = 197524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RetrieveData(SNetListenSocket_t hListenSocket, Il2CppStructArray<byte> pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hListenSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubDest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubMsgSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &phSocket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_RetrieveData_Public_Static_Boolean_SNetListenSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00072AD8 File Offset: 0x00070CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197524, XrefRangeEnd = 197528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDRemote;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peSocketStatus;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punIPRemote;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punPortRemote;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_GetSocketInfo_Public_Static_Boolean_SNetSocket_t_byref_CSteamID_byref_Int32_byref_SteamIPAddress_t_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00072B50 File Offset: 0x00070D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197528, XrefRangeEnd = 197532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hListenSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_GetListenSocketInfo_Public_Static_Boolean_SNetListenSocket_t_byref_SteamIPAddress_t_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00072BAC File Offset: 0x00070DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197532, XrefRangeEnd = 197536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_GetSocketConnectionType_Public_Static_ESNetSocketConnectionType_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00072BEC File Offset: 0x00070DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197536, XrefRangeEnd = 197540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworking.NativeMethodInfoPtr_GetMaxPacketSize_Public_Static_Int32_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0000BA42 File Offset: 0x00009C42
		public SteamGameServerNetworking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_UInt32_EP2PSend_Int32_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_CSteamID_Int32_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_CSteamID_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_CSteamID_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_CloseP2PChannelWithUser_Public_Static_Boolean_CSteamID_Int32_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_GetP2PSessionState_Public_Static_Boolean_CSteamID_byref_P2PSessionState_t_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocket_Public_Static_SNetListenSocket_t_Int32_SteamIPAddress_t_UInt16_Boolean_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_CreateP2PConnectionSocket_Public_Static_SNetSocket_t_CSteamID_Int32_Int32_Boolean_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_CreateConnectionSocket_Public_Static_SNetSocket_t_SteamIPAddress_t_UInt16_Int32_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_DestroySocket_Public_Static_Boolean_SNetSocket_t_Boolean_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_DestroyListenSocket_Public_Static_Boolean_SNetListenSocket_t_Boolean_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_SendDataOnSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_IsDataAvailableOnSocket_Public_Static_Boolean_SNetSocket_t_byref_UInt32_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveDataFromSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_IsDataAvailable_Public_Static_Boolean_SNetListenSocket_t_byref_UInt32_byref_SNetSocket_t_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveData_Public_Static_Boolean_SNetListenSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_SNetSocket_t_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketInfo_Public_Static_Boolean_SNetSocket_t_byref_CSteamID_byref_Int32_byref_SteamIPAddress_t_byref_UInt16_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_GetListenSocketInfo_Public_Static_Boolean_SNetListenSocket_t_byref_SteamIPAddress_t_byref_UInt16_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketConnectionType_Public_Static_ESNetSocketConnectionType_SNetSocket_t_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxPacketSize_Public_Static_Int32_SNetSocket_t_0;
	}
}
