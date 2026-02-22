using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B9 RID: 441
	[StructLayout(2)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		// Token: 0x0600227E RID: 8830 RVA: 0x000A2EEC File Offset: 0x000A10EC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryStartPurchaseResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryStartPurchaseResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr);
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "m_result");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_m_ulOrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "m_ulOrderID");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_m_ulTransID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "m_ulTransID");
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0000CDB6 File Offset: 0x0000AFB6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x000A2F6C File Offset: 0x000A116C
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeFieldInfoPtr_m_ulOrderID;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeFieldInfoPtr_m_ulTransID;

		// Token: 0x04001C1F RID: 7199
		[FieldOffset(0)]
		public EResult m_result;

		// Token: 0x04001C20 RID: 7200
		[FieldOffset(8)]
		public ulong m_ulOrderID;

		// Token: 0x04001C21 RID: 7201
		[FieldOffset(16)]
		public ulong m_ulTransID;
	}
}
