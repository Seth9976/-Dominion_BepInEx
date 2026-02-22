using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000045 RID: 69
	public class IVisualElementScheduler : Il2CppObjectBase
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x00004488 File Offset: 0x00002688
		// Note: this type is marked as 'beforefieldinit'.
		static IVisualElementScheduler()
		{
			Il2CppClassPointerStore<IVisualElementScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IVisualElementScheduler");
			IVisualElementScheduler.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduler>.NativeClassPtr, 100663663);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0001B050 File Offset: 0x00019250
		[CallerCount(0)]
		public unsafe virtual IVisualElementScheduledItem Execute(Action updateEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updateEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduler.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr3) : null;
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000044B7 File Offset: 0x000026B7
		public IVisualElementScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_0;
	}
}
