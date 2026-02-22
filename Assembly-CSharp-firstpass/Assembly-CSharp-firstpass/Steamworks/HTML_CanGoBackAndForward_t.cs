using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A4 RID: 420
	[StructLayout(2)]
	public struct HTML_CanGoBackAndForward_t
	{
		// Token: 0x060021EE RID: 8686 RVA: 0x000A1E40 File Offset: 0x000A0040
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_CanGoBackAndForward_t()
		{
			Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_CanGoBackAndForward_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr);
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "k_iCallback");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "unBrowserHandle");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_bCanGoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "bCanGoBack");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_bCanGoForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "bCanGoForward");
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0000C7B3 File Offset: 0x0000A9B3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000A1EC0 File Offset: 0x000A00C0
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x0000C7C5 File Offset: 0x0000A9C5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr_bCanGoBack;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr_bCanGoForward;

		// Token: 0x04001BA4 RID: 7076
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04001BA5 RID: 7077
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool bCanGoBack;

		// Token: 0x04001BA6 RID: 7078
		[FieldOffset(5)]
		[MarshalAs(4)]
		public bool bCanGoForward;
	}
}
