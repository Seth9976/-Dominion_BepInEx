using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001DB RID: 475
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		// Token: 0x06002318 RID: 8984 RVA: 0x0000D4B3 File Offset: 0x0000B6B3
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayPrevious_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlayPrevious_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr);
			MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000A421C File Offset: 0x000A241C
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x0000D4FE File Offset: 0x0000B6FE
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
