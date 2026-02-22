using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000189 RID: 393
	[StructLayout(2)]
	public struct SetPersonaNameResponse_t
	{
		// Token: 0x06002142 RID: 8514 RVA: 0x000A08A0 File Offset: 0x0009EAA0
		// Note: this type is marked as 'beforefieldinit'.
		static SetPersonaNameResponse_t()
		{
			Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SetPersonaNameResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr);
			SetPersonaNameResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "k_iCallback");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "m_bSuccess");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_m_bLocalSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "m_bLocalSuccess");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "m_result");
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0000C0C2 File Offset: 0x0000A2C2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x000A0920 File Offset: 0x0009EB20
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SetPersonaNameResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetPersonaNameResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeFieldInfoPtr_m_bLocalSuccess;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04001B02 RID: 6914
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bSuccess;

		// Token: 0x04001B03 RID: 6915
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool m_bLocalSuccess;

		// Token: 0x04001B04 RID: 6916
		[FieldOffset(4)]
		public EResult m_result;
	}
}
