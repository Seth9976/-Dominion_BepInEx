using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000B7 RID: 183
	public class ICloneable : Il2CppObjectBase
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x0000566C File Offset: 0x0000386C
		// Note: this type is marked as 'beforefieldinit'.
		static ICloneable()
		{
			Il2CppClassPointerStore<ICloneable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ICloneable");
			ICloneable.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloneable>.NativeClassPtr, 100665456);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0005C934 File Offset: 0x0005AB34
		[CallerCount(0)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICloneable.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0000569B File Offset: 0x0000389B
		public ICloneable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0;
	}
}
