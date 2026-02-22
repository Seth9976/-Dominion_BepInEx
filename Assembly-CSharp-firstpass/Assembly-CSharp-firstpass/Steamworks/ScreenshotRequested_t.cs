using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200020B RID: 523
	[StructLayout(2)]
	public struct ScreenshotRequested_t
	{
		// Token: 0x0600248C RID: 9356 RVA: 0x0000E410 File Offset: 0x0000C610
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotRequested_t()
		{
			Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ScreenshotRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr);
			ScreenshotRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x0000E449 File Offset: 0x0000C649
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x000A7108 File Offset: 0x000A5308
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x0000E45B File Offset: 0x0000C65B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
