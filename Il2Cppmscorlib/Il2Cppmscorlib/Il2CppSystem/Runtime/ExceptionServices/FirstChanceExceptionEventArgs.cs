using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x0200040D RID: 1037
	public class FirstChanceExceptionEventArgs : EventArgs
	{
		// Token: 0x06004162 RID: 16738 RVA: 0x00018DC6 File Offset: 0x00016FC6
		// Note: this type is marked as 'beforefieldinit'.
		static FirstChanceExceptionEventArgs()
		{
			Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "FirstChanceExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x00018DEB File Offset: 0x00016FEB
		public FirstChanceExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
