using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000158 RID: 344
	[StructLayout(2)]
	public struct PopResolveCard
	{
		// Token: 0x06002231 RID: 8753 RVA: 0x0001573C File Offset: 0x0001393C
		// Note: this type is marked as 'beforefieldinit'.
		static PopResolveCard()
		{
			Il2CppClassPointerStore<PopResolveCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "PopResolveCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopResolveCard>.NativeClassPtr);
			PopResolveCard.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopResolveCard>.NativeClassPtr, "card");
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00015775 File Offset: 0x00013975
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PopResolveCard>.NativeClassPtr, ref this));
		}

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x040017C8 RID: 6088
		[FieldOffset(0)]
		public int card;
	}
}
