using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B1 RID: 433
	[StructLayout(2)]
	public struct HTML_BrowserRestarted_t
	{
		// Token: 0x0600225E RID: 8798 RVA: 0x000A2AA0 File Offset: 0x000A0CA0
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_BrowserRestarted_t()
		{
			Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_BrowserRestarted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr);
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "k_iCallback");
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "unBrowserHandle");
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_unOldBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "unOldBrowserHandle");
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0000CC7D File Offset: 0x0000AE7D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x000A2B0C File Offset: 0x000A0D0C
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x0000CC8F File Offset: 0x0000AE8F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_BrowserRestarted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_BrowserRestarted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr_unOldBrowserHandle;

		// Token: 0x04001BEE RID: 7150
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04001BEF RID: 7151
		[FieldOffset(4)]
		public HHTMLBrowser unOldBrowserHandle;
	}
}
