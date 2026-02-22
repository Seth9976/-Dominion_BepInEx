using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000210 RID: 528
	[StructLayout(2)]
	public struct ItemInstalled_t
	{
		// Token: 0x060024B4 RID: 9396 RVA: 0x000A75B8 File Offset: 0x000A57B8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInstalled_t()
		{
			Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ItemInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr);
			ItemInstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "k_iCallback");
			ItemInstalled_t.NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "m_unAppID");
			ItemInstalled_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0000E5EA File Offset: 0x0000C7EA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000A7624 File Offset: 0x000A5824
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ItemInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeFieldInfoPtr_m_unAppID;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E12 RID: 7698
		[FieldOffset(0)]
		public AppId_t m_unAppID;

		// Token: 0x04001E13 RID: 7699
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
