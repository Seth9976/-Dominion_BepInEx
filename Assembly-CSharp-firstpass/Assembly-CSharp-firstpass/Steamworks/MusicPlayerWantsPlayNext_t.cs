using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001DC RID: 476
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayNext_t
	{
		// Token: 0x0600231C RID: 8988 RVA: 0x0000D50C File Offset: 0x0000B70C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayNext_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlayNext_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr);
			MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0000D545 File Offset: 0x0000B745
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000A4238 File Offset: 0x000A2438
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x0000D557 File Offset: 0x0000B757
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
