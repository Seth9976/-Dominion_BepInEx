using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A5 RID: 421
	[StructLayout(2)]
	public struct HTML_HorizontalScroll_t
	{
		// Token: 0x060021F2 RID: 8690 RVA: 0x000A1EDC File Offset: 0x000A00DC
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_HorizontalScroll_t()
		{
			Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_HorizontalScroll_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr);
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "k_iCallback");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unBrowserHandle");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unScrollMax");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unScrollCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unScrollCurrent");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_flPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "flPageScale");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_bVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "bVisible");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_unPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "unPageSize");
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0000C7D3 File Offset: 0x0000A9D3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x000A1F98 File Offset: 0x000A0198
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x0000C7E5 File Offset: 0x0000A9E5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_HorizontalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_HorizontalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeFieldInfoPtr_unScrollMax;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeFieldInfoPtr_unScrollCurrent;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeFieldInfoPtr_flPageScale;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_bVisible;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr_unPageSize;

		// Token: 0x04001BAE RID: 7086
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04001BAF RID: 7087
		[FieldOffset(4)]
		public uint unScrollMax;

		// Token: 0x04001BB0 RID: 7088
		[FieldOffset(8)]
		public uint unScrollCurrent;

		// Token: 0x04001BB1 RID: 7089
		[FieldOffset(12)]
		public float flPageScale;

		// Token: 0x04001BB2 RID: 7090
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool bVisible;

		// Token: 0x04001BB3 RID: 7091
		[FieldOffset(20)]
		public uint unPageSize;
	}
}
