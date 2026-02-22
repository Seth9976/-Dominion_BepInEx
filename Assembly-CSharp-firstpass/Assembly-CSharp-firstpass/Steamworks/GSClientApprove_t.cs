using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200018E RID: 398
	[StructLayout(2)]
	public struct GSClientApprove_t
	{
		// Token: 0x0600215B RID: 8539 RVA: 0x000A0B38 File Offset: 0x0009ED38
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientApprove_t()
		{
			Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientApprove_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr);
			GSClientApprove_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "k_iCallback");
			GSClientApprove_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "m_SteamID");
			GSClientApprove_t.NativeFieldInfoPtr_m_OwnerSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "m_OwnerSteamID");
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000A0BA4 File Offset: 0x0009EDA4
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x0000C20E File Offset: 0x0000A40E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientApprove_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientApprove_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeFieldInfoPtr_m_OwnerSteamID;

		// Token: 0x04001B11 RID: 6929
		[FieldOffset(0)]
		public CSteamID m_SteamID;

		// Token: 0x04001B12 RID: 6930
		[FieldOffset(8)]
		public CSteamID m_OwnerSteamID;
	}
}
