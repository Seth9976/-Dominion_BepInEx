using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001DA RID: 474
	[StructLayout(2)]
	public struct MusicPlayerWantsPause_t
	{
		// Token: 0x06002314 RID: 8980 RVA: 0x0000D45A File Offset: 0x0000B65A
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPause_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPause_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr);
			MusicPlayerWantsPause_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0000D493 File Offset: 0x0000B693
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x000A4200 File Offset: 0x000A2400
		// (set) Token: 0x06002317 RID: 8983 RVA: 0x0000D4A5 File Offset: 0x0000B6A5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPause_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPause_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
