using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D8 RID: 472
	[StructLayout(2)]
	public struct MusicPlayerWillQuit_t
	{
		// Token: 0x0600230C RID: 8972 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWillQuit_t()
		{
			Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWillQuit_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr);
			MusicPlayerWillQuit_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0000D3E1 File Offset: 0x0000B5E1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x000A41C8 File Offset: 0x000A23C8
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x0000D3F3 File Offset: 0x0000B5F3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWillQuit_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWillQuit_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
