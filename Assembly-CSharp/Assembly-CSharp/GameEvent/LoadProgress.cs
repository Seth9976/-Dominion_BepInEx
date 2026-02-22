using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200015C RID: 348
	[StructLayout(2)]
	public struct LoadProgress
	{
		// Token: 0x06002239 RID: 8761 RVA: 0x0001582F File Offset: 0x00013A2F
		// Note: this type is marked as 'beforefieldinit'.
		static LoadProgress()
		{
			Il2CppClassPointerStore<LoadProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "LoadProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadProgress>.NativeClassPtr);
			LoadProgress.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadProgress>.NativeClassPtr, "progress");
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00015868 File Offset: 0x00013A68
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadProgress>.NativeClassPtr, ref this));
		}

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeFieldInfoPtr_progress;

		// Token: 0x040017D2 RID: 6098
		[FieldOffset(0)]
		public float progress;
	}
}
