using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001CB RID: 459
	[StructLayout(2)]
	public struct SubmitPlayerResultResultCallback_t
	{
		// Token: 0x060022CD RID: 8909 RVA: 0x000A3C00 File Offset: 0x000A1E00
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitPlayerResultResultCallback_t()
		{
			Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SubmitPlayerResultResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr);
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "k_iCallback");
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "m_eResult");
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_ullUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "ullUniqueGameID");
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_steamIDPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "steamIDPlayer");
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0000D039 File Offset: 0x0000B239
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000A3C80 File Offset: 0x000A1E80
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x0000D04B File Offset: 0x0000B24B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeFieldInfoPtr_ullUniqueGameID;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeFieldInfoPtr_steamIDPlayer;

		// Token: 0x04001CB9 RID: 7353
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001CBA RID: 7354
		[FieldOffset(8)]
		public ulong ullUniqueGameID;

		// Token: 0x04001CBB RID: 7355
		[FieldOffset(16)]
		public CSteamID steamIDPlayer;
	}
}
