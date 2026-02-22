using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace SA.Foundation.Events
{
	// Token: 0x02000033 RID: 51
	public class SA_iEvent : Il2CppObjectBase
	{
		// Token: 0x0600019A RID: 410 RVA: 0x000025E1 File Offset: 0x000007E1
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iEvent()
		{
			Il2CppClassPointerStore<SA_iEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_iEvent");
			SA_iEvent.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iEvent>.NativeClassPtr, 100663548);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000A070 File Offset: 0x00008270
		[CallerCount(0)]
		public unsafe virtual void AddListener(Action listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iEvent.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002610 File Offset: 0x00000810
		public SA_iEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
