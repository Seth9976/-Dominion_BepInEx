using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct UILineInfo
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00004470 File Offset: 0x00002670
		// Note: this type is marked as 'beforefieldinit'.
		static UILineInfo()
		{
			Il2CppClassPointerStore<UILineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UILineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr);
			UILineInfo.NativeFieldInfoPtr_startCharIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "startCharIdx");
			UILineInfo.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "height");
			UILineInfo.NativeFieldInfoPtr_topY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "topY");
			UILineInfo.NativeFieldInfoPtr_leading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "leading");
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000024FE File Offset: 0x000006FE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_startCharIdx;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_topY;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_leading;

		// Token: 0x04000081 RID: 129
		[FieldOffset(0)]
		public int startCharIdx;

		// Token: 0x04000082 RID: 130
		[FieldOffset(4)]
		public int height;

		// Token: 0x04000083 RID: 131
		[FieldOffset(8)]
		public float topY;

		// Token: 0x04000084 RID: 132
		[FieldOffset(12)]
		public float leading;
	}
}
