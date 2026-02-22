using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CC RID: 204
	[Serializable]
	[StructLayout(2)]
	public struct GradientSettings
	{
		// Token: 0x06000B89 RID: 2953 RVA: 0x00030094 File Offset: 0x0002E294
		// Note: this type is marked as 'beforefieldinit'.
		static GradientSettings()
		{
			Il2CppClassPointerStore<GradientSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GradientSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr);
			GradientSettings.NativeFieldInfoPtr_gradientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "gradientType");
			GradientSettings.NativeFieldInfoPtr_addressMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "addressMode");
			GradientSettings.NativeFieldInfoPtr_radialFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "radialFocus");
			GradientSettings.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, "location");
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000073B2 File Offset: 0x000055B2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_gradientType;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_addressMode;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_radialFocus;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x04000646 RID: 1606
		[FieldOffset(0)]
		public GradientType gradientType;

		// Token: 0x04000647 RID: 1607
		[FieldOffset(4)]
		public AddressMode addressMode;

		// Token: 0x04000648 RID: 1608
		[FieldOffset(8)]
		public Vector2 radialFocus;

		// Token: 0x04000649 RID: 1609
		[FieldOffset(16)]
		public RectInt location;
	}
}
