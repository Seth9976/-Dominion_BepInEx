using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000F RID: 15
	public class IFocusRing : Il2CppObjectBase
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x0000E754 File Offset: 0x0000C954
		// Note: this type is marked as 'beforefieldinit'.
		static IFocusRing()
		{
			Il2CppClassPointerStore<IFocusRing>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IFocusRing");
			IFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Abstract_Virtual_New_FocusChangeDirection_Focusable_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFocusRing>.NativeClassPtr, 100663346);
			IFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Abstract_Virtual_New_Focusable_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFocusRing>.NativeClassPtr, 100663347);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		[CallerCount(0)]
		public unsafe virtual FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Abstract_Virtual_New_FocusChangeDirection_Focusable_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000E814 File Offset: 0x0000CA14
		[CallerCount(0)]
		public unsafe virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Abstract_Virtual_New_Focusable_Focusable_FocusChangeDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002584 File Offset: 0x00000784
		public IFocusRing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusChangeDirection_Public_Abstract_Virtual_New_FocusChangeDirection_Focusable_EventBase_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFocusable_Public_Abstract_Virtual_New_Focusable_Focusable_FocusChangeDirection_0;
	}
}
