using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000522 RID: 1314
	[StructLayout(2)]
	public struct ManifestEnvelope
	{
		// Token: 0x06004C14 RID: 19476 RVA: 0x0015B070 File Offset: 0x00159270
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestEnvelope()
		{
			Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ManifestEnvelope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr);
			ManifestEnvelope.NativeFieldInfoPtr_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "Format");
			ManifestEnvelope.NativeFieldInfoPtr_MajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "MajorVersion");
			ManifestEnvelope.NativeFieldInfoPtr_MinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "MinorVersion");
			ManifestEnvelope.NativeFieldInfoPtr_Magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "Magic");
			ManifestEnvelope.NativeFieldInfoPtr_TotalChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "TotalChunks");
			ManifestEnvelope.NativeFieldInfoPtr_ChunkNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "ChunkNumber");
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x0001CB11 File Offset: 0x0001AD11
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, ref this));
		}

		// Token: 0x04003D5F RID: 15711
		private static readonly IntPtr NativeFieldInfoPtr_Format;

		// Token: 0x04003D60 RID: 15712
		private static readonly IntPtr NativeFieldInfoPtr_MajorVersion;

		// Token: 0x04003D61 RID: 15713
		private static readonly IntPtr NativeFieldInfoPtr_MinorVersion;

		// Token: 0x04003D62 RID: 15714
		private static readonly IntPtr NativeFieldInfoPtr_Magic;

		// Token: 0x04003D63 RID: 15715
		private static readonly IntPtr NativeFieldInfoPtr_TotalChunks;

		// Token: 0x04003D64 RID: 15716
		private static readonly IntPtr NativeFieldInfoPtr_ChunkNumber;

		// Token: 0x04003D65 RID: 15717
		[FieldOffset(0)]
		public ManifestEnvelope.ManifestFormats Format;

		// Token: 0x04003D66 RID: 15718
		[FieldOffset(1)]
		public byte MajorVersion;

		// Token: 0x04003D67 RID: 15719
		[FieldOffset(2)]
		public byte MinorVersion;

		// Token: 0x04003D68 RID: 15720
		[FieldOffset(3)]
		public byte Magic;

		// Token: 0x04003D69 RID: 15721
		[FieldOffset(4)]
		public ushort TotalChunks;

		// Token: 0x04003D6A RID: 15722
		[FieldOffset(6)]
		public ushort ChunkNumber;

		// Token: 0x02000688 RID: 1672
		public enum ManifestFormats : byte
		{
			// Token: 0x040045E8 RID: 17896
			SimpleXmlFormat = 1
		}
	}
}
