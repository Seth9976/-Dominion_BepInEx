using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000147 RID: 327
	[StructLayout(2)]
	public struct DeliriumResult
	{
		// Token: 0x060021FF RID: 8703 RVA: 0x00080A2C File Offset: 0x0007EC2C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliriumResult()
		{
			Il2CppClassPointerStore<DeliriumResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "DeliriumResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliriumResult>.NativeClassPtr);
			DeliriumResult.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliriumResult>.NativeClassPtr, "player_instance_id");
			DeliriumResult.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliriumResult>.NativeClassPtr, "result");
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0001542A File Offset: 0x0001362A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeliriumResult>.NativeClassPtr, ref this));
		}

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400177A RID: 6010
		[FieldOffset(0)]
		public int player_instance_id;

		// Token: 0x0400177B RID: 6011
		[FieldOffset(4)]
		public int result;
	}
}
