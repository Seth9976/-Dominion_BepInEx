using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct YogaSize
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000488C File Offset: 0x00002A8C
		// Note: this type is marked as 'beforefieldinit'.
		static YogaSize()
		{
			Il2CppClassPointerStore<YogaSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "YogaSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaSize>.NativeClassPtr);
			YogaSize.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, "width");
			YogaSize.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, "height");
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000292C File Offset: 0x00000B2C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, ref this));
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000089 RID: 137
		[FieldOffset(0)]
		public float width;

		// Token: 0x0400008A RID: 138
		[FieldOffset(4)]
		public float height;
	}
}
