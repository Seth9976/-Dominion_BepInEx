using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038F RID: 911
	public class IEnvoyInfo : Il2CppObjectBase
	{
		// Token: 0x06003B3B RID: 15163 RVA: 0x000164C0 File Offset: 0x000146C0
		// Note: this type is marked as 'beforefieldinit'.
		static IEnvoyInfo()
		{
			Il2CppClassPointerStore<IEnvoyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IEnvoyInfo");
			IEnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnvoyInfo>.NativeClassPtr, 100672056);
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x00117DCC File Offset: 0x00115FCC
		public unsafe virtual IMessageSink EnvoySinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x000164EF File Offset: 0x000146EF
		public IEnvoyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0;
	}
}
