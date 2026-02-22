using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000159 RID: 345
	[StructLayout(2)]
	public struct PushRevealCard
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x00081090 File Offset: 0x0007F290
		// Note: this type is marked as 'beforefieldinit'.
		static PushRevealCard()
		{
			Il2CppClassPointerStore<PushRevealCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "PushRevealCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PushRevealCard>.NativeClassPtr);
			PushRevealCard.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PushRevealCard>.NativeClassPtr, "card");
			PushRevealCard.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PushRevealCard>.NativeClassPtr, "player");
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00015787 File Offset: 0x00013987
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PushRevealCard>.NativeClassPtr, ref this));
		}

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040017CB RID: 6091
		[FieldOffset(0)]
		public int card;

		// Token: 0x040017CC RID: 6092
		[FieldOffset(4)]
		public int player;
	}
}
