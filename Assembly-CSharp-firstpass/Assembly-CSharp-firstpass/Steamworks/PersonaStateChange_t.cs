using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000178 RID: 376
	[StructLayout(2)]
	public struct PersonaStateChange_t
	{
		// Token: 0x060020E5 RID: 8421 RVA: 0x0009FB94 File Offset: 0x0009DD94
		// Note: this type is marked as 'beforefieldinit'.
		static PersonaStateChange_t()
		{
			Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PersonaStateChange_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr);
			PersonaStateChange_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "k_iCallback");
			PersonaStateChange_t.NativeFieldInfoPtr_m_ulSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "m_ulSteamID");
			PersonaStateChange_t.NativeFieldInfoPtr_m_nChangeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "m_nChangeFlags");
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0000BD9F File Offset: 0x00009F9F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0009FC00 File Offset: 0x0009DE00
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0000BDB1 File Offset: 0x00009FB1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PersonaStateChange_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PersonaStateChange_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamID;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeFieldInfoPtr_m_nChangeFlags;

		// Token: 0x04001A9E RID: 6814
		[FieldOffset(0)]
		public ulong m_ulSteamID;

		// Token: 0x04001A9F RID: 6815
		[FieldOffset(8)]
		public EPersonaChange m_nChangeFlags;
	}
}
