using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C6 RID: 198
	public sealed class StyleVariable : ValueType
	{
		// Token: 0x06000B4C RID: 2892 RVA: 0x0002F450 File Offset: 0x0002D650
		// Note: this type is marked as 'beforefieldinit'.
		static StyleVariable()
		{
			Il2CppClassPointerStore<StyleVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr);
			StyleVariable.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, "name");
			StyleVariable.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, "sheet");
			StyleVariable.NativeFieldInfoPtr_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, "handles");
			StyleVariable.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, 100664262);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002F4D0 File Offset: 0x0002D6D0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariable.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00007149 File Offset: 0x00005349
		public StyleVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00007152 File Offset: 0x00005352
		public StyleVariable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr))
		{
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0002F514 File Offset: 0x0002D714
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00007164 File Offset: 0x00005364
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0002F53C File Offset: 0x0002D73C
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00007183 File Offset: 0x00005383
		public unsafe StyleSheet sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0002F56C File Offset: 0x0002D76C
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x000071A2 File Offset: 0x000053A2
		public unsafe Il2CppStructArray<StyleValueHandle> handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeFieldInfoPtr_sheet;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr_handles;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
