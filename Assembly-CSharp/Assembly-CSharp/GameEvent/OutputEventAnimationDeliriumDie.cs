using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200013F RID: 319
	[StructLayout(2)]
	public struct OutputEventAnimationDeliriumDie
	{
		// Token: 0x060021EF RID: 8687 RVA: 0x00080768 File Offset: 0x0007E968
		// Note: this type is marked as 'beforefieldinit'.
		static OutputEventAnimationDeliriumDie()
		{
			Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "OutputEventAnimationDeliriumDie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr);
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_delirium_die_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "delirium_die_instance_id");
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_effect_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "effect_type");
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_animation_source_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "animation_source_location");
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_animation_source_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "animation_source_instance_id");
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_animation_destination_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "animation_destination_location");
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_animation_destination_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "animation_destination_instance_id");
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_animation_event_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "animation_event_hint");
			OutputEventAnimationDeliriumDie.NativeFieldInfoPtr_animation_extra_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, "animation_extra_data");
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00015328 File Offset: 0x00013528
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutputEventAnimationDeliriumDie>.NativeClassPtr, ref this));
		}

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeFieldInfoPtr_delirium_die_instance_id;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeFieldInfoPtr_effect_type;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeFieldInfoPtr_animation_source_location;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeFieldInfoPtr_animation_source_instance_id;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeFieldInfoPtr_animation_destination_location;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeFieldInfoPtr_animation_destination_instance_id;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeFieldInfoPtr_animation_event_hint;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeFieldInfoPtr_animation_extra_data;

		// Token: 0x04001752 RID: 5970
		[FieldOffset(0)]
		public int delirium_die_instance_id;

		// Token: 0x04001753 RID: 5971
		[FieldOffset(4)]
		public int effect_type;

		// Token: 0x04001754 RID: 5972
		[FieldOffset(8)]
		public int animation_source_location;

		// Token: 0x04001755 RID: 5973
		[FieldOffset(12)]
		public int animation_source_instance_id;

		// Token: 0x04001756 RID: 5974
		[FieldOffset(16)]
		public int animation_destination_location;

		// Token: 0x04001757 RID: 5975
		[FieldOffset(20)]
		public int animation_destination_instance_id;

		// Token: 0x04001758 RID: 5976
		[FieldOffset(24)]
		public int animation_event_hint;

		// Token: 0x04001759 RID: 5977
		[FieldOffset(28)]
		public int animation_extra_data;
	}
}
