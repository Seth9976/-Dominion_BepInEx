using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041B RID: 1051
	public class INotifyCompletion : Il2CppObjectBase
	{
		// Token: 0x060041D1 RID: 16849 RVA: 0x000190EA File Offset: 0x000172EA
		// Note: this type is marked as 'beforefieldinit'.
		static INotifyCompletion()
		{
			Il2CppClassPointerStore<INotifyCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "INotifyCompletion");
			INotifyCompletion.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyCompletion>.NativeClassPtr, 100672878);
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x0012FD88 File Offset: 0x0012DF88
		[CallerCount(0)]
		public unsafe virtual void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifyCompletion.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x00019119 File Offset: 0x00017319
		public INotifyCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035AB RID: 13739
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
