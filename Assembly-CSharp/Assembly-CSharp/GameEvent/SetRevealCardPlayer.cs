using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200015B RID: 347
	[StructLayout(2)]
	public struct SetRevealCardPlayer
	{
		// Token: 0x06002237 RID: 8759 RVA: 0x000157E4 File Offset: 0x000139E4
		// Note: this type is marked as 'beforefieldinit'.
		static SetRevealCardPlayer()
		{
			Il2CppClassPointerStore<SetRevealCardPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "SetRevealCardPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRevealCardPlayer>.NativeClassPtr);
			SetRevealCardPlayer.NativeFieldInfoPtr_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRevealCardPlayer>.NativeClassPtr, "player_index");
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0001581D File Offset: 0x00013A1D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetRevealCardPlayer>.NativeClassPtr, ref this));
		}

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeFieldInfoPtr_player_index;

		// Token: 0x040017D0 RID: 6096
		[FieldOffset(0)]
		public int player_index;
	}
}
