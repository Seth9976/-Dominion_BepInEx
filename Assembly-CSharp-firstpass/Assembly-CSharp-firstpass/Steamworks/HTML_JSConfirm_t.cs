using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A9 RID: 425
	public sealed class HTML_JSConfirm_t : ValueType
	{
		// Token: 0x06002214 RID: 8724 RVA: 0x000A232C File Offset: 0x000A052C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_JSConfirm_t()
		{
			Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_JSConfirm_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr);
			HTML_JSConfirm_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "k_iCallback");
			HTML_JSConfirm_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "unBrowserHandle");
			HTML_JSConfirm_t.NativeFieldInfoPtr_pchMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "pchMessage");
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0000C945 File Offset: 0x0000AB45
		public HTML_JSConfirm_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0000C94E File Offset: 0x0000AB4E
		public HTML_JSConfirm_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x000A2398 File Offset: 0x000A0598
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x0000C960 File Offset: 0x0000AB60
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_JSConfirm_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_JSConfirm_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x000A23B4 File Offset: 0x000A05B4
		// (set) Token: 0x0600221A RID: 8730 RVA: 0x0000C96E File Offset: 0x0000AB6E
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x000A23DC File Offset: 0x000A05DC
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x0000C989 File Offset: 0x0000AB89
		public unsafe string pchMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_pchMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_pchMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr_pchMessage;
	}
}
