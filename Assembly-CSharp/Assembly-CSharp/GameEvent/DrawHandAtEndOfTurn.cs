using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000138 RID: 312
	[StructLayout(2)]
	public struct DrawHandAtEndOfTurn
	{
		// Token: 0x060021E1 RID: 8673 RVA: 0x0008035C File Offset: 0x0007E55C
		// Note: this type is marked as 'beforefieldinit'.
		static DrawHandAtEndOfTurn()
		{
			Il2CppClassPointerStore<DrawHandAtEndOfTurn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "DrawHandAtEndOfTurn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawHandAtEndOfTurn>.NativeClassPtr);
			DrawHandAtEndOfTurn.NativeFieldInfoPtr_turn_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawHandAtEndOfTurn>.NativeClassPtr, "turn_player_index");
			DrawHandAtEndOfTurn.NativeFieldInfoPtr_switch_to_opponent_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawHandAtEndOfTurn>.NativeClassPtr, "switch_to_opponent_turn");
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000152AA File Offset: 0x000134AA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawHandAtEndOfTurn>.NativeClassPtr, ref this));
		}

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr_turn_player_index;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr_switch_to_opponent_turn;

		// Token: 0x04001706 RID: 5894
		[FieldOffset(0)]
		public int turn_player_index;

		// Token: 0x04001707 RID: 5895
		[FieldOffset(4)]
		public int switch_to_opponent_turn;
	}
}
