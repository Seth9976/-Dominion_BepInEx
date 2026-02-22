using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200015F RID: 351
	[StructLayout(2)]
	public struct LogUpdated
	{
		// Token: 0x0600223F RID: 8767 RVA: 0x00015910 File Offset: 0x00013B10
		// Note: this type is marked as 'beforefieldinit'.
		static LogUpdated()
		{
			Il2CppClassPointerStore<LogUpdated>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "LogUpdated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogUpdated>.NativeClassPtr);
			LogUpdated.NativeFieldInfoPtr_update_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogUpdated>.NativeClassPtr, "update_count");
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00015949 File Offset: 0x00013B49
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogUpdated>.NativeClassPtr, ref this));
		}

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeFieldInfoPtr_update_count;

		// Token: 0x040017D8 RID: 6104
		[FieldOffset(0)]
		public int update_count;
	}
}
