using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D3 RID: 467
	[StructLayout(2)]
	public struct PlaybackStatusHasChanged_t
	{
		// Token: 0x060022F8 RID: 8952 RVA: 0x0000D224 File Offset: 0x0000B424
		// Note: this type is marked as 'beforefieldinit'.
		static PlaybackStatusHasChanged_t()
		{
			Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PlaybackStatusHasChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr);
			PlaybackStatusHasChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0000D25D File Offset: 0x0000B45D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x000A40E4 File Offset: 0x000A22E4
		// (set) Token: 0x060022FB RID: 8955 RVA: 0x0000D26F File Offset: 0x0000B46F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlaybackStatusHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlaybackStatusHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
