using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E3 RID: 483
	[StructLayout(2)]
	public struct P2PSessionRequest_t
	{
		// Token: 0x06002338 RID: 9016 RVA: 0x000A450C File Offset: 0x000A270C
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionRequest_t()
		{
			Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "P2PSessionRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr);
			P2PSessionRequest_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, "k_iCallback");
			P2PSessionRequest_t.NativeFieldInfoPtr_m_steamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, "m_steamIDRemote");
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0000D625 File Offset: 0x0000B825
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000A4564 File Offset: 0x000A2764
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0000D637 File Offset: 0x0000B837
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(P2PSessionRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(P2PSessionRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDRemote;

		// Token: 0x04001CF7 RID: 7415
		[FieldOffset(0)]
		public CSteamID m_steamIDRemote;
	}
}
