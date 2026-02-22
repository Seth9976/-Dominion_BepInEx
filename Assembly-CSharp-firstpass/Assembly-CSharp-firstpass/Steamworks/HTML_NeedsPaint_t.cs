using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200019C RID: 412
	[StructLayout(2)]
	public struct HTML_NeedsPaint_t
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x000A15C8 File Offset: 0x0009F7C8
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_NeedsPaint_t()
		{
			Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTML_NeedsPaint_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr);
			HTML_NeedsPaint_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "k_iCallback");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unBrowserHandle");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_pBGRA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "pBGRA");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unWide");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unTall");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateX");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateY");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateWide");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unUpdateTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unUpdateTall");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unScrollX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unScrollX");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unScrollY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unScrollY");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_flPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "flPageScale");
			HTML_NeedsPaint_t.NativeFieldInfoPtr_unPageSerial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, "unPageSerial");
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0000C478 File Offset: 0x0000A678
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_NeedsPaint_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x000A16FC File Offset: 0x0009F8FC
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x0000C48A File Offset: 0x0000A68A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_NeedsPaint_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_NeedsPaint_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeFieldInfoPtr_unBrowserHandle;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeFieldInfoPtr_pBGRA;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeFieldInfoPtr_unWide;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeFieldInfoPtr_unTall;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateX;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateY;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateWide;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeFieldInfoPtr_unUpdateTall;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeFieldInfoPtr_unScrollX;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeFieldInfoPtr_unScrollY;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeFieldInfoPtr_flPageScale;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeFieldInfoPtr_unPageSerial;

		// Token: 0x04001B73 RID: 7027
		[FieldOffset(0)]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04001B74 RID: 7028
		[FieldOffset(8)]
		public IntPtr pBGRA;

		// Token: 0x04001B75 RID: 7029
		[FieldOffset(16)]
		public uint unWide;

		// Token: 0x04001B76 RID: 7030
		[FieldOffset(20)]
		public uint unTall;

		// Token: 0x04001B77 RID: 7031
		[FieldOffset(24)]
		public uint unUpdateX;

		// Token: 0x04001B78 RID: 7032
		[FieldOffset(28)]
		public uint unUpdateY;

		// Token: 0x04001B79 RID: 7033
		[FieldOffset(32)]
		public uint unUpdateWide;

		// Token: 0x04001B7A RID: 7034
		[FieldOffset(36)]
		public uint unUpdateTall;

		// Token: 0x04001B7B RID: 7035
		[FieldOffset(40)]
		public uint unScrollX;

		// Token: 0x04001B7C RID: 7036
		[FieldOffset(44)]
		public uint unScrollY;

		// Token: 0x04001B7D RID: 7037
		[FieldOffset(48)]
		public float flPageScale;

		// Token: 0x04001B7E RID: 7038
		[FieldOffset(52)]
		public uint unPageSerial;
	}
}
