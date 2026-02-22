using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000148 RID: 328
	[StructLayout(2)]
	public struct TransformCard
	{
		// Token: 0x06002201 RID: 8705 RVA: 0x00080A84 File Offset: 0x0007EC84
		// Note: this type is marked as 'beforefieldinit'.
		static TransformCard()
		{
			Il2CppClassPointerStore<TransformCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "TransformCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformCard>.NativeClassPtr);
			TransformCard.NativeFieldInfoPtr_source_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformCard>.NativeClassPtr, "source_player_instance_id");
			TransformCard.NativeFieldInfoPtr_source_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformCard>.NativeClassPtr, "source_card_instance_id");
			TransformCard.NativeFieldInfoPtr_transform_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformCard>.NativeClassPtr, "transform_card_instance_id");
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0001543C File Offset: 0x0001363C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformCard>.NativeClassPtr, ref this));
		}

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_source_player_instance_id;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr_source_card_instance_id;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeFieldInfoPtr_transform_card_instance_id;

		// Token: 0x0400177F RID: 6015
		[FieldOffset(0)]
		public int source_player_instance_id;

		// Token: 0x04001780 RID: 6016
		[FieldOffset(4)]
		public int source_card_instance_id;

		// Token: 0x04001781 RID: 6017
		[FieldOffset(8)]
		public int transform_card_instance_id;
	}
}
