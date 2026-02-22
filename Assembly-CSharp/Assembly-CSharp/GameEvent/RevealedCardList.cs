using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000142 RID: 322
	[StructLayout(2)]
	public struct RevealedCardList
	{
		// Token: 0x060021F5 RID: 8693 RVA: 0x00080910 File Offset: 0x0007EB10
		// Note: this type is marked as 'beforefieldinit'.
		static RevealedCardList()
		{
			Il2CppClassPointerStore<RevealedCardList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "RevealedCardList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealedCardList>.NativeClassPtr);
			RevealedCardList.NativeFieldInfoPtr_active_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealedCardList>.NativeClassPtr, "active_card_instance_id");
			RevealedCardList.NativeFieldInfoPtr_enable_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealedCardList>.NativeClassPtr, "enable_list");
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x0001535E File Offset: 0x0001355E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RevealedCardList>.NativeClassPtr, ref this));
		}

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeFieldInfoPtr_active_card_instance_id;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeFieldInfoPtr_enable_list;

		// Token: 0x04001768 RID: 5992
		[FieldOffset(0)]
		public int active_card_instance_id;

		// Token: 0x04001769 RID: 5993
		[FieldOffset(4)]
		public int enable_list;
	}
}
