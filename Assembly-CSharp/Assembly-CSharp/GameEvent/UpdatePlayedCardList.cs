using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000149 RID: 329
	[StructLayout(2)]
	public struct UpdatePlayedCardList
	{
		// Token: 0x06002203 RID: 8707 RVA: 0x00080AF0 File Offset: 0x0007ECF0
		// Note: this type is marked as 'beforefieldinit'.
		static UpdatePlayedCardList()
		{
			Il2CppClassPointerStore<UpdatePlayedCardList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "UpdatePlayedCardList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePlayedCardList>.NativeClassPtr);
			UpdatePlayedCardList.NativeFieldInfoPtr_update_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePlayedCardList>.NativeClassPtr, "update_type");
			UpdatePlayedCardList.NativeFieldInfoPtr_played_card_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePlayedCardList>.NativeClassPtr, "played_card_index");
			UpdatePlayedCardList.NativeFieldInfoPtr_played_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePlayedCardList>.NativeClassPtr, "played_card_instance_id");
			UpdatePlayedCardList.NativeFieldInfoPtr_played_card_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePlayedCardList>.NativeClassPtr, "played_card_flags");
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0001544E File Offset: 0x0001364E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePlayedCardList>.NativeClassPtr, ref this));
		}

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeFieldInfoPtr_update_type;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeFieldInfoPtr_played_card_index;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeFieldInfoPtr_played_card_instance_id;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeFieldInfoPtr_played_card_flags;

		// Token: 0x04001786 RID: 6022
		[FieldOffset(0)]
		public int update_type;

		// Token: 0x04001787 RID: 6023
		[FieldOffset(4)]
		public int played_card_index;

		// Token: 0x04001788 RID: 6024
		[FieldOffset(8)]
		public int played_card_instance_id;

		// Token: 0x04001789 RID: 6025
		[FieldOffset(12)]
		public int played_card_flags;
	}
}
