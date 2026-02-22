using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001AB RID: 427
	public sealed class HTML_NewWindow_t : ValueType
	{
		// Token: 0x06002228 RID: 8744 RVA: 0x000A2518 File Offset: 0x000A0718
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_NewWindow_t()
		{
			Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_NewWindow_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr);
			HTML_NewWindow_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "k_iCallback");
			HTML_NewWindow_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unBrowserHandle");
			HTML_NewWindow_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "pchURL");
			HTML_NewWindow_t.NativeFieldInfoPtr_unX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unX");
			HTML_NewWindow_t.NativeFieldInfoPtr_unY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unY");
			HTML_NewWindow_t.NativeFieldInfoPtr_unWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unWide");
			HTML_NewWindow_t.NativeFieldInfoPtr_unTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unTall");
			HTML_NewWindow_t.NativeFieldInfoPtr_unNewWindow_BrowserHandle_IGNORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "unNewWindow_BrowserHandle_IGNORE");
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0000CA2A File Offset: 0x0000AC2A
		public HTML_NewWindow_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0000CA33 File Offset: 0x0000AC33
		public HTML_NewWindow_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x000A25E8 File Offset: 0x000A07E8
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x0000CA45 File Offset: 0x0000AC45
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_NewWindow_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_NewWindow_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x000A2604 File Offset: 0x000A0804
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x0000CA53 File Offset: 0x0000AC53
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x000A262C File Offset: 0x000A082C
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x0000CA6E File Offset: 0x0000AC6E
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x000A2654 File Offset: 0x000A0854
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x0000CA8D File Offset: 0x0000AC8D
		public unsafe uint unX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unX)) = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x000A267C File Offset: 0x000A087C
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
		public unsafe uint unY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unY)) = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x000A26A4 File Offset: 0x000A08A4
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x0000CAC3 File Offset: 0x0000ACC3
		public unsafe uint unWide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unWide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unWide)) = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x000A26CC File Offset: 0x000A08CC
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x0000CADE File Offset: 0x0000ACDE
		public unsafe uint unTall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unTall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unTall)) = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x000A26F4 File Offset: 0x000A08F4
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x0000CAF9 File Offset: 0x0000ACF9
		public unsafe HHTMLBrowser unNewWindow_BrowserHandle_IGNORE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unNewWindow_BrowserHandle_IGNORE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_unNewWindow_BrowserHandle_IGNORE)) = value;
			}
		}

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeFieldInfoPtr_unX;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeFieldInfoPtr_unY;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeFieldInfoPtr_unWide;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeFieldInfoPtr_unTall;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeFieldInfoPtr_unNewWindow_BrowserHandle_IGNORE;
	}
}
