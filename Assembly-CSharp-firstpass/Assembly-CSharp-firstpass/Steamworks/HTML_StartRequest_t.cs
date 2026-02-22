using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200019D RID: 413
	public sealed class HTML_StartRequest_t : ValueType
	{
		// Token: 0x060021A9 RID: 8617 RVA: 0x000A1718 File Offset: 0x0009F918
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_StartRequest_t()
		{
			Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_StartRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr);
			HTML_StartRequest_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "k_iCallback");
			HTML_StartRequest_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "unBrowserHandle");
			HTML_StartRequest_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "pchURL");
			HTML_StartRequest_t.NativeFieldInfoPtr_pchTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "pchTarget");
			HTML_StartRequest_t.NativeFieldInfoPtr_pchPostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "pchPostData");
			HTML_StartRequest_t.NativeFieldInfoPtr_bIsRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "bIsRedirect");
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0000C498 File Offset: 0x0000A698
		public HTML_StartRequest_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0000C4A1 File Offset: 0x0000A6A1
		public HTML_StartRequest_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x000A17C0 File Offset: 0x0009F9C0
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x0000C4B3 File Offset: 0x0000A6B3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_StartRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_StartRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x000A17DC File Offset: 0x0009F9DC
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x0000C4C1 File Offset: 0x0000A6C1
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000A1804 File Offset: 0x0009FA04
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x000A182C File Offset: 0x0009FA2C
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x0000C4FB File Offset: 0x0000A6FB
		public unsafe string pchTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000A1854 File Offset: 0x0009FA54
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0000C51A File Offset: 0x0000A71A
		public unsafe string pchPostData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchPostData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_pchPostData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000A187C File Offset: 0x0009FA7C
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x0000C539 File Offset: 0x0000A739
		public unsafe bool bIsRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_bIsRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_bIsRedirect)) = value;
			}
		}

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeFieldInfoPtr_pchTarget;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeFieldInfoPtr_pchPostData;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeFieldInfoPtr_bIsRedirect;
	}
}
