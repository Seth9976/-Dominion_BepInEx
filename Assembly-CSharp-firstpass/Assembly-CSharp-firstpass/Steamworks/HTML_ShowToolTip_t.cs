using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001AE RID: 430
	public sealed class HTML_ShowToolTip_t : ValueType
	{
		// Token: 0x06002248 RID: 8776 RVA: 0x000A287C File Offset: 0x000A0A7C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_ShowToolTip_t()
		{
			Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_ShowToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr);
			HTML_ShowToolTip_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "k_iCallback");
			HTML_ShowToolTip_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "unBrowserHandle");
			HTML_ShowToolTip_t.NativeFieldInfoPtr_pchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "pchMsg");
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0000CB97 File Offset: 0x0000AD97
		public HTML_ShowToolTip_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		public HTML_ShowToolTip_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x000A28E8 File Offset: 0x000A0AE8
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x0000CBB2 File Offset: 0x0000ADB2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_ShowToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_ShowToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000A2904 File Offset: 0x000A0B04
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x000A292C File Offset: 0x000A0B2C
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x0000CBDB File Offset: 0x0000ADDB
		public unsafe string pchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_pchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_pchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeFieldInfoPtr_pchMsg;
	}
}
