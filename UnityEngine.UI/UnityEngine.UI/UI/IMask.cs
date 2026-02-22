using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000016 RID: 22
	public class IMask : Il2CppObjectBase
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0000FF54 File Offset: 0x0000E154
		// Note: this type is marked as 'beforefieldinit'.
		static IMask()
		{
			Il2CppClassPointerStore<IMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMask");
			IMask.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMask>.NativeClassPtr, 100663632);
			IMask.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMask>.NativeClassPtr, 100663633);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		[CallerCount(0)]
		public unsafe virtual bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMask.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		public unsafe virtual RectTransform rectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMask.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002D18 File Offset: 0x00000F18
		public IMask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0;
	}
}
