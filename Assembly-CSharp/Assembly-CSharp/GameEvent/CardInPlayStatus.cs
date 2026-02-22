using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000141 RID: 321
	[StructLayout(2)]
	public struct CardInPlayStatus
	{
		// Token: 0x060021F3 RID: 8691 RVA: 0x00080890 File Offset: 0x0007EA90
		// Note: this type is marked as 'beforefieldinit'.
		static CardInPlayStatus()
		{
			Il2CppClassPointerStore<CardInPlayStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "CardInPlayStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardInPlayStatus>.NativeClassPtr);
			CardInPlayStatus.NativeFieldInfoPtr_cardinplay_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayStatus>.NativeClassPtr, "cardinplay_instance_id");
			CardInPlayStatus.NativeFieldInfoPtr_sourcecard_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayStatus>.NativeClassPtr, "sourcecard_instance_id");
			CardInPlayStatus.NativeFieldInfoPtr_owner_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayStatus>.NativeClassPtr, "owner_instance_id");
			CardInPlayStatus.NativeFieldInfoPtr_inplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayStatus>.NativeClassPtr, "inplay");
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0001534C File Offset: 0x0001354C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CardInPlayStatus>.NativeClassPtr, ref this));
		}

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeFieldInfoPtr_cardinplay_instance_id;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeFieldInfoPtr_sourcecard_instance_id;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeFieldInfoPtr_owner_instance_id;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_inplay;

		// Token: 0x04001762 RID: 5986
		[FieldOffset(0)]
		public int cardinplay_instance_id;

		// Token: 0x04001763 RID: 5987
		[FieldOffset(4)]
		public int sourcecard_instance_id;

		// Token: 0x04001764 RID: 5988
		[FieldOffset(8)]
		public int owner_instance_id;

		// Token: 0x04001765 RID: 5989
		[FieldOffset(12)]
		public int inplay;
	}
}
