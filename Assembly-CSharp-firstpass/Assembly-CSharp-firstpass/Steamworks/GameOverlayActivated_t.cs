using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000179 RID: 377
	[StructLayout(2)]
	public struct GameOverlayActivated_t
	{
		// Token: 0x060020E9 RID: 8425 RVA: 0x0009FC1C File Offset: 0x0009DE1C
		// Note: this type is marked as 'beforefieldinit'.
		static GameOverlayActivated_t()
		{
			Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameOverlayActivated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr);
			GameOverlayActivated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, "k_iCallback");
			GameOverlayActivated_t.NativeFieldInfoPtr_m_bActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, "m_bActive");
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0000BDBF File Offset: 0x00009FBF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x0009FC74 File Offset: 0x0009DE74
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x0000BDD1 File Offset: 0x00009FD1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameOverlayActivated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameOverlayActivated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeFieldInfoPtr_m_bActive;

		// Token: 0x04001AA2 RID: 6818
		[FieldOffset(0)]
		public byte m_bActive;
	}
}
