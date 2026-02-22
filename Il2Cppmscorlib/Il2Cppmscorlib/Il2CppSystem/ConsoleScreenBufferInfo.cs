using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014F RID: 335
	[StructLayout(2)]
	public struct ConsoleScreenBufferInfo
	{
		// Token: 0x06001721 RID: 5921 RVA: 0x00089F30 File Offset: 0x00088130
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleScreenBufferInfo()
		{
			Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleScreenBufferInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr);
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Size");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_CursorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "CursorPosition");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Attribute");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Window");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_MaxWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "MaxWindowSize");
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0000829D File Offset: 0x0000649D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr_CursorPosition;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeFieldInfoPtr_Window;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeFieldInfoPtr_MaxWindowSize;

		// Token: 0x0400156E RID: 5486
		[FieldOffset(0)]
		public Coord Size;

		// Token: 0x0400156F RID: 5487
		[FieldOffset(4)]
		public Coord CursorPosition;

		// Token: 0x04001570 RID: 5488
		[FieldOffset(8)]
		public short Attribute;

		// Token: 0x04001571 RID: 5489
		[FieldOffset(10)]
		public SmallRect Window;

		// Token: 0x04001572 RID: 5490
		[FieldOffset(18)]
		public Coord MaxWindowSize;
	}
}
