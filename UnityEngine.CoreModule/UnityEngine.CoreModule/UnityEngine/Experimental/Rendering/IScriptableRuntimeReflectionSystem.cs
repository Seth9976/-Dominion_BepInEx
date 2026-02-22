using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200016A RID: 362
	public class IScriptableRuntimeReflectionSystem : Il2CppObjectBase
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x0000ED4A File Offset: 0x0000CF4A
		// Note: this type is marked as 'beforefieldinit'.
		static IScriptableRuntimeReflectionSystem()
		{
			Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "IScriptableRuntimeReflectionSystem");
			IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr, 100665278);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000600A4 File Offset: 0x0005E2A4
		[CallerCount(0)]
		public unsafe virtual bool TickRealtimeProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0000ED79 File Offset: 0x0000CF79
		public IScriptableRuntimeReflectionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0;
	}
}
