using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E4 RID: 228
	public sealed class StylePropertyValue : ValueType
	{
		// Token: 0x06000CA5 RID: 3237 RVA: 0x00032CBC File Offset: 0x00030EBC
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyValue()
		{
			Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr);
			StylePropertyValue.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr, "sheet");
			StylePropertyValue.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr, "handle");
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0000800C File Offset: 0x0000620C
		public StylePropertyValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00008015 File Offset: 0x00006215
		public StylePropertyValue()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyValue>.NativeClassPtr))
		{
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00032D14 File Offset: 0x00030F14
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00008027 File Offset: 0x00006227
		public unsafe StyleSheet sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00032D44 File Offset: 0x00030F44
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00008046 File Offset: 0x00006246
		public unsafe StyleValueHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValue.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_sheet;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_handle;
	}
}
