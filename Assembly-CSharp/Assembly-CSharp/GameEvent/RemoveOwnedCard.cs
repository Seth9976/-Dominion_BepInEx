using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200014D RID: 333
	[StructLayout(2)]
	public struct RemoveOwnedCard
	{
		// Token: 0x0600220B RID: 8715 RVA: 0x00080CC8 File Offset: 0x0007EEC8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveOwnedCard()
		{
			Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "RemoveOwnedCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr);
			RemoveOwnedCard.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr, "player_instance_id");
			RemoveOwnedCard.NativeFieldInfoPtr_remove_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr, "remove_card_instance_id");
			RemoveOwnedCard.NativeFieldInfoPtr_remove_card_namehash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr, "remove_card_namehash");
			RemoveOwnedCard.NativeFieldInfoPtr_remove_card_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr, "remove_card_count");
			RemoveOwnedCard.NativeFieldInfoPtr_replace_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr, "replace_card_instance_id");
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00015496 File Offset: 0x00013696
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveOwnedCard>.NativeClassPtr, ref this));
		}

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeFieldInfoPtr_remove_card_instance_id;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeFieldInfoPtr_remove_card_namehash;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeFieldInfoPtr_remove_card_count;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeFieldInfoPtr_replace_card_instance_id;

		// Token: 0x040017A3 RID: 6051
		[FieldOffset(0)]
		public int player_instance_id;

		// Token: 0x040017A4 RID: 6052
		[FieldOffset(4)]
		public int remove_card_instance_id;

		// Token: 0x040017A5 RID: 6053
		[FieldOffset(8)]
		public int remove_card_namehash;

		// Token: 0x040017A6 RID: 6054
		[FieldOffset(12)]
		public int remove_card_count;

		// Token: 0x040017A7 RID: 6055
		[FieldOffset(16)]
		public int replace_card_instance_id;
	}
}
