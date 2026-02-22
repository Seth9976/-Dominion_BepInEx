using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200015E RID: 350
	[StructLayout(2)]
	public struct PauseForRevealedCards
	{
		// Token: 0x0600223D RID: 8765 RVA: 0x000158C5 File Offset: 0x00013AC5
		// Note: this type is marked as 'beforefieldinit'.
		static PauseForRevealedCards()
		{
			Il2CppClassPointerStore<PauseForRevealedCards>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "PauseForRevealedCards");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseForRevealedCards>.NativeClassPtr);
			PauseForRevealedCards.NativeFieldInfoPtr_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseForRevealedCards>.NativeClassPtr, "player_index");
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000158FE File Offset: 0x00013AFE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PauseForRevealedCards>.NativeClassPtr, ref this));
		}

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeFieldInfoPtr_player_index;

		// Token: 0x040017D6 RID: 6102
		[FieldOffset(0)]
		public int player_index;
	}
}
