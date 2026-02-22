using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A6 RID: 678
	[StructLayout(2)]
	public struct VoidTaskResult
	{
		// Token: 0x06002E04 RID: 11780 RVA: 0x000100BB File Offset: 0x0000E2BB
		// Note: this type is marked as 'beforefieldinit'.
		static VoidTaskResult()
		{
			Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "VoidTaskResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000100E0 File Offset: 0x0000E2E0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr, ref this));
		}
	}
}
