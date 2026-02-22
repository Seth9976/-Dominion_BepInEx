using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001EB RID: 491
	[StructLayout(2)]
	public struct SteamParentalSettingsChanged_t
	{
		// Token: 0x06002379 RID: 9081 RVA: 0x0000D8D7 File Offset: 0x0000BAD7
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParentalSettingsChanged_t()
		{
			Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamParentalSettingsChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr);
			SteamParentalSettingsChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0000D910 File Offset: 0x0000BB10
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000A4CE8 File Offset: 0x000A2EE8
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x0000D922 File Offset: 0x0000BB22
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamParentalSettingsChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamParentalSettingsChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
