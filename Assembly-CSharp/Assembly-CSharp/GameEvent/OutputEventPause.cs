using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200013B RID: 315
	[StructLayout(2)]
	public struct OutputEventPause
	{
		// Token: 0x060021E7 RID: 8679 RVA: 0x0008048C File Offset: 0x0007E68C
		// Note: this type is marked as 'beforefieldinit'.
		static OutputEventPause()
		{
			Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "OutputEventPause");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr);
			OutputEventPause.NativeFieldInfoPtr_pause_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr, "pause_type");
			OutputEventPause.NativeFieldInfoPtr_animation_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr, "animation_data");
			OutputEventPause.NativeFieldInfoPtr_include_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr, "include_player_index");
			OutputEventPause.NativeFieldInfoPtr_exclude_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr, "exclude_player_index");
			OutputEventPause.NativeFieldInfoPtr_pause_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr, "pause_timer");
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000152E0 File Offset: 0x000134E0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutputEventPause>.NativeClassPtr, ref this));
		}

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_pause_type;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_animation_data;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeFieldInfoPtr_include_player_index;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr_exclude_player_index;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_pause_timer;

		// Token: 0x04001719 RID: 5913
		[FieldOffset(0)]
		public int pause_type;

		// Token: 0x0400171A RID: 5914
		[FieldOffset(4)]
		public uint animation_data;

		// Token: 0x0400171B RID: 5915
		[FieldOffset(8)]
		public int include_player_index;

		// Token: 0x0400171C RID: 5916
		[FieldOffset(12)]
		public int exclude_player_index;

		// Token: 0x0400171D RID: 5917
		[FieldOffset(16)]
		public float pause_timer;
	}
}
