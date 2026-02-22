using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000018 RID: 24
	[StructLayout(2)]
	public struct PanelClearSettings
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00010728 File Offset: 0x0000E928
		// Note: this type is marked as 'beforefieldinit'.
		static PanelClearSettings()
		{
			Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PanelClearSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr);
			PanelClearSettings.NativeFieldInfoPtr_clearDepthStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, "clearDepthStencil");
			PanelClearSettings.NativeFieldInfoPtr_clearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, "clearColor");
			PanelClearSettings.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, "color");
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002962 File Offset: 0x00000B62
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PanelClearSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_clearDepthStencil;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_clearColor;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040000B7 RID: 183
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool clearDepthStencil;

		// Token: 0x040000B8 RID: 184
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool clearColor;

		// Token: 0x040000B9 RID: 185
		[FieldOffset(4)]
		public Color color;
	}
}
