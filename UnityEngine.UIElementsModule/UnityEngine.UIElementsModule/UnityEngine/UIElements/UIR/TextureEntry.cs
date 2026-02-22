using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D4 RID: 212
	public sealed class TextureEntry : ValueType
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x00031268 File Offset: 0x0002F468
		// Note: this type is marked as 'beforefieldinit'.
		static TextureEntry()
		{
			Il2CppClassPointerStore<TextureEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "TextureEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr);
			TextureEntry.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr, "source");
			TextureEntry.NativeFieldInfoPtr_actual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr, "actual");
			TextureEntry.NativeFieldInfoPtr_replaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr, "replaced");
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00007983 File Offset: 0x00005B83
		public TextureEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0000798C File Offset: 0x00005B8C
		public TextureEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureEntry>.NativeClassPtr))
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x000312D4 File Offset: 0x0002F4D4
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0000799E File Offset: 0x00005B9E
		public unsafe Texture source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00031304 File Offset: 0x0002F504
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x000079BD File Offset: 0x00005BBD
		public unsafe TextureId actual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_actual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_actual)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003132C File Offset: 0x0002F52C
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x000079D8 File Offset: 0x00005BD8
		public unsafe bool replaced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_replaced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureEntry.NativeFieldInfoPtr_replaced)) = value;
			}
		}

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeFieldInfoPtr_actual;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_replaced;
	}
}
