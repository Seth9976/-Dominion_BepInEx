using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200014C RID: 332
	[StructLayout(2)]
	public struct AddOwnedCard
	{
		// Token: 0x06002209 RID: 8713 RVA: 0x00080C48 File Offset: 0x0007EE48
		// Note: this type is marked as 'beforefieldinit'.
		static AddOwnedCard()
		{
			Il2CppClassPointerStore<AddOwnedCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "AddOwnedCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOwnedCard>.NativeClassPtr);
			AddOwnedCard.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOwnedCard>.NativeClassPtr, "player_instance_id");
			AddOwnedCard.NativeFieldInfoPtr_add_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOwnedCard>.NativeClassPtr, "add_card_instance_id");
			AddOwnedCard.NativeFieldInfoPtr_add_card_namehash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOwnedCard>.NativeClassPtr, "add_card_namehash");
			AddOwnedCard.NativeFieldInfoPtr_add_card_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOwnedCard>.NativeClassPtr, "add_card_count");
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00015484 File Offset: 0x00013684
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddOwnedCard>.NativeClassPtr, ref this));
		}

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr_add_card_instance_id;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeFieldInfoPtr_add_card_namehash;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeFieldInfoPtr_add_card_count;

		// Token: 0x0400179A RID: 6042
		[FieldOffset(0)]
		public int player_instance_id;

		// Token: 0x0400179B RID: 6043
		[FieldOffset(4)]
		public int add_card_instance_id;

		// Token: 0x0400179C RID: 6044
		[FieldOffset(8)]
		public int add_card_namehash;

		// Token: 0x0400179D RID: 6045
		[FieldOffset(12)]
		public int add_card_count;
	}
}
