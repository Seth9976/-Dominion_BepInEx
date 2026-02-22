using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D9 RID: 473
	[StructLayout(2)]
	public struct MusicPlayerWantsPlay_t
	{
		// Token: 0x06002310 RID: 8976 RVA: 0x0000D401 File Offset: 0x0000B601
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlay_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlay_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr);
			MusicPlayerWantsPlay_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x0000D43A File Offset: 0x0000B63A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x000A41E4 File Offset: 0x000A23E4
		// (set) Token: 0x06002313 RID: 8979 RVA: 0x0000D44C File Offset: 0x0000B64C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlay_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlay_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
