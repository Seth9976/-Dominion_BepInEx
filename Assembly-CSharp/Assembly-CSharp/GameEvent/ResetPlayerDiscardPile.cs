using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000144 RID: 324
	[StructLayout(2)]
	public struct ResetPlayerDiscardPile
	{
		// Token: 0x060021F9 RID: 8697 RVA: 0x00015382 File Offset: 0x00013582
		// Note: this type is marked as 'beforefieldinit'.
		static ResetPlayerDiscardPile()
		{
			Il2CppClassPointerStore<ResetPlayerDiscardPile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "ResetPlayerDiscardPile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetPlayerDiscardPile>.NativeClassPtr);
			ResetPlayerDiscardPile.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPlayerDiscardPile>.NativeClassPtr, "player_instance_id");
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000153BB File Offset: 0x000135BB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResetPlayerDiscardPile>.NativeClassPtr, ref this));
		}

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x04001771 RID: 6001
		[FieldOffset(0)]
		public int player_instance_id;
	}
}
