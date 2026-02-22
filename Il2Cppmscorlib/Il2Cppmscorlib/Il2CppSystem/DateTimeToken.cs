using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000AE RID: 174
	[StructLayout(2)]
	public struct DateTimeToken
	{
		// Token: 0x06000C71 RID: 3185 RVA: 0x0005AC88 File Offset: 0x00058E88
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeToken()
		{
			Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr);
			DateTimeToken.NativeFieldInfoPtr_dtt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "dtt");
			DateTimeToken.NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "suffix");
			DateTimeToken.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "num");
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000052F8 File Offset: 0x000034F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeFieldInfoPtr_dtt;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeFieldInfoPtr_suffix;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04000A5C RID: 2652
		[FieldOffset(0)]
		public DateTimeParse.DTT dtt;

		// Token: 0x04000A5D RID: 2653
		[FieldOffset(4)]
		public TokenType suffix;

		// Token: 0x04000A5E RID: 2654
		[FieldOffset(8)]
		public int num;
	}
}
