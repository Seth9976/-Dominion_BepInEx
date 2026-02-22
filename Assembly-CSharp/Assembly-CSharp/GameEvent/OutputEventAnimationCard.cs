using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200013C RID: 316
	[StructLayout(2)]
	public struct OutputEventAnimationCard
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x00080520 File Offset: 0x0007E720
		// Note: this type is marked as 'beforefieldinit'.
		static OutputEventAnimationCard()
		{
			Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "OutputEventAnimationCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr);
			OutputEventAnimationCard.NativeFieldInfoPtr_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "card_instance_id");
			OutputEventAnimationCard.NativeFieldInfoPtr_effect_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "effect_type");
			OutputEventAnimationCard.NativeFieldInfoPtr_animation_source_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "animation_source_location");
			OutputEventAnimationCard.NativeFieldInfoPtr_animation_source_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "animation_source_instance_id");
			OutputEventAnimationCard.NativeFieldInfoPtr_animation_destination_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "animation_destination_location");
			OutputEventAnimationCard.NativeFieldInfoPtr_animation_destination_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "animation_destination_instance_id");
			OutputEventAnimationCard.NativeFieldInfoPtr_animation_event_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "animation_event_hint");
			OutputEventAnimationCard.NativeFieldInfoPtr_animation_extra_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, "animation_extra_data");
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000152F2 File Offset: 0x000134F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutputEventAnimationCard>.NativeClassPtr, ref this));
		}

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_card_instance_id;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr_effect_type;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr_animation_source_location;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_animation_source_instance_id;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_animation_destination_location;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_animation_destination_instance_id;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr_animation_event_hint;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr_animation_extra_data;

		// Token: 0x04001726 RID: 5926
		[FieldOffset(0)]
		public int card_instance_id;

		// Token: 0x04001727 RID: 5927
		[FieldOffset(4)]
		public int effect_type;

		// Token: 0x04001728 RID: 5928
		[FieldOffset(8)]
		public int animation_source_location;

		// Token: 0x04001729 RID: 5929
		[FieldOffset(12)]
		public int animation_source_instance_id;

		// Token: 0x0400172A RID: 5930
		[FieldOffset(16)]
		public int animation_destination_location;

		// Token: 0x0400172B RID: 5931
		[FieldOffset(20)]
		public int animation_destination_instance_id;

		// Token: 0x0400172C RID: 5932
		[FieldOffset(24)]
		public int animation_event_hint;

		// Token: 0x0400172D RID: 5933
		[FieldOffset(28)]
		public int animation_extra_data;
	}
}
