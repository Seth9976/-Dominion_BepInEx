using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000190 RID: 400
	[StructLayout(2)]
	public struct GSClientKick_t
	{
		// Token: 0x0600216C RID: 8556 RVA: 0x000A0D88 File Offset: 0x0009EF88
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientKick_t()
		{
			Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientKick_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr);
			GSClientKick_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "k_iCallback");
			GSClientKick_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "m_SteamID");
			GSClientKick_t.NativeFieldInfoPtr_m_eDenyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "m_eDenyReason");
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x0000C29A File Offset: 0x0000A49A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x000A0DF4 File Offset: 0x0009EFF4
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientKick_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientKick_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeFieldInfoPtr_m_eDenyReason;

		// Token: 0x04001B1C RID: 6940
		[FieldOffset(0)]
		public CSteamID m_SteamID;

		// Token: 0x04001B1D RID: 6941
		[FieldOffset(8)]
		public EDenyReason m_eDenyReason;
	}
}
