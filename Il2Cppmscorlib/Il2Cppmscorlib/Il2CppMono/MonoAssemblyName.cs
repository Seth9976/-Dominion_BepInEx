using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000E RID: 14
	[StructLayout(2)]
	public struct MonoAssemblyName
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00023988 File Offset: 0x00021B88
		// Note: this type is marked as 'beforefieldinit'.
		static MonoAssemblyName()
		{
			Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "MonoAssemblyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr);
			MonoAssemblyName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "name");
			MonoAssemblyName.NativeFieldInfoPtr_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "culture");
			MonoAssemblyName.NativeFieldInfoPtr_hash_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_value");
			MonoAssemblyName.NativeFieldInfoPtr_public_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "public_key");
			MonoAssemblyName.NativeFieldInfoPtr_public_key_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "public_key_token");
			MonoAssemblyName.NativeFieldInfoPtr_hash_alg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_alg");
			MonoAssemblyName.NativeFieldInfoPtr_hash_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_len");
			MonoAssemblyName.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "flags");
			MonoAssemblyName.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "major");
			MonoAssemblyName.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "minor");
			MonoAssemblyName.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "build");
			MonoAssemblyName.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "revision");
			MonoAssemblyName.NativeFieldInfoPtr_arch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "arch");
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002125 File Offset: 0x00000325
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, ref this));
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_culture;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_hash_value;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_public_key;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_public_key_token;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_hash_alg;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_hash_len;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_revision;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_arch;

		// Token: 0x04000046 RID: 70
		[FieldOffset(0)]
		public IntPtr name;

		// Token: 0x04000047 RID: 71
		[FieldOffset(8)]
		public IntPtr culture;

		// Token: 0x04000048 RID: 72
		[FieldOffset(16)]
		public IntPtr hash_value;

		// Token: 0x04000049 RID: 73
		[FieldOffset(24)]
		public IntPtr public_key;

		// Token: 0x0400004A RID: 74
		[FieldOffset(32)]
		public MonoAssemblyName._public_key_token_e__FixedBuffer public_key_token;

		// Token: 0x0400004B RID: 75
		[FieldOffset(52)]
		public uint hash_alg;

		// Token: 0x0400004C RID: 76
		[FieldOffset(56)]
		public uint hash_len;

		// Token: 0x0400004D RID: 77
		[FieldOffset(60)]
		public uint flags;

		// Token: 0x0400004E RID: 78
		[FieldOffset(64)]
		public ushort major;

		// Token: 0x0400004F RID: 79
		[FieldOffset(66)]
		public ushort minor;

		// Token: 0x04000050 RID: 80
		[FieldOffset(68)]
		public ushort build;

		// Token: 0x04000051 RID: 81
		[FieldOffset(70)]
		public ushort revision;

		// Token: 0x04000052 RID: 82
		[FieldOffset(72)]
		public ushort arch;

		// Token: 0x02000535 RID: 1333
		[ObfuscatedName("Mono.MonoAssemblyName+<public_key_token>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _public_key_token_e__FixedBuffer
		{
			// Token: 0x06004D66 RID: 19814 RVA: 0x0001D4B6 File Offset: 0x0001B6B6
			// Note: this type is marked as 'beforefieldinit'.
			static _public_key_token_e__FixedBuffer()
			{
				Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "<public_key_token>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr);
				MonoAssemblyName._public_key_token_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06004D67 RID: 19815 RVA: 0x0001D4EA File Offset: 0x0001B6EA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04003E78 RID: 15992
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04003E79 RID: 15993
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}
