using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000161 RID: 353
	[StructLayout(2)]
	public struct Cookie
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x0005ED28 File Offset: 0x0005CF28
		// Note: this type is marked as 'beforefieldinit'.
		static Cookie()
		{
			Il2CppClassPointerStore<Cookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Cookie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cookie>.NativeClassPtr);
			Cookie.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "instanceID");
			Cookie.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "scale");
			Cookie.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "sizes");
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0000EBBA File Offset: 0x0000CDBA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cookie>.NativeClassPtr, ref this));
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0005ED94 File Offset: 0x0005CF94
		public static Cookie Defaults()
		{
			Cookie cookie;
			cookie.instanceID = 0;
			cookie.scale = 1f;
			cookie.sizes = new Vector2(1f, 1f);
			return cookie;
		}

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x040013E3 RID: 5091
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040013E4 RID: 5092
		[FieldOffset(4)]
		public float scale;

		// Token: 0x040013E5 RID: 5093
		[FieldOffset(8)]
		public Vector2 sizes;
	}
}
