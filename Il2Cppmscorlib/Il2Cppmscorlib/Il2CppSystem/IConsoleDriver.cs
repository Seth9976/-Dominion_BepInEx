using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x0200011C RID: 284
	public class IConsoleDriver : Il2CppObjectBase
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x00007218 File Offset: 0x00005418
		// Note: this type is marked as 'beforefieldinit'.
		static IConsoleDriver()
		{
			Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IConsoleDriver");
			IConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr, 100666781);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0007F3FC File Offset: 0x0007D5FC
		[CallerCount(0)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00007247 File Offset: 0x00005447
		public IConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0;
	}
}
