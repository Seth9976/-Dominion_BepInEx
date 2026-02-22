using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A6 RID: 422
	[StructLayout(2)]
	public struct HTML_VerticalScroll_t
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x000A1FB4 File Offset: 0x000A01B4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_VerticalScroll_t()
		{
			Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_VerticalScroll_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr);
			HTML_VerticalScroll_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "k_iCallback");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unBrowserHandle");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unScrollMax");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unScrollCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unScrollCurrent");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_flPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "flPageScale");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_bVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "bVisible");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_unPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "unPageSize");
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x0000C7F3 File Offset: 0x0000A9F3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x000A2070 File Offset: 0x000A0270
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x0000C805 File Offset: 0x0000AA05
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_VerticalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_VerticalScroll_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeFieldInfoPtr_unScrollMax;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr_unScrollCurrent;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeFieldInfoPtr_flPageScale;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeFieldInfoPtr_bVisible;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr_unPageSize;

		// Token: 0x04001BBB RID: 7099
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04001BBC RID: 7100
		[FieldOffset(4)]
		public uint unScrollMax;

		// Token: 0x04001BBD RID: 7101
		[FieldOffset(8)]
		public uint unScrollCurrent;

		// Token: 0x04001BBE RID: 7102
		[FieldOffset(12)]
		public float flPageScale;

		// Token: 0x04001BBF RID: 7103
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool bVisible;

		// Token: 0x04001BC0 RID: 7104
		[FieldOffset(20)]
		public uint unPageSize;
	}
}
