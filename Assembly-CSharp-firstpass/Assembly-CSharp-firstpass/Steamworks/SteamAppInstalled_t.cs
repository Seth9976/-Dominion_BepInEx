using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000170 RID: 368
	[StructLayout(2)]
	public struct SteamAppInstalled_t
	{
		// Token: 0x060020B1 RID: 8369 RVA: 0x0009F588 File Offset: 0x0009D788
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppInstalled_t()
		{
			Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAppInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr);
			SteamAppInstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, "k_iCallback");
			SteamAppInstalled_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0000BB74 File Offset: 0x00009D74
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0009F5E0 File Offset: 0x0009D7E0
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x0000BB86 File Offset: 0x00009D86
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAppInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAppInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001A79 RID: 6777
		[FieldOffset(0)]
		public AppId_t m_nAppID;
	}
}
