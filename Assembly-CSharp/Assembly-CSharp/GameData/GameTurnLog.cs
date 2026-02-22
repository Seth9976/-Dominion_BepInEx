using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x02000130 RID: 304
	public sealed class GameTurnLog : ValueType
	{
		// Token: 0x060021BF RID: 8639 RVA: 0x0001506D File Offset: 0x0001326D
		// Note: this type is marked as 'beforefieldinit'.
		static GameTurnLog()
		{
			Il2CppClassPointerStore<GameTurnLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "GameTurnLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameTurnLog>.NativeClassPtr);
			GameTurnLog.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLog>.NativeClassPtr, "entries");
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000150A6 File Offset: 0x000132A6
		public GameTurnLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000150AF File Offset: 0x000132AF
		public GameTurnLog()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameTurnLog>.NativeClassPtr))
		{
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00080020 File Offset: 0x0007E220
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x000150C1 File Offset: 0x000132C1
		public unsafe Il2CppReferenceArray<GameTurnLogEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLog.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameTurnLogEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLog.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeFieldInfoPtr_entries;
	}
}
