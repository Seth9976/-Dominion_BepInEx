using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B8 RID: 440
	[StructLayout(2)]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		// Token: 0x0600227A RID: 8826 RVA: 0x000A2E3C File Offset: 0x000A103C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryEligiblePromoItemDefIDs_t()
		{
			Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryEligiblePromoItemDefIDs_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr);
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_result");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_steamID");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_numEligiblePromoItemDefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_numEligiblePromoItemDefs");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_bCachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_bCachedData");
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x0000CD96 File Offset: 0x0000AF96
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeFieldInfoPtr_m_numEligiblePromoItemDefs;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeFieldInfoPtr_m_bCachedData;

		// Token: 0x04001C17 RID: 7191
		[FieldOffset(0)]
		public EResult m_result;

		// Token: 0x04001C18 RID: 7192
		[FieldOffset(4)]
		public CSteamID m_steamID;

		// Token: 0x04001C19 RID: 7193
		[FieldOffset(12)]
		public int m_numEligiblePromoItemDefs;

		// Token: 0x04001C1A RID: 7194
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bCachedData;
	}
}
