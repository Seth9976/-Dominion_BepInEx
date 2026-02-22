using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000156 RID: 342
	[StructLayout(2)]
	public struct CardsAdded
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x000156A6 File Offset: 0x000138A6
		// Note: this type is marked as 'beforefieldinit'.
		static CardsAdded()
		{
			Il2CppClassPointerStore<CardsAdded>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "CardsAdded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardsAdded>.NativeClassPtr);
			CardsAdded.NativeFieldInfoPtr_new_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardsAdded>.NativeClassPtr, "new_cards");
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x000156DF File Offset: 0x000138DF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CardsAdded>.NativeClassPtr, ref this));
		}

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeFieldInfoPtr_new_cards;

		// Token: 0x040017C4 RID: 6084
		[FieldOffset(0)]
		public int new_cards;
	}
}
