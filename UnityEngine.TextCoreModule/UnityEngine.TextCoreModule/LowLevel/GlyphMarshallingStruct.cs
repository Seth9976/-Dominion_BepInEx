using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000010 RID: 16
	[StructLayout(2)]
	public struct GlyphMarshallingStruct
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00006CF8 File Offset: 0x00004EF8
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphMarshallingStruct()
		{
			Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphMarshallingStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr);
			GlyphMarshallingStruct.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "index");
			GlyphMarshallingStruct.NativeFieldInfoPtr_metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "metrics");
			GlyphMarshallingStruct.NativeFieldInfoPtr_glyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "glyphRect");
			GlyphMarshallingStruct.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "scale");
			GlyphMarshallingStruct.NativeFieldInfoPtr_atlasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "atlasIndex");
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000027E5 File Offset: 0x000009E5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, ref this));
		}

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_metrics;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_glyphRect;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_atlasIndex;

		// Token: 0x04000104 RID: 260
		[FieldOffset(0)]
		public uint index;

		// Token: 0x04000105 RID: 261
		[FieldOffset(4)]
		public GlyphMetrics metrics;

		// Token: 0x04000106 RID: 262
		[FieldOffset(24)]
		public GlyphRect glyphRect;

		// Token: 0x04000107 RID: 263
		[FieldOffset(40)]
		public float scale;

		// Token: 0x04000108 RID: 264
		[FieldOffset(44)]
		public int atlasIndex;
	}
}
