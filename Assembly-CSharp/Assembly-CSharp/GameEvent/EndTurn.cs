using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000137 RID: 311
	[StructLayout(2)]
	public struct EndTurn
	{
		// Token: 0x060021DF RID: 8671 RVA: 0x000802DC File Offset: 0x0007E4DC
		// Note: this type is marked as 'beforefieldinit'.
		static EndTurn()
		{
			Il2CppClassPointerStore<EndTurn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "EndTurn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndTurn>.NativeClassPtr);
			EndTurn.NativeFieldInfoPtr_ussr_ops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndTurn>.NativeClassPtr, "ussr_ops");
			EndTurn.NativeFieldInfoPtr_usa_ops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndTurn>.NativeClassPtr, "usa_ops");
			EndTurn.NativeFieldInfoPtr_defcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndTurn>.NativeClassPtr, "defcon");
			EndTurn.NativeFieldInfoPtr_space_race = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndTurn>.NativeClassPtr, "space_race");
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00015298 File Offset: 0x00013498
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndTurn>.NativeClassPtr, ref this));
		}

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr_ussr_ops;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr_usa_ops;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_defcon;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_space_race;

		// Token: 0x04001700 RID: 5888
		[FieldOffset(0)]
		public int ussr_ops;

		// Token: 0x04001701 RID: 5889
		[FieldOffset(4)]
		public int usa_ops;

		// Token: 0x04001702 RID: 5890
		[FieldOffset(8)]
		public int defcon;

		// Token: 0x04001703 RID: 5891
		[FieldOffset(12)]
		public int space_race;
	}
}
