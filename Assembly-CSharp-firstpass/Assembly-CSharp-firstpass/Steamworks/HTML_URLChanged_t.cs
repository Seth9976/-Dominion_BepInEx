using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200019F RID: 415
	public sealed class HTML_URLChanged_t : ValueType
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x000A1918 File Offset: 0x0009FB18
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_URLChanged_t()
		{
			Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_URLChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr);
			HTML_URLChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "k_iCallback");
			HTML_URLChanged_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "unBrowserHandle");
			HTML_URLChanged_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "pchURL");
			HTML_URLChanged_t.NativeFieldInfoPtr_pchPostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "pchPostData");
			HTML_URLChanged_t.NativeFieldInfoPtr_bIsRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "bIsRedirect");
			HTML_URLChanged_t.NativeFieldInfoPtr_pchPageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "pchPageTitle");
			HTML_URLChanged_t.NativeFieldInfoPtr_bNewNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "bNewNavigation");
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0000C574 File Offset: 0x0000A774
		public HTML_URLChanged_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0000C57D File Offset: 0x0000A77D
		public HTML_URLChanged_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x000A19D4 File Offset: 0x0009FBD4
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x0000C58F File Offset: 0x0000A78F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_URLChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_URLChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000A19F0 File Offset: 0x0009FBF0
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x0000C59D File Offset: 0x0000A79D
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x000A1A18 File Offset: 0x0009FC18
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000A1A40 File Offset: 0x0009FC40
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x0000C5D7 File Offset: 0x0000A7D7
		public unsafe string pchPostData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPostData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPostData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000A1A68 File Offset: 0x0009FC68
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x0000C5F6 File Offset: 0x0000A7F6
		public unsafe bool bIsRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bIsRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bIsRedirect)) = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x000A1A90 File Offset: 0x0009FC90
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x0000C611 File Offset: 0x0000A811
		public unsafe string pchPageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPageTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_pchPageTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x000A1AB8 File Offset: 0x0009FCB8
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x0000C630 File Offset: 0x0000A830
		public unsafe bool bNewNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bNewNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_bNewNavigation)) = value;
			}
		}

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeFieldInfoPtr_pchPostData;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeFieldInfoPtr_bIsRedirect;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeFieldInfoPtr_pchPageTitle;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeFieldInfoPtr_bNewNavigation;
	}
}
