using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x0200000A RID: 10
	public class IClipper : Il2CppObjectBase
	{
		// Token: 0x0600007D RID: 125 RVA: 0x000022ED File Offset: 0x000004ED
		// Note: this type is marked as 'beforefieldinit'.
		static IClipper()
		{
			Il2CppClassPointerStore<IClipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IClipper");
			IClipper.NativeMethodInfoPtr_PerformClipping_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClipper>.NativeClassPtr, 100663365);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008D34 File Offset: 0x00006F34
		[CallerCount(0)]
		public unsafe virtual void PerformClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClipper.NativeMethodInfoPtr_PerformClipping_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000231C File Offset: 0x0000051C
		public IClipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_PerformClipping_Public_Abstract_Virtual_New_Void_0;
	}
}
