using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D7 RID: 471
	[StructLayout(2)]
	public struct MusicPlayerRemoteToFront_t
	{
		// Token: 0x06002308 RID: 8968 RVA: 0x0000D34F File Offset: 0x0000B54F
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteToFront_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerRemoteToFront_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr);
			MusicPlayerRemoteToFront_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x0000D388 File Offset: 0x0000B588
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x000A41AC File Offset: 0x000A23AC
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x0000D39A File Offset: 0x0000B59A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteToFront_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteToFront_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
