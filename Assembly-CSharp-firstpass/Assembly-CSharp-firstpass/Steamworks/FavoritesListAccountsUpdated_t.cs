using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C5 RID: 453
	[StructLayout(2)]
	public struct FavoritesListAccountsUpdated_t
	{
		// Token: 0x060022B5 RID: 8885 RVA: 0x000A3790 File Offset: 0x000A1990
		// Note: this type is marked as 'beforefieldinit'.
		static FavoritesListAccountsUpdated_t()
		{
			Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FavoritesListAccountsUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr);
			FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, "k_iCallback");
			FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0000CF79 File Offset: 0x0000B179
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000A37E8 File Offset: 0x000A19E8
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x0000CF8B File Offset: 0x0000B18B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001C79 RID: 7289
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
