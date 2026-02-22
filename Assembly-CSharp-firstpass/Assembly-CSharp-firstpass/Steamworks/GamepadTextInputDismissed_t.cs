using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200023C RID: 572
	[StructLayout(2)]
	public struct GamepadTextInputDismissed_t
	{
		// Token: 0x06002591 RID: 9617 RVA: 0x000A9304 File Offset: 0x000A7504
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadTextInputDismissed_t()
		{
			Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GamepadTextInputDismissed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr);
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "k_iCallback");
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_m_bSubmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "m_bSubmitted");
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_m_unSubmittedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "m_unSubmittedText");
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x0000EE3F File Offset: 0x0000D03F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x000A9370 File Offset: 0x000A7570
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x0000EE51 File Offset: 0x0000D051
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTextInputDismissed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTextInputDismissed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeFieldInfoPtr_m_bSubmitted;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeFieldInfoPtr_m_unSubmittedText;

		// Token: 0x04001F10 RID: 7952
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bSubmitted;

		// Token: 0x04001F11 RID: 7953
		[FieldOffset(4)]
		public uint m_unSubmittedText;
	}
}
