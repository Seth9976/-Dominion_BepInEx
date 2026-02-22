using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000037 RID: 55
	public static class UIElementsPackageUtility : Object
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x00014C3C File Offset: 0x00012E3C
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsPackageUtility()
		{
			Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsPackageUtility");
			UIElementsPackageUtility.NativeFieldInfoPtr_EditorResourcesBasePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, "EditorResourcesBasePath");
			UIElementsPackageUtility.NativeFieldInfoPtr_IsUIEPackageLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, "IsUIEPackageLoaded");
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003680 File Offset: 0x00001880
		public UIElementsPackageUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00014C8C File Offset: 0x00012E8C
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003689 File Offset: 0x00001889
		public unsafe static string EditorResourcesBasePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsPackageUtility.NativeFieldInfoPtr_EditorResourcesBasePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsPackageUtility.NativeFieldInfoPtr_EditorResourcesBasePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00014CAC File Offset: 0x00012EAC
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000369B File Offset: 0x0000189B
		public unsafe static bool IsUIEPackageLoaded
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIElementsPackageUtility.NativeFieldInfoPtr_IsUIEPackageLoaded, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsPackageUtility.NativeFieldInfoPtr_IsUIEPackageLoaded, (void*)(&value));
			}
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_EditorResourcesBasePath;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_IsUIEPackageLoaded;
	}
}
