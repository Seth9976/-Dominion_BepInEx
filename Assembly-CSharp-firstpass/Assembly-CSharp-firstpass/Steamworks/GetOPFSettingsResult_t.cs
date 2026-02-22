using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200023E RID: 574
	[StructLayout(2)]
	public struct GetOPFSettingsResult_t
	{
		// Token: 0x060025A2 RID: 9634 RVA: 0x000A9554 File Offset: 0x000A7754
		// Note: this type is marked as 'beforefieldinit'.
		static GetOPFSettingsResult_t()
		{
			Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetOPFSettingsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr);
			GetOPFSettingsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "k_iCallback");
			GetOPFSettingsResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "m_eResult");
			GetOPFSettingsResult_t.NativeFieldInfoPtr_m_unVideoAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "m_unVideoAppID");
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0000EEDD File Offset: 0x0000D0DD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000A95C0 File Offset: 0x000A77C0
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x0000EEEF File Offset: 0x0000D0EF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetOPFSettingsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetOPFSettingsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeFieldInfoPtr_m_unVideoAppID;

		// Token: 0x04001F1B RID: 7963
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001F1C RID: 7964
		[FieldOffset(4)]
		public AppId_t m_unVideoAppID;
	}
}
