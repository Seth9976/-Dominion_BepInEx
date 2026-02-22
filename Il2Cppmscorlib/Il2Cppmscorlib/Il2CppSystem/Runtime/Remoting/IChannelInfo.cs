using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038E RID: 910
	public class IChannelInfo : Il2CppObjectBase
	{
		// Token: 0x06003B38 RID: 15160 RVA: 0x00016488 File Offset: 0x00014688
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelInfo()
		{
			Il2CppClassPointerStore<IChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IChannelInfo");
			IChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelInfo>.NativeClassPtr, 100672055);
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06003B39 RID: 15161 RVA: 0x00117D80 File Offset: 0x00115F80
		public unsafe virtual Il2CppReferenceArray<Object> ChannelData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x000164B7 File Offset: 0x000146B7
		public IChannelInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;
	}
}
