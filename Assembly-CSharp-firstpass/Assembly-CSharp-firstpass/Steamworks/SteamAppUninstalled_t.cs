using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000171 RID: 369
	[StructLayout(2)]
	public struct SteamAppUninstalled_t
	{
		// Token: 0x060020B5 RID: 8373 RVA: 0x0009F5FC File Offset: 0x0009D7FC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppUninstalled_t()
		{
			Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAppUninstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr);
			SteamAppUninstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, "k_iCallback");
			SteamAppUninstalled_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x0000BB94 File Offset: 0x00009D94
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0009F654 File Offset: 0x0009D854
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0000BBA6 File Offset: 0x00009DA6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAppUninstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAppUninstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001A7C RID: 6780
		[FieldOffset(0)]
		public AppId_t m_nAppID;
	}
}
