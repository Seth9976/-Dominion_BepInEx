using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000152 RID: 338
	[StructLayout(2)]
	public struct GameOver
	{
		// Token: 0x0600221E RID: 8734 RVA: 0x00015569 File Offset: 0x00013769
		// Note: this type is marked as 'beforefieldinit'.
		static GameOver()
		{
			Il2CppClassPointerStore<GameOver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "GameOver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOver>.NativeClassPtr);
			GameOver.NativeFieldInfoPtr_playEndGamePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOver>.NativeClassPtr, "playEndGamePopup");
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000155A2 File Offset: 0x000137A2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameOver>.NativeClassPtr, ref this));
		}

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeFieldInfoPtr_playEndGamePopup;

		// Token: 0x040017BD RID: 6077
		[FieldOffset(0)]
		public int playEndGamePopup;
	}
}
