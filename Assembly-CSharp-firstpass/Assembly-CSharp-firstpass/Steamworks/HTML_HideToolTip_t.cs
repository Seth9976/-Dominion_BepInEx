using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B0 RID: 432
	[StructLayout(2)]
	public struct HTML_HideToolTip_t
	{
		// Token: 0x0600225A RID: 8794 RVA: 0x000A2A2C File Offset: 0x000A0C2C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_HideToolTip_t()
		{
			Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_HideToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr);
			HTML_HideToolTip_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, "k_iCallback");
			HTML_HideToolTip_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, "unBrowserHandle");
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0000CC5D File Offset: 0x0000AE5D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x000A2A84 File Offset: 0x000A0C84
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0000CC6F File Offset: 0x0000AE6F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_HideToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_HideToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BEA RID: 7146
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;
	}
}
