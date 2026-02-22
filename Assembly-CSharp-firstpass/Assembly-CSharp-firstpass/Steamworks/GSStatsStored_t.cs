using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000199 RID: 409
	[StructLayout(2)]
	public struct GSStatsStored_t
	{
		// Token: 0x06002199 RID: 8601 RVA: 0x000A1458 File Offset: 0x0009F658
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsStored_t()
		{
			Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSStatsStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr);
			GSStatsStored_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "k_iCallback");
			GSStatsStored_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "m_eResult");
			GSStatsStored_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0000C418 File Offset: 0x0000A618
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x000A14C4 File Offset: 0x0009F6C4
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x0000C42A File Offset: 0x0000A62A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001B5E RID: 7006
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001B5F RID: 7007
		[FieldOffset(4)]
		public CSteamID m_steamIDUser;
	}
}
