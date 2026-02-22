using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002EA RID: 746
	[Serializable]
	[StructLayout(2)]
	public struct ISteamNetworkingConnectionCustomSignaling
	{
		// Token: 0x06002B2E RID: 11054 RVA: 0x000B93C0 File Offset: 0x000B75C0
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamNetworkingConnectionCustomSignaling()
		{
			Il2CppClassPointerStore<ISteamNetworkingConnectionCustomSignaling>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamNetworkingConnectionCustomSignaling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamNetworkingConnectionCustomSignaling>.NativeClassPtr);
			ISteamNetworkingConnectionCustomSignaling.NativeMethodInfoPtr_SendSignal_Public_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingConnectionCustomSignaling>.NativeClassPtr, 100668876);
			ISteamNetworkingConnectionCustomSignaling.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingConnectionCustomSignaling>.NativeClassPtr, 100668877);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000B9418 File Offset: 0x000B7618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210884, XrefRangeEnd = 210885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendSignal(HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pMsg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingConnectionCustomSignaling.NativeMethodInfoPtr_SendSignal_Public_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000B9484 File Offset: 0x000B7684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210885, XrefRangeEnd = 210886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingConnectionCustomSignaling.NativeMethodInfoPtr_Release_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00011105 File Offset: 0x0000F305
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ISteamNetworkingConnectionCustomSignaling>.NativeClassPtr, ref this));
		}

		// Token: 0x04002989 RID: 10633
		private static readonly IntPtr NativeMethodInfoPtr_SendSignal_Public_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_IntPtr_Int32_0;

		// Token: 0x0400298A RID: 10634
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
	}
}
