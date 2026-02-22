using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001CC RID: 460
	[StructLayout(2)]
	public struct EndGameResultCallback_t
	{
		// Token: 0x060022D1 RID: 8913 RVA: 0x000A3C9C File Offset: 0x000A1E9C
		// Note: this type is marked as 'beforefieldinit'.
		static EndGameResultCallback_t()
		{
			Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "EndGameResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr);
			EndGameResultCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, "k_iCallback");
			EndGameResultCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, "m_eResult");
			EndGameResultCallback_t.NativeFieldInfoPtr_ullUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, "ullUniqueGameID");
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0000D059 File Offset: 0x0000B259
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndGameResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000A3D08 File Offset: 0x000A1F08
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x0000D06B File Offset: 0x0000B26B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EndGameResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EndGameResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeFieldInfoPtr_ullUniqueGameID;

		// Token: 0x04001CBF RID: 7359
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001CC0 RID: 7360
		[FieldOffset(8)]
		public ulong ullUniqueGameID;
	}
}
