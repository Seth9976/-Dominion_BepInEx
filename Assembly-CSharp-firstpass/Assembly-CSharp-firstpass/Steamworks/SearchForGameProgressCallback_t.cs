using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C6 RID: 454
	[StructLayout(2)]
	public struct SearchForGameProgressCallback_t
	{
		// Token: 0x060022B9 RID: 8889 RVA: 0x000A3804 File Offset: 0x000A1A04
		// Note: this type is marked as 'beforefieldinit'.
		static SearchForGameProgressCallback_t()
		{
			Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SearchForGameProgressCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr);
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "k_iCallback");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_m_ullSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "m_ullSearchID");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "m_eResult");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_m_lobbyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "m_lobbyID");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_m_steamIDEndedSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "m_steamIDEndedSearch");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_m_nSecondsRemainingEstimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "m_nSecondsRemainingEstimate");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_m_cPlayersSearching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "m_cPlayersSearching");
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0000CF99 File Offset: 0x0000B199
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x000A38C0 File Offset: 0x000A1AC0
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x0000CFAB File Offset: 0x0000B1AB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SearchForGameProgressCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SearchForGameProgressCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeFieldInfoPtr_m_ullSearchID;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeFieldInfoPtr_m_lobbyID;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDEndedSearch;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeFieldInfoPtr_m_nSecondsRemainingEstimate;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeFieldInfoPtr_m_cPlayersSearching;

		// Token: 0x04001C81 RID: 7297
		[FieldOffset(0)]
		public ulong m_ullSearchID;

		// Token: 0x04001C82 RID: 7298
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04001C83 RID: 7299
		[FieldOffset(12)]
		public CSteamID m_lobbyID;

		// Token: 0x04001C84 RID: 7300
		[FieldOffset(20)]
		public CSteamID m_steamIDEndedSearch;

		// Token: 0x04001C85 RID: 7301
		[FieldOffset(28)]
		public int m_nSecondsRemainingEstimate;

		// Token: 0x04001C86 RID: 7302
		[FieldOffset(32)]
		public int m_cPlayersSearching;
	}
}
