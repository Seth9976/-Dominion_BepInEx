using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001DE RID: 478
	[StructLayout(2)]
	public struct MusicPlayerWantsLooped_t
	{
		// Token: 0x06002324 RID: 8996 RVA: 0x000A42C8 File Offset: 0x000A24C8
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsLooped_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsLooped_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr);
			MusicPlayerWantsLooped_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsLooped_t.NativeFieldInfoPtr_m_bLooped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, "m_bLooped");
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0000D585 File Offset: 0x0000B785
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000A4320 File Offset: 0x000A2520
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x0000D597 File Offset: 0x0000B797
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsLooped_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsLooped_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeFieldInfoPtr_m_bLooped;

		// Token: 0x04001CE8 RID: 7400
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bLooped;
	}
}
