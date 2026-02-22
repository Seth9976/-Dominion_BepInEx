using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net
{
	// Token: 0x02000010 RID: 16
	[StructLayout(2)]
	public struct CFStreamClientContext
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00013150 File Offset: 0x00011350
		// Note: this type is marked as 'beforefieldinit'.
		static CFStreamClientContext()
		{
			Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFStreamClientContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr);
			CFStreamClientContext.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr, "Version");
			CFStreamClientContext.NativeFieldInfoPtr_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr, "Info");
			CFStreamClientContext.NativeFieldInfoPtr_Retain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr, "Retain");
			CFStreamClientContext.NativeFieldInfoPtr_Release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr, "Release");
			CFStreamClientContext.NativeFieldInfoPtr_CopyDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr, "CopyDescription");
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000023D3 File Offset: 0x000005D3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CFStreamClientContext>.NativeClassPtr, ref this));
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_Info;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_Retain;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_Release;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_CopyDescription;

		// Token: 0x04000074 RID: 116
		[FieldOffset(0)]
		public IntPtr Version;

		// Token: 0x04000075 RID: 117
		[FieldOffset(8)]
		public IntPtr Info;

		// Token: 0x04000076 RID: 118
		[FieldOffset(16)]
		public IntPtr Retain;

		// Token: 0x04000077 RID: 119
		[FieldOffset(24)]
		public IntPtr Release;

		// Token: 0x04000078 RID: 120
		[FieldOffset(32)]
		public IntPtr CopyDescription;
	}
}
