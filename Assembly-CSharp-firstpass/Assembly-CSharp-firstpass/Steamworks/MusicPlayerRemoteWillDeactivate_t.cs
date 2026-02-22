using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D6 RID: 470
	[StructLayout(2)]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		// Token: 0x06002304 RID: 8964 RVA: 0x0000D2F6 File Offset: 0x0000B4F6
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteWillDeactivate_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerRemoteWillDeactivate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr);
			MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0000D32F File Offset: 0x0000B52F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x000A4190 File Offset: 0x000A2390
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x0000D341 File Offset: 0x0000B541
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
