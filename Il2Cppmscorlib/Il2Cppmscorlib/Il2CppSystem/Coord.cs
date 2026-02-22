using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014D RID: 333
	[StructLayout(2)]
	public struct Coord
	{
		// Token: 0x0600171D RID: 5917 RVA: 0x00089E58 File Offset: 0x00088058
		// Note: this type is marked as 'beforefieldinit'.
		static Coord()
		{
			Il2CppClassPointerStore<Coord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Coord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coord>.NativeClassPtr);
			Coord.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "X");
			Coord.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "Y");
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00008279 File Offset: 0x00006479
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Coord>.NativeClassPtr, ref this));
		}

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400155F RID: 5471
		[FieldOffset(0)]
		public short X;

		// Token: 0x04001560 RID: 5472
		[FieldOffset(2)]
		public short Y;
	}
}
