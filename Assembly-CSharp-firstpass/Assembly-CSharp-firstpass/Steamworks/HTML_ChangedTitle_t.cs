using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A2 RID: 418
	public sealed class HTML_ChangedTitle_t : ValueType
	{
		// Token: 0x060021E1 RID: 8673 RVA: 0x000A1CCC File Offset: 0x0009FECC
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_ChangedTitle_t()
		{
			Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_ChangedTitle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr);
			HTML_ChangedTitle_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "k_iCallback");
			HTML_ChangedTitle_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "unBrowserHandle");
			HTML_ChangedTitle_t.NativeFieldInfoPtr_pchTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "pchTitle");
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0000C730 File Offset: 0x0000A930
		public HTML_ChangedTitle_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0000C739 File Offset: 0x0000A939
		public HTML_ChangedTitle_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x000A1D38 File Offset: 0x0009FF38
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x0000C74B File Offset: 0x0000A94B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_ChangedTitle_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_ChangedTitle_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x000A1D54 File Offset: 0x0009FF54
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x0000C759 File Offset: 0x0000A959
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000A1D7C File Offset: 0x0009FF7C
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0000C774 File Offset: 0x0000A974
		public unsafe string pchTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_pchTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_pchTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeFieldInfoPtr_pchTitle;
	}
}
