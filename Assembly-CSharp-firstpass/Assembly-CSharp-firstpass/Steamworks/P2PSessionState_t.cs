using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002AE RID: 686
	[StructLayout(2)]
	public struct P2PSessionState_t
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x000ABF78 File Offset: 0x000AA178
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionState_t()
		{
			Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "P2PSessionState_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr);
			P2PSessionState_t.NativeFieldInfoPtr_m_bConnectionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_bConnectionActive");
			P2PSessionState_t.NativeFieldInfoPtr_m_bConnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_bConnecting");
			P2PSessionState_t.NativeFieldInfoPtr_m_eP2PSessionError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_eP2PSessionError");
			P2PSessionState_t.NativeFieldInfoPtr_m_bUsingRelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_bUsingRelay");
			P2PSessionState_t.NativeFieldInfoPtr_m_nBytesQueuedForSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nBytesQueuedForSend");
			P2PSessionState_t.NativeFieldInfoPtr_m_nPacketsQueuedForSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nPacketsQueuedForSend");
			P2PSessionState_t.NativeFieldInfoPtr_m_nRemoteIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nRemoteIP");
			P2PSessionState_t.NativeFieldInfoPtr_m_nRemotePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nRemotePort");
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeFieldInfoPtr_m_bConnectionActive;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeFieldInfoPtr_m_bConnecting;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeFieldInfoPtr_m_eP2PSessionError;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeFieldInfoPtr_m_bUsingRelay;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeFieldInfoPtr_m_nBytesQueuedForSend;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeFieldInfoPtr_m_nPacketsQueuedForSend;

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeFieldInfoPtr_m_nRemoteIP;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeFieldInfoPtr_m_nRemotePort;

		// Token: 0x04002694 RID: 9876
		[FieldOffset(0)]
		public byte m_bConnectionActive;

		// Token: 0x04002695 RID: 9877
		[FieldOffset(1)]
		public byte m_bConnecting;

		// Token: 0x04002696 RID: 9878
		[FieldOffset(2)]
		public byte m_eP2PSessionError;

		// Token: 0x04002697 RID: 9879
		[FieldOffset(3)]
		public byte m_bUsingRelay;

		// Token: 0x04002698 RID: 9880
		[FieldOffset(4)]
		public int m_nBytesQueuedForSend;

		// Token: 0x04002699 RID: 9881
		[FieldOffset(8)]
		public int m_nPacketsQueuedForSend;

		// Token: 0x0400269A RID: 9882
		[FieldOffset(12)]
		public uint m_nRemoteIP;

		// Token: 0x0400269B RID: 9883
		[FieldOffset(16)]
		public ushort m_nRemotePort;
	}
}
