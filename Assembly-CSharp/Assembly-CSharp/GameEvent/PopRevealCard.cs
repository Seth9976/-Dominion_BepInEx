using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200015A RID: 346
	[StructLayout(2)]
	public struct PopRevealCard
	{
		// Token: 0x06002235 RID: 8757 RVA: 0x00015799 File Offset: 0x00013999
		// Note: this type is marked as 'beforefieldinit'.
		static PopRevealCard()
		{
			Il2CppClassPointerStore<PopRevealCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "PopRevealCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopRevealCard>.NativeClassPtr);
			PopRevealCard.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopRevealCard>.NativeClassPtr, "card");
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x000157D2 File Offset: 0x000139D2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PopRevealCard>.NativeClassPtr, ref this));
		}

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x040017CE RID: 6094
		[FieldOffset(0)]
		public int card;
	}
}
