using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001AC RID: 428
	[StructLayout(2)]
	public struct HTML_SetCursor_t
	{
		// Token: 0x0600223B RID: 8763 RVA: 0x000A271C File Offset: 0x000A091C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_SetCursor_t()
		{
			Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_SetCursor_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr);
			HTML_SetCursor_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "k_iCallback");
			HTML_SetCursor_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "unBrowserHandle");
			HTML_SetCursor_t.NativeFieldInfoPtr_eMouseCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "eMouseCursor");
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0000CB14 File Offset: 0x0000AD14
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x000A2788 File Offset: 0x000A0988
		// (set) Token: 0x0600223E RID: 8766 RVA: 0x0000CB26 File Offset: 0x0000AD26
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_SetCursor_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_SetCursor_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeFieldInfoPtr_eMouseCursor;

		// Token: 0x04001BDD RID: 7133
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04001BDE RID: 7134
		[FieldOffset(4)]
		public uint eMouseCursor;
	}
}
