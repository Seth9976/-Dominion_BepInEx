using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000139 RID: 313
	[StructLayout(2)]
	public struct PlayerSelectedOption
	{
		// Token: 0x060021E3 RID: 8675 RVA: 0x000803B4 File Offset: 0x0007E5B4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSelectedOption()
		{
			Il2CppClassPointerStore<PlayerSelectedOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "PlayerSelectedOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectedOption>.NativeClassPtr);
			PlayerSelectedOption.NativeFieldInfoPtr_selection_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectedOption>.NativeClassPtr, "selection_player_index");
			PlayerSelectedOption.NativeFieldInfoPtr_selection_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectedOption>.NativeClassPtr, "selection_hint");
			PlayerSelectedOption.NativeFieldInfoPtr_selection_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectedOption>.NativeClassPtr, "selection_id");
			PlayerSelectedOption.NativeFieldInfoPtr_selection_optional_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectedOption>.NativeClassPtr, "selection_optional_data");
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000152BC File Offset: 0x000134BC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSelectedOption>.NativeClassPtr, ref this));
		}

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_selection_player_index;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_selection_hint;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_selection_id;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_selection_optional_data;

		// Token: 0x0400170C RID: 5900
		[FieldOffset(0)]
		public uint selection_player_index;

		// Token: 0x0400170D RID: 5901
		[FieldOffset(4)]
		public ushort selection_hint;

		// Token: 0x0400170E RID: 5902
		[FieldOffset(6)]
		public ushort selection_id;

		// Token: 0x0400170F RID: 5903
		[FieldOffset(8)]
		public uint selection_optional_data;
	}
}
