using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct UICharInfo
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00004418 File Offset: 0x00002618
		// Note: this type is marked as 'beforefieldinit'.
		static UICharInfo()
		{
			Il2CppClassPointerStore<UICharInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UICharInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr);
			UICharInfo.NativeFieldInfoPtr_cursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, "cursorPos");
			UICharInfo.NativeFieldInfoPtr_charWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, "charWidth");
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000024EC File Offset: 0x000006EC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_cursorPos;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_charWidth;

		// Token: 0x0400007B RID: 123
		[FieldOffset(0)]
		public Vector2 cursorPos;

		// Token: 0x0400007C RID: 124
		[FieldOffset(8)]
		public float charWidth;
	}
}
