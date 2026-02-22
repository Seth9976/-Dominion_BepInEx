using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A0 RID: 416
	public sealed class HTML_FinishedRequest_t : ValueType
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x000A1AE0 File Offset: 0x0009FCE0
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_FinishedRequest_t()
		{
			Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_FinishedRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr);
			HTML_FinishedRequest_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "k_iCallback");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "unBrowserHandle");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "pchURL");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_pchPageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "pchPageTitle");
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0000C64B File Offset: 0x0000A84B
		public HTML_FinishedRequest_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0000C654 File Offset: 0x0000A854
		public HTML_FinishedRequest_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x000A1B60 File Offset: 0x0009FD60
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x0000C666 File Offset: 0x0000A866
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_FinishedRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_FinishedRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x000A1B7C File Offset: 0x0009FD7C
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x0000C674 File Offset: 0x0000A874
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x000A1BA4 File Offset: 0x0009FDA4
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x0000C68F File Offset: 0x0000A88F
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x000A1BCC File Offset: 0x0009FDCC
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x0000C6AE File Offset: 0x0000A8AE
		public unsafe string pchPageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchPageTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_pchPageTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeFieldInfoPtr_pchPageTitle;
	}
}
