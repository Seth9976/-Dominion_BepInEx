using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200020A RID: 522
	[StructLayout(2)]
	public struct ScreenshotReady_t
	{
		// Token: 0x06002488 RID: 9352 RVA: 0x000A7080 File Offset: 0x000A5280
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotReady_t()
		{
			Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ScreenshotReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr);
			ScreenshotReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "k_iCallback");
			ScreenshotReady_t.NativeFieldInfoPtr_m_hLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "m_hLocal");
			ScreenshotReady_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000A70EC File Offset: 0x000A52EC
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x0000E402 File Offset: 0x0000C602
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeFieldInfoPtr_m_hLocal;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DF2 RID: 7666
		[FieldOffset(0)]
		public ScreenshotHandle m_hLocal;

		// Token: 0x04001DF3 RID: 7667
		[FieldOffset(4)]
		public EResult m_eResult;
	}
}
