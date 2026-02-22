using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E1 RID: 481
	[StructLayout(2)]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		// Token: 0x06002330 RID: 9008 RVA: 0x000A4424 File Offset: 0x000A2624
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerSelectsPlaylistEntry_t()
		{
			Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerSelectsPlaylistEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr);
			MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_nID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, "nID");
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0000D5E5 File Offset: 0x0000B7E5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000A447C File Offset: 0x000A267C
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x0000D5F7 File Offset: 0x0000B7F7
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr_nID;

		// Token: 0x04001CF1 RID: 7409
		[FieldOffset(0)]
		public int nID;
	}
}
