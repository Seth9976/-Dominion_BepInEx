using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001AA RID: 426
	public sealed class HTML_FileOpenDialog_t : ValueType
	{
		// Token: 0x0600221D RID: 8733 RVA: 0x000A2404 File Offset: 0x000A0604
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_FileOpenDialog_t()
		{
			Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_FileOpenDialog_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr);
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "k_iCallback");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "unBrowserHandle");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "pchTitle");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchInitialFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "pchInitialFile");
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		public HTML_FileOpenDialog_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0000C9B1 File Offset: 0x0000ABB1
		public HTML_FileOpenDialog_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000A2484 File Offset: 0x000A0684
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x0000C9C3 File Offset: 0x0000ABC3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_FileOpenDialog_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_FileOpenDialog_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x000A24A0 File Offset: 0x000A06A0
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x0000C9D1 File Offset: 0x0000ABD1
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000A24C8 File Offset: 0x000A06C8
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		public unsafe string pchTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000A24F0 File Offset: 0x000A06F0
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x0000CA0B File Offset: 0x0000AC0B
		public unsafe string pchInitialFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchInitialFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_pchInitialFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr_pchTitle;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeFieldInfoPtr_pchInitialFile;
	}
}
