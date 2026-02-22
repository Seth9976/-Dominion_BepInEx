using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x0200012A RID: 298
	[Serializable]
	public class PlayerConnection : ScriptableObject
	{
		// Token: 0x06001757 RID: 5975 RVA: 0x00057B5C File Offset: 0x00055D5C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerConnection()
		{
			Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr);
			PlayerConnection.NativeFieldInfoPtr_connectionNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "connectionNative");
			PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_PlayerEditorConnectionEvents");
			PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_connectedPlayers");
			PlayerConnection.NativeFieldInfoPtr_m_IsInitilized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "m_IsInitilized");
			PlayerConnection.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "s_Instance");
			PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665039);
			PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665040);
			PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665041);
			PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665042);
			PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665043);
			PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665044);
			PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665045);
			PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665046);
			PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665047);
			PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665048);
			PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665049);
			PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665050);
			PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665051);
			PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665052);
			PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665053);
			PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665054);
			PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665055);
			PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665056);
			PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, 100665057);
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x00057D6C File Offset: 0x00055F6C
		public unsafe static PlayerConnection instance
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 81737, RefRangeEnd = 81742, XrefRangeStart = 81713, XrefRangeEnd = 81737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr3) : null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x00057DA0 File Offset: 0x00055FA0
		public unsafe bool isConnected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81742, XrefRangeEnd = 81752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00057DDC File Offset: 0x00055FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81752, XrefRangeEnd = 81761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerConnection CreateInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr3) : null;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00057E10 File Offset: 0x00056010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81761, XrefRangeEnd = 81765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00057E44 File Offset: 0x00056044
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 81771, RefRangeEnd = 81776, XrefRangeStart = 81765, XrefRangeEnd = 81771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPlayerEditorConnectionNative GetConnectionNativeApi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(intPtr3) : null;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00057E84 File Offset: 0x00056084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81838, RefRangeEnd = 81839, XrefRangeStart = 81776, XrefRangeEnd = 81838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Register(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00057ED4 File Offset: 0x000560D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81879, RefRangeEnd = 81880, XrefRangeStart = 81839, XrefRangeEnd = 81879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unregister(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00057F24 File Offset: 0x00056124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81880, XrefRangeEnd = 81900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterConnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00057F68 File Offset: 0x00056168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81900, XrefRangeEnd = 81904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00057FAC File Offset: 0x000561AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81904, XrefRangeEnd = 81908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00057FF0 File Offset: 0x000561F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81908, XrefRangeEnd = 81912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00058034 File Offset: 0x00056234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81912, XrefRangeEnd = 81921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(Guid messageId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00058084 File Offset: 0x00056284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81921, XrefRangeEnd = 81930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TrySend(Guid messageId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000580E0 File Offset: 0x000562E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81930, XrefRangeEnd = 81964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BlockUntilRecvMsg(Guid messageId, int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00058138 File Offset: 0x00056338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81964, XrefRangeEnd = 81974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0005816C File Offset: 0x0005636C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81974, XrefRangeEnd = 81985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000581CC File Offset: 0x000563CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81985, XrefRangeEnd = 81994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectedCallbackInternal(int playerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00058200 File Offset: 0x00056400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81994, XrefRangeEnd = 82003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectedCallback(int playerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00058234 File Offset: 0x00056434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82003, XrefRangeEnd = 82027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerConnection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0000D1F3 File Offset: 0x0000B3F3
		public PlayerConnection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00058270 File Offset: 0x00056470
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		public unsafe static IPlayerEditorConnectionNative connectionNative
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerConnection.NativeFieldInfoPtr_connectionNative, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerConnection.NativeFieldInfoPtr_connectionNative, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00058298 File Offset: 0x00056498
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x0000D20E File Offset: 0x0000B40E
		public unsafe PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x000582C8 File Offset: 0x000564C8
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x0000D22D File Offset: 0x0000B42D
		public unsafe List<int> m_connectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x000582F8 File Offset: 0x000564F8
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x0000D24C File Offset: 0x0000B44C
		public unsafe bool m_IsInitilized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_IsInitilized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.NativeFieldInfoPtr_m_IsInitilized)) = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00058320 File Offset: 0x00056520
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x0000D267 File Offset: 0x0000B467
		public unsafe static PlayerConnection s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerConnection.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerConnection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerConnection.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr_connectionNative;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerEditorConnectionEvents;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeFieldInfoPtr_m_connectedPlayers;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeFieldInfoPtr_m_IsInitilized;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000959 RID: 2393
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x060030B8 RID: 12472 RVA: 0x0006DC78 File Offset: 0x0006BE78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, "messageId");
				PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100665058);
				PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100665059);
			}

			// Token: 0x060030B9 RID: 12473 RVA: 0x0006DCE0 File Offset: 0x0006BEE0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030BA RID: 12474 RVA: 0x0006DD1C File Offset: 0x0006BF1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81703, XrefRangeEnd = 81708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Register_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060030BB RID: 12475 RVA: 0x000175AE File Offset: 0x000157AE
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x060030BC RID: 12476 RVA: 0x0006DD6C File Offset: 0x0006BF6C
			// (set) Token: 0x060030BD RID: 12477 RVA: 0x000175B7 File Offset: 0x000157B7
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001D07 RID: 7431
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001D08 RID: 7432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D09 RID: 7433
			private static readonly IntPtr NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x0200095A RID: 2394
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x060030BE RID: 12478 RVA: 0x0006DD94 File Offset: 0x0006BF94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, "messageId");
				PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100665060);
				PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100665061);
			}

			// Token: 0x060030BF RID: 12479 RVA: 0x0006DDFC File Offset: 0x0006BFFC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x0006DE38 File Offset: 0x0006C038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81708, XrefRangeEnd = 81713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Unregister_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060030C1 RID: 12481 RVA: 0x000175D2 File Offset: 0x000157D2
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x060030C2 RID: 12482 RVA: 0x0006DE88 File Offset: 0x0006C088
			// (set) Token: 0x060030C3 RID: 12483 RVA: 0x000175DB File Offset: 0x000157DB
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001D0A RID: 7434
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001D0B RID: 7435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D0C RID: 7436
			private static readonly IntPtr NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x0200095B RID: 2395
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x060030C4 RID: 12484 RVA: 0x0006DEB0 File Offset: 0x0006C0B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerConnection>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr);
				PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, "msgReceived");
				PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100665062);
				PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100665063);
			}

			// Token: 0x060030C5 RID: 12485 RVA: 0x0006DF18 File Offset: 0x0006C118
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030C6 RID: 12486 RVA: 0x0006DF54 File Offset: 0x0006C154
			[CallerCount(0)]
			public unsafe void _BlockUntilRecvMsg_b__0(MessageEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030C7 RID: 12487 RVA: 0x000175F6 File Offset: 0x000157F6
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x060030C8 RID: 12488 RVA: 0x0006DF98 File Offset: 0x0006C198
			// (set) Token: 0x060030C9 RID: 12489 RVA: 0x000175FF File Offset: 0x000157FF
			public unsafe bool msgReceived
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived)) = value;
				}
			}

			// Token: 0x04001D0D RID: 7437
			private static readonly IntPtr NativeFieldInfoPtr_msgReceived;

			// Token: 0x04001D0E RID: 7438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D0F RID: 7439
			private static readonly IntPtr NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0;
		}

		// Token: 0x0200095C RID: 2396
		public sealed class <>c__DisplayClass12_0
		{
		}

		// Token: 0x0200095D RID: 2397
		public sealed class <>c__DisplayClass13_0
		{
		}

		// Token: 0x0200095E RID: 2398
		public sealed class <>c__DisplayClass20_0
		{
		}
	}
}
