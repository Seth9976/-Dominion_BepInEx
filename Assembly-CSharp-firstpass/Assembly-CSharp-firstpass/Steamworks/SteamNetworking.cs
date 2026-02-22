using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000162 RID: 354
	public static class SteamNetworking : Object
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x0007D7F0 File Offset: 0x0007B9F0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworking()
		{
			Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr);
			SteamNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_UInt32_EP2PSend_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667036);
			SteamNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667037);
			SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667038);
			SteamNetworking.NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667039);
			SteamNetworking.NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667040);
			SteamNetworking.NativeMethodInfoPtr_CloseP2PChannelWithUser_Public_Static_Boolean_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667041);
			SteamNetworking.NativeMethodInfoPtr_GetP2PSessionState_Public_Static_Boolean_CSteamID_byref_P2PSessionState_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667042);
			SteamNetworking.NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667043);
			SteamNetworking.NativeMethodInfoPtr_CreateListenSocket_Public_Static_SNetListenSocket_t_Int32_SteamIPAddress_t_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667044);
			SteamNetworking.NativeMethodInfoPtr_CreateP2PConnectionSocket_Public_Static_SNetSocket_t_CSteamID_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667045);
			SteamNetworking.NativeMethodInfoPtr_CreateConnectionSocket_Public_Static_SNetSocket_t_SteamIPAddress_t_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667046);
			SteamNetworking.NativeMethodInfoPtr_DestroySocket_Public_Static_Boolean_SNetSocket_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667047);
			SteamNetworking.NativeMethodInfoPtr_DestroyListenSocket_Public_Static_Boolean_SNetListenSocket_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667048);
			SteamNetworking.NativeMethodInfoPtr_SendDataOnSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667049);
			SteamNetworking.NativeMethodInfoPtr_IsDataAvailableOnSocket_Public_Static_Boolean_SNetSocket_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667050);
			SteamNetworking.NativeMethodInfoPtr_RetrieveDataFromSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667051);
			SteamNetworking.NativeMethodInfoPtr_IsDataAvailable_Public_Static_Boolean_SNetListenSocket_t_byref_UInt32_byref_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667052);
			SteamNetworking.NativeMethodInfoPtr_RetrieveData_Public_Static_Boolean_SNetListenSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667053);
			SteamNetworking.NativeMethodInfoPtr_GetSocketInfo_Public_Static_Boolean_SNetSocket_t_byref_CSteamID_byref_Int32_byref_SteamIPAddress_t_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667054);
			SteamNetworking.NativeMethodInfoPtr_GetListenSocketInfo_Public_Static_Boolean_SNetListenSocket_t_byref_SteamIPAddress_t_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667055);
			SteamNetworking.NativeMethodInfoPtr_GetSocketConnectionType_Public_Static_ESNetSocketConnectionType_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667056);
			SteamNetworking.NativeMethodInfoPtr_GetMaxPacketSize_Public_Static_Int32_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100667057);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0007D9D8 File Offset: 0x0007BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200588, XrefRangeEnd = 200592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_UInt32_EP2PSend_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0007DA54 File Offset: 0x0007BC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200592, XrefRangeEnd = 200596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0007DAA0 File Offset: 0x0007BCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200596, XrefRangeEnd = 200600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0007DB1C File Offset: 0x0007BD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200600, XrefRangeEnd = 200604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDRemote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0007DB5C File Offset: 0x0007BD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200604, XrefRangeEnd = 200608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDRemote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0007DB9C File Offset: 0x0007BD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200608, XrefRangeEnd = 200612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_CloseP2PChannelWithUser_Public_Static_Boolean_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0007DBE8 File Offset: 0x0007BDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200612, XrefRangeEnd = 200616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_GetP2PSessionState_Public_Static_Boolean_CSteamID_byref_P2PSessionState_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0007DC34 File Offset: 0x0007BE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200616, XrefRangeEnd = 200620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowP2PPacketRelay(bool bAllow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAllow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0007DC74 File Offset: 0x0007BE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200620, XrefRangeEnd = 200625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_CreateListenSocket_Public_Static_SNetListenSocket_t_Int32_SteamIPAddress_t_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0007DCDC File Offset: 0x0007BEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200625, XrefRangeEnd = 200630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_CreateP2PConnectionSocket_Public_Static_SNetSocket_t_CSteamID_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0007DD44 File Offset: 0x0007BF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200630, XrefRangeEnd = 200635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_CreateConnectionSocket_Public_Static_SNetSocket_t_SteamIPAddress_t_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200635, XrefRangeEnd = 200639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_DestroySocket_Public_Static_Boolean_SNetSocket_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0007DDEC File Offset: 0x0007BFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200639, XrefRangeEnd = 200643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_DestroyListenSocket_Public_Static_Boolean_SNetListenSocket_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0007DE38 File Offset: 0x0007C038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200643, XrefRangeEnd = 200647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_SendDataOnSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0007DEA4 File Offset: 0x0007C0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200647, XrefRangeEnd = 200651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_IsDataAvailableOnSocket_Public_Static_Boolean_SNetSocket_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0007DEF0 File Offset: 0x0007C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200651, XrefRangeEnd = 200655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_RetrieveDataFromSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0007DF5C File Offset: 0x0007C15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200655, XrefRangeEnd = 200659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_IsDataAvailable_Public_Static_Boolean_SNetListenSocket_t_byref_UInt32_byref_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0007DFB8 File Offset: 0x0007C1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200659, XrefRangeEnd = 200663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_RetrieveData_Public_Static_Boolean_SNetListenSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0007E034 File Offset: 0x0007C234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200663, XrefRangeEnd = 200667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_GetSocketInfo_Public_Static_Boolean_SNetSocket_t_byref_CSteamID_byref_Int32_byref_SteamIPAddress_t_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0007E0AC File Offset: 0x0007C2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200667, XrefRangeEnd = 200671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_GetListenSocketInfo_Public_Static_Boolean_SNetListenSocket_t_byref_SteamIPAddress_t_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0007E108 File Offset: 0x0007C308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200671, XrefRangeEnd = 200675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_GetSocketConnectionType_Public_Static_ESNetSocketConnectionType_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0007E148 File Offset: 0x0007C348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200675, XrefRangeEnd = 200679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_GetMaxPacketSize_Public_Static_Int32_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0000BAD2 File Offset: 0x00009CD2
		public SteamNetworking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_UInt32_EP2PSend_Int32_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_CSteamID_Int32_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_CSteamID_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_CSteamID_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_CloseP2PChannelWithUser_Public_Static_Boolean_CSteamID_Int32_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_GetP2PSessionState_Public_Static_Boolean_CSteamID_byref_P2PSessionState_t_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocket_Public_Static_SNetListenSocket_t_Int32_SteamIPAddress_t_UInt16_Boolean_0;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_CreateP2PConnectionSocket_Public_Static_SNetSocket_t_CSteamID_Int32_Int32_Boolean_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_CreateConnectionSocket_Public_Static_SNetSocket_t_SteamIPAddress_t_UInt16_Int32_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_DestroySocket_Public_Static_Boolean_SNetSocket_t_Boolean_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_DestroyListenSocket_Public_Static_Boolean_SNetListenSocket_t_Boolean_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_SendDataOnSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_IsDataAvailableOnSocket_Public_Static_Boolean_SNetSocket_t_byref_UInt32_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveDataFromSocket_Public_Static_Boolean_SNetSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_IsDataAvailable_Public_Static_Boolean_SNetListenSocket_t_byref_UInt32_byref_SNetSocket_t_0;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveData_Public_Static_Boolean_SNetListenSocket_t_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_byref_SNetSocket_t_0;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketInfo_Public_Static_Boolean_SNetSocket_t_byref_CSteamID_byref_Int32_byref_SteamIPAddress_t_byref_UInt16_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_GetListenSocketInfo_Public_Static_Boolean_SNetListenSocket_t_byref_SteamIPAddress_t_byref_UInt16_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketConnectionType_Public_Static_ESNetSocketConnectionType_SNetSocket_t_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxPacketSize_Public_Static_Int32_SNetSocket_t_0;
	}
}
