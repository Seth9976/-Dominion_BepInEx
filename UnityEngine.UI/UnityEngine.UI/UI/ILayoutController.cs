using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000020 RID: 32
	public class ILayoutController : Il2CppObjectBase
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x0001727C File Offset: 0x0001547C
		// Note: this type is marked as 'beforefieldinit'.
		static ILayoutController()
		{
			Il2CppClassPointerStore<ILayoutController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ILayoutController");
			ILayoutController.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutController>.NativeClassPtr, 100663912);
			ILayoutController.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutController>.NativeClassPtr, 100663913);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000172CC File Offset: 0x000154CC
		[CallerCount(0)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutController.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00017308 File Offset: 0x00015508
		[CallerCount(0)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutController.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00003756 File Offset: 0x00001956
		public ILayoutController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0;
	}
}
