using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028D RID: 653
	public sealed class Mutex : WaitHandle
	{
		// Token: 0x06002C61 RID: 11361 RVA: 0x0000F6C7 File Offset: 0x0000D8C7
		// Note: this type is marked as 'beforefieldinit'.
		static Mutex()
		{
			Il2CppClassPointerStore<Mutex>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Mutex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mutex>.NativeClassPtr);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		public Mutex(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
