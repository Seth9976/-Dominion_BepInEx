using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x0200012A RID: 298
	[StructLayout(2)]
	public struct PlayerData
	{
		// Token: 0x06002140 RID: 8512 RVA: 0x0007F184 File Offset: 0x0007D384
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerData()
		{
			Il2CppClassPointerStore<PlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "PlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerData>.NativeClassPtr);
			PlayerData.NativeFieldInfoPtr_superpower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "superpower");
			PlayerData.NativeFieldInfoPtr_playerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "playerID");
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000149A0 File Offset: 0x00012BA0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, ref this));
		}

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeFieldInfoPtr_superpower;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeFieldInfoPtr_playerID;

		// Token: 0x0400166A RID: 5738
		[FieldOffset(0)]
		public int superpower;

		// Token: 0x0400166B RID: 5739
		[FieldOffset(4)]
		public int playerID;
	}
}
