using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C2 RID: 450
	[StructLayout(2)]
	public struct LobbyMatchList_t
	{
		// Token: 0x060022A9 RID: 8873 RVA: 0x000A35F8 File Offset: 0x000A17F8
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyMatchList_t()
		{
			Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyMatchList_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr);
			LobbyMatchList_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, "k_iCallback");
			LobbyMatchList_t.NativeFieldInfoPtr_m_nLobbiesMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, "m_nLobbiesMatching");
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0000CF19 File Offset: 0x0000B119
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x000A3650 File Offset: 0x000A1850
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0000CF2B File Offset: 0x0000B12B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyMatchList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyMatchList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeFieldInfoPtr_m_nLobbiesMatching;

		// Token: 0x04001C6A RID: 7274
		[FieldOffset(0)]
		public uint m_nLobbiesMatching;
	}
}
