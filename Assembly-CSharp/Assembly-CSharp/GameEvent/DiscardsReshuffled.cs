using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000155 RID: 341
	[StructLayout(2)]
	public struct DiscardsReshuffled
	{
		// Token: 0x0600222B RID: 8747 RVA: 0x0001566F File Offset: 0x0001386F
		// Note: this type is marked as 'beforefieldinit'.
		static DiscardsReshuffled()
		{
			Il2CppClassPointerStore<DiscardsReshuffled>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "DiscardsReshuffled");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscardsReshuffled>.NativeClassPtr);
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00015694 File Offset: 0x00013894
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscardsReshuffled>.NativeClassPtr, ref this));
		}
	}
}
