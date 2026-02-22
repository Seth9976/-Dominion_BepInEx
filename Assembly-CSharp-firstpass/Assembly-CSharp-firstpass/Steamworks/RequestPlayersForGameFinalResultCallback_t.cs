using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001CA RID: 458
	[StructLayout(2)]
	public struct RequestPlayersForGameFinalResultCallback_t
	{
		// Token: 0x060022C9 RID: 8905 RVA: 0x000A3B64 File Offset: 0x000A1D64
		// Note: this type is marked as 'beforefieldinit'.
		static RequestPlayersForGameFinalResultCallback_t()
		{
			Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RequestPlayersForGameFinalResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr);
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "k_iCallback");
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "m_eResult");
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_m_ullSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "m_ullSearchID");
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_m_ullUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "m_ullUniqueGameID");
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0000D019 File Offset: 0x0000B219
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x000A3BE4 File Offset: 0x000A1DE4
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0000D02B File Offset: 0x0000B22B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeFieldInfoPtr_m_ullSearchID;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeFieldInfoPtr_m_ullUniqueGameID;

		// Token: 0x04001CB2 RID: 7346
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001CB3 RID: 7347
		[FieldOffset(8)]
		public ulong m_ullSearchID;

		// Token: 0x04001CB4 RID: 7348
		[FieldOffset(16)]
		public ulong m_ullUniqueGameID;
	}
}
