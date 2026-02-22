using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200019B RID: 411
	[StructLayout(2)]
	public struct HTML_BrowserReady_t
	{
		// Token: 0x060021A1 RID: 8609 RVA: 0x000A1554 File Offset: 0x0009F754
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_BrowserReady_t()
		{
			Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_BrowserReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr);
			HTML_BrowserReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, "k_iCallback");
			HTML_BrowserReady_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, "unBrowserHandle");
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0000C458 File Offset: 0x0000A658
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000A15AC File Offset: 0x0009F7AC
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x0000C46A File Offset: 0x0000A66A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_BrowserReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_BrowserReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B65 RID: 7013
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;
	}
}
