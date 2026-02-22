using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000145 RID: 325
	[StructLayout(2)]
	public struct CloseDreamscapeTray
	{
		// Token: 0x060021FB RID: 8699 RVA: 0x000153CD File Offset: 0x000135CD
		// Note: this type is marked as 'beforefieldinit'.
		static CloseDreamscapeTray()
		{
			Il2CppClassPointerStore<CloseDreamscapeTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "CloseDreamscapeTray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloseDreamscapeTray>.NativeClassPtr);
			CloseDreamscapeTray.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloseDreamscapeTray>.NativeClassPtr, "player_instance_id");
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00015406 File Offset: 0x00013606
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CloseDreamscapeTray>.NativeClassPtr, ref this));
		}

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x04001773 RID: 6003
		[FieldOffset(0)]
		public int player_instance_id;
	}
}
