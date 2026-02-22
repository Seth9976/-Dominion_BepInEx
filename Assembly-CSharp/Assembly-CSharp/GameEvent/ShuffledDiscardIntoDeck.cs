using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000154 RID: 340
	[StructLayout(2)]
	public struct ShuffledDiscardIntoDeck
	{
		// Token: 0x06002229 RID: 8745 RVA: 0x00015624 File Offset: 0x00013824
		// Note: this type is marked as 'beforefieldinit'.
		static ShuffledDiscardIntoDeck()
		{
			Il2CppClassPointerStore<ShuffledDiscardIntoDeck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "ShuffledDiscardIntoDeck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShuffledDiscardIntoDeck>.NativeClassPtr);
			ShuffledDiscardIntoDeck.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuffledDiscardIntoDeck>.NativeClassPtr, "zero");
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0001565D File Offset: 0x0001385D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShuffledDiscardIntoDeck>.NativeClassPtr, ref this));
		}

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040017C2 RID: 6082
		[FieldOffset(0)]
		public int zero;
	}
}
