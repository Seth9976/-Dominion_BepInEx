using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000077 RID: 119
	public class IMouseEventInternal : Il2CppObjectBase
	{
		// Token: 0x060006B9 RID: 1721 RVA: 0x00021B08 File Offset: 0x0001FD08
		// Note: this type is marked as 'beforefieldinit'.
		static IMouseEventInternal()
		{
			Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMouseEventInternal");
			IMouseEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100663904);
			IMouseEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100663905);
			IMouseEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100663906);
			IMouseEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100663907);
			IMouseEventInternal.NativeMethodInfoPtr_get_sourcePointerEvent_Public_Abstract_Virtual_New_get_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100663908);
			IMouseEventInternal.NativeMethodInfoPtr_set_sourcePointerEvent_Public_Abstract_Virtual_New_set_Void_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100663909);
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00021BA8 File Offset: 0x0001FDA8
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00021BF0 File Offset: 0x0001FDF0
		public unsafe virtual bool triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00021C3C File Offset: 0x0001FE3C
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00021C84 File Offset: 0x0001FE84
		public unsafe virtual bool recomputeTopElementUnderMouse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00021CD0 File Offset: 0x0001FED0
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00021D1C File Offset: 0x0001FF1C
		public unsafe virtual IPointerEvent sourcePointerEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_get_sourcePointerEvent_Public_Abstract_Virtual_New_get_IPointerEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPointerEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_set_sourcePointerEvent_Public_Abstract_Virtual_New_set_Void_IPointerEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00004F89 File Offset: 0x00003189
		public IMouseEventInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_get_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_set_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_get_sourcePointerEvent_Public_Abstract_Virtual_New_get_IPointerEvent_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_set_sourcePointerEvent_Public_Abstract_Virtual_New_set_Void_IPointerEvent_0;
	}
}
