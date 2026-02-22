using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000148 RID: 328
	[StructLayout(2)]
	public struct BRECORD
	{
		// Token: 0x060016FA RID: 5882 RVA: 0x00089450 File Offset: 0x00087650
		// Note: this type is marked as 'beforefieldinit'.
		static BRECORD()
		{
			Il2CppClassPointerStore<BRECORD>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "BRECORD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BRECORD>.NativeClassPtr);
			BRECORD.NativeFieldInfoPtr_pvRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pvRecord");
			BRECORD.NativeFieldInfoPtr_pRecInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pRecInfo");
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000081A0 File Offset: 0x000063A0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, ref this));
		}

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeFieldInfoPtr_pvRecord;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeFieldInfoPtr_pRecInfo;

		// Token: 0x04001534 RID: 5428
		[FieldOffset(0)]
		public IntPtr pvRecord;

		// Token: 0x04001535 RID: 5429
		[FieldOffset(8)]
		public IntPtr pRecInfo;
	}
}
