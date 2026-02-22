using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A8 RID: 424
	public sealed class HTML_JSAlert_t : ValueType
	{
		// Token: 0x0600220B RID: 8715 RVA: 0x000A2254 File Offset: 0x000A0454
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_JSAlert_t()
		{
			Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_JSAlert_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr);
			HTML_JSAlert_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "k_iCallback");
			HTML_JSAlert_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "unBrowserHandle");
			HTML_JSAlert_t.NativeFieldInfoPtr_pchMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "pchMessage");
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0000C8E2 File Offset: 0x0000AAE2
		public HTML_JSAlert_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0000C8EB File Offset: 0x0000AAEB
		public HTML_JSAlert_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x000A22C0 File Offset: 0x000A04C0
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x0000C8FD File Offset: 0x0000AAFD
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_JSAlert_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_JSAlert_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x000A22DC File Offset: 0x000A04DC
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x0000C90B File Offset: 0x0000AB0B
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x000A2304 File Offset: 0x000A0504
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x0000C926 File Offset: 0x0000AB26
		public unsafe string pchMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_pchMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_pchMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeFieldInfoPtr_pchMessage;
	}
}
