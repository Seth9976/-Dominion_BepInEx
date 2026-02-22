using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028F RID: 655
	[StructLayout(2)]
	public struct NativeOverlapped
	{
		// Token: 0x06002C6B RID: 11371 RVA: 0x000E2A30 File Offset: 0x000E0C30
		// Note: this type is marked as 'beforefieldinit'.
		static NativeOverlapped()
		{
			Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "NativeOverlapped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr);
			NativeOverlapped.NativeFieldInfoPtr_InternalLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalLow");
			NativeOverlapped.NativeFieldInfoPtr_InternalHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalHigh");
			NativeOverlapped.NativeFieldInfoPtr_OffsetLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetLow");
			NativeOverlapped.NativeFieldInfoPtr_OffsetHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetHigh");
			NativeOverlapped.NativeFieldInfoPtr_EventHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "EventHandle");
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0000F6FE File Offset: 0x0000D8FE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, ref this));
		}

		// Token: 0x04002698 RID: 9880
		private static readonly IntPtr NativeFieldInfoPtr_InternalLow;

		// Token: 0x04002699 RID: 9881
		private static readonly IntPtr NativeFieldInfoPtr_InternalHigh;

		// Token: 0x0400269A RID: 9882
		private static readonly IntPtr NativeFieldInfoPtr_OffsetLow;

		// Token: 0x0400269B RID: 9883
		private static readonly IntPtr NativeFieldInfoPtr_OffsetHigh;

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeFieldInfoPtr_EventHandle;

		// Token: 0x0400269D RID: 9885
		[FieldOffset(0)]
		public IntPtr InternalLow;

		// Token: 0x0400269E RID: 9886
		[FieldOffset(8)]
		public IntPtr InternalHigh;

		// Token: 0x0400269F RID: 9887
		[FieldOffset(16)]
		public int OffsetLow;

		// Token: 0x040026A0 RID: 9888
		[FieldOffset(20)]
		public int OffsetHigh;

		// Token: 0x040026A1 RID: 9889
		[FieldOffset(24)]
		public IntPtr EventHandle;
	}
}
