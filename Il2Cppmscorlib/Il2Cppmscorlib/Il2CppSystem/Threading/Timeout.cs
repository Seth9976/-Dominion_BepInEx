using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000289 RID: 649
	public static class Timeout : Object
	{
		// Token: 0x06002C16 RID: 11286 RVA: 0x0000F597 File Offset: 0x0000D797
		// Note: this type is marked as 'beforefieldinit'.
		static Timeout()
		{
			Il2CppClassPointerStore<Timeout>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Timeout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timeout>.NativeClassPtr);
			Timeout.NativeFieldInfoPtr_InfiniteTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timeout>.NativeClassPtr, "InfiniteTimeSpan");
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		public Timeout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x000E1310 File Offset: 0x000DF510
		// (set) Token: 0x06002C19 RID: 11289 RVA: 0x0000F5D9 File Offset: 0x0000D7D9
		public unsafe static TimeSpan InfiniteTimeSpan
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Timeout.NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Timeout.NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&value));
			}
		}

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeFieldInfoPtr_InfiniteTimeSpan;
	}
}
