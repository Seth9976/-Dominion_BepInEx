using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000094 RID: 148
	public class IPointerEventInternal : Il2CppObjectBase
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x00025650 File Offset: 0x00023850
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerEventInternal()
		{
			Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IPointerEventInternal");
			IPointerEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100664041);
			IPointerEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100664042);
			IPointerEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100664043);
			IPointerEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100664044);
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x000256C8 File Offset: 0x000238C8
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00025710 File Offset: 0x00023910
		public unsafe virtual bool triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0002575C File Offset: 0x0002395C
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x000257A4 File Offset: 0x000239A4
		public unsafe virtual bool recomputeTopElementUnderPointer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000551D File Offset: 0x0000371D
		public IPointerEventInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_get_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_set_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
