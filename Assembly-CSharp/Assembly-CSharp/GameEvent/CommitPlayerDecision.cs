using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200015D RID: 349
	[StructLayout(2)]
	public struct CommitPlayerDecision
	{
		// Token: 0x0600223B RID: 8763 RVA: 0x0001587A File Offset: 0x00013A7A
		// Note: this type is marked as 'beforefieldinit'.
		static CommitPlayerDecision()
		{
			Il2CppClassPointerStore<CommitPlayerDecision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "CommitPlayerDecision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommitPlayerDecision>.NativeClassPtr);
			CommitPlayerDecision.NativeFieldInfoPtr_moveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommitPlayerDecision>.NativeClassPtr, "moveCount");
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000158B3 File Offset: 0x00013AB3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommitPlayerDecision>.NativeClassPtr, ref this));
		}

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeFieldInfoPtr_moveCount;

		// Token: 0x040017D4 RID: 6100
		[FieldOffset(0)]
		public int moveCount;
	}
}
