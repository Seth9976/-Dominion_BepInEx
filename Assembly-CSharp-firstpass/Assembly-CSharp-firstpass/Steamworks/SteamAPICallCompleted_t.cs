using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000239 RID: 569
	[StructLayout(2)]
	public struct SteamAPICallCompleted_t
	{
		// Token: 0x06002585 RID: 9605 RVA: 0x000A91D8 File Offset: 0x000A73D8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPICallCompleted_t()
		{
			Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPICallCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr);
			SteamAPICallCompleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "k_iCallback");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_m_hAsyncCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_hAsyncCall");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_m_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_iCallback");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_m_cubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_cubParam");
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x0000EDA6 File Offset: 0x0000CFA6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x000A9258 File Offset: 0x000A7458
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAPICallCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAPICallCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeFieldInfoPtr_m_hAsyncCall;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeFieldInfoPtr_m_iCallback;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeFieldInfoPtr_m_cubParam;

		// Token: 0x04001F06 RID: 7942
		[FieldOffset(0)]
		public SteamAPICall_t m_hAsyncCall;

		// Token: 0x04001F07 RID: 7943
		[FieldOffset(8)]
		public int m_iCallback;

		// Token: 0x04001F08 RID: 7944
		[FieldOffset(12)]
		public uint m_cubParam;
	}
}
