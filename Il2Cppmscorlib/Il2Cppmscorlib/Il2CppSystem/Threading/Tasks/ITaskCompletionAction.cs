using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A7 RID: 679
	public class ITaskCompletionAction : Il2CppObjectBase
	{
		// Token: 0x06002E06 RID: 11782 RVA: 0x000100F2 File Offset: 0x0000E2F2
		// Note: this type is marked as 'beforefieldinit'.
		static ITaskCompletionAction()
		{
			Il2CppClassPointerStore<ITaskCompletionAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ITaskCompletionAction");
			ITaskCompletionAction.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITaskCompletionAction>.NativeClassPtr, 100670602);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000E94B8 File Offset: 0x000E76B8
		[CallerCount(0)]
		public unsafe virtual void Invoke(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITaskCompletionAction.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00010121 File Offset: 0x0000E321
		public ITaskCompletionAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0;
	}
}
