using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001A7 RID: 423
	public sealed class HTML_LinkAtPosition_t : ValueType
	{
		// Token: 0x060021FA RID: 8698 RVA: 0x000A208C File Offset: 0x000A028C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_LinkAtPosition_t()
		{
			Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_LinkAtPosition_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr);
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "k_iCallback");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "unBrowserHandle");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "x");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "y");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_pchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "pchURL");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_bInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "bInput");
			HTML_LinkAtPosition_t.NativeFieldInfoPtr_bLiveLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr, "bLiveLink");
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0000C813 File Offset: 0x0000AA13
		public HTML_LinkAtPosition_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0000C81C File Offset: 0x0000AA1C
		public HTML_LinkAtPosition_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_LinkAtPosition_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x000A2148 File Offset: 0x000A0348
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x0000C82E File Offset: 0x0000AA2E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_LinkAtPosition_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_LinkAtPosition_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x000A2164 File Offset: 0x000A0364
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x0000C83C File Offset: 0x0000AA3C
		public unsafe HHTMLBrowser unBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_unBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_unBrowserHandle)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x000A218C File Offset: 0x000A038C
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x0000C857 File Offset: 0x0000AA57
		public unsafe uint x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x000A21B4 File Offset: 0x000A03B4
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x0000C872 File Offset: 0x0000AA72
		public unsafe uint y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x000A21DC File Offset: 0x000A03DC
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x0000C88D File Offset: 0x0000AA8D
		public unsafe string pchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_pchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_pchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000A2204 File Offset: 0x000A0404
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		public unsafe bool bInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bInput)) = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000A222C File Offset: 0x000A042C
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x0000C8C7 File Offset: 0x0000AAC7
		public unsafe bool bLiveLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bLiveLink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_LinkAtPosition_t.NativeFieldInfoPtr_bLiveLink)) = value;
			}
		}

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeFieldInfoPtr_pchURL;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeFieldInfoPtr_bInput;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeFieldInfoPtr_bLiveLink;
	}
}
