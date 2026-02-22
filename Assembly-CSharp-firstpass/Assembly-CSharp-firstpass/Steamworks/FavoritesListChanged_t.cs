using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001BB RID: 443
	[StructLayout(2)]
	public struct FavoritesListChanged_t
	{
		// Token: 0x0600228D RID: 8845 RVA: 0x000A3114 File Offset: 0x000A1314
		// Note: this type is marked as 'beforefieldinit'.
		static FavoritesListChanged_t()
		{
			Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FavoritesListChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr);
			FavoritesListChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "k_iCallback");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nIP");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nQueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nQueryPort");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nConnPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nConnPort");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nAppID");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nFlags");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_bAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_bAdd");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_unAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_unAccountId");
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0000CE39 File Offset: 0x0000B039
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x000A31E4 File Offset: 0x000A13E4
		// (set) Token: 0x06002290 RID: 8848 RVA: 0x0000CE4B File Offset: 0x0000B04B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FavoritesListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FavoritesListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeFieldInfoPtr_m_nIP;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeFieldInfoPtr_m_nQueryPort;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeFieldInfoPtr_m_nConnPort;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeFieldInfoPtr_m_nFlags;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeFieldInfoPtr_m_bAdd;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeFieldInfoPtr_m_unAccountId;

		// Token: 0x04001C2F RID: 7215
		[FieldOffset(0)]
		public uint m_nIP;

		// Token: 0x04001C30 RID: 7216
		[FieldOffset(4)]
		public uint m_nQueryPort;

		// Token: 0x04001C31 RID: 7217
		[FieldOffset(8)]
		public uint m_nConnPort;

		// Token: 0x04001C32 RID: 7218
		[FieldOffset(12)]
		public uint m_nAppID;

		// Token: 0x04001C33 RID: 7219
		[FieldOffset(16)]
		public uint m_nFlags;

		// Token: 0x04001C34 RID: 7220
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool m_bAdd;

		// Token: 0x04001C35 RID: 7221
		[FieldOffset(24)]
		public AccountID_t m_unAccountId;
	}
}
