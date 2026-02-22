using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001DF RID: 479
	[StructLayout(2)]
	public struct MusicPlayerWantsVolume_t
	{
		// Token: 0x06002328 RID: 9000 RVA: 0x000A433C File Offset: 0x000A253C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsVolume_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsVolume_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr);
			MusicPlayerWantsVolume_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsVolume_t.NativeFieldInfoPtr_m_flNewVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, "m_flNewVolume");
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0000D5A5 File Offset: 0x0000B7A5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000A4394 File Offset: 0x000A2594
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x0000D5B7 File Offset: 0x0000B7B7
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsVolume_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsVolume_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeFieldInfoPtr_m_flNewVolume;

		// Token: 0x04001CEB RID: 7403
		[FieldOffset(0)]
		public float m_flNewVolume;
	}
}
