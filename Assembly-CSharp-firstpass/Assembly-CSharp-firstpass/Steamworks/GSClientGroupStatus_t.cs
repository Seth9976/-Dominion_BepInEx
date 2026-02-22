using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000194 RID: 404
	[StructLayout(2)]
	public struct GSClientGroupStatus_t
	{
		// Token: 0x06002185 RID: 8581 RVA: 0x000A10FC File Offset: 0x0009F2FC
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientGroupStatus_t()
		{
			Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientGroupStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr);
			GSClientGroupStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "k_iCallback");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_SteamIDUser");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_SteamIDGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_SteamIDGroup");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_bMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_bMember");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_bOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_bOfficer");
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x0000C378 File Offset: 0x0000A578
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x000A1190 File Offset: 0x0009F390
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x0000C38A File Offset: 0x0000A58A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientGroupStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientGroupStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDUser;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDGroup;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeFieldInfoPtr_m_bMember;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeFieldInfoPtr_m_bOfficer;

		// Token: 0x04001B35 RID: 6965
		[FieldOffset(0)]
		public CSteamID m_SteamIDUser;

		// Token: 0x04001B36 RID: 6966
		[FieldOffset(8)]
		public CSteamID m_SteamIDGroup;

		// Token: 0x04001B37 RID: 6967
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bMember;

		// Token: 0x04001B38 RID: 6968
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool m_bOfficer;
	}
}
