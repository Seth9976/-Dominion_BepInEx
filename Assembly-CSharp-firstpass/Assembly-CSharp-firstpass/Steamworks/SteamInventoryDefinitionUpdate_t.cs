using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B7 RID: 439
	[StructLayout(2)]
	public struct SteamInventoryDefinitionUpdate_t
	{
		// Token: 0x06002276 RID: 8822 RVA: 0x0000CD3D File Offset: 0x0000AF3D
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryDefinitionUpdate_t()
		{
			Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryDefinitionUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr);
			SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x0000CD76 File Offset: 0x0000AF76
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x000A2E20 File Offset: 0x000A1020
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x0000CD88 File Offset: 0x0000AF88
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
