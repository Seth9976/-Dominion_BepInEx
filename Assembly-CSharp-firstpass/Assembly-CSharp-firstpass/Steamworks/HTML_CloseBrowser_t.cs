using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200019E RID: 414
	[StructLayout(2)]
	public struct HTML_CloseBrowser_t
	{
		// Token: 0x060021B8 RID: 8632 RVA: 0x000A18A4 File Offset: 0x0009FAA4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_CloseBrowser_t()
		{
			Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_CloseBrowser_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr);
			HTML_CloseBrowser_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, "k_iCallback");
			HTML_CloseBrowser_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, "unBrowserHandle");
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0000C554 File Offset: 0x0000A754
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x000A18FC File Offset: 0x0009FAFC
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x0000C566 File Offset: 0x0000A766
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_CloseBrowser_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_CloseBrowser_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B87 RID: 7047
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;
	}
}
