using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200013E RID: 318
	[StructLayout(2)]
	public struct KingdomStackStatus
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x000806E8 File Offset: 0x0007E8E8
		// Note: this type is marked as 'beforefieldinit'.
		static KingdomStackStatus()
		{
			Il2CppClassPointerStore<KingdomStackStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "KingdomStackStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KingdomStackStatus>.NativeClassPtr);
			KingdomStackStatus.NativeFieldInfoPtr_kingdom_stack_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStackStatus>.NativeClassPtr, "kingdom_stack_instance_id");
			KingdomStackStatus.NativeFieldInfoPtr_remaining_card_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStackStatus>.NativeClassPtr, "remaining_card_count");
			KingdomStackStatus.NativeFieldInfoPtr_sample_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStackStatus>.NativeClassPtr, "sample_card_instance_id");
			KingdomStackStatus.NativeFieldInfoPtr_stack_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStackStatus>.NativeClassPtr, "stack_location");
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00015316 File Offset: 0x00013516
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KingdomStackStatus>.NativeClassPtr, ref this));
		}

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeFieldInfoPtr_kingdom_stack_instance_id;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeFieldInfoPtr_remaining_card_count;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeFieldInfoPtr_sample_card_instance_id;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeFieldInfoPtr_stack_location;

		// Token: 0x04001746 RID: 5958
		[FieldOffset(0)]
		public int kingdom_stack_instance_id;

		// Token: 0x04001747 RID: 5959
		[FieldOffset(4)]
		public int remaining_card_count;

		// Token: 0x04001748 RID: 5960
		[FieldOffset(8)]
		public int sample_card_instance_id;

		// Token: 0x04001749 RID: 5961
		[FieldOffset(12)]
		public ushort stack_location;
	}
}
