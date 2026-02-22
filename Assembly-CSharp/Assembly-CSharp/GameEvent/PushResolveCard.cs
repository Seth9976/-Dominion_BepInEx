using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000157 RID: 343
	[StructLayout(2)]
	public struct PushResolveCard
	{
		// Token: 0x0600222F RID: 8751 RVA: 0x000156F1 File Offset: 0x000138F1
		// Note: this type is marked as 'beforefieldinit'.
		static PushResolveCard()
		{
			Il2CppClassPointerStore<PushResolveCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "PushResolveCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PushResolveCard>.NativeClassPtr);
			PushResolveCard.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PushResolveCard>.NativeClassPtr, "card");
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0001572A File Offset: 0x0001392A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PushResolveCard>.NativeClassPtr, ref this));
		}

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x040017C6 RID: 6086
		[FieldOffset(0)]
		public int card;
	}
}
