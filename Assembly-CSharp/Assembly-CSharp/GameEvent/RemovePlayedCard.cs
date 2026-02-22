using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200014B RID: 331
	[StructLayout(2)]
	public struct RemovePlayedCard
	{
		// Token: 0x06002207 RID: 8711 RVA: 0x00080BF0 File Offset: 0x0007EDF0
		// Note: this type is marked as 'beforefieldinit'.
		static RemovePlayedCard()
		{
			Il2CppClassPointerStore<RemovePlayedCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "RemovePlayedCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePlayedCard>.NativeClassPtr);
			RemovePlayedCard.NativeFieldInfoPtr_remove_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePlayedCard>.NativeClassPtr, "remove_instance_id");
			RemovePlayedCard.NativeFieldInfoPtr_played_card_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePlayedCard>.NativeClassPtr, "played_card_flags");
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00015472 File Offset: 0x00013672
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemovePlayedCard>.NativeClassPtr, ref this));
		}

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeFieldInfoPtr_remove_instance_id;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeFieldInfoPtr_played_card_flags;

		// Token: 0x04001794 RID: 6036
		[FieldOffset(0)]
		public int remove_instance_id;

		// Token: 0x04001795 RID: 6037
		[FieldOffset(4)]
		public uint played_card_flags;
	}
}
