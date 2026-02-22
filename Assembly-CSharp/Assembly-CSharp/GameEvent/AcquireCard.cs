using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200014F RID: 335
	[StructLayout(2)]
	public struct AcquireCard
	{
		// Token: 0x06002218 RID: 8728 RVA: 0x00080E7C File Offset: 0x0007F07C
		// Note: this type is marked as 'beforefieldinit'.
		static AcquireCard()
		{
			Il2CppClassPointerStore<AcquireCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "AcquireCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireCard>.NativeClassPtr);
			AcquireCard.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireCard>.NativeClassPtr, "player_instance_id");
			AcquireCard.NativeFieldInfoPtr_acquire_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireCard>.NativeClassPtr, "acquire_card_instance_id");
			AcquireCard.NativeFieldInfoPtr_acquire_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireCard>.NativeClassPtr, "acquire_location");
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00015533 File Offset: 0x00013733
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AcquireCard>.NativeClassPtr, ref this));
		}

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr_acquire_card_instance_id;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeFieldInfoPtr_acquire_location;

		// Token: 0x040017AF RID: 6063
		[FieldOffset(0)]
		public int player_instance_id;

		// Token: 0x040017B0 RID: 6064
		[FieldOffset(4)]
		public int acquire_card_instance_id;

		// Token: 0x040017B1 RID: 6065
		[FieldOffset(8)]
		public int acquire_location;
	}
}
