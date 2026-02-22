using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041C RID: 1052
	public class ICriticalNotifyCompletion : Il2CppObjectBase
	{
		// Token: 0x060041D4 RID: 16852 RVA: 0x00019122 File Offset: 0x00017322
		// Note: this type is marked as 'beforefieldinit'.
		static ICriticalNotifyCompletion()
		{
			Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ICriticalNotifyCompletion");
			ICriticalNotifyCompletion.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr, 100672879);
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x0012FDD8 File Offset: 0x0012DFD8
		[CallerCount(0)]
		public unsafe virtual void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICriticalNotifyCompletion.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x00019151 File Offset: 0x00017351
		public ICriticalNotifyCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035AC RID: 13740
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
