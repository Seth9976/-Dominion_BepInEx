using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace SA.Foundation.Events
{
	// Token: 0x02000036 RID: 54
	public class SA_iSafeEvent : Il2CppObjectBase
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x0000A348 File Offset: 0x00008548
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iSafeEvent()
		{
			Il2CppClassPointerStore<SA_iSafeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_iSafeEvent");
			SA_iSafeEvent.NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iSafeEvent>.NativeClassPtr, 100663553);
			SA_iSafeEvent.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iSafeEvent>.NativeClassPtr, 100663554);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000A398 File Offset: 0x00008598
		[CallerCount(0)]
		public unsafe virtual void AddSafeListener(Object callbackTarget, Action listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iSafeEvent.NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[CallerCount(0)]
		public unsafe virtual void RemoveListener(Action listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iSafeEvent.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000262B File Offset: 0x0000082B
		public SA_iSafeEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
