using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200013D RID: 317
	[StructLayout(2)]
	public struct OutputEventAnimationResource
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x000805F0 File Offset: 0x0007E7F0
		// Note: this type is marked as 'beforefieldinit'.
		static OutputEventAnimationResource()
		{
			Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "OutputEventAnimationResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr);
			OutputEventAnimationResource.NativeFieldInfoPtr_animation_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "animation_type");
			OutputEventAnimationResource.NativeFieldInfoPtr_effect_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "effect_type");
			OutputEventAnimationResource.NativeFieldInfoPtr_animation_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "animation_hint");
			OutputEventAnimationResource.NativeFieldInfoPtr_animation_source_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "animation_source_location");
			OutputEventAnimationResource.NativeFieldInfoPtr_animation_source_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "animation_source_instance_id");
			OutputEventAnimationResource.NativeFieldInfoPtr_animation_destination_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "animation_destination_location");
			OutputEventAnimationResource.NativeFieldInfoPtr_animation_destination_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "animation_destination_instance_id");
			OutputEventAnimationResource.NativeFieldInfoPtr_animation_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "animation_card_instance_id");
			OutputEventAnimationResource.NativeFieldInfoPtr_extra_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "extra_data");
			OutputEventAnimationResource.NativeFieldInfoPtr_owner_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, "owner_id");
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00015304 File Offset: 0x00013504
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutputEventAnimationResource>.NativeClassPtr, ref this));
		}

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr_animation_type;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeFieldInfoPtr_effect_type;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeFieldInfoPtr_animation_hint;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeFieldInfoPtr_animation_source_location;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeFieldInfoPtr_animation_source_instance_id;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeFieldInfoPtr_animation_destination_location;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeFieldInfoPtr_animation_destination_instance_id;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeFieldInfoPtr_animation_card_instance_id;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_extra_data;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_owner_id;

		// Token: 0x04001738 RID: 5944
		[FieldOffset(0)]
		public uint animation_type;

		// Token: 0x04001739 RID: 5945
		[FieldOffset(4)]
		public uint effect_type;

		// Token: 0x0400173A RID: 5946
		[FieldOffset(8)]
		public uint animation_hint;

		// Token: 0x0400173B RID: 5947
		[FieldOffset(12)]
		public uint animation_source_location;

		// Token: 0x0400173C RID: 5948
		[FieldOffset(16)]
		public uint animation_source_instance_id;

		// Token: 0x0400173D RID: 5949
		[FieldOffset(20)]
		public uint animation_destination_location;

		// Token: 0x0400173E RID: 5950
		[FieldOffset(24)]
		public uint animation_destination_instance_id;

		// Token: 0x0400173F RID: 5951
		[FieldOffset(28)]
		public uint animation_card_instance_id;

		// Token: 0x04001740 RID: 5952
		[FieldOffset(32)]
		public uint extra_data;

		// Token: 0x04001741 RID: 5953
		[FieldOffset(36)]
		public uint owner_id;
	}
}
