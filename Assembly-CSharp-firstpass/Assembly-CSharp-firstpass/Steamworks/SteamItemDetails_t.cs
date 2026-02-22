using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002AC RID: 684
	[StructLayout(2)]
	public struct SteamItemDetails_t
	{
		// Token: 0x06002742 RID: 10050 RVA: 0x000ABEA0 File Offset: 0x000AA0A0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamItemDetails_t()
		{
			Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamItemDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr);
			SteamItemDetails_t.NativeFieldInfoPtr_m_itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_itemId");
			SteamItemDetails_t.NativeFieldInfoPtr_m_iDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_iDefinition");
			SteamItemDetails_t.NativeFieldInfoPtr_m_unQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_unQuantity");
			SteamItemDetails_t.NativeFieldInfoPtr_m_unFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "m_unFlags");
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0000FACC File Offset: 0x0000DCCC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeFieldInfoPtr_m_itemId;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeFieldInfoPtr_m_iDefinition;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeFieldInfoPtr_m_unQuantity;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeFieldInfoPtr_m_unFlags;

		// Token: 0x04002684 RID: 9860
		[FieldOffset(0)]
		public SteamItemInstanceID_t m_itemId;

		// Token: 0x04002685 RID: 9861
		[FieldOffset(8)]
		public SteamItemDef_t m_iDefinition;

		// Token: 0x04002686 RID: 9862
		[FieldOffset(12)]
		public ushort m_unQuantity;

		// Token: 0x04002687 RID: 9863
		[FieldOffset(14)]
		public ushort m_unFlags;
	}
}
