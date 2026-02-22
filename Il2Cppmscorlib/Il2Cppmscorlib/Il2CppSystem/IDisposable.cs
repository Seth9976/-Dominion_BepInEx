using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000BC RID: 188
	public class IDisposable : Il2CppObjectBase
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x00005726 File Offset: 0x00003926
		// Note: this type is marked as 'beforefieldinit'.
		static IDisposable()
		{
			Il2CppClassPointerStore<IDisposable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IDisposable");
			IDisposable.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDisposable>.NativeClassPtr, 100665477);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0005D2B0 File Offset: 0x0005B4B0
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDisposable.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00005755 File Offset: 0x00003955
		public IDisposable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;
	}
}
