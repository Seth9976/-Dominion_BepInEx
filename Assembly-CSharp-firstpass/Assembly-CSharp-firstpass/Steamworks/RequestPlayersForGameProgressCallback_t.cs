using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C8 RID: 456
	[StructLayout(2)]
	public struct RequestPlayersForGameProgressCallback_t
	{
		// Token: 0x060022C1 RID: 8897 RVA: 0x000A39B4 File Offset: 0x000A1BB4
		// Note: this type is marked as 'beforefieldinit'.
		static RequestPlayersForGameProgressCallback_t()
		{
			Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RequestPlayersForGameProgressCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr);
			RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, "k_iCallback");
			RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, "m_eResult");
			RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr_m_ullSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, "m_ullSearchID");
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0000CFD9 File Offset: 0x0000B1D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000A3A20 File Offset: 0x000A1C20
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0000CFEB File Offset: 0x0000B1EB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeFieldInfoPtr_m_ullSearchID;

		// Token: 0x04001C97 RID: 7319
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001C98 RID: 7320
		[FieldOffset(8)]
		public ulong m_ullSearchID;
	}
}
