using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000140 RID: 320
	[StructLayout(2)]
	public struct CenterRowStatus
	{
		// Token: 0x060021F1 RID: 8689 RVA: 0x00080838 File Offset: 0x0007EA38
		// Note: this type is marked as 'beforefieldinit'.
		static CenterRowStatus()
		{
			Il2CppClassPointerStore<CenterRowStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "CenterRowStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CenterRowStatus>.NativeClassPtr);
			CenterRowStatus.NativeFieldInfoPtr_centerrow_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowStatus>.NativeClassPtr, "centerrow_index");
			CenterRowStatus.NativeFieldInfoPtr_centerrow_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowStatus>.NativeClassPtr, "centerrow_status");
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0001533A File Offset: 0x0001353A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CenterRowStatus>.NativeClassPtr, ref this));
		}

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeFieldInfoPtr_centerrow_index;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeFieldInfoPtr_centerrow_status;

		// Token: 0x0400175C RID: 5980
		[FieldOffset(0)]
		public int centerrow_index;

		// Token: 0x0400175D RID: 5981
		[FieldOffset(4)]
		public int centerrow_status;
	}
}
