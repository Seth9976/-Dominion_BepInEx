using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C7 RID: 455
	[StructLayout(2)]
	public struct SearchForGameResultCallback_t
	{
		// Token: 0x060022BD RID: 8893 RVA: 0x000A38DC File Offset: 0x000A1ADC
		// Note: this type is marked as 'beforefieldinit'.
		static SearchForGameResultCallback_t()
		{
			Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SearchForGameResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr);
			SearchForGameResultCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "k_iCallback");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_m_ullSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "m_ullSearchID");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "m_eResult");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_m_nCountPlayersInGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "m_nCountPlayersInGame");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_m_nCountAcceptedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "m_nCountAcceptedGame");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_m_steamIDHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "m_steamIDHost");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_m_bFinalCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "m_bFinalCallback");
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0000CFB9 File Offset: 0x0000B1B9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000A3998 File Offset: 0x000A1B98
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x0000CFCB File Offset: 0x0000B1CB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SearchForGameResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SearchForGameResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_m_ullSearchID;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeFieldInfoPtr_m_nCountPlayersInGame;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeFieldInfoPtr_m_nCountAcceptedGame;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDHost;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr_m_bFinalCallback;

		// Token: 0x04001C8E RID: 7310
		[FieldOffset(0)]
		public ulong m_ullSearchID;

		// Token: 0x04001C8F RID: 7311
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04001C90 RID: 7312
		[FieldOffset(12)]
		public int m_nCountPlayersInGame;

		// Token: 0x04001C91 RID: 7313
		[FieldOffset(16)]
		public int m_nCountAcceptedGame;

		// Token: 0x04001C92 RID: 7314
		[FieldOffset(20)]
		public CSteamID m_steamIDHost;

		// Token: 0x04001C93 RID: 7315
		[FieldOffset(28)]
		[MarshalAs(4)]
		public bool m_bFinalCallback;
	}
}
