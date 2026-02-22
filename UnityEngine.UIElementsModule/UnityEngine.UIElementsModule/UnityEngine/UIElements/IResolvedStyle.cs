using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B6 RID: 182
	public class IResolvedStyle : Il2CppObjectBase
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x0002C0AC File Offset: 0x0002A2AC
		// Note: this type is marked as 'beforefieldinit'.
		static IResolvedStyle()
		{
			Il2CppClassPointerStore<IResolvedStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IResolvedStyle");
			IResolvedStyle.NativeMethodInfoPtr_get_display_Public_Abstract_Virtual_New_get_DisplayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolvedStyle>.NativeClassPtr, 100664190);
			IResolvedStyle.NativeMethodInfoPtr_get_visibility_Public_Abstract_Virtual_New_get_Visibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolvedStyle>.NativeClassPtr, 100664191);
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002C0FC File Offset: 0x0002A2FC
		public unsafe virtual DisplayStyle display
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolvedStyle.NativeMethodInfoPtr_get_display_Public_Abstract_Virtual_New_get_DisplayStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0002C144 File Offset: 0x0002A344
		public unsafe virtual Visibility visibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolvedStyle.NativeMethodInfoPtr_get_visibility_Public_Abstract_Virtual_New_get_Visibility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000064FC File Offset: 0x000046FC
		public IResolvedStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_get_display_Public_Abstract_Virtual_New_get_DisplayStyle_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_get_visibility_Public_Abstract_Virtual_New_get_Visibility_0;
	}
}
