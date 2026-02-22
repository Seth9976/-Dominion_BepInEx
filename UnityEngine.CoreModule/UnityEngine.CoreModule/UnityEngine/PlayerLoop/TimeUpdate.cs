using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x0200011F RID: 287
	[StructLayout(2)]
	public struct TimeUpdate
	{
		// Token: 0x0600171F RID: 5919 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		// Note: this type is marked as 'beforefieldinit'.
		static TimeUpdate()
		{
			Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "TimeUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0000CF0D File Offset: 0x0000B10D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008DB RID: 2267
		[StructLayout(2)]
		public struct WaitForLastPresentationAndUpdateTime
		{
			// Token: 0x06002FB9 RID: 12217 RVA: 0x00015D5B File Offset: 0x00013F5B
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForLastPresentationAndUpdateTime()
			{
				Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, "WaitForLastPresentationAndUpdateTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr);
			}

			// Token: 0x06002FBA RID: 12218 RVA: 0x00015D7B File Offset: 0x00013F7B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr, ref this));
			}
		}
	}
}
