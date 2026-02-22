using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000151 RID: 337
	[StructLayout(2)]
	public struct AchievementData
	{
		// Token: 0x0600221C RID: 8732 RVA: 0x00080F54 File Offset: 0x0007F154
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementData()
		{
			Il2CppClassPointerStore<AchievementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "AchievementData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementData>.NativeClassPtr);
			AchievementData.NativeFieldInfoPtr_achievementID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "achievementID");
			AchievementData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "data");
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00015557 File Offset: 0x00013757
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, ref this));
		}

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeFieldInfoPtr_achievementID;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040017BA RID: 6074
		[FieldOffset(0)]
		public int achievementID;

		// Token: 0x040017BB RID: 6075
		[FieldOffset(8)]
		public long data;
	}
}
