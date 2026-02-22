using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002EB RID: 747
	[Serializable]
	[StructLayout(2)]
	public struct ISteamNetworkingCustomSignalingRecvContext
	{
		// Token: 0x06002B32 RID: 11058 RVA: 0x000B94AC File Offset: 0x000B76AC
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamNetworkingCustomSignalingRecvContext()
		{
			Il2CppClassPointerStore<ISteamNetworkingCustomSignalingRecvContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamNetworkingCustomSignalingRecvContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamNetworkingCustomSignalingRecvContext>.NativeClassPtr);
			ISteamNetworkingCustomSignalingRecvContext.NativeMethodInfoPtr_OnConnectRequest_Public_IntPtr_HSteamNetConnection_byref_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingCustomSignalingRecvContext>.NativeClassPtr, 100668878);
			ISteamNetworkingCustomSignalingRecvContext.NativeMethodInfoPtr_SendRejectionSignal_Public_Void_byref_SteamNetworkingIdentity_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingCustomSignalingRecvContext>.NativeClassPtr, 100668879);
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000B9504 File Offset: 0x000B7704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210886, XrefRangeEnd = 210887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityPeer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingCustomSignalingRecvContext.NativeMethodInfoPtr_OnConnectRequest_Public_IntPtr_HSteamNetConnection_byref_SteamNetworkingIdentity_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000B9554 File Offset: 0x000B7754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210887, XrefRangeEnd = 210888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityPeer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pMsg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingCustomSignalingRecvContext.NativeMethodInfoPtr_SendRejectionSignal_Public_Void_byref_SteamNetworkingIdentity_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x00011117 File Offset: 0x0000F317
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ISteamNetworkingCustomSignalingRecvContext>.NativeClassPtr, ref this));
		}

		// Token: 0x0400298B RID: 10635
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectRequest_Public_IntPtr_HSteamNetConnection_byref_SteamNetworkingIdentity_0;

		// Token: 0x0400298C RID: 10636
		private static readonly IntPtr NativeMethodInfoPtr_SendRejectionSignal_Public_Void_byref_SteamNetworkingIdentity_IntPtr_Int32_0;
	}
}
