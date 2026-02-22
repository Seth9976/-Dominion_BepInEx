using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000209 RID: 521
	[StructLayout(2)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		// Token: 0x06002484 RID: 9348 RVA: 0x000A6FD0 File Offset: 0x000A51D0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileReadAsyncComplete_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageFileReadAsyncComplete_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr);
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_hFileReadAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_hFileReadAsync");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_eResult");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_nOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_nOffset");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_cubRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_cubRead");
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000A7064 File Offset: 0x000A5264
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x0000E3E2 File Offset: 0x0000C5E2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeFieldInfoPtr_m_hFileReadAsync;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeFieldInfoPtr_m_nOffset;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeFieldInfoPtr_m_cubRead;

		// Token: 0x04001DEB RID: 7659
		[FieldOffset(0)]
		public SteamAPICall_t m_hFileReadAsync;

		// Token: 0x04001DEC RID: 7660
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04001DED RID: 7661
		[FieldOffset(12)]
		public uint m_nOffset;

		// Token: 0x04001DEE RID: 7662
		[FieldOffset(16)]
		public uint m_cubRead;
	}
}
