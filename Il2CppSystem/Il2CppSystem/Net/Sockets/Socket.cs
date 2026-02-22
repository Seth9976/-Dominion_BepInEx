using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.NetworkInformation;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000127 RID: 295
	public class Socket : Object
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x000595D4 File Offset: 0x000577D4
		// Note: this type is marked as 'beforefieldinit'.
		static Socket()
		{
			Il2CppClassPointerStore<Socket>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "Socket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket>.NativeClassPtr);
			Socket.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_InternalSyncObject");
			Socket.NativeFieldInfoPtr_s_SupportsIPv4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv4");
			Socket.NativeFieldInfoPtr_s_SupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv6");
			Socket.NativeFieldInfoPtr_s_OSSupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_OSSupportsIPv6");
			Socket.NativeFieldInfoPtr_s_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_Initialized");
			Socket.NativeFieldInfoPtr_s_LoggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_LoggingEnabled");
			Socket.NativeFieldInfoPtr_is_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_closed");
			Socket.NativeFieldInfoPtr_is_listening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_listening");
			Socket.NativeFieldInfoPtr_useOverlappedIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "useOverlappedIO");
			Socket.NativeFieldInfoPtr_linger_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "linger_timeout");
			Socket.NativeFieldInfoPtr_addressFamily = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "addressFamily");
			Socket.NativeFieldInfoPtr_socketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "socketType");
			Socket.NativeFieldInfoPtr_protocolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "protocolType");
			Socket.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_Handle");
			Socket.NativeFieldInfoPtr_seed_endpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "seed_endpoint");
			Socket.NativeFieldInfoPtr_ReadSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReadSem");
			Socket.NativeFieldInfoPtr_WriteSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WriteSem");
			Socket.NativeFieldInfoPtr_is_blocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_blocking");
			Socket.NativeFieldInfoPtr_is_bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_bound");
			Socket.NativeFieldInfoPtr_is_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_connected");
			Socket.NativeFieldInfoPtr_m_IntCleanedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_IntCleanedUp");
			Socket.NativeFieldInfoPtr_connect_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "connect_in_progress");
			Socket.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ID");
			Socket.NativeFieldInfoPtr_AcceptAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AcceptAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginAcceptCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptCallback");
			Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptReceiveCallback");
			Socket.NativeFieldInfoPtr_ConnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ConnectAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginConnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginConnectCallback");
			Socket.NativeFieldInfoPtr_DisconnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "DisconnectAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginDisconnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginDisconnectCallback");
			Socket.NativeFieldInfoPtr_ReceiveAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveGenericCallback");
			Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveFromAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveFromCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveFromCallback");
			Socket.NativeFieldInfoPtr_SendAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginSendGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginSendGenericCallback");
			Socket.NativeFieldInfoPtr_SendToAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendToAsyncCallback");
			Socket.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666019);
			Socket.NativeMethodInfoPtr_get_SupportsIPv4_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666020);
			Socket.NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666021);
			Socket.NativeMethodInfoPtr_get_SupportsIPv6_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666022);
			Socket.NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666023);
			Socket.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666024);
			Socket.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666025);
			Socket.NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666026);
			Socket.NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666027);
			Socket.NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666028);
			Socket.NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666029);
			Socket.NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666030);
			Socket.NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666031);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666032);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666033);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666034);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666035);
			Socket.NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666036);
			Socket.NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666037);
			Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666038);
			Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666039);
			Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666040);
			Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666041);
			Socket.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666042);
			Socket.NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666043);
			Socket.NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666044);
			Socket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666045);
			Socket.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666046);
			Socket.NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666047);
			Socket.NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666048);
			Socket.NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666049);
			Socket.NativeMethodInfoPtr_SocketDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666050);
			Socket.NativeMethodInfoPtr_Socket_internal_Private_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666051);
			Socket.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666052);
			Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666053);
			Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666054);
			Socket.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666055);
			Socket.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666056);
			Socket.NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666057);
			Socket.NativeMethodInfoPtr_Blocking_internal_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666058);
			Socket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666059);
			Socket.NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666060);
			Socket.NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666061);
			Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666062);
			Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666063);
			Socket.NativeMethodInfoPtr_Accept_Public_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666064);
			Socket.NativeMethodInfoPtr_Accept_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666065);
			Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666066);
			Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666067);
			Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666068);
			Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666069);
			Socket.NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666070);
			Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666071);
			Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666072);
			Socket.NativeMethodInfoPtr_Listen_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666073);
			Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666074);
			Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666075);
			Socket.NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666076);
			Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666077);
			Socket.NativeMethodInfoPtr_BeginMConnect_Private_Static_Void_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666078);
			Socket.NativeMethodInfoPtr_BeginSConnect_Private_Static_Void_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666079);
			Socket.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666080);
			Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666081);
			Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666082);
			Socket.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666083);
			Socket.NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666084);
			Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666085);
			Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666086);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666087);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666088);
			Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666089);
			Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666090);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666091);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666092);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666093);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666094);
			Socket.NativeMethodInfoPtr_ReceiveFrom_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666095);
			Socket.NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666096);
			Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666097);
			Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666098);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666099);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666100);
			Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666101);
			Socket.NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666102);
			Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666103);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666104);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666105);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666106);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666107);
			Socket.NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666108);
			Socket.NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666109);
			Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666110);
			Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666111);
			Socket.NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666112);
			Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666113);
			Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666114);
			Socket.NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666115);
			Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666116);
			Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666117);
			Socket.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666118);
			Socket.NativeMethodInfoPtr_Close_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666119);
			Socket.NativeMethodInfoPtr_Close_internal_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666120);
			Socket.NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666121);
			Socket.NativeMethodInfoPtr_Shutdown_internal_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666122);
			Socket.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666123);
			Socket.NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666124);
			Socket.NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666125);
			Socket.NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666126);
			Socket.NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666127);
			Socket.NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666128);
			Socket.NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666129);
			Socket.NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666130);
			Socket.NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666131);
			Socket.NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666132);
			Socket.NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666133);
			Socket.NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666134);
			Socket.NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100666135);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0005A220 File Offset: 0x00058420
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56003, RefRangeEnd = 56006, XrefRangeStart = 55967, XrefRangeEnd = 56003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref addressFamily;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref protocolType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0005A284 File Offset: 0x00058484
		public unsafe static bool SupportsIPv4
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 56012, RefRangeEnd = 56013, XrefRangeStart = 56006, XrefRangeEnd = 56012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_SupportsIPv4_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0005A2B4 File Offset: 0x000584B4
		public unsafe static bool OSSupportsIPv4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56013, XrefRangeEnd = 56019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0005A2E4 File Offset: 0x000584E4
		public unsafe static bool SupportsIPv6
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 56025, RefRangeEnd = 56026, XrefRangeStart = 56019, XrefRangeEnd = 56025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_SupportsIPv6_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0005A314 File Offset: 0x00058514
		public unsafe static bool OSSupportsIPv6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56026, XrefRangeEnd = 56032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0005A344 File Offset: 0x00058544
		public unsafe IntPtr Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0005A380 File Offset: 0x00058580
		public unsafe AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0005A3BC File Offset: 0x000585BC
		public unsafe SocketType SocketType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0005A3F8 File Offset: 0x000585F8
		public unsafe ProtocolType ProtocolType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0005A434 File Offset: 0x00058634
		public unsafe bool DontFragment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56032, XrefRangeEnd = 56033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0005A474 File Offset: 0x00058674
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0005A4B0 File Offset: 0x000586B0
		public unsafe bool DualMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56033, XrefRangeEnd = 56037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56037, XrefRangeEnd = 56038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0005A4F0 File Offset: 0x000586F0
		public unsafe bool IsDualMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0005A52C File Offset: 0x0005872C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56039, RefRangeEnd = 56040, XrefRangeStart = 56038, XrefRangeEnd = 56039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0005A588 File Offset: 0x00058788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56048, RefRangeEnd = 56049, XrefRangeStart = 56040, XrefRangeEnd = 56048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0005A600 File Offset: 0x00058800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56057, RefRangeEnd = 56058, XrefRangeStart = 56049, XrefRangeEnd = 56057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0005A678 File Offset: 0x00058878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56059, RefRangeEnd = 56060, XrefRangeStart = 56058, XrefRangeEnd = 56059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0005A6D4 File Offset: 0x000588D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56060, XrefRangeEnd = 56064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IOControl(IOControlCode ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ioControlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionInValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionOutValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0005A744 File Offset: 0x00058944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56064, XrefRangeEnd = 56065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIPProtectionLevel(IPProtectionLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0005A784 File Offset: 0x00058984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56066, RefRangeEnd = 56067, XrefRangeStart = 56065, XrefRangeEnd = 56066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0005A824 File Offset: 0x00058A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56078, RefRangeEnd = 56080, XrefRangeStart = 56067, XrefRangeEnd = 56078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSend(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0005A874 File Offset: 0x00058A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56097, RefRangeEnd = 56098, XrefRangeStart = 56080, XrefRangeEnd = 56097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0005A914 File Offset: 0x00058B14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56109, RefRangeEnd = 56111, XrefRangeStart = 56098, XrefRangeEnd = 56109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceive(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0005A964 File Offset: 0x00058B64
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56111, XrefRangeEnd = 56126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x0005A998 File Offset: 0x00058B98
		public unsafe bool CleanedUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 56126, RefRangeEnd = 56127, XrefRangeStart = 56126, XrefRangeEnd = 56126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0005A9D4 File Offset: 0x00058BD4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 56188, RefRangeEnd = 56197, XrefRangeStart = 56127, XrefRangeEnd = 56188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSockets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0005A9FC File Offset: 0x00058BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56201, RefRangeEnd = 56202, XrefRangeStart = 56197, XrefRangeEnd = 56201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0005AA30 File Offset: 0x00058C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Socket.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0005AA6C File Offset: 0x00058C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56206, RefRangeEnd = 56207, XrefRangeStart = 56202, XrefRangeEnd = 56206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalShutdown(SocketShutdown how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0005AAAC File Offset: 0x00058CAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56212, RefRangeEnd = 56215, XrefRangeStart = 56207, XrefRangeEnd = 56212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0005AB14 File Offset: 0x00058D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56227, RefRangeEnd = 56228, XrefRangeStart = 56215, XrefRangeEnd = 56227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proto;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(safe_handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0005AB8C File Offset: 0x00058D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56230, RefRangeEnd = 56231, XrefRangeStart = 56228, XrefRangeEnd = 56230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SocketDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SocketDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0005ABC0 File Offset: 0x00058DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56231, XrefRangeEnd = 56232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proto;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Socket_internal_Private_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0005AC34 File Offset: 0x00058E34
		public unsafe EndPoint LocalEndPoint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 56237, RefRangeEnd = 56239, XrefRangeStart = 56232, XrefRangeEnd = 56237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0005AC74 File Offset: 0x00058E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56246, RefRangeEnd = 56247, XrefRangeStart = 56239, XrefRangeEnd = 56246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0005ACD4 File Offset: 0x00058ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56247, XrefRangeEnd = 56248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0005AD30 File Offset: 0x00058F30
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x0005AD6C File Offset: 0x00058F6C
		public unsafe bool Blocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 56253, RefRangeEnd = 56255, XrefRangeStart = 56248, XrefRangeEnd = 56253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0005ADAC File Offset: 0x00058FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56262, RefRangeEnd = 56263, XrefRangeStart = 56255, XrefRangeEnd = 56262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref block;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0005AE00 File Offset: 0x00059000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56264, RefRangeEnd = 56265, XrefRangeStart = 56263, XrefRangeEnd = 56264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blocking_internal(IntPtr socket, bool block, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref block;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Blocking_internal_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0005AE50 File Offset: 0x00059050
		public unsafe bool Connected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x0005AE8C File Offset: 0x0005908C
		public unsafe bool NoDelay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56265, XrefRangeEnd = 56267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0005AECC File Offset: 0x000590CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56276, RefRangeEnd = 56278, XrefRangeStart = 56267, XrefRangeEnd = 56276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Poll(int microSeconds, SelectMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref microSeconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0005AF24 File Offset: 0x00059124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56285, RefRangeEnd = 56286, XrefRangeStart = 56278, XrefRangeEnd = 56285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0005AF90 File Offset: 0x00059190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56286, XrefRangeEnd = 56287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0005AFF8 File Offset: 0x000591F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56307, RefRangeEnd = 56310, XrefRangeStart = 56287, XrefRangeEnd = 56307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket Accept()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_Public_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0005B038 File Offset: 0x00059238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56316, RefRangeEnd = 56318, XrefRangeStart = 56310, XrefRangeEnd = 56316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Accept(Socket acceptSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptSocket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0005B07C File Offset: 0x0005927C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56326, RefRangeEnd = 56327, XrefRangeStart = 56318, XrefRangeEnd = 56326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket EndAccept(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0005B0CC File Offset: 0x000592CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56327, XrefRangeEnd = 56335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket EndAccept(out Il2CppStructArray<byte> buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesTransferred;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr5) : null;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0005B150 File Offset: 0x00059350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56347, RefRangeEnd = 56349, XrefRangeStart = 56335, XrefRangeEnd = 56347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr3) : null;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0005B1B0 File Offset: 0x000593B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56349, XrefRangeEnd = 56350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0005B20C File Offset: 0x0005940C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56359, RefRangeEnd = 56360, XrefRangeStart = 56350, XrefRangeEnd = 56359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(EndPoint localEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localEP);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0005B250 File Offset: 0x00059450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56367, RefRangeEnd = 56369, XrefRangeStart = 56360, XrefRangeEnd = 56367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0005B2A8 File Offset: 0x000594A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56369, XrefRangeEnd = 56370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Bind_internal(IntPtr sock, SocketAddress sa, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0005B2FC File Offset: 0x000594FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56375, RefRangeEnd = 56376, XrefRangeStart = 56370, XrefRangeEnd = 56375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Listen(int backlog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref backlog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0005B33C File Offset: 0x0005953C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56383, RefRangeEnd = 56384, XrefRangeStart = 56376, XrefRangeEnd = 56383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backlog;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0005B390 File Offset: 0x00059590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56384, XrefRangeEnd = 56385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Listen_internal(IntPtr sock, int backlog, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backlog;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0005B3E0 File Offset: 0x000595E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56408, RefRangeEnd = 56410, XrefRangeStart = 56385, XrefRangeEnd = 56408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(EndPoint remoteEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0005B424 File Offset: 0x00059624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56419, RefRangeEnd = 56420, XrefRangeStart = 56410, XrefRangeEnd = 56419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0005B498 File Offset: 0x00059698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56430, RefRangeEnd = 56431, XrefRangeStart = 56420, XrefRangeEnd = 56430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginMConnect(SocketAsyncResult sockares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginMConnect_Private_Static_Void_SocketAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0005B4D0 File Offset: 0x000596D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56458, RefRangeEnd = 56460, XrefRangeStart = 56431, XrefRangeEnd = 56458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSConnect(SocketAsyncResult sockares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSConnect_Private_Static_Void_SocketAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0005B508 File Offset: 0x00059708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56469, RefRangeEnd = 56471, XrefRangeStart = 56460, XrefRangeEnd = 56469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndConnect(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0005B54C File Offset: 0x0005974C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56479, RefRangeEnd = 56480, XrefRangeStart = 56471, XrefRangeEnd = 56479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0005B5B0 File Offset: 0x000597B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56480, XrefRangeEnd = 56481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0005B610 File Offset: 0x00059810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56486, RefRangeEnd = 56487, XrefRangeStart = 56481, XrefRangeEnd = 56486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect(bool reuseSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reuseSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0005B650 File Offset: 0x00059850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56496, RefRangeEnd = 56497, XrefRangeStart = 56487, XrefRangeEnd = 56496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDisconnect(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0005B694 File Offset: 0x00059894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56504, RefRangeEnd = 56505, XrefRangeStart = 56497, XrefRangeEnd = 56504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reuse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0005B6E8 File Offset: 0x000598E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56505, XrefRangeEnd = 56506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect_internal(IntPtr sock, bool reuse, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reuse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_IntPtr_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0005B738 File Offset: 0x00059938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56513, RefRangeEnd = 56514, XrefRangeStart = 56506, XrefRangeEnd = 56513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0005B7C0 File Offset: 0x000599C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56552, RefRangeEnd = 56553, XrefRangeStart = 56514, XrefRangeEnd = 56552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0005B82C File Offset: 0x00059A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56553, XrefRangeEnd = 56570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0005B8DC File Offset: 0x00059ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56570, XrefRangeEnd = 56582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0005B938 File Offset: 0x00059B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56590, RefRangeEnd = 56591, XrefRangeStart = 56582, XrefRangeEnd = 56590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0005B9C0 File Offset: 0x00059BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56591, XrefRangeEnd = 56592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0005BA44 File Offset: 0x00059C44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56600, RefRangeEnd = 56603, XrefRangeStart = 56592, XrefRangeEnd = 56600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0005BACC File Offset: 0x00059CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56603, XrefRangeEnd = 56604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0005BB50 File Offset: 0x00059D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56609, RefRangeEnd = 56610, XrefRangeStart = 56604, XrefRangeEnd = 56609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReceiveFrom(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			remoteEP = ((intPtr4 == 0) ? null : new EndPoint(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0005BC04 File Offset: 0x00059E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56618, RefRangeEnd = 56619, XrefRangeStart = 56610, XrefRangeEnd = 56618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			endPoint = ((intPtr4 == 0) ? null : new EndPoint(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0005BC7C File Offset: 0x00059E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56627, RefRangeEnd = 56628, XrefRangeStart = 56619, XrefRangeEnd = 56627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sockaddr);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sockaddr = ((intPtr4 == 0) ? null : new SocketAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0005BD30 File Offset: 0x00059F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56628, XrefRangeEnd = 56629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sockaddr);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sockaddr = ((intPtr4 == 0) ? null : new SocketAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0005BDE0 File Offset: 0x00059FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56629, XrefRangeEnd = 56636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0005BE68 File Offset: 0x0005A068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56674, RefRangeEnd = 56675, XrefRangeStart = 56636, XrefRangeEnd = 56674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0005BED4 File Offset: 0x0005A0D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56701, RefRangeEnd = 56702, XrefRangeStart = 56675, XrefRangeEnd = 56701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0005BF84 File Offset: 0x0005A184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56715, RefRangeEnd = 56717, XrefRangeStart = 56702, XrefRangeEnd = 56715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sent_so_far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0005BFC8 File Offset: 0x0005A1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56717, XrefRangeEnd = 56729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0005C024 File Offset: 0x0005A224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56737, RefRangeEnd = 56738, XrefRangeStart = 56729, XrefRangeEnd = 56737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0005C0AC File Offset: 0x0005A2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56738, XrefRangeEnd = 56739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0005C130 File Offset: 0x0005A330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56747, RefRangeEnd = 56750, XrefRangeStart = 56739, XrefRangeEnd = 56747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0005C1B8 File Offset: 0x0005A3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56750, XrefRangeEnd = 56751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0005C23C File Offset: 0x0005A43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56759, RefRangeEnd = 56760, XrefRangeStart = 56751, XrefRangeEnd = 56759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSendTo(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0005C28C File Offset: 0x0005A48C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 56772, RefRangeEnd = 56778, XrefRangeStart = 56760, XrefRangeEnd = 56772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005C2E8 File Offset: 0x0005A4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56785, RefRangeEnd = 56786, XrefRangeStart = 56778, XrefRangeEnd = 56785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj_val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0005C36C File Offset: 0x0005A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56786, XrefRangeEnd = 56787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj_val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0005C3EC File Offset: 0x0005A5EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 56793, RefRangeEnd = 56799, XrefRangeStart = 56787, XrefRangeEnd = 56793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0005C448 File Offset: 0x0005A648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56806, RefRangeEnd = 56808, XrefRangeStart = 56799, XrefRangeEnd = 56806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj_val);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byte_val);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref int_val;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005C4DC File Offset: 0x0005A6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56808, XrefRangeEnd = 56809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj_val);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byte_val);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref int_val;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0005C56C File Offset: 0x0005A76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56809, XrefRangeEnd = 56813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IOControl(int ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ioControlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionInValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionOutValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0005C5DC File Offset: 0x0005A7DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56820, RefRangeEnd = 56823, XrefRangeStart = 56813, XrefRangeEnd = 56820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ioctl_code;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0005C660 File Offset: 0x0005A860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56823, XrefRangeEnd = 56824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IOControl_internal(IntPtr sock, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ioctl_code;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0005C6E0 File Offset: 0x0005A8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56828, RefRangeEnd = 56829, XrefRangeStart = 56824, XrefRangeEnd = 56828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0005C714 File Offset: 0x0005A914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56833, RefRangeEnd = 56834, XrefRangeStart = 56829, XrefRangeEnd = 56833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0005C754 File Offset: 0x0005A954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56835, RefRangeEnd = 56836, XrefRangeStart = 56834, XrefRangeEnd = 56835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Close_internal(IntPtr socket, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_internal_Internal_Static_Void_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0005C794 File Offset: 0x0005A994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56843, RefRangeEnd = 56844, XrefRangeStart = 56836, XrefRangeEnd = 56843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref how;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0005C7E8 File Offset: 0x0005A9E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56845, RefRangeEnd = 56846, XrefRangeStart = 56844, XrefRangeEnd = 56845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref how;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_internal_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0005C838 File Offset: 0x0005AA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56846, XrefRangeEnd = 56861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Socket.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0005C884 File Offset: 0x0005AA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56861, XrefRangeEnd = 56875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Linger(IntPtr handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0005C8C4 File Offset: 0x0005AAC4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 56875, RefRangeEnd = 56908, XrefRangeStart = 56875, XrefRangeEnd = 56875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposedAndClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		[CallerCount(0)]
		public unsafe void ThrowIfBufferNull(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0005C93C File Offset: 0x0005AB3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 56908, RefRangeEnd = 56915, XrefRangeStart = 56908, XrefRangeEnd = 56908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfBufferOutOfRange(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0005C99C File Offset: 0x0005AB9C
		[CallerCount(0)]
		public unsafe void ThrowIfUdp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0005C9D0 File Offset: 0x0005ABD0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 56918, RefRangeEnd = 56928, XrefRangeStart = 56915, XrefRangeEnd = 56918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0005CA44 File Offset: 0x0005AC44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56943, RefRangeEnd = 56946, XrefRangeStart = 56928, XrefRangeEnd = 56943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(job);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0005CAA8 File Offset: 0x0005ACA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 56955, RefRangeEnd = 56959, XrefRangeStart = 56946, XrefRangeEnd = 56955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56960, RefRangeEnd = 56961, XrefRangeStart = 56959, XrefRangeEnd = 56960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void cancel_blocking_socket_operation(Thread thread)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0005CB30 File Offset: 0x0005AD30
		public unsafe static int FamilyHint
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 56981, RefRangeEnd = 56985, XrefRangeStart = 56961, XrefRangeEnd = 56981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0005CB60 File Offset: 0x0005AD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56985, XrefRangeEnd = 56986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref networkInterface;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0005CBA0 File Offset: 0x0005ADA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56986, XrefRangeEnd = 56990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref networkInterface;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00009FA8 File Offset: 0x000081A8
		public Socket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0005CBE0 File Offset: 0x0005ADE0
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x00009FB1 File Offset: 0x000081B1
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0005CC08 File Offset: 0x0005AE08
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00009FC3 File Offset: 0x000081C3
		public unsafe static bool s_SupportsIPv4
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0005CC24 File Offset: 0x0005AE24
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00009FD1 File Offset: 0x000081D1
		public unsafe static bool s_SupportsIPv6
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&value));
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0005CC40 File Offset: 0x0005AE40
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x00009FDF File Offset: 0x000081DF
		public unsafe static bool s_OSSupportsIPv6
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&value));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0005CC5C File Offset: 0x0005AE5C
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x00009FED File Offset: 0x000081ED
		public unsafe static bool s_Initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_Initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_Initialized, (void*)(&value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0005CC78 File Offset: 0x0005AE78
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x00009FFB File Offset: 0x000081FB
		public unsafe static bool s_LoggingEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0005CC94 File Offset: 0x0005AE94
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0000A009 File Offset: 0x00008209
		public unsafe bool is_closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_closed)) = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0005CCBC File Offset: 0x0005AEBC
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0000A024 File Offset: 0x00008224
		public unsafe bool is_listening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_listening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_listening)) = value;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0005CCE4 File Offset: 0x0005AEE4
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0000A03F File Offset: 0x0000823F
		public unsafe bool useOverlappedIO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_useOverlappedIO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_useOverlappedIO)) = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0005CD0C File Offset: 0x0005AF0C
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0000A05A File Offset: 0x0000825A
		public unsafe int linger_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_linger_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_linger_timeout)) = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0005CD34 File Offset: 0x0005AF34
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x0000A075 File Offset: 0x00008275
		public unsafe AddressFamily addressFamily
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_addressFamily);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_addressFamily)) = value;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0005CD5C File Offset: 0x0005AF5C
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0000A090 File Offset: 0x00008290
		public unsafe SocketType socketType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_socketType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_socketType)) = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0005CD84 File Offset: 0x0005AF84
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0000A0AB File Offset: 0x000082AB
		public unsafe ProtocolType protocolType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_protocolType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_protocolType)) = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0005CDAC File Offset: 0x0005AFAC
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x0000A0C6 File Offset: 0x000082C6
		public unsafe SafeSocketHandle m_Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0005CDDC File Offset: 0x0005AFDC
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0000A0E5 File Offset: 0x000082E5
		public unsafe EndPoint seed_endpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_seed_endpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_seed_endpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0005CE0C File Offset: 0x0005B00C
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0000A104 File Offset: 0x00008304
		public unsafe SemaphoreSlim ReadSem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ReadSem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ReadSem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0005CE3C File Offset: 0x0005B03C
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x0000A123 File Offset: 0x00008323
		public unsafe SemaphoreSlim WriteSem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_WriteSem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_WriteSem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0005CE6C File Offset: 0x0005B06C
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x0000A142 File Offset: 0x00008342
		public unsafe bool is_blocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_blocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_blocking)) = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0005CE94 File Offset: 0x0005B094
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x0000A15D File Offset: 0x0000835D
		public unsafe bool is_bound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_bound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_bound)) = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0005CEBC File Offset: 0x0005B0BC
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x0000A178 File Offset: 0x00008378
		public unsafe bool is_connected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_connected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_connected)) = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0005CEE4 File Offset: 0x0005B0E4
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0000A193 File Offset: 0x00008393
		public unsafe int m_IntCleanedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_IntCleanedUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_IntCleanedUp)) = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0005CF0C File Offset: 0x0005B10C
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0000A1AE File Offset: 0x000083AE
		public unsafe bool connect_in_progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_connect_in_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_connect_in_progress)) = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0005CF34 File Offset: 0x0005B134
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0005CF5C File Offset: 0x0005B15C
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public unsafe static AsyncCallback AcceptAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_AcceptAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_AcceptAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0005CF84 File Offset: 0x0005B184
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x0000A1F6 File Offset: 0x000083F6
		public unsafe static IOAsyncCallback BeginAcceptCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginAcceptCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginAcceptCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0005CFAC File Offset: 0x0005B1AC
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0000A208 File Offset: 0x00008408
		public unsafe static IOAsyncCallback BeginAcceptReceiveCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0005CFD4 File Offset: 0x0005B1D4
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0000A21A File Offset: 0x0000841A
		public unsafe static AsyncCallback ConnectAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ConnectAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ConnectAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0005CFFC File Offset: 0x0005B1FC
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x0000A22C File Offset: 0x0000842C
		public unsafe static IOAsyncCallback BeginConnectCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginConnectCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginConnectCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0005D024 File Offset: 0x0005B224
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x0000A23E File Offset: 0x0000843E
		public unsafe static AsyncCallback DisconnectAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_DisconnectAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_DisconnectAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0005D04C File Offset: 0x0005B24C
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x0000A250 File Offset: 0x00008450
		public unsafe static IOAsyncCallback BeginDisconnectCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginDisconnectCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginDisconnectCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0005D074 File Offset: 0x0005B274
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x0000A262 File Offset: 0x00008462
		public unsafe static AsyncCallback ReceiveAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ReceiveAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ReceiveAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0005D09C File Offset: 0x0005B29C
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0000A274 File Offset: 0x00008474
		public unsafe static IOAsyncCallback BeginReceiveCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0005D0C4 File Offset: 0x0005B2C4
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x0000A286 File Offset: 0x00008486
		public unsafe static IOAsyncCallback BeginReceiveGenericCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0005D0EC File Offset: 0x0005B2EC
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x0000A298 File Offset: 0x00008498
		public unsafe static AsyncCallback ReceiveFromAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0005D114 File Offset: 0x0005B314
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0000A2AA File Offset: 0x000084AA
		public unsafe static IOAsyncCallback BeginReceiveFromCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveFromCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveFromCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0005D13C File Offset: 0x0005B33C
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0000A2BC File Offset: 0x000084BC
		public unsafe static AsyncCallback SendAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SendAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SendAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0005D164 File Offset: 0x0005B364
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0000A2CE File Offset: 0x000084CE
		public unsafe static IOAsyncCallback BeginSendGenericCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginSendGenericCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginSendGenericCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0005D18C File Offset: 0x0005B38C
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public unsafe static AsyncCallback SendToAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SendToAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SendToAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportsIPv4;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportsIPv6;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeFieldInfoPtr_s_OSSupportsIPv6;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeFieldInfoPtr_s_Initialized;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr_s_LoggingEnabled;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeFieldInfoPtr_is_closed;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr_is_listening;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr_useOverlappedIO;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeFieldInfoPtr_linger_timeout;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeFieldInfoPtr_addressFamily;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeFieldInfoPtr_socketType;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeFieldInfoPtr_protocolType;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeFieldInfoPtr_seed_endpoint;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeFieldInfoPtr_ReadSem;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeFieldInfoPtr_WriteSem;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeFieldInfoPtr_is_blocking;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeFieldInfoPtr_is_bound;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeFieldInfoPtr_is_connected;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeFieldInfoPtr_m_IntCleanedUp;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeFieldInfoPtr_connect_in_progress;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeFieldInfoPtr_AcceptAsyncCallback;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeFieldInfoPtr_BeginAcceptCallback;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeFieldInfoPtr_BeginAcceptReceiveCallback;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeFieldInfoPtr_ConnectAsyncCallback;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeFieldInfoPtr_BeginConnectCallback;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeFieldInfoPtr_DisconnectAsyncCallback;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeFieldInfoPtr_BeginDisconnectCallback;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeFieldInfoPtr_ReceiveAsyncCallback;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveCallback;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveGenericCallback;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeFieldInfoPtr_ReceiveFromAsyncCallback;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveFromCallback;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeFieldInfoPtr_SendAsyncCallback;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeFieldInfoPtr_BeginSendGenericCallback;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr_SendToAsyncCallback;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsIPv4_Public_Static_get_Boolean_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsIPv6_Public_Static_get_Boolean_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_SocketDefaults_Private_Void_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_Socket_internal_Private_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_Blocking_internal_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Public_Socket_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Internal_Void_Socket_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_Accept_internal_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_Bind_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Void_Int32_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_Listen_internal_Private_Static_Void_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_BeginMConnect_Private_Static_Void_SocketAsyncResult_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_BeginSConnect_Private_Static_Void_SocketAsyncResult_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_Connect_internal_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_IntPtr_Boolean_byref_Int32_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Int32_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Internal_Static_Void_IntPtr_byref_Int32_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_internal_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0;

		// Token: 0x020001EC RID: 492
		[StructLayout(2)]
		public struct WSABUF
		{
			// Token: 0x06001BE1 RID: 7137 RVA: 0x00071800 File Offset: 0x0006FA00
			// Note: this type is marked as 'beforefieldinit'.
			static WSABUF()
			{
				Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WSABUF");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr);
				Socket.WSABUF.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, "len");
				Socket.WSABUF.NativeFieldInfoPtr_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, "buf");
			}

			// Token: 0x06001BE2 RID: 7138 RVA: 0x0000FA01 File Offset: 0x0000DC01
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, ref this));
			}

			// Token: 0x04001533 RID: 5427
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x04001534 RID: 5428
			private static readonly IntPtr NativeFieldInfoPtr_buf;

			// Token: 0x04001535 RID: 5429
			[FieldOffset(0)]
			public int len;

			// Token: 0x04001536 RID: 5430
			[FieldOffset(8)]
			public IntPtr buf;
		}

		// Token: 0x020001ED RID: 493
		[ObfuscatedName("System.Net.Sockets.Socket+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001BE3 RID: 7139 RVA: 0x00071854 File Offset: 0x0006FA54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Socket.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr);
				Socket.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9");
				Socket.__c.NativeFieldInfoPtr___9__242_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__242_0");
				Socket.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666138);
				Socket.__c.NativeMethodInfoPtr__BeginSend_b__242_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666139);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666140);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_1_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666141);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_2_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666142);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_3_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666143);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_4_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666144);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_5_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666145);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_6_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666146);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_7_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666147);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_8_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666148);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_9_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666149);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_10_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666150);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_11_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666151);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_12_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666152);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_13_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666153);
				Socket.__c.NativeMethodInfoPtr___cctor_b__310_14_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100666154);
			}

			// Token: 0x06001BE4 RID: 7140 RVA: 0x000719FC File Offset: 0x0006FBFC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BE5 RID: 7141 RVA: 0x00071A38 File Offset: 0x0006FC38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55772, XrefRangeEnd = 55779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSend_b__242_0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__BeginSend_b__242_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BE6 RID: 7142 RVA: 0x00071A7C File Offset: 0x0006FC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55779, XrefRangeEnd = 55795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_0(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BE7 RID: 7143 RVA: 0x00071AC0 File Offset: 0x0006FCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55795, XrefRangeEnd = 55801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_1(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_1_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BE8 RID: 7144 RVA: 0x00071B04 File Offset: 0x0006FD04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55801, XrefRangeEnd = 55815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_2(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_2_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BE9 RID: 7145 RVA: 0x00071B48 File Offset: 0x0006FD48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55815, XrefRangeEnd = 55830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_3(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_3_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BEA RID: 7146 RVA: 0x00071B8C File Offset: 0x0006FD8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55830, XrefRangeEnd = 55855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_4(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_4_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BEB RID: 7147 RVA: 0x00071BD0 File Offset: 0x0006FDD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55855, XrefRangeEnd = 55870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_5(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_5_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BEC RID: 7148 RVA: 0x00071C14 File Offset: 0x0006FE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55870, XrefRangeEnd = 55874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_6(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_6_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BED RID: 7149 RVA: 0x00071C58 File Offset: 0x0006FE58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55874, XrefRangeEnd = 55889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_7(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_7_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BEE RID: 7150 RVA: 0x00071C9C File Offset: 0x0006FE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55889, XrefRangeEnd = 55898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_8(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_8_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BEF RID: 7151 RVA: 0x00071CE0 File Offset: 0x0006FEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55898, XrefRangeEnd = 55902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_9(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_9_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF0 RID: 7152 RVA: 0x00071D24 File Offset: 0x0006FF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55902, XrefRangeEnd = 55917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_10(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_10_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF1 RID: 7153 RVA: 0x00071D68 File Offset: 0x0006FF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55917, XrefRangeEnd = 55922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_11(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_11_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF2 RID: 7154 RVA: 0x00071DAC File Offset: 0x0006FFAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55922, XrefRangeEnd = 55937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_12(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_12_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF3 RID: 7155 RVA: 0x00071DF0 File Offset: 0x0006FFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55937, XrefRangeEnd = 55941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_13(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_13_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF4 RID: 7156 RVA: 0x00071E34 File Offset: 0x00070034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55941, XrefRangeEnd = 55956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__310_14(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__310_14_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF5 RID: 7157 RVA: 0x0000FA13 File Offset: 0x0000DC13
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00071E78 File Offset: 0x00070078
			// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x0000FA1C File Offset: 0x0000DC1C
			public unsafe static Socket.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00071EA0 File Offset: 0x000700A0
			// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x0000FA2E File Offset: 0x0000DC2E
			public unsafe static IOAsyncCallback __9__242_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__242_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__242_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001537 RID: 5431
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001538 RID: 5432
			private static readonly IntPtr NativeFieldInfoPtr___9__242_0;

			// Token: 0x04001539 RID: 5433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400153A RID: 5434
			private static readonly IntPtr NativeMethodInfoPtr__BeginSend_b__242_0_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400153B RID: 5435
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_0_Internal_Void_IAsyncResult_0;

			// Token: 0x0400153C RID: 5436
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_1_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400153D RID: 5437
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_2_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400153E RID: 5438
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_3_Internal_Void_IAsyncResult_0;

			// Token: 0x0400153F RID: 5439
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_4_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001540 RID: 5440
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_5_Internal_Void_IAsyncResult_0;

			// Token: 0x04001541 RID: 5441
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_6_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001542 RID: 5442
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_7_Internal_Void_IAsyncResult_0;

			// Token: 0x04001543 RID: 5443
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_8_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001544 RID: 5444
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_9_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001545 RID: 5445
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_10_Internal_Void_IAsyncResult_0;

			// Token: 0x04001546 RID: 5446
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_11_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001547 RID: 5447
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_12_Internal_Void_IAsyncResult_0;

			// Token: 0x04001548 RID: 5448
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_13_Internal_Void_IOAsyncResult_0;

			// Token: 0x04001549 RID: 5449
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__310_14_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x020001EE RID: 494
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass243_0")]
		public sealed class __c__DisplayClass243_0 : Object
		{
			// Token: 0x06001BFA RID: 7162 RVA: 0x00071EC8 File Offset: 0x000700C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass243_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass243_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr);
				Socket.__c__DisplayClass243_0.NativeFieldInfoPtr_sent_so_far = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr, "sent_so_far");
				Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr, 100666155);
				Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr, 100666156);
			}

			// Token: 0x06001BFB RID: 7163 RVA: 0x00071F30 File Offset: 0x00070130
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass243_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass243_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BFC RID: 7164 RVA: 0x00071F6C File Offset: 0x0007016C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55956, XrefRangeEnd = 55963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSendCallback_b__0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass243_0.NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BFD RID: 7165 RVA: 0x0000FA40 File Offset: 0x0000DC40
			public __c__DisplayClass243_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00071FB0 File Offset: 0x000701B0
			// (set) Token: 0x06001BFF RID: 7167 RVA: 0x0000FA49 File Offset: 0x0000DC49
			public unsafe int sent_so_far
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass243_0.NativeFieldInfoPtr_sent_so_far);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass243_0.NativeFieldInfoPtr_sent_so_far)) = value;
				}
			}

			// Token: 0x0400154A RID: 5450
			private static readonly IntPtr NativeFieldInfoPtr_sent_so_far;

			// Token: 0x0400154B RID: 5451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400154C RID: 5452
			private static readonly IntPtr NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0;
		}

		// Token: 0x020001EF RID: 495
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass299_0")]
		public sealed class __c__DisplayClass299_0 : Object
		{
			// Token: 0x06001C00 RID: 7168 RVA: 0x00071FD8 File Offset: 0x000701D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass299_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass299_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr);
				Socket.__c__DisplayClass299_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, "<>4__this");
				Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, "job");
				Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, "handle");
				Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, 100666157);
				Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr, 100666158);
			}

			// Token: 0x06001C01 RID: 7169 RVA: 0x00072068 File Offset: 0x00070268
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass299_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass299_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C02 RID: 7170 RVA: 0x000720A4 File Offset: 0x000702A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55963, XrefRangeEnd = 55967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QueueIOSelectorJob_b__0(Task t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass299_0.NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C03 RID: 7171 RVA: 0x0000FA64 File Offset: 0x0000DC64
			public __c__DisplayClass299_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000720E8 File Offset: 0x000702E8
			// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0000FA6D File Offset: 0x0000DC6D
			public unsafe Socket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00072118 File Offset: 0x00070318
			// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0000FA8C File Offset: 0x0000DC8C
			public unsafe IOSelectorJob job
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_job);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOSelectorJob>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_job), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00072148 File Offset: 0x00070348
			// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0000FAAB File Offset: 0x0000DCAB
			public unsafe IntPtr handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass299_0.NativeFieldInfoPtr_handle)) = value;
				}
			}

			// Token: 0x0400154D RID: 5453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400154E RID: 5454
			private static readonly IntPtr NativeFieldInfoPtr_job;

			// Token: 0x0400154F RID: 5455
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04001550 RID: 5456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001551 RID: 5457
			private static readonly IntPtr NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0;
		}
	}
}
