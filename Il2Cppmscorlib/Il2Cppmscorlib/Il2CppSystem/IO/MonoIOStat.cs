using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200021E RID: 542
	[StructLayout(2)]
	public struct MonoIOStat
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x000C0CE8 File Offset: 0x000BEEE8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoIOStat()
		{
			Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIOStat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr);
			MonoIOStat.NativeFieldInfoPtr_fileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "fileAttributes");
			MonoIOStat.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "Length");
			MonoIOStat.NativeFieldInfoPtr_CreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "CreationTime");
			MonoIOStat.NativeFieldInfoPtr_LastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastAccessTime");
			MonoIOStat.NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastWriteTime");
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, ref this));
		}

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_fileAttributes;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_CreationTime;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_LastAccessTime;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeFieldInfoPtr_LastWriteTime;

		// Token: 0x04001FB1 RID: 8113
		[FieldOffset(0)]
		public FileAttributes fileAttributes;

		// Token: 0x04001FB2 RID: 8114
		[FieldOffset(8)]
		public long Length;

		// Token: 0x04001FB3 RID: 8115
		[FieldOffset(16)]
		public long CreationTime;

		// Token: 0x04001FB4 RID: 8116
		[FieldOffset(24)]
		public long LastAccessTime;

		// Token: 0x04001FB5 RID: 8117
		[FieldOffset(32)]
		public long LastWriteTime;
	}
}
