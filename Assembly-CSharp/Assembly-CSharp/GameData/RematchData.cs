using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x02000135 RID: 309
	[StructLayout(2)]
	public struct RematchData
	{
		// Token: 0x060021DD RID: 8669 RVA: 0x0008025C File Offset: 0x0007E45C
		// Note: this type is marked as 'beforefieldinit'.
		static RematchData()
		{
			Il2CppClassPointerStore<RematchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "RematchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RematchData>.NativeClassPtr);
			RematchData.NativeFieldInfoPtr_rematchCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RematchData>.NativeClassPtr, "rematchCreated");
			RematchData.NativeFieldInfoPtr_rematchStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RematchData>.NativeClassPtr, "rematchStarted");
			RematchData.NativeFieldInfoPtr_rematchReadyPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RematchData>.NativeClassPtr, "rematchReadyPlayers");
			RematchData.NativeFieldInfoPtr_rematchMaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RematchData>.NativeClassPtr, "rematchMaxPlayers");
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00015286 File Offset: 0x00013486
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RematchData>.NativeClassPtr, ref this));
		}

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeFieldInfoPtr_rematchCreated;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeFieldInfoPtr_rematchStarted;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeFieldInfoPtr_rematchReadyPlayers;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeFieldInfoPtr_rematchMaxPlayers;

		// Token: 0x040016B3 RID: 5811
		[FieldOffset(0)]
		public int rematchCreated;

		// Token: 0x040016B4 RID: 5812
		[FieldOffset(4)]
		public int rematchStarted;

		// Token: 0x040016B5 RID: 5813
		[FieldOffset(8)]
		public int rematchReadyPlayers;

		// Token: 0x040016B6 RID: 5814
		[FieldOffset(12)]
		public int rematchMaxPlayers;
	}
}
