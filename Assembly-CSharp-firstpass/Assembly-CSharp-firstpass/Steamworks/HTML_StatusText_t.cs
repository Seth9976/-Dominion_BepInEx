using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001AD RID: 429
	public sealed class HTML_StatusText_t : ValueType
	{
		// Token: 0x0600223F RID: 8767 RVA: 0x000A27A4 File Offset: 0x000A09A4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_StatusText_t()
		{
			Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_StatusText_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr);
			HTML_StatusText_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "k_iCallback");
			HTML_StatusText_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "unBrowserHandle");
			HTML_StatusText_t.NativeFieldInfoPtr_pchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "pchMsg");
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0000CB34 File Offset: 0x0000AD34
		public HTML_StatusText_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0000CB3D File Offset: 0x0000AD3D
		public HTML_StatusText_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000A2810 File Offset: 0x000A0A10
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x0000CB4F File Offset: 0x0000AD4F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_StatusText_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_StatusText_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x000A282C File Offset: 0x000A0A2C
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x0000CB5D File Offset: 0x0000AD5D
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x000A2854 File Offset: 0x000A0A54
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x0000CB78 File Offset: 0x0000AD78
		public unsafe string pchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_pchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_pchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeFieldInfoPtr_pchMsg;
	}
}
