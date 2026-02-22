using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A3 RID: 419
	[StructLayout(2)]
	public struct HTML_SearchResults_t
	{
		// Token: 0x060021EA RID: 8682 RVA: 0x000A1DA4 File Offset: 0x0009FFA4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_SearchResults_t()
		{
			Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_SearchResults_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr);
			HTML_SearchResults_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "k_iCallback");
			HTML_SearchResults_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "unBrowserHandle");
			HTML_SearchResults_t.NativeFieldInfoPtr_unResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "unResults");
			HTML_SearchResults_t.NativeFieldInfoPtr_unCurrentMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "unCurrentMatch");
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0000C793 File Offset: 0x0000A993
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x000A1E24 File Offset: 0x000A0024
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x0000C7A5 File Offset: 0x0000A9A5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_SearchResults_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_SearchResults_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeFieldInfoPtr_unResults;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeFieldInfoPtr_unCurrentMatch;

		// Token: 0x04001B9D RID: 7069
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04001B9E RID: 7070
		[FieldOffset(4)]
		public uint unResults;

		// Token: 0x04001B9F RID: 7071
		[FieldOffset(8)]
		public uint unCurrentMatch;
	}
}
