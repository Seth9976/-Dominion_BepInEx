using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D5 RID: 469
	[StructLayout(2)]
	public struct MusicPlayerRemoteWillActivate_t
	{
		// Token: 0x06002300 RID: 8960 RVA: 0x0000D29D File Offset: 0x0000B49D
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteWillActivate_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerRemoteWillActivate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr);
			MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0000D2D6 File Offset: 0x0000B4D6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x000A4174 File Offset: 0x000A2374
		// (set) Token: 0x06002303 RID: 8963 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
