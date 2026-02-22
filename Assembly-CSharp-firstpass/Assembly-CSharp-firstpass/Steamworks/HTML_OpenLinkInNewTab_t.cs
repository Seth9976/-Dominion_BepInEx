using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A1 RID: 417
	public sealed class HTML_OpenLinkInNewTab_t : ValueType
	{
		// Token: 0x060021D8 RID: 8664 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_OpenLinkInNewTab_t()
		{
			Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_OpenLinkInNewTab_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr);
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "k_iCallback");
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "unBrowserHandle");
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "pchURL");
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0000C6CD File Offset: 0x0000A8CD
		public HTML_OpenLinkInNewTab_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0000C6D6 File Offset: 0x0000A8D6
		public HTML_OpenLinkInNewTab_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x000A1C60 File Offset: 0x0009FE60
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x000A1C7C File Offset: 0x0009FE7C
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x0000C6F6 File Offset: 0x0000A8F6
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x000A1CA4 File Offset: 0x0009FEA4
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x0000C711 File Offset: 0x0000A911
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;
	}
}
