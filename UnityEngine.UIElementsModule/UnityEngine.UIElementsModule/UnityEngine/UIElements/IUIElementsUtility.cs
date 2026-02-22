using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000039 RID: 57
	public class IUIElementsUtility : Il2CppObjectBase
	{
		// Token: 0x060002FA RID: 762 RVA: 0x00015390 File Offset: 0x00013590
		// Note: this type is marked as 'beforefieldinit'.
		static IUIElementsUtility()
		{
			Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IUIElementsUtility");
			IUIElementsUtility.NativeMethodInfoPtr_TakeCapture_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100663542);
			IUIElementsUtility.NativeMethodInfoPtr_ReleaseCapture_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100663543);
			IUIElementsUtility.NativeMethodInfoPtr_ProcessEvent_Public_Abstract_Virtual_New_Boolean_Int32_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100663544);
			IUIElementsUtility.NativeMethodInfoPtr_CleanupRoots_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100663545);
			IUIElementsUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Public_Abstract_Virtual_New_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100663546);
			IUIElementsUtility.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100663547);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00015430 File Offset: 0x00013630
		[CallerCount(0)]
		public unsafe virtual bool TakeCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_TakeCapture_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00015478 File Offset: 0x00013678
		[CallerCount(0)]
		public unsafe virtual bool ReleaseCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_ReleaseCapture_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000154C0 File Offset: 0x000136C0
		[CallerCount(0)]
		public unsafe virtual bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventHandled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_ProcessEvent_Public_Abstract_Virtual_New_Boolean_Int32_IntPtr_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00015530 File Offset: 0x00013730
		[CallerCount(0)]
		public unsafe virtual bool CleanupRoots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_CleanupRoots_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00015578 File Offset: 0x00013778
		[CallerCount(0)]
		public unsafe virtual bool EndContainerGUIFromException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Public_Abstract_Virtual_New_Boolean_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000155D0 File Offset: 0x000137D0
		[CallerCount(0)]
		public unsafe virtual bool MakeCurrentIMGUIContainerDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000037A1 File Offset: 0x000019A1
		public IUIElementsUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_TakeCapture_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCapture_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Abstract_Virtual_New_Boolean_Int32_IntPtr_byref_Boolean_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRoots_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUIFromException_Public_Abstract_Virtual_New_Boolean_Exception_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Public_Abstract_Virtual_New_Boolean_0;
	}
}
