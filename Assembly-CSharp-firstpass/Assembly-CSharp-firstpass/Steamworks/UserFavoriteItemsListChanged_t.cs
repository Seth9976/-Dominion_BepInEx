using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000212 RID: 530
	[StructLayout(2)]
	public struct UserFavoriteItemsListChanged_t
	{
		// Token: 0x060024BC RID: 9404 RVA: 0x000A76DC File Offset: 0x000A58DC
		// Note: this type is marked as 'beforefieldinit'.
		static UserFavoriteItemsListChanged_t()
		{
			Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserFavoriteItemsListChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr);
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "k_iCallback");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "m_nPublishedFileId");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "m_eResult");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_m_bWasAddRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "m_bWasAddRequest");
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x0000E62A File Offset: 0x0000C82A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000A775C File Offset: 0x000A595C
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0000E63C File Offset: 0x0000C83C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeFieldInfoPtr_m_bWasAddRequest;

		// Token: 0x04001E1F RID: 7711
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E20 RID: 7712
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04001E21 RID: 7713
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bWasAddRequest;
	}
}
