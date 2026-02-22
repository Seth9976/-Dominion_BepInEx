using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001AF RID: 431
	public sealed class HTML_UpdateToolTip_t : ValueType
	{
		// Token: 0x06002251 RID: 8785 RVA: 0x000A2954 File Offset: 0x000A0B54
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_UpdateToolTip_t()
		{
			Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_UpdateToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr);
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "k_iCallback");
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "unBrowserHandle");
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_pchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "pchMsg");
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0000CBFA File Offset: 0x0000ADFA
		public HTML_UpdateToolTip_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0000CC03 File Offset: 0x0000AE03
		public HTML_UpdateToolTip_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000A29C0 File Offset: 0x000A0BC0
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x0000CC15 File Offset: 0x0000AE15
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_UpdateToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_UpdateToolTip_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000A29DC File Offset: 0x000A0BDC
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x0000CC23 File Offset: 0x0000AE23
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x000A2A04 File Offset: 0x000A0C04
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x0000CC3E File Offset: 0x0000AE3E
		public unsafe string pchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_pchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_pchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeFieldInfoPtr_pchMsg;
	}
}
