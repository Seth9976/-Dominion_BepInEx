using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E3 RID: 227
	public class ICloseEx : Il2CppObjectBase
	{
		// Token: 0x06000D10 RID: 3344 RVA: 0x0000713B File Offset: 0x0000533B
		// Note: this type is marked as 'beforefieldinit'.
		static ICloseEx()
		{
			Il2CppClassPointerStore<ICloseEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICloseEx");
			ICloseEx.NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloseEx>.NativeClassPtr, 100665138);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00041B7C File Offset: 0x0003FD7C
		[CallerCount(0)]
		public unsafe virtual void CloseEx(CloseExState closeState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICloseEx.NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0000716A File Offset: 0x0000536A
		public ICloseEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0;
	}
}
